using DTO.TrainModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Train_Model
{
    public class CommentAccess : AccessDatabase
    {
        public List<CommentData> LayToanBoTikiComment()
        {
            List<CommentData> dscmt = new List<CommentData>();
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select * from [tiki_book_comments]";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int stt = reader.GetInt32(0);
                string cmt = reader.GetString(1);
                int label = reader.GetInt32(2);

                CommentData cmtdata = new CommentData();
                cmtdata.stt = stt;
                cmtdata.cmt = cmt;
                cmtdata.label = label;
                dscmt.Add(cmtdata);
            }
            reader.Close();
            return dscmt;
        }
    }
}
