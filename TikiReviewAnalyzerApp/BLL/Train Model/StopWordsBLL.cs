using DAL.Train_Model;
using DTO.TrainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Train_Model
{
    public class StopWordsBLL
    {
        StopWordAccess swa = new StopWordAccess();

        public List<StopWordData> LayStopWords()
        {
            return swa.LayStopWords();
        }
    }
}
