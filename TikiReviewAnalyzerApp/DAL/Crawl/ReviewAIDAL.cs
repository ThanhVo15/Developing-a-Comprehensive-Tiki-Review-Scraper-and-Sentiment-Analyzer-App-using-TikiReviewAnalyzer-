using System.Data.SqlClient;
using System.Configuration;
using DTO;
using System;

namespace DAL
{
    public class ReviewAIDAL
    {
        private readonly string _connectionString;

        public ReviewAIDAL()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        public int InsertReviewCate(ReviewGPTCateDTO reviewCate)
        {
            int insertedId = -1; // Khởi tạo giá trị mặc định để xác định lỗi nếu xảy ra
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    string query = "INSERT INTO [TikiReviewAnalyzer].[Tiki].[ReviewGPTCate] (ProductID, title, sub_title) OUTPUT INSERTED.ID VALUES (@ProductID, @Title, @SubTitle)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", reviewCate.ProductID);
                    cmd.Parameters.AddWithValue("@Title", reviewCate.Title ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@SubTitle", reviewCate.SubTitle ?? (object)DBNull.Value);

                    conn.Open();
                    insertedId = (int)cmd.ExecuteScalar(); // Lấy ID của bản ghi vừa chèn
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in InsertReviewCate: {ex.Message}");
                }
            }
            return insertedId;
        }

        public void InsertReview(ReviewGPTDTO review)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    string query = "INSERT INTO [TikiReviewAnalyzer].[Tiki].[ReviewGPT] (GPTCateID, texts) VALUES (@GPTCateID, @Text)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@GPTCateID", review.GPTCateID);
                    cmd.Parameters.AddWithValue("@Text", review.Text ?? (object)DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in InsertReview: {ex.Message}");
                }
            }
        }

    }
}
