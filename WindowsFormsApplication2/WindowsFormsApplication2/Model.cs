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

        public Model()
        {
            DIS[0] = new bool[] { false, false, false, false };
            DIS[1] = new bool[] { false, false, false, false };

            DOS[0] = new bool[] { false, false, false, false };
            DOS[1] = new bool[] { false, false, false, false };

            AIS[0] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };


            thd = new Thread(new ThreadStart(DataUpdate_Thread));
            thd.Start();

        }

        private bool MbsInit()
        {
            bool isSucess = true;

            mdb = new ModbusClient("COM13");
            mdb.Baudrate = 9600;
            mdb.Parity = System.IO.Ports.Parity.None;
            mdb.ConnectionTimeout = 100;
            mdb.Connect();

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
            DIS[0] = mdb.ReadCoils(0, 4);
            mdb.WriteMultipleCoils(64, DOS[0]);

            mdb.UnitIdentifier = 121;
            DIS[1] = mdb.ReadCoils(0, 4);
            mdb.WriteMultipleCoils(64, DOS[1]);

            mdb.UnitIdentifier = 100;
            AIS[0] = mdb.ReadInputRegisters(0, 8);
        }

        public void Test()
        { 
            
        }
    }
}
