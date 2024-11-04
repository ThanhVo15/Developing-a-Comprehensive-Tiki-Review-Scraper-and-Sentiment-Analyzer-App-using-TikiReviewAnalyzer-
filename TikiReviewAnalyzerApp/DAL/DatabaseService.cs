using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseService
    {
        public static SqlConnection connection = null;
        public static bool Connect(string serverName, string databaseName, string userName, string password)
        {
            if (connection != null && connection.State == ConnectionState.Open)
                return true;
            try
            {
                string strConn = "server=" + serverName + ";database=" + databaseName + ";user id=" + userName + ";pwd=" + password;
                SqlConnection con = new SqlConnection(strConn);
                connection = con;
                Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public static void Open()
        {
            if (connection != null && connection.State == ConnectionState.Closed)
                connection.Open();
        }
        public static void Close()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
