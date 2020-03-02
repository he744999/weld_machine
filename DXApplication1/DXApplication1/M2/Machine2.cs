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

        public enum Trigger { TURN, W, R, TIMEOUT };

        public States _state = States.Off;
        public StateMachine<States, Trigger> _machine;

        public string _id { get; private set; }


        Task tWithDelay;
        Random r = new Random();

        public Machine2(string id)
        {
            // 配料机标识符
            _id = id;

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

            _machine.Configure(States.Read).Permit(Trigger.TIMEOUT, States.Write);
            _machine.Configure(States.Write).Permit(Trigger.TIMEOUT, States.Read);

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

        private async void OnEntryread()
        {
            OutputEvent("OnEntryread");
            await Task.Delay(1000);
            _machine.Fire(Trigger.TIMEOUT);

        }

        private async void OnEntrywrite()
        {
            OutputEvent("OnEntrywrite");
            await Task.Delay(1000);
            _machine.Fire(Trigger.TIMEOUT);
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
