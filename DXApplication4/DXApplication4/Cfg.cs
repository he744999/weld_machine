using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpConfig;

namespace DXApplication4
{
    class Cfg
    {
        static string filename = "2.cfg";
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
        }



        public void ChangeEvent(bool p)
        {
            config["Start"]["IsAutoConnect"].IntValue = p ? 1 : 0;
            
        }
    }
}
