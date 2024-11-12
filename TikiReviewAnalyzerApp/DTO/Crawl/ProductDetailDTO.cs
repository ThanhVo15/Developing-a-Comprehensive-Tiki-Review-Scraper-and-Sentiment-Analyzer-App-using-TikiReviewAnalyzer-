using System.Net.Configuration;

namespace DTO
{
    public class ProductDetailDTO
    {
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ProdDescriptions { get; set; }
        public string ProdShortDescriptions { get; set; } 
        public string ProdURL { get; set; } 
        public string SellerID { get; set; }
        public string spid { get; set; }
    }
}
