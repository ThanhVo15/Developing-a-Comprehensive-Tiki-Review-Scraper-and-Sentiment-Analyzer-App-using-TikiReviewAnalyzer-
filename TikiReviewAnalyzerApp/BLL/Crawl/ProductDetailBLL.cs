using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class ProductDetailBLL
    {
        private readonly ProductDetailDAL _productDetailDAL;

        public ProductDetailBLL()
        {
            _productDetailDAL = new ProductDetailDAL();
        }
        public ProductDetailDTO GetProductDetailByProductID(string productID)
        {
            return _productDetailDAL.GetProductDetailByProductID(productID);
        }
        public void SaveProductDetail(ProductDetailDTO productDetail)
        {
            // Kiểm tra trùng lặp trước khi lưu vào cơ sở dữ liệu
            if (!_productDetailDAL.CheckDuplicateProductDetail(productDetail.ProductID))
            {
                _productDetailDAL.InsertProductDetail(productDetail);
            }
        }

        public bool CheckDuplicateProductDetail(string productId)
        {
            return _productDetailDAL.CheckDuplicateProductDetail(productId);
        }
    }
}
