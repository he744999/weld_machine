﻿using System;
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
        }

        //--------------------------------------------------------------------------
        // 一号配料机

        public int RawValue1 { get => AIS[0][0]; set => AIS[0][0]= value; }

        public bool BigDoor1     { get => DOS[1][0]; set => DOS[1][0]= value; }
        public bool SmallDoor1   { get => DOS[1][1]; set => DOS[1][1]= value; }
        public bool WeightDoor1  { get => DOS[1][2]; set => DOS[1][2]= value; }


        //--------------------------------------------------------------------------
        // 二号配料机

        public int RawValue2 { get => AIS[0][1]; set => AIS[0][1] = value; }

        public bool BigDoor2 { get => DOS[2][0]; set => DOS[2][0] = value; }
        public bool SmallDoor2 { get => DOS[2][1]; set => DOS[2][1] = value; }
        public bool WeightDoor2 { get => DOS[2][2]; set => DOS[2][2] = value; }

        public bool HomeSwitch { get => DIS[1][0]; set => DIS[1][0] = value; }

        //--------------------------------------------------------------------------
        // Light状态机测试用
        public bool Light { get => DOS[0][0]; set => DOS[0][0] = value; }
        public bool WriteAction { get => DOS[0][1]; set => DOS[0][1] = value; }
        public bool ReadAction { get => DOS[0][2]; set => DOS[0][2] = value; }

        public bool LightSwitch { get => DIS[0][0]; set => DIS[0][0] = value; }
        public bool WriteSwitch { get => DIS[0][1]; set => DIS[0][1] = value; }
        public bool ReadSwitch { get => DIS[0][2]; set => DIS[0][2] = value; }

        //--------------------------------------------------------------------------
        // Stepper状态机测试用
        public bool LimitSwitch { get => DIS[1][0]; set => DOS[1][0] = value; }


    }
}