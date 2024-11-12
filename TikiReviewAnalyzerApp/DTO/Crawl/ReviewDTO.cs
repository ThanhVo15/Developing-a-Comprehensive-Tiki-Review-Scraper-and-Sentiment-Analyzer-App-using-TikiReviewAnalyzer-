using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReviewDTO
    {
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ReviewID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CreatedTime { get; set; }
        public string CustomerID { get; set; }
        public string ImagesURL { get; set; }
        public decimal? Rating { get; set; }

    }
}

