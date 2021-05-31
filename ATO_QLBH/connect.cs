using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ATO_QLBH
{
    public static class connect
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SqlConnection connection;
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connection());
        }
        public static SqlConnection cn
        {
            get
            {
                connection = new SqlConnection(DTO_QLBH.Encode.Decrypt(System.IO.File.ReadAllText("connectionString.txt")));
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                connection.Open();
                return connection;
            }
        }
        public static bool KQCN()
        {
            if (connection.State != null)
                return true;
            else
                return false;
        }
        public static void Close()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
        public static DataTable dataTableFromQuery(string query)
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, cn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Close();
                    return dt;
                }
            }
            catch
            {
                return null;
            }
        }
        public static bool excQuery(string query)
        {
            try
            {
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    cm.ExecuteNonQuery();
                    Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
       
    }
}
