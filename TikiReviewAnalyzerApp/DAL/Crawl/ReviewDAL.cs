using System;
using System.Data.SqlClient;
using System.Configuration;
using DTO;

namespace DAL
{
    public class ReviewDAL
    {
        private readonly string _connectionString;

        public ReviewDAL()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        public void InsertReview(ReviewDTO review)
        {
            string query = "INSERT INTO Tiki.Review (ProductID, ReviewID, Title, Content, Created_Time, CustomerID, ImagesURL, Rating) " +
                           "VALUES (@ProductID, @ReviewID, @Title, @Content, @CreatedTime, @CustomerID, @ImagesURL, @Rating)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", review.ProductID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ReviewID", review.ReviewID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Title", review.Title ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Content", review.Content ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CreatedTime", review.CreatedTime ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CustomerID", review.CustomerID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ImagesURL", review.ImagesURL ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Rating", review.Rating ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public bool CheckDuplicateReview(string reviewId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM [Tiki].[Review] WHERE ReviewID = @ReviewID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReviewID", reviewId);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
