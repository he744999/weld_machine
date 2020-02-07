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

        public enum States { on, off, read, write };

        public enum Trigger { turn, W, R};

        public States _state = States.off;
        public StateMachine<States, Trigger> _machine;


        public string _id { get; set; }


        Timer t1 = new Timer();
        Timer t2 = new Timer();
        Random r = new Random();


        public Machine2(string id)
        {
            // 配料机标识符
            _id = id;


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

            _machine.Configure(States.on).Permit(Trigger.R, States.read);

            _machine.Configure(States.on).Permit(Trigger.W, States.write);

            _machine.Configure(States.read).Permit(Trigger.W, States.write)
                .SubstateOf(States.on)
                .OnEntry(t => OnEntryread())
                .OnExit(t => OnExitread());

            _machine.Configure(States.write).Permit(Trigger.R, States.read)
                .SubstateOf(States.on)
                .OnEntry(t => OnEntrywrite())
                .OnExit(t => OnExitwrite());
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

        private void OnEntryread()
        {
            OutputEvent("OnEntryread");
        }

        private void OnEntrywrite()
        {
            OutputEvent("OnEntrywrite");
        }
        private void OnExitOff()
        {
            OutputEvent("OnExitOff");
        }
        private void OnExitOn()
        {
            OutputEvent("OnExitOn");
        }
        private void OnExitwrite()
        {
            OutputEvent("OnExitwrite");
        }

        private void OnExitread()
        {
            OutputEvent("OnExitread");
        }
    }
}
