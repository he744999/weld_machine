using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;

namespace WindowsFormsApplication2
{
    class Machine
    {
        public enum States {on, off};
        public enum Trigger {tick};

        public States _state = States.on;
        public StateMachine<States, Trigger> _machine;

        public string title;


        public Machine(string _title)
        {
            this.title = _title;
            _machine = new StateMachine<States, Trigger>(() => _state, s => _state = s);

            _machine.Configure(States.on).Permit(Trigger.tick, States.off)
                .OnEntry(t => LedOn());
            _machine.Configure(States.off).Permit(Trigger.tick, States.on)
                .OnEntry(t => LedOff());
        }

        private bool LedOn()
        { 
            bool s = true;
            return s;

        }

        private bool[] LedOff()
        { 
            bool s = false;
            return s;
        }


    }
}
