using System;
using EasyModbus;
using System.Threading;
using System.IO.Ports;
using MathNet.Numerics;

namespace DXApplication1
{
    public class ModelTemp
    {

        //--------------------------------------------------------------------------
        // 全局输入/出模型

        public volatile static bool[][] DIS_OLD = new bool[3][];
        public EventHandler SendInputEvent;

        //--------------------------------------------------------------------------
        // 一号配料机
        public volatile  float currentWeight1;
        private volatile float kValue1 =   0.123000f;
        private volatile int oValue1 = 300;

        public int RawValue1 { get => Model.AIS[0][0]; set => Model.AIS[0][0] = value; }

        public float KValue1 { get => kValue1; set => kValue1 = value; }
        public int OValue1 { get => oValue1; set => oValue1 = value; }

        //--------------------------------------------------------------------------
        // 二号配料机
        public  volatile float currentWeight2;
        private volatile float kValue2 = 0.0000000f;
        private volatile int oValue2 = 300;

        public int RawValue2 { get => Model.AIS[0][1]; }
        public float KValue2 { get => kValue2; set => kValue2 = value; }
        public int OValue2 { get => oValue2; set => oValue2 = value; }

        private Thread thd;
        private Thread thd2;

        public ModelTemp()
        {
            DIS_OLD[0] = new bool[] { false, false, false, false };
            DIS_OLD[1] = new bool[] { false, false, false, false };
            DIS_OLD[2] = new bool[] { false, false, false, false };

            thd = new Thread(new ThreadStart(DataHandler));
            thd.Name = "modeltemp";
            thd.IsBackground = true;
            thd.Start();

            thd2 = new Thread(new ThreadStart(InputHandler));
            thd2.Name = "modelinput";
            thd2.IsBackground = true;
            thd2.Start();
        }

        private void InputHandler()
        {
            while(true)
            {
                for (int i = 0; i < DIS_OLD.Length; i++)
                {
                    for (int j = 0; j < DIS_OLD[i].Length; j++)
                    {
                        if (DIS_OLD[i][j] != Model.DIS[i][j])
                        {
                            if(i ==0 && j == 0)
                            {
                                SendInputEvent($"LightSwitch-{Model.DIS[i][j]}", EventArgs.Empty);
                            }
                            if (i == 0 && j == 1)
                            {
                                SendInputEvent($"WriteSwitch-{Model.DIS[i][j]}", EventArgs.Empty);
                            }
                            if (i == 0 && j == 2)
                            {
                                SendInputEvent($"ReadSwitch-{Model.DIS[i][j]}", EventArgs.Empty);
                            }
                            DIS_OLD[i][j] = Model.DIS[i][j];
                        }
                    }
                }
                Thread.Sleep(500);
            }
        }

        private void DataHandler()
        {
            while (true)
            {
                currentWeight1 = (((float)RawValue1 - oValue1)) * KValue1;

                currentWeight2 = (((float)RawValue2 - oValue2)) * KValue2;

                Thread.Sleep(500);
            }
        }
    }
}