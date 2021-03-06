﻿using System;
using Stateless;
using System.Timers;

namespace DXApplication1
{
    public partial class Machine3ALL
    {
        public delegate void SendMessageDelegate(string data);
        public event SendMessageDelegate SendMessageEvent;

        public enum States { Idle, Initial, Begin, Wait, Okk };
        public enum Trigger { TIMEOUT, INIT, START, CHECK, OK, RESTART };

        public States _state = States.Idle;
        public StateMachine<States, Trigger> _machine;

        public string Name { get; set; }

        Timer t = new Timer();
        Machine3 m1;
        Machine3 m2;


        public Machine3ALL(string name_, Machine3 m1_, Machine3 m2_)
        {
            Name = name_;

            m1 = m1_;
            m2 = m2_;
            t.Elapsed += new ElapsedEventHandler(timerEvent);
            t.AutoReset = false;
            t.Interval = 500;

            // 初始状态buffer -> 系统准备
            _machine = new StateMachine<States, Trigger>(() => _state, s => _state = s);
            _machine.OnUnhandledTrigger((state, trigger) => { });

            _machine.Configure(States.Idle)
                .PermitIf(Trigger.INIT, States.Initial, new Func<bool>(() => StateTest()))
                .OnEntry(() => OnEntryReady());

            _machine.Configure(States.Initial)
                .Permit(Trigger.START, States.Begin)
                .OnExit(()  => OnExitInitial())
                .OnEntry(() => OnEntryInitial());

            _machine.Configure(States.Begin)
                .Permit(Trigger.CHECK, States.Wait)
                .PermitReentry(Trigger.TIMEOUT)
                .OnEntry(() => OnEntryBegin());

            _machine.Configure(States.Wait)
                .Permit(Trigger.OK, States.Okk)
                .PermitReentry(Trigger.TIMEOUT)
                .OnEntry(() => OnEntryWait());

            _machine.Configure(States.Okk)
                .Permit(Trigger.RESTART, States.Idle)
                .OnExit(() => OnExitOkk())
                .OnEntry(() => OnEntryOkk());
            _machine.OnTransitioned(t => Console.WriteLine($"{Name} OnTransitioned: {t.Source} -> {t.Destination} via {t.Trigger}({string.Join(", ", t.Parameters)})"));

        }

        private void OnExitOkk()
        {
            SendMessageEvent("OnExitOkk");
            m1._machine.Fire(Machine3.Trigger.REREADY);
            m2._machine.Fire(Machine3.Trigger.REREADY);
        }
        private void OnExitInitial()
        {
            SendMessageEvent("OnExitOkk");
            m1._machine.Fire(Machine3.Trigger.BEGIN);
            m2._machine.Fire(Machine3.Trigger.BEGIN);
        }

        private void OnEntryOkk()
        {
            SendMessageEvent("OnEntryOkk");
        }

        private bool StateTest()
        {
            bool s;
            if (m1._state == Machine3.States.Idle && m2._state == Machine3.States.Idle)
            {
                s = true;
            }else
            {
                s = false;
            }
            return s;
        }

        private void OnEntryInitial()
        {
            SendMessageEvent("OnEntryInitial");
            _machine.Fire(Trigger.START);
        }
        private void OnEntryBegin()
        {
            SendMessageEvent("OnEntryBegin");
            if (m1._state == Machine3.States.Ready&& m2._state == Machine3.States.Ready)
            {
                m1._machine.Fire(Machine3.Trigger.START); 
                m2._machine.Fire(Machine3.Trigger.START);
                _machine.Fire(Trigger.CHECK);
            }else
            {
                t.Start();
            }
        }

        private void OnEntryWait()
        {
            SendMessageEvent("OnEntryWait");
            if (m1._state == Machine3.States.Okk && m2._state == Machine3.States.Okk)
            {
                _machine.Fire(Trigger.OK);
            }
            else
            {
                t.Start();
            }
        }



        private void OnEntryReady()
        {
            SendMessageEvent("OnEntryReady");
        }

        private void timerEvent(object sender, EventArgs e)
        {
            _machine.Fire(Trigger.TIMEOUT);
        }
    }
}