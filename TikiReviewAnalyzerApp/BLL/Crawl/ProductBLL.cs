using System.Collections.Generic;
using DTO;
using DAL;

namespace BLL
{
    public class ProductBLL
    {
        private readonly ProductDAL _productDAL;

        public ProductBLL()
        {
            _productDAL = new ProductDAL();
        }

        public void SaveProducts(List<ProductDTO> products, string categoryUrl)
        {
            foreach (var product in products)
            {
                if (!CheckDuplicateProduct(product.ProductID))
                {
                    _productDAL.InsertProduct(product, categoryUrl); 
                }
            }
        }

        public bool CheckDuplicateProduct(string productId)
        {
            return _productDAL.CheckDuplicateProduct(productId);
        }

        public bool CheckDuplicateProducts(List<ProductDTO> products)
        {
            foreach (var product in products)
            {
                if (CheckDuplicateProduct(product.ProductID))
                {
                    return true; // Nếu có bất kỳ sản phẩm nào trùng lặp, trả về true
                }
            }
            return false; 
        }
    }
}
