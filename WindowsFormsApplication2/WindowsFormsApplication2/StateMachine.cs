using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;

namespace WindowsFormsApplication2
{
    public partial class Machine
    {
        public delegate void SendMessageDelegate(string data);
        public static event SendMessageDelegate SendMessageEvent;

        public enum States  {buffer, reset, ready, lock1, lock2, lock3, lock4, right, left, unlock4, unlock3, unlock2, unlock1};
        public enum Trigger {TIMEOUT, STOP1, NEXT1, ROLLLBACK1, RUN1, BACK1};

        public States _state = States.buffer;
        public StateMachine<States, Trigger> _machine;

        public string title { get; set; }

        Setup cfg = new Setup();

        public Machine()
        {
            // 初始状态buffer -> 系统准备
            _machine = new StateMachine<States, Trigger>(() => _state, s => _state = s);
            _machine.OnUnhandledTrigger((state, trigger) => { });

            // [buffer] -(TIMEOUT)> [reset] -> 检测滑台是否到位
            _machine.Configure(States.buffer).Permit(Trigger.TIMEOUT, States.reset)
                .OnExit(t => OnExitBuffer());

            // [reset] -(STOP1)> [ready] -> 滑台复位完成
            _machine.Configure(States.reset).Permit(Trigger.STOP1, States.ready)
                .OnExit(t => OnExitReset()).OnEntry(t => OnEntryReset());

            // [ready] -(NEXT1)> [lock1] -> 夹紧气缸1作用
            _machine.Configure(States.ready).Permit(Trigger.NEXT1, States.lock1)
                .OnEntry(t => OnEntryReady()).OnExit(t => OnEntryLock1());

            // [lock1] -(NEXT1)> [lock2] -> 夹紧气缸1作用 
            _machine.Configure(States.lock1).Permit(Trigger.NEXT1, States.lock2)
                .OnEntry(t => OnEntryLock2());
            // [lock1] -(NEXT1)> [lock1] -> 夹紧气缸1复位
            _machine.Configure(States.lock1).Permit(Trigger.ROLLLBACK1, States.ready)
                .OnEntry(t => OnEntryReady());



            _machine.Configure(States.lock2).Permit(Trigger.NEXT1, States.lock3)
                .OnEntry(t => OnEntryLock3());
            _machine.Configure(States.lock2).Permit(Trigger.ROLLLBACK1, States.lock1)
                .OnEntry(t => OnEntryLock1());


            _machine.Configure(States.lock3).Permit(Trigger.NEXT1, States.lock4)
                .OnEntry(t => OnEntryLock4());
            _machine.Configure(States.lock3).Permit(Trigger.ROLLLBACK1, States.lock2)
                .OnEntry(t => OnEntryLock2());

            _machine.Configure(States.lock4).Permit(Trigger.RUN1, States.right)
                .OnEntry(t => OnEntryRight());
            _machine.Configure(States.lock4).Permit(Trigger.ROLLLBACK1, States.lock3)
                .OnEntry(t => OnEntryLock3());

            _machine.Configure(States.right).Permit(Trigger.BACK1, States.left)
                .OnEntry(t => OnEntryLeft());
            _machine.Configure(States.left).Permit(Trigger.STOP1, States.unlock4)
                .OnEntry(t => OnEntryUnlock4());
            _machine.Configure(States.unlock4).Permit(Trigger.TIMEOUT, States.unlock3)
                .OnEntry(t => OnEntryUnlock3());
            _machine.Configure(States.unlock3).Permit(Trigger.TIMEOUT, States.unlock2)
                .OnEntry(t => OnEntryUnlock2());
            _machine.Configure(States.unlock2).Permit(Trigger.TIMEOUT, States.unlock1)
                .OnEntry(t => OnEntryUnlock1());
            _machine.Configure(States.unlock1).Permit(Trigger.TIMEOUT, States.ready)
                .OnEntry(t => OnEntryReady());
        }

        private void OnExitReset()
        {
            SendMessageEvent("OnExitReset"); 
        }



        private void OnEntryUnlock1()
        {
            SendMessageEvent("OnEntryUnlock1"); 
        }

        private void OnEntryUnlock2()
        {
            SendMessageEvent("OnEntryUnlock2"); 
        }

        private void OnEntryUnlock3()
        {
            SendMessageEvent("OnEntryUnlock3"); 
        }

        private void OnEntryUnlock4()
        {
            SendMessageEvent("OnEntryUnlock4"); 
        }

        private void OnEntryLeft()
        {
            SendMessageEvent("OnEntryLeft"); 
        }

        private void OnEntryRight()
        {
            SendMessageEvent("OnEntryRight");
        }

        private void OnEntryLock4()
        {
            SendMessageEvent("OnEntryLock4");
        }

        private void OnEntryLock3()
        {
            SendMessageEvent("OnEntryLock3");
        }

        private void OnEntryLock2()
        {
            SendMessageEvent("OnEntryLock2");
        }

        private void OnEntryLock1()
        {
            SendMessageEvent("OnEntryLock1");
        }

        private void OnExitBuffer()
        {
            SendMessageEvent("OnExitBuffer");
        }

        private void OnEntryReady()
        {
            SendMessageEvent("OnEnterReady");
        }
        private void OnEntryReset()
        {
             SendMessageEvent("OnEntryReset"); 
        }
    }
}
