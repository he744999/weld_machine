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

        //public delegate void SendMessageDelegate(bool s);
        //public static event SendMessageDelegate SendMessageEvent;

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
        // 在程序中关闭串口输出，可用于自由切换端口


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
                    mdb.UnitIdentifier = 120;
                    DIS[0] = mdb.ReadDiscreteInputs(0x64, 4);
                    mdb.WriteMultipleCoils(0, DOS[0]);
                    DOS_COILS[0] = mdb.ReadCoils(0, 4);

                    mdb.UnitIdentifier = 121;
                    DIS[1] = mdb.ReadDiscreteInputs(0x64, 4);
                    mdb.WriteMultipleCoils(0, DOS[1]);
                    DOS_COILS[1] = mdb.ReadCoils(0, 4);

                    mdb.UnitIdentifier = 100;
                    //AIS[0] = mdb.ReadInputRegisters(256, 8);
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
