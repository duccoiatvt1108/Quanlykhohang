using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace Tạo_Bảng_Biểu
{
    public static class ConnectData
    {
        public static string ConnectString = @"Data Source=DESKTOP-0MIFM7F\SQLEXPRESS;Initial Catalog=QLK;Integrated Security=True";
        public static SqlConnection con;

        public static void Connect()
        {
            con = new SqlConnection(ConnectString);
            con.Open();
        }
        public static void Close()
        {
            con.Close();
        }
    }
}
