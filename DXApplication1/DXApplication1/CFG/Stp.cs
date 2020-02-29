using System;
using SharpConfig;
using System.Management;


namespace DXApplication1
{
    class Stp
    {
        // 
        static string filename = @"C:\Users\pomelo\Desktop\t\DXApplication1\DXApplication1\CFG\setup.cfg";

        static Configuration config = Configuration.LoadFromFile(filename);
        public string Guid   { get => config["Start"]["guid"].StringValue; set => config["Start"]["guid"].StringValue= value; }

        public float K1      { get => config["cheng1"]["k"].FloatValue;   set => config["cheng1"]["k"].FloatValue= value; }
        public int Ovalue1 { get => config["cheng1"]["0Value"].IntValue; set => config["cheng1"]["0Value"].IntValue = value; }

        public float K2      { get => config["cheng2"]["k"].FloatValue;   set => config["cheng2"]["k"].FloatValue= value; }
        public int Ovalue2 { get => config["cheng2"]["0Value"].IntValue; set => config["cheng2"]["0Value"].IntValue = value; }

        public int IsAutoConnectMdb { get => config["Start"]["IsAutoConnectMdb"].IntValue; set => config["Start"]["IsAutoConnectMdb"].IntValue = value; }
        public int IsAutoConnectStepper { get => config["Start"]["IsAutoConnectStepper"].IntValue; set => config["Start"]["IsAutoConnectStepper"].IntValue = value; }

        public string LastSerialPort { get => config["Start"]["LastSerialPort"].StringValue; set => config["Start"]["LastSerialPort"].StringValue = value; }

        public Stp()
        {
        }
        ~Stp()
        {
            config.SaveToFile(filename);
        }

    }
}