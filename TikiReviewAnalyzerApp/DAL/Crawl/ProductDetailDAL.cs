using System;
using System.Configuration;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ProductDetailDAL
    {
        private readonly string _connectionString;

        public ProductDetailDAL()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        public void InsertProductDetail(ProductDetailDTO productDetail)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Tiki.ProductDetail (ProductID, ProdDescriptions, ProdShortDescriptions, ProdURL, spid, SellerID) " +
                               "VALUES (@ProductID, @ProdDescriptions, @ProdShortDescriptions, @ProdURL, @spid, @SellerID)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productDetail.ProductID);
                cmd.Parameters.AddWithValue("@ProdDescriptions", productDetail.ProdDescriptions ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ProdShortDescriptions", productDetail.ProdShortDescriptions ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ProdURL", productDetail.ProdURL ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@spid", productDetail.spid ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SellerID", productDetail.SellerID ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public ProductDetailDTO GetProductDetailByProductID(string productID)
        {
            ProductDetailDTO productDetail = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT ProductID, ProdDescriptions, ProdShortDescriptions, ProdURL, spid, SellerID " +
                               "FROM Tiki.ProductDetail WHERE ProductID = @ProductID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productID);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        productDetail = new ProductDetailDTO
                        {
                            ProductID = reader["ProductID"].ToString(),
                            ProdDescriptions = reader["ProdDescriptions"]?.ToString(),
                            ProdShortDescriptions = reader["ProdShortDescriptions"]?.ToString(),
                            ProdURL = reader["ProdURL"]?.ToString(),
                            spid = reader["spid"]?.ToString(),
                            SellerID = reader["SellerID"]?.ToString()
                        };
                    }
                }
            }

            return productDetail;
        }

        public bool CheckDuplicateProductDetail(string productId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM Tiki.ProductDetail WHERE ProductID = @ProductID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productId);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
