using System;
using Stateless;
using System.Timers;
using System.Threading.Tasks;


namespace DXApplication1
{
    public partial class Machine2
    {
        public delegate void OutputDelegate(string data);
        public static event OutputDelegate OutputEvent;


        public enum States { On, Off, Read, Write };

        public enum Trigger { TURN, W, R };

        public States _state = States.Off;
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

            _machine.Configure(States.Off).Permit(Trigger.TURN, States.On)
                .OnEntry(t => OnEntryOff())
                .OnExit(t => OnExitOff());

            _machine.Configure(States.On).Permit(Trigger.TURN, States.Off)
                .OnEntry(t => OnEntryOn())
                .OnExit(t => OnExitOn());
                  

                //OnEntryAsync(() => Task.Run(() => test()))     _machine.FireAsync(Trigger trigger);

            _machine.Configure(States.On).Permit(Trigger.R, States.Read);

            _machine.Configure(States.On).Permit(Trigger.W, States.Write);

            _machine.Configure(States.Read).Permit(Trigger.W, States.Write)
                .SubstateOf(States.On)
                .OnEntry(t => OnEntryread())
                .OnExit(t => OnExitread());

            _machine.Configure(States.Write).Permit(Trigger.R, States.Read)
                .SubstateOf(States.On)
                .OnEntry(t => OnEntrywrite())
                .OnExit(t => OnExitwrite());
        }

        private void OnEntryOff()
        {
            OutputEvent("OnEntryOff");
        }

        private void OnEntryOn()
        {
            OutputEvent("OnEntryOn");
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
