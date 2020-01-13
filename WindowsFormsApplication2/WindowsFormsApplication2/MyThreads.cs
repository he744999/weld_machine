using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;

namespace WindowsFormsApplication2
{
    class MyThreads
    {
        public volatile static bool[][] DIS = new bool[2][];
        public volatile static bool[][] DOS = new bool[2][];
        public volatile static int[][] AIS  = new int[2][];

        private static ModbusClient mdb;
        public MyThreads()
        {
            DIS[0] = new bool[] { false, false, false, false };
            DIS[1] = new bool[] { false, false, false, false };

            DOS[0] = new bool[] { false, false, false, false };
            DOS[1] = new bool[] { false, false, false, false };

            AIS[0] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        private bool SerialInit()
        {
            bool isSucess = false;

            return isSucess;
        }

        public void Test()
        { 
            
        }
    }
}
