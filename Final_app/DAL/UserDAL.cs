using DTO;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL
    {
        // Phương thức xác thực người dùng với thông tin về server và database
        public bool ValidateUser(string serverName, string databaseName, string username, string password)
        {
            // Chuỗi kết nối động
            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";

            // Truy vấn SQL kiểm tra người dùng trong bảng Users.Account
            string query = "SELECT COUNT(*) FROM Users.Account WHERE AccUserName = @username AND AccPassword = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;  // Nếu có dữ liệu trả về true
            }
        }

        public bool RegisterUser(string serverName, string databaseName, UserDTO user)
        {
            // Chuỗi kết nối động
            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";

            // Truy vấn SQL thêm người dùng vào bảng Users.Account
            string query = "INSERT INTO Users.Account (AccFirstName, AccLastName, AccEmail, AccPhoneNumber, AccDateOfBirth, AccUserName, AccPassword) " +
                           "VALUES (@firstName, @lastName, @email, @phoneNumber, @dateOfBirth, @username, @password)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstName", user.AccFirstName);
                cmd.Parameters.AddWithValue("@lastName", user.AccLastName);
                cmd.Parameters.AddWithValue("@email", user.AccEmail);
                cmd.Parameters.AddWithValue("@phoneNumber", user.AccPhoneNumber);
                cmd.Parameters.AddWithValue("@dateOfBirth", user.AccDateOfBirth);
                cmd.Parameters.AddWithValue("@username", user.AccUserName);
                cmd.Parameters.AddWithValue("@password", user.AccPassword);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;  // Nếu có dữ liệu thêm vào trả về true
            }
        }

        // Phương thức kiểm tra tên người dùng đã tồn tại chưa
        public bool CheckUsernameExist(string serverName, string databaseName, string username)
        {
            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";
            string query = "SELECT COUNT(*) FROM Users.Account WHERE AccUserName = @username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Phương thức kiểm tra thông tin người dùng
        public bool CheckUserInfo(string serverName, string databaseName, string userName, string email, string phoneNumber)
        {
            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";
            string query = "SELECT COUNT(*) FROM Users.Account WHERE AccUserName = @userName AND AccEmail = @Email AND AccPhoneNumber = @PhoneNumber";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Phương thức cập nhật mật khẩu
        public bool UpdatePassword(string serverName, string databaseName, string userName, string newPassword)
        {
            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";
            string query = "UPDATE Users.Account SET AccPassword = @Password WHERE AccUserName = @UserName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@UserName", userName);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
