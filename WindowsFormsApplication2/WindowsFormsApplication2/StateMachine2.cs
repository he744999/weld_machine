using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;
using System.Timers;


namespace WindowsFormsApplication2
{
    public partial class Machine2
    {
        public delegate void OutputDelegate(string data);
        public static event OutputDelegate OutputEvent;

        public delegate void Output2Delegate(string data1, int data2);
        public static event Output2Delegate OutputEvent2;

        public enum States  {ready, fast, slow_t, slow_k, over};

        public enum Trigger {start, almost, TIMEOUT, ook, restart};

        public States _state = States.ready;
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
            t1.Elapsed += Tick1Event;

            t2.Interval = 100;
            t2.AutoReset = false;
            t2.Elapsed += Tick2Event;

            _machine = new StateMachine<States, Trigger>(() => _state, s => _state = s);
            _machine.OnUnhandledTrigger((state, trigger) => { });

            _machine.Configure(States.ready).Permit(Trigger.start, States.fast)
                .OnEntry(t => OnEntryReady());
                  

            _machine.Configure(States.fast).Permit(Trigger.almost, States.slow_t)
                .OnEntry(t => OnEntryFast());

            _machine.Configure(States.slow_t).Permit(Trigger.TIMEOUT, States.slow_k)
                .OnEntry(t => OnEntrySlowt());
            _machine.Configure(States.slow_k).Permit(Trigger.TIMEOUT, States.slow_t)
                .OnEntry(t => OnEntrySlowk());

            _machine.Configure(States.slow_t).Permit(Trigger.ook, States.over);
            _machine.Configure(States.slow_k).Permit(Trigger.ook, States.over);

            _machine.Configure(States.over).Permit(Trigger.restart, States.ready)
                .OnEntry(t => OnEntryOver());
        }

        public void s()
        {
            t2.Start();
        }


        private void Tick2Event(object sender, ElapsedEventArgs e)
        {
            int t = Math.Abs(target - current);
            if (t > slow_value)
            {
                _machine.Fire(Trigger.start);
                return;
            }
            if (t < slow_value && t > ook_value)
            {
                _machine.Fire(Trigger.almost);
                return;
            }
            if (t < ook_value)
            {
                _machine.Fire(Trigger.ook);
                t2.Stop();
                return;
            }
        }

        private void OnEntrySlowk()
        {
            OutputEvent("OnEntrySlowk");
            t1.Start();
        }

        private void OnEntrySlowt()
        {
            OutputEvent("OnEntrySlowt");
            t1.Start();
        }

        private void OnEntryOver()
        {
            OutputEvent("OnEntryOver");
        }

        private void OnEntryOkk()
        {
            OutputEvent("OnEntryOkk");
        }

        private void OnEntrySlow()
        {
            OutputEvent("OnEntrySlow");
        }

        private void OnEntryFast()
        {
            OutputEvent("OnEntryFast");
        }

        private void OnEntryReady()
        {
            OutputEvent("OnEntryReady");
        }


        public void run()
        {
            int temp = target -current;
            if (temp > slow_value)
            { 
                _machine.Fire(Trigger.start);
            }
            if (slow_value > temp && temp > ook_value)
            { 
                _machine.Fire(Trigger.almost);
            }
            if (temp < ook_value)
            { 
                _machine.Fire(Trigger.ook);
            }
        }
        public void randomAdd(string data)
        {
            int value = r.Next(0,20);
            if (data == "add")
            { 
                OutputEvent2("add" , value);
            }
            if (data == "sub")
            { 
                OutputEvent2("sub" , value);
            }
        }

        private void Tick1Event(object sender, ElapsedEventArgs e)
        {
            _machine.Fire(Trigger.TIMEOUT);
        }
    }
}
