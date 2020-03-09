using Stateless;
using Stateless.Graph;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DXApplication1
{
    public partial class Machine3
    {
        /// <summary>
        /// 这是一个简单配料机控制模型
        /// </summary>
        /// <param name="data"></param>
        public delegate void SendMessageDelegate(string data);
        public event SendMessageDelegate SendMessageEvent;

        public enum States { Idle, Ready, Faster, SlowT, SlowK, Okk , LostOver,  empty};
        public enum Trigger {BEGIN,  TIMEOUT, START, OVER, SLOWLY, OK, REREADY, RESTART};

        public States _state = States.Idle;
        public StateMachine<States, Trigger> _machine;
        private string name = null;
        Thread thd = null;

        private double slowValue = 20.0;
        private double okValue   = 2.0;
        private double targetValue = 0.0;
        private double currentValue = 0.0;


        public double TargetValue { get => targetValue; set => targetValue = value; }
        public double CurrentValue { get => currentValue; set => currentValue = value; }
        public double OkValue { get => okValue; set => okValue = value; }
        public double SlowValue { get => slowValue; set => slowValue = value; }

        public Machine3(string name_)
        {
            name = name_ + " Machine";
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
            _machine.OnUnhandledTrigger((state, trigger) => { });

            _machine.Configure(States.Idle).Permit(Trigger.BEGIN, States.Ready)
                .OnEntry(t => SendMessageEvent("OnEntryEasy"));

            _machine.Configure(States.Ready).Permit(Trigger.START, States.Faster)
                .OnEntry(t => SendMessageEvent("OnEntryReady"));

            _machine.Configure(States.Faster).Permit(Trigger.SLOWLY, States.SlowT)
                .OnEntry(t => SendMessageEvent("OnEntryFaster"));

            _machine.Configure(States.Faster).Permit(Trigger.OVER, States.Okk);

            _machine.Configure(States.SlowT).Permit(Trigger.TIMEOUT, States.SlowK)
                .OnEntry(t => OnEntrySlowT("OnEntrySlowT"));

            _machine.Configure(States.SlowK).Permit(Trigger.TIMEOUT, States.SlowT)
                .OnEntry(t => OnEntrySlowK("OnEntrySlowK"));

            _machine.Configure(States.SlowK).Permit(Trigger.OK, States.Okk);
            _machine.Configure(States.SlowT).Permit(Trigger.OK, States.Okk);

            _machine.Configure(States.Okk).Permit(Trigger.RESTART, States.Idle)
                .OnEntry(t => SendMessageEvent("OnEntryOkk"));

            _machine.Configure(States.Okk).Permit(Trigger.REREADY, States.Ready);

            _machine.OnTransitioned(t => Console.WriteLine($"{name} OnTransitioned: {t.Source} -> {t.Destination} via {t.Trigger}({string.Join(", ", t.Parameters)})"));

        }
        private void ThreadWorking()
        {
            Thread.Sleep(3000);
            while(true)
            {
                if(_state != States.Idle)
                {
                    double delta = targetValue - currentValue;

                    if(delta  > SlowValue)
                    {
                        _machine.Fire(Trigger.START);
                    }

                    if (delta < SlowValue && delta > OkValue)
                    {
                        _machine.Fire(Trigger.SLOWLY);
                    }
                    if(delta < OkValue && delta > 0)
                    {
                        _machine.Fire(Trigger.OK);
                    }
                    if(delta < 0)
                    {
                        _machine.Fire(Trigger.OVER);
                    }
                }
                Thread.Sleep(100);
            }
        }

        private async void OnEntrySlowK(string v)
        {
            SendMessageEvent(v);
            await Task.Delay(1000);
            _machine.Fire(Trigger.TIMEOUT);
        }

        private async void OnEntrySlowT(string v)
        {
            SendMessageEvent(v);
            await Task.Delay(1000);
            _machine.Fire(Trigger.TIMEOUT);
        }

        public string ToDOTGraph()
        {
                return UmlDotGraph.Format(_machine.GetInfo());
        }
    }
}