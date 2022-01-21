using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Storage_using_SQL_server.Helper_Code.Common
{
    public class DAL
    {
        public static int executeQuery(string query)
        {
            // Initialization.  
            int rowCount = 0;
            string strConn = "Data Source=GIANGENSQLEXPRESS;Database=SQL Database Name;User Id=SQL User Name;Password=SQL Password;";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
              
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandTimeout = 12 * 3600; 

               
                sqlConnection.Open();

                rowCount = sqlCommand.ExecuteNonQuery();

       
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                
                sqlConnection.Close();

                throw ex;
            }

            return rowCount;
        }
    }
}