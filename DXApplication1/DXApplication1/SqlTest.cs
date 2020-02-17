using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DXApplication1
{
    class SqlTest
    {
        static SqlConnection conn = null;

        static SqlTest()
        {
            conn = new SqlConnection(
                new SqlConnectionStringBuilder()
                {
                    DataSource = "DESKTOP-78DJR73",
                    InitialCatalog = "test",
                    UserID = "sa",
                    Password = "1212"
                }.ConnectionString
            );
        }
        public SqlTest()
        {
        }


        
        public bool ConnectTest()
        {
            bool s = false;

            try
            {
                conn.Open();
                s = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                s = false;
            }
            return s;
        }
        public string squeryTest()
        {
            // string sqlinfo = "SELECT * FROM [test].[dbo].[Table_1]";
            string sqlinfo2 = @"INSERT INTO [test].[dbo].[User] VALUES (9, 'pomelo', '12331')";
            SqlCommand command = new SqlCommand(sqlinfo2, conn);
            command.CommandTimeout = 10;
            object res = command.ExecuteScalar();
            conn.Close();
            return "2323";
        }
    }
}
