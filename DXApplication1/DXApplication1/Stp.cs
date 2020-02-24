using System;
using SharpConfig;
using System.Management;


namespace DXApplication1
{
    class Stp
    {
        // 
        static string filename = @"C:\Users\pomelo\Desktop\t\DXApplication1\DXApplication1\setup.cfg";

        static Configuration config = Configuration.LoadFromFile(filename);
        public string Guid   { get => config["Start"]["guid"].StringValue; set => config["Start"]["guid"].StringValue= value; }

        public double   K1      { get => config["Start"]["k1"].DoubleValue;   set => config["Start"]["k1"].DoubleValue= value; }
        public int      Ovalue1 { get => config["Start"]["0Value1"].IntValue; set => config["Start"]["0Value1"].IntValue= value; }
        public double   K2      { get => config["Start"]["k2"].DoubleValue;   set => config["Start"]["k2"].DoubleValue = value; }
        public int      Ovalue2 { get => config["Start"]["0Value2"].IntValue; set => config["Start"]["0Value2"].IntValue = value; }

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