using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using System.Threading;
using System.IO.Ports;
using System.Diagnostics;
namespace WindowsFormsApplication2
{
    class Model
    {
        public volatile static bool[][] DIS = new bool[2][];
        public volatile static bool[][] DOS = new bool[2][];
        public volatile static bool[][] DOS_COILS = new bool[2][];
        public volatile static int[][] AIS  = new int[2][];

        private static ModbusClient mdb;
        private Thread thd = null;
        private bool OneConnceted = true;

        public bool isRunning = false;

        public delegate void SendMessageDelegate(bool s);
        // public static event SendMessageDelegate SendMessageEvent;

        public delegate void SendCoilsErrorDelegate(string data);
        public static event SendCoilsErrorDelegate CoilsError;


        public string[] ports;

        public Model()
        {
            DIS[0] = new bool[] { false, false, false, false };
            DIS[1] = new bool[] { false, false, false, false };

            DOS[0] = new bool[] { false, false, false, false };
            DOS[1] = new bool[] { false, false, false, false };

            DOS_COILS[0] = new bool[] { false, false, false, false };
            DOS_COILS[1] = new bool[] { false, false, false, false };

            AIS[0] = new int[]  { 0, 0, 100, 0, 0, 0, 0, 0 };
            thd = new Thread(new ThreadStart(DataUpdate_Thread));
            ports = SerialPort.GetPortNames();
            mdb = new ModbusClient();

        }

        public bool MbsInit(string port)
        {
            //mdb = new ModbusClient(port);
            bool state = false;
            mdb.SerialPort = port;
            mdb.Baudrate = 9600;
            mdb.StopBits = System.IO.Ports.StopBits.One;
            mdb.Parity = System.IO.Ports.Parity.None;
            mdb.ConnectionTimeout = 200;
            mdb.Connect();
            // Serial 只连接一次, View关闭btn只是停止输出了 :)
            if (OneConnceted)
            {
                try
                {
                    thd.Start();
                    OneConnceted = false;
                    state = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    state = false;
                }
            }
            isRunning = true;
            return state;
        }

        public void DataUpdate_Thread()
        {
            while (true)
            {
                if (isRunning)
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

                    // 检查 输出继电器线圈状态是否和输出数组一致，否 ，发送CoilsError事件
                    for (int i = 0; i < DOS.Length; i++)
                    {
                        if (DOS[0][i] != DOS_COILS[0][i])
                        {
                            CoilsError("Coils error in " + i.ToString());
                            mdb.UnitIdentifier = 120;
                            mdb.WriteSingleCoil(i, DOS_COILS[0][i]);
                        }
                        if (DOS[1][i] != DOS_COILS[1][i])
                        {
                            CoilsError("Coils error in " + (i+4).ToString());
                            mdb.UnitIdentifier = 121;
                            mdb.WriteSingleCoil(i, DOS_COILS[0][i] );
                        }
                    }
                }
            }
        
        }
        public void Test()
        { 
            
        }

        public void CloseOutput()
        {
            /*
            if (isRunning)
            {
                mdb.UnitIdentifier = 120;
                mdb.WriteMultipleCoils(0, DOS[0]);
                mdb.UnitIdentifier = 121;
                mdb.WriteMultipleCoils(0, DOS[1]);
                Thread.Sleep(1000);
            }
             */
            mdb.Disconnect();
            thd.Abort();
        }
        public void Close_Serial()
        {
            isRunning = false;
        }
    }
}
