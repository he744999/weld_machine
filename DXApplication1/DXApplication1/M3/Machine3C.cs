using Stateless;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DXApplication1
{
    public partial class Machine3C
    {
        /// <summary>
        /// 这是一个简单配料机控制模型
        /// </summary>
        /// <param name="data"></param>
        public delegate void SendMessageDelegate(string data);
        public event SendMessageDelegate SendMessageEvent;

        static int NTotalNums;
        
        enum States { Idle, Ready, Round, Ok };
        enum Trigger {INIT, START, NEXT, OK, RESTART };

        States _state = States.Idle;
        StateMachine<States, Trigger> _machine;

        private string Name = null;
        Thread thd = null;

        StateMachine<States, Trigger>.TriggerWithParameters<int> WriteSomething;

        public int NTotalNums1 { get => NTotalNums; private set => NTotalNums = value; }

        public Machine3C(string name_)
        {
            NTotalNums = 0;


            Name = name_ + " Machine";
            thd = new Thread(new ThreadStart(ThreadWorking));
            thd.Name = name_ + " thread";
            thd.IsBackground = true;
            thd.Start();
            MachineConfig();
        }

        private void MachineConfig()
        {
            // 初始状态buffer -> 系统准备
            _machine = new StateMachine<States, Trigger>(() => _state, s => _state = s);

            WriteSomething = _machine.SetTriggerParameters<int>(Trigger.INIT);

            _machine.OnUnhandledTrigger((state, trigger) => { });

            _machine.Configure(States.Idle)
                .OnEntry(t => SendMessageEvent("onEntryIdle"))
                .OnExit(t => SendMessageEvent("onExitIdle"))
                .Permit(Trigger.INIT, States.Ready);


            _machine.Configure(States.Ready).Permit(Trigger.START, States.Round)
                .OnEntryFrom(WriteSomething, text => OnAssigned(text), "Caller number to call")
                .OnEntry(t => SendMessageEvent("onEntryReady"));

            _machine.Configure(States.Round)
                .Permit(Trigger.OK, States.Ok)
                .PermitReentry(Trigger.NEXT)
                .OnEntry(t => SendMessageEvent("OnEntryRound"));


            _machine.Configure(States.Ok)
                .Permit(Trigger.RESTART, States.Idle)
                .OnEntry(t => SendMessageEvent("onEntryOk"));

            _machine.OnTransitioned(t => Console.WriteLine($"{Name} OnTransitioned: {t.Source} -> {t.Destination} via {t.Trigger}({string.Join(", ", t.Parameters)})"));

        }
        public string GetStates()
        {
            return _state.ToString();
        }



        private void OnAssigned(int info)
        {
            Console.WriteLine(info.ToString() + "------------");
        }

        private void ThreadWorking()
        {
            Thread.Sleep(3000);
            while(true)
            {
                Thread.Sleep(100);
            }
        }

        public void MachineInit(int v)
        {
            NTotalNums = v;
            _machine.Fire(WriteSomething, v);
        }

        public void Init()
        {
            _machine.Fire(Machine3C.Trigger.START);
        }


        public void Restart()
        {
            _machine.Fire(Machine3C.Trigger.RESTART);
        }

        public void Next()
        {
            if(NTotalNums == 0)
            {
                _machine.Fire(Trigger.OK);
            }
            else
            {
                NTotalNums--;
                _machine.Fire(Machine3C.Trigger.NEXT);
            }
        }

    }
}