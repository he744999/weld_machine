using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;
using System.Timers;


namespace DXApplication4
{
    public partial class Machine2
    {
        public delegate void OutputDelegate(string data);
        public static event OutputDelegate OutputEvent;

        public delegate void Output2Delegate(string data1, int data2);
        public static event Output2Delegate OutputEvent2;

        public enum States { on, off, forward, back };

        public enum Trigger { turn, f, b };

        public States _state = States.off;
        public StateMachine<States, Trigger> _machine;


        public string _id { get; set; }

        int target;
        public int current;
        int slow_value;
        int ook_value;

        Timer t1 = new Timer();
        Timer t2 = new Timer();
        Random r = new Random();


        public Machine2(string id)
        {
            // 配料机标识符
            _id = id;

            target = 300;
            current = 0;
            slow_value = 30;
            ook_value = 3;

            t1.Interval = 500;
            t1.AutoReset = true;

            t2.Interval = 100;
            t2.AutoReset = false;

            _machine = new StateMachine<States, Trigger>(() => _state, s => _state = s);
            _machine.OnUnhandledTrigger((state, trigger) => { });

            _machine.Configure(States.off).Permit(Trigger.turn, States.on)
                .OnEntry(t => OnEntryOff())
                .OnExit(t => OnExitOff());


            _machine.Configure(States.on).Permit(Trigger.turn, States.off)
                .OnEntry(t => OnEntryOn())
                .OnExit(t => OnExitOn());

            _machine.Configure(States.on).Permit(Trigger.f, States.forward);

            _machine.Configure(States.on).Permit(Trigger.b, States.back);

            _machine.Configure(States.forward).Permit(Trigger.b, States.back)
                .SubstateOf(States.on)
                .OnEntry(t => OnEntryForward())
                .OnExit(t => OnExitForward());

            _machine.Configure(States.back).Permit(Trigger.f, States.forward)
                .SubstateOf(States.on)
                .OnEntry(t => OnEntryBack())
                .OnExit(t => OnExitBack());
        }
        private void OnEntryOff()
        {
            OutputEvent("OnEntryOff");
            t1.Start();
        }

        private void OnEntryOn()
        {
            OutputEvent("OnEntryOn");
            t1.Start();
        }

        private void OnEntryForward()
        {
            OutputEvent("OnEntryForward");
        }

        private void OnEntryBack()
        {
            OutputEvent("OnEntryBack");
        }
        private void OnExitOff()
        {
            OutputEvent("OnExitOff");
        }
        private void OnExitOn()
        {
            OutputEvent("OnExitOn");
        }
        private void OnExitBack()
        {
            OutputEvent("OnExitBack");
        }

        private void OnExitForward()
        {
            OutputEvent("OnExitForward");
        }
    }
}
