using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO_QLBH
{
    public class Backup
    {
        public static void BackUp()
        {
            //Connect to DB
            SqlConnection connect;
            string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            connect = new SqlConnection(con);
            connect.Open();
            //----------------------------------------------------------------------------------------------------

            //Execute SQL---------------
            SqlCommand command;
            command = new SqlCommand(@"backup database QLBH to disk ='c:\SQLBackup\wcBackUp1.bak' with init,stats=10", connect);
            command.ExecuteNonQuery();
            //-------------------------------------------------------------------------------------------------------------------------------
            connect.Close();

                //
        }
        public static void Restore()
        {
            //Connect SQL-----------
            SqlConnection connect;
            string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            connect = new SqlConnection(con);
            connect.Open();
            //-----------------------------------------------------------------------------------------

            //Excute SQL----------------
            SqlCommand command;
            command = new SqlCommand("use master", connect);
            command.ExecuteNonQuery();
            command = new SqlCommand(@"restore database QLBH_Restore from disk = 'c:\SQLBackup\wcBackUp1.bak'", connect);
            command.ExecuteNonQuery();
            //--------------------------------------------------------------------------------------------------------
            connect.Close();
        }
    }
}
