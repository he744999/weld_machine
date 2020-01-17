using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using System.Threading;
using System.IO.Ports;

namespace WindowsFormsApplication2
{
    class Model
    {
        public volatile static bool[][] DIS = new bool[2][];
        public volatile static bool[][] DOS = new bool[2][];
        public volatile static int[][] AIS  = new int[2][];

        private static ModbusClient mdb;
        private int Loop_Interrupt = 10;
        private Thread thd;
        public bool state = false;
        public bool isRunning = true;

        //public delegate void SendMessageDelegate(bool s);
        //public static event SendMessageDelegate SendMessageEvent;

        public string[] ports;

        public Model()
        {
            DIS[0] = new bool[] { false, false, false, false };
            DIS[1] = new bool[] { false, false, false, false };

            DOS[0] = new bool[] { false, false, false, false };
            DOS[1] = new bool[] { false, false, false, false };

            AIS[0] = new int[]  { 0, 0, 100, 0, 0, 0, 0, 0 };
            thd = new Thread(new ThreadStart(DataUpdate_Thread));
            ports = SerialPort.GetPortNames();
        }

        public void Close_Serial()
        {
            if (mdb.Available(100))
            {
                mdb.Disconnect();
                isRunning = false;
            }
        }

        public bool MbsInit(string port)
        {
            mdb = new ModbusClient(port);
            mdb.Baudrate = 9600;
            mdb.StopBits = System.IO.Ports.StopBits.One;
            mdb.Parity = System.IO.Ports.Parity.None;
            mdb.ConnectionTimeout = 1200;
            try
            {
                mdb.Connect();
                thd.Start();
                isRunning = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                isRunning = false;
            }
            return isRunning;
        }

        public void DataUpdate_Thread()
        {
            while (true)
            {
                if (isRunning)
                {
                    DataUpdate();
                }
                else
                {
                    Console.WriteLine("out 0-0000000000000000000");
                    break;
                }
            }
        
        }

        private void DataUpdate()
        {

            mdb.UnitIdentifier = 120;
            DIS[0] = mdb.ReadDiscreteInputs(0x64, 4);
            mdb.WriteMultipleCoils(0, DOS[0]);

            mdb.UnitIdentifier = 121;
            DIS[1] = mdb.ReadDiscreteInputs(0x64, 4);
            mdb.WriteMultipleCoils(0, DOS[1]);

            mdb.UnitIdentifier = 100;
            AIS[0] = mdb.ReadInputRegisters(256, 8);
        }

        public void Test()
        { 
            
        }

        public void CloseOutput(bool isOpen)
        {
            thd.Abort();
            if (isOpen)
            {
                mdb.UnitIdentifier = 120;
                mdb.WriteMultipleCoils(0, DOS[0]);
                mdb.UnitIdentifier = 121;
                mdb.WriteMultipleCoils(0, DOS[1]);
            }
        }
    }
}
