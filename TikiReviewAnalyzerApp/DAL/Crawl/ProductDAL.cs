using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using DTO;

namespace DAL
{
    public class ProductDAL
    {
        private readonly string _connectionString;

        // Constructor to initialize the connection string from configuration
        public ProductDAL()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        // Inserts a new product record into the database with associated category
        public void InsertProduct(ProductDTO product, string categoryUrl)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                // Step 1: Check if ProductCategoryID exists in ProductCategory table
                string checkCategoryQuery = "SELECT COUNT(*) FROM Tiki.ProductCategory WHERE ProductCategoryID = @ProductCategoryID";
                SqlCommand checkCategoryCmd = new SqlCommand(checkCategoryQuery, conn);
                checkCategoryCmd.Parameters.AddWithValue("@ProductCategoryID", product.ProductCategoryID);

                conn.Open();
                int categoryExists = (int)checkCategoryCmd.ExecuteScalar();

                // Step 2: If ProductCategoryID does not exist, insert it into ProductCategory table
                if (categoryExists == 0)
                {
                    // Extract category text from the provided URL
                    string categoryText = ExtractCategoryTextFromUrl(categoryUrl);

                    string insertCategoryQuery = "INSERT INTO Tiki.ProductCategory (ProductCategoryID, ProductCategoryText, ProductCategoryLink) " +
                                                 "VALUES (@ProductCategoryID, @ProductCategoryText, @ProductCategoryLink)";
                    SqlCommand insertCategoryCmd = new SqlCommand(insertCategoryQuery, conn);
                    insertCategoryCmd.Parameters.AddWithValue("@ProductCategoryID", product.ProductCategoryID);
                    insertCategoryCmd.Parameters.AddWithValue("@ProductCategoryText", categoryText ?? (object)DBNull.Value);
                    insertCategoryCmd.Parameters.AddWithValue("@ProductCategoryLink", categoryUrl);

                    insertCategoryCmd.ExecuteNonQuery();
                }

                // Step 3: Insert product data into the Products table
                string query = "INSERT INTO Tiki.Products (ProductCategoryID, ProductID, ProductSKU, ProductName, ProductOriginalPrice, ProductPrice, ProductQuantitySold, RatingAverage, ReviewCount, UrlPath) " +
                               "VALUES (@ProductCategoryID, @ProductID, @ProductSKU, @ProductName, @ProductOriginalPrice, @ProductPrice, @ProductQuantitySold, @RatingAverage, @ReviewCount, @UrlPath)";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Assign parameter values for the Products table
                cmd.Parameters.AddWithValue("@ProductCategoryID", product.ProductCategoryID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                cmd.Parameters.AddWithValue("@ProductSKU", product.ProductSKU);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@ProductOriginalPrice", product.ProductOriginalPrice);
                cmd.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
                cmd.Parameters.AddWithValue("@ProductQuantitySold", product.ProductQuantitySold);
                cmd.Parameters.AddWithValue("@RatingAverage", product.RatingAverage);
                cmd.Parameters.AddWithValue("@ReviewCount", product.ReviewCount ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@UrlPath", product.UrlPath);

                cmd.ExecuteNonQuery();
            }
        }

        // Helper method to extract category text from a URL
        private string ExtractCategoryTextFromUrl(string url)
        {
            try
            {
                var uri = new Uri(url);
                var segments = uri.Segments;
                if (segments.Length > 1)
                {
                    return segments[segments.Length - 2].Trim('/'); // Extracts the segment before 'cXXXX' and removes '/'
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error extracting ProductCategoryText: {ex.Message}");
            }

            return null;
        }

        // Checks if a product already exists in the database
        public bool CheckDuplicateProduct(string productId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM [Tiki].[Products] WHERE ProductID = @ProductID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productId);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Returns true if product exists, false otherwise
            }
        }

        // Checks if product details already exist for a given product ID
        public bool CheckDuplicateProductDetail(string productId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM [Tiki].[ProductDetail] WHERE ProductID = @ProductID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productId);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Returns true if product details exist, false otherwise
            }
        }
    }
}
