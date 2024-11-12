using DAL.Train_Model;
using DTO.TrainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Train_Model
{
    public class CmtBLL
    {
        CommentAccess cma = new CommentAccess();

        public List<CommentData> LayToanBoTikiComment()
        {
            return cma.LayToanBoTikiComment();
        }
    }
}
