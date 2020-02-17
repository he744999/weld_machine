using System;
using EasyModbus;
using System.Threading;
using System.IO.Ports;

namespace DXApplication1
{
    public partial class Model
    {

        //--------------------------------------------------------------------------
        // 全局输入/出模型
        public volatile static bool[][] DIS       = new bool[3][];
        public volatile static bool[][] DOS       = new bool[3][];
        public volatile static bool[][] DOS_COILS = new bool[3][];
        public volatile static int[][]  AIS       = new int[3][];

        // 串口对象和信息
        private static ModbusClient mdb;
        public string[] ports;

        // 线程输入出
        private Thread thd = null;
        public static bool isRunning = false;
        public static bool isCommunicating = false;

        // 线程技术称值类
        private Thread thd2 = null;

        // 委托事件
        public delegate string MessageDelegate1(object sender, string data);
        public static event MessageDelegate1 Model2ControllerMessageHanlder;

        //--------------------------------------------------------------------------
        // 一号配料机
        private volatile int currentWeight1;
        private double kValue1 = 0;
        private int oValue1 = 300;

        public int RawValue1 { get => AIS[0][0]; set => AIS[0][0]= value; }

        public bool BigDoor1     { get => DOS[1][0]; set => DOS[1][0]= value; }
        public bool SmallDoor1   { get => DOS[1][1]; set => DOS[1][1]= value; }
        public bool WeightDoor1  { get => DOS[1][2]; set => DOS[1][2]= value; }

        public int CurrentWeight1 { get => currentWeight1; set => currentWeight1 = value; }
        public double KValue1 { get => kValue1; set => kValue1 = value; }
        public int OValue1 { get => oValue1; set => oValue1 = value; }

        //--------------------------------------------------------------------------
        // 二号配料机
        private volatile int currentWeight2;
        private double kValue2 = 0;
        private int oValue2 = 300;

        public int RawValue2 { get => AIS[0][1]; set => AIS[0][1] = value; }

        public bool BigDoor2 { get => DOS[2][0]; set => DOS[2][0] = value; }
        public bool SmallDoor2 { get => DOS[2][1]; set => DOS[2][1] = value; }
        public bool WeightDoor2 { get => DOS[2][2]; set => DOS[2][2] = value; }

        public int CurrentWeight2 { get => currentWeight2; set => currentWeight2 = value; }
        public double KValue2 { get => kValue2; set => kValue2 = value; }
        public int OValue2 { get => oValue2; set => oValue2 = value; }

        //--------------------------------------------------------------------------
        // Light状态机测试用
        public bool Light { get => DOS[0][0]; set => DOS[0][0] = value; }
        public bool WriteAction { get => DOS[0][1]; set => DOS[0][1] = value; }
        public bool ReadAction { get => DOS[0][2]; set => DOS[0][2] = value; }

        public bool LightSwitch { get => DIS[0][0]; set => DIS[0][0] = value; }
        public bool WriteSwitch { get => DIS[0][1]; set => DIS[0][1] = value; }
        public bool ReadSwitch { get => DIS[0][2]; set => DIS[0][2] = value; }


        public Model()
        {
            DIS[0] = new bool[] { false, false, false, false };
            DIS[1] = new bool[] { false, false, false, false };
            DIS[2] = new bool[] { false, false, false, false };

            DOS[0] = new bool[] { false, false, false, false };
            DOS[1] = new bool[] { false, false, false, false };
            DOS[2] = new bool[] { false, false, false, false };

            DOS_COILS[0] = new bool[] { false, false, false, false };
            DOS_COILS[1] = new bool[] { false, false, false, false };
            DOS_COILS[2] = new bool[] { false, false, false, false };


            AIS[0] = new int[] { 0, 0, 100, 0, 0, 0, 0, 0 };
            AIS[1] = new int[] { 0, 0, 100, 0, 0, 0, 0, 0 };
            thd = new Thread(new ThreadStart(SerialRunning));
            thd.IsBackground = true;
            thd2 = new Thread(new ThreadStart(thdTest));
            thd2.IsBackground = true;
            thd.Name = "SerialCommunicating";
            thd2.Name = "thdTest";

            UpdatePorts();
            mdb = new ModbusClient();

            isRunning = true;
            // thd.Start();
            thd2.Start();
        }

        private void test3(object sender, string e)
        {
            Console.WriteLine("dfsd");
        }

        public void test(object sender, EventArgs e)
        {

        }
        public void Close()
        {
            isCommunicating = false;
            isRunning = false;
            if (mdb.Connected) { mdb.Disconnect();}
        }


        public bool MbsInit(string port)
        {
            mdb.SerialPort = port;
            mdb.Baudrate = 9600;
            mdb.StopBits = System.IO.Ports.StopBits.One;
            mdb.Parity = System.IO.Ports.Parity.None;
            mdb.ConnectionTimeout = 200;
            try
            {
                mdb.Connect();
                isCommunicating = true;
                if(thd.ThreadState ==  (System.Threading.ThreadState.Unstarted | System.Threading.ThreadState.Background) )
                {
                    thd.Start();
                    isRunning = true;
                }

            }
            catch
            {
                isCommunicating = false;
            }
            return isCommunicating;
        }

        public void SerialRunning()
        {
            Thread.Sleep(2000);

            while (isRunning)
            {
                if (isCommunicating)
                {
                    // 模块1-  DI和DO 及读取线圈状态
                    mdb.UnitIdentifier = 120;
                    DIS[0] = mdb.ReadDiscreteInputs(0x64, 4);
                    mdb.WriteMultipleCoils(0, DOS[0]);
                    DOS_COILS[0] = mdb.ReadCoils(0, 4);
                    // 模块2-  DI和DO 及读取线圈状态
                    mdb.UnitIdentifier = 121;
                    DIS[1] = mdb.ReadDiscreteInputs(0x64, 4);
                    mdb.WriteMultipleCoils(0, DOS[1]);
                    DOS_COILS[1] = mdb.ReadCoils(0, 4);
                    // 模块3-  AI
                    mdb.UnitIdentifier = 100;
                    //AIS[0] = mdb.ReadInputRegisters(256, 8);
                    /*
                    // 检查 输出继电器线圈状态是否和输出数组一致，否 ，发送CoilsError事件
                    for (int i = 0; i < DOS.Length; i++)
                    {
                        if (DOS[0][i] != DOS_COILS[0][i])
                        {
                            mdb.UnitIdentifier = 120;
                            mdb.WriteSingleCoil(i, DOS_COILS[0][i]);
                        }
                        if (DOS[1][i] != DOS_COILS[1][i])
                        {
                            mdb.UnitIdentifier = 121;
                            mdb.WriteSingleCoil(i, DOS_COILS[0][i] );
                        }
                    }
                    */
                    string temp = Model2ControllerMessageHanlder("communica", "Communicating");
                }else{
                    string temp = Model2ControllerMessageHanlder("no communica", "No communication");
                    Thread.Sleep(500);
                }

            }
        }

        public void UpdatePorts()
        {
            ports = SerialPort.GetPortNames();
            if(ports.Length == 0)
            {
                ports = new string[] { "no port" };
            }
        }
        public void thdTest()
        {
            while(true)
            {
                // Console.WriteLine("thdTest");
                currentWeight1 = Convert.ToInt32((RawValue1 - OValue1) * KValue1);
                currentWeight2 = Convert.ToInt32((RawValue2 - OValue2) * KValue2);
                Thread.Sleep(100);
            }

        }

    }

    public class LoginCompletedEventArgs : EventArgs
    {
        private readonly string Message;
        
        public LoginCompletedEventArgs(string msg)
        {
            this.Message = msg;
        }
    }
}