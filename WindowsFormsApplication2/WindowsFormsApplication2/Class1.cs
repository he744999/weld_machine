using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class sql
    {
        static string str = "server=DESKTOP-69FPAO3\\SQLEXPRESS12;database=test;uid=sa;pwd=12";
        private static SqlConnection sql1 = new SqlConnection(str);
        
        public sql()
        { 
            
        }
        public static bool test()
        {
            bool s = false;
            try
            {
                sql1.Open();
                s = true;
                Console.WriteLine("success");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                s = false;
                Console.WriteLine("error");
            }
            return s;
        }
    }
}
