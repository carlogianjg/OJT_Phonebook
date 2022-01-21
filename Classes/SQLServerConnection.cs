using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;

namespace OJT_012022_Activity1.Classes
{
    class DbClass
    {

        public static string GetConnectionStrings()
        {
            string strConString = ConfigurationManager.ConnectionStrings["conString"].ToString();
            return strConString;
        }

        public static string sql;
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand("", con);
        public static SqlDataReader rd;
        public static DataTable dt;
        public static SqlDataAdapter da;


        public static void openConnection()
        {
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    
                }
            }
            catch
            {
                
            }
        }

    }
}
