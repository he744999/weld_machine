using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpConfig;
using System.Management;

namespace DXApplication4
{
    class Cfg
    {
        static string filename = @"C:\Users\heli7\Desktop\weld_machine\DXApplication4\DXApplication4\2.cfg";
        static Configuration config = Configuration.LoadFromFile(filename);

        Section sec = config["General"];
        public int ttt;


        public Cfg()
        {
            ttt= config["Start"]["IsAutoConnect"].IntValue;

        }
        ~Cfg()
        {
            config.SaveToFile(filename);
        }

        public void test()
        {
            int IsAuto = config["Start"]["IsAutoConnect"].IntValue;
            Console.WriteLine(IsAuto);
            ManagementObject searcher = new ManagementObject("SELECT * FROM Win32_PhysicalMedia");

        }



        public void ChangeEvent(bool p)
        {
            config["Start"]["IsAutoConnect"].IntValue = p ? 1 : 0;
            
        }
    }
}
