using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using System.Threading;

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

        public Model()
        {
            DIS[0] = new bool[] { false, false, false, false };
            DIS[1] = new bool[] { false, false, false, false };

            DOS[0] = new bool[] { false, false, false, false };
            DOS[1] = new bool[] { false, false, false, false };

            AIS[0] = new int[]  { 0, 0, 100, 0, 0, 0, 0, 0 };

            //if (MbsInit())
            //{
                //Console.WriteLine("222222222222222");
            //}

            thd = new Thread(new ThreadStart(DataUpdate_Thread));
            //thd.Start();

        }

        public bool MbsInit()
        {
            bool isSucess = true;

            mdb = new ModbusClient("COM13");
            mdb.Baudrate = 9600;
            mdb.StopBits = System.IO.Ports.StopBits.One;
            mdb.Parity = System.IO.Ports.Parity.None;
            mdb.ConnectionTimeout = 500;
            mdb.Connect();
            if (isSucess)
            { 
                thd.Start();
            }
            this.state = true;
            return isSucess;
        }

        public bool MbsInit(string port)
        {
            bool isSucess = true;

            mdb = new ModbusClient(port);
            Console.WriteLine(port);
            mdb.Baudrate = 9600;
            mdb.StopBits = System.IO.Ports.StopBits.One;
            mdb.Parity = System.IO.Ports.Parity.None;
            mdb.ConnectionTimeout = 500;
            mdb.Connect();
            if (isSucess)
            { 
                thd.Start();
            }
            this.state = true;
            return isSucess;
        }

        public void DataUpdate_Thread()
        {
            while (true)
            {
                DataUpdate();
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
