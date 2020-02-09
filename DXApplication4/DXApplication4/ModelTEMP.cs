using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using System.Threading;
using System.IO.Ports;
using System.Diagnostics;
using System.Xml.Linq;


namespace DXApplication4
{
    class ModelTemp
    {

        public volatile static int[][] AIS = new int[2][];


        public double data_raw { get; set; }
        public double data_zero { get; set; }
        public double data_k { get; set; }
        public double data_show { get; set; }
        int loopInterrupt = 100;

        private Thread thd = null;

        public bool isRunning = false;

        private bool isEnding = false;


        public ModelTemp()
        {

            AIS[0] = new int[] { 0, 0, 100, 0, 0, 0, 0, 0 };
            thd = new Thread(new ThreadStart(weightUpdate));
            thd.Start();
            data_k = 0.52;
            data_zero = 50.0;
            data_raw = 100.0;

        }
        ~ModelTemp()
        {
            Console.WriteLine("pomelo");
            isEnding = true;
        }

        private void weightUpdate()
        {
            while (true)
            {
                data_show = ((data_raw - data_zero) * data_k);
                // Console.WriteLine(data_show);
                // Thread.Sleep(loopInterrupt);
                if (isEnding == true)
                {
                    break;
                }
            }
        }



        public void close()
        {
            // thd.Abort();
        }
    }
}
