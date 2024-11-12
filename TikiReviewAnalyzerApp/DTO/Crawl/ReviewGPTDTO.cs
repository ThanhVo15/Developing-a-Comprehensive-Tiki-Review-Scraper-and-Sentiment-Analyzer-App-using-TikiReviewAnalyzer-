using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReviewGPTDTO
    {
        public int ID { get; set; } 
        public int GPTCateID { get; set; }
        public string Text { get; set; } 
    }
}
