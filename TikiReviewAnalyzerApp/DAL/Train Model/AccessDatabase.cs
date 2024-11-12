using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Train_Model
{
    public class AccessDatabase
    {
        protected SqlConnection conn = null;
        string strConn = "Server=THANH-OS\\MSSQLSERVER01; Database=TikiReviewAnalyzer; User Id=sa; Password=123456;";

        public void OpenConnection()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
