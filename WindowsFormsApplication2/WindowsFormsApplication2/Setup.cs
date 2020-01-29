using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WindowsFormsApplication2
{
    class st
    {
        static Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);        
        
        public st()
        {
            config.AppSettings.Settings.Add("11111111111111111111111111111", "3333333333333333");
            config.Save(ConfigurationSaveMode.Modified);
        }
        public static string GetConfig(string key)
        {

            string val = string.Empty;

            if (ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                val = ConfigurationManager.AppSettings[key];
            }
            return val;

        }

        public void test()
        { 
            
        }

    }
}
