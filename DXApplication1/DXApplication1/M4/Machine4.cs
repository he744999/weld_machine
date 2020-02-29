using System;
using Stateless;
using System.Timers;

namespace DXApplication1
{
    public partial class Machine4
    {
        /// <summary>
        /// 这是一个简单配料机控制模型
        /// </summary>
        /// <param name="data"></param>
        public delegate void SendMessageDelegate(string data);
        public event SendMessageDelegate SendMessageEvent;

        public enum States { Running, Fast, Back, SlowFast, Okk };
        public enum Trigger { START, TIMEOUT, TOGGLE, REREADY };

        public States _state = States.Running;
        public StateMachine<States, Trigger> _machine;
        private string id = null;


        Timer t1 = new Timer();


        public Machine4(string name)
        {
            id = name + " Machine";
            MachineConfig();
            t1.Interval = 1000;
            t1.Elapsed += t1Event;

        }

        private void t1Event(object sender, ElapsedEventArgs e)
        {
            _machine.Fire(Trigger.TIMEOUT);
        }

        private void MachineConfig()
        {
            // 初始状态buffer -> 系统准备
            _machine = new StateMachine<States, Trigger>(() => _state, s => _state = s);
            _machine.OnUnhandledTrigger((state, trigger) => { });

            _machine.Configure(States.Running).Permit(Trigger.START, States.Fast)
                .OnEntry(t => SendMessageEvent("OnEntryRunning"));

            _machine.Configure(States.Fast).Permit(Trigger.TOGGLE, States.Back)
                .OnExit(t => OnExitFast())
                .OnEntry(t => SendMessageEvent("OnEntryFast"));

            _machine.Configure(States.Back).Permit(Trigger.TOGGLE, States.Okk)
                .OnEntry(t => SendMessageEvent("OnEntryBack"));

            _machine.Configure(States.Okk).Permit(Trigger.REREADY, States.Running)
                .OnEntry(t => SendMessageEvent("OnEntryOkk"));

        }

        private void OnExitFast()
        {
            SendMessageEvent("OnExitFast");
        }
    }
}