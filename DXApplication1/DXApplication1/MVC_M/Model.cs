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

        static Model()
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

            AIS[0] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            AIS[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        }
        public Model()
        {

        }
    }
}