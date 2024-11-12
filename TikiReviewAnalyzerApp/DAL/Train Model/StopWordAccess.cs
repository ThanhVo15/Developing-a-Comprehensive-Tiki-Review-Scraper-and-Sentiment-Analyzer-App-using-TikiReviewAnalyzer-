using DTO.TrainModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Train_Model
{
    public class StopWordAccess : AccessDatabase
    {
        public List<StopWordData> LayStopWords()
        {
            List<StopWordData> dsStopWords = new List<StopWordData>();
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select * from [vietnamese-stopwords]";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string strop_words = reader.GetString(1);

                StopWordData stopWord = new StopWordData();
                stopWord.id = id;
                stopWord.stop_words = strop_words;
                dsStopWords.Add(stopWord);
            }
            reader.Close();
            return dsStopWords;
        }
    }
}
