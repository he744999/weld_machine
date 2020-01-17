using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;

namespace WindowsFormsApplication2
{
    public partial class Machine
    {
        public delegate bool SendMessageDelegate(bool s);
        public static event SendMessageDelegate SendMessageEvent;

        public enum States  {buffer, reset, ready, lock1, lock2, lock3, lock4, right, left, unlock4, unlock3, unlock2, unlock1};
        public enum Trigger {TIMEOUT, STOP1, NEXT1, ROLLLBACK1, RUN1, BACK1};

        public States _state = States.buffer;
        public StateMachine<States, Trigger> _machine;

        public string title { get; set; }

        Setup cfg = new Setup();

        public Machine()
        {
            _machine = new StateMachine<States, Trigger>(() => _state, s => _state = s);

            _machine.Configure(States.buffer).Permit(Trigger.TIMEOUT, States.reset)
                .OnExit(t => OnExitBuffer());
            _machine.Configure(States.reset).Permit(Trigger.STOP1, States.ready)
                .OnEntry(t => OnEntryReady());
        }

        private void OnExitBuffer()
        {
            bool s = SendMessageEvent(false);
            System.Console.WriteLine(s);
        
        }

        private void OnEntryReady()
        { 
        
        }
    }
}
