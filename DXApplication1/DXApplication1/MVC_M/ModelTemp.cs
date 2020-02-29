using System;
using EasyModbus;
using System.Threading;
using System.IO.Ports;
using MathNet.Numerics;

namespace DXApplication1
{
    public partial class ModelTemp
    {

        //--------------------------------------------------------------------------
        // 全局输入/出模型


        //--------------------------------------------------------------------------
        // 一号配料机
        public volatile  float currentWeight1;
        private volatile float kValue1 =   0.123000f;
        private volatile int oValue1 = 300;

        public int RawValue1 { get => Model.AIS[0][0];  }
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

        public ModelTemp()
        {
            thd = new Thread(new ThreadStart(DataHandler));
            thd.Name = "modeltemp";
            thd.IsBackground = true;
            thd.Start();
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