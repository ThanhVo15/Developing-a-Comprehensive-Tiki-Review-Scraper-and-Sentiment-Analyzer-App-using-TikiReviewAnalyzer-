using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string ProductCategoryID { get; set; }
        public string ProductID { get; set; }
        public string ProductSKU { get; set; }
        public string ProductName { get; set; }
        public int ProductOriginalPrice { get; set; }
        public int ProductPrice { get; set; }
        public int ProductQuantitySold { get; set; }
        public decimal RatingAverage { get; set; }
        public int? ReviewCount { get; set; }
        public string UrlPath { get; set; }
    }
}
