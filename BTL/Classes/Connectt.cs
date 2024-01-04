using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.Classes
{
    class Connectt
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public SqlConnection OpenDB()
        {
            conn = new SqlConnection("Data Source=VDT\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
            return conn;
        }
        public static void OpenConnection()
        {
            string sql = "Data Source=VDT\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
            try
            {
                conn = new SqlConnection(sql);
                conn.Open();
            }
            catch (Exception ex)
            {

            }
        }
        public static void DisConnection()
        {
            conn.Close();
            conn.Dispose();
            conn = null;

        }
    }
}
