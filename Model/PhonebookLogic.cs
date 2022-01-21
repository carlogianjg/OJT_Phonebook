using Data_Storage_using_SQL_server.Helper_Code.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data_Storage_using_SQL_server.Model.BusinessLogic.Helper_Code.Common
{
    public class PhonebookLogic
    {
        public static void SaveInfo(string FirstName)
        {
            try
            {
                
                string query = "INSERT INTO [PhoneBook] ([FirstName])" +
                                " Values ('" +FirstName+ "')";

                DAL.executeQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}