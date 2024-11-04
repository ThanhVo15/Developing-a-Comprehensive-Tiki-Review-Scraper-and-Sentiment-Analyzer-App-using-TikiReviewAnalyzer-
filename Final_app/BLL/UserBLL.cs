using DAL;
using DTO;

namespace BLL
{
    public class UserBLL
    {
        private UserDAL userDAL = new UserDAL();

        // Cập nhật thứ tự tham số theo cách mà bạn truyền từ GUI
        public bool Login(string serverName, string databaseName, string username, string password)
        {
            // Gọi DAL để xác thực người dùng với đầy đủ các tham số
            return userDAL.ValidateUser(serverName, databaseName, username, password);
        }

        public bool CheckUsernameExist(string serverName, string databaseName, string username)
        {
            return userDAL.CheckUsernameExist(serverName, databaseName, username);
        }

        public bool RegisterUser(string serverName, string databaseName, UserDTO user)
        {
            // Có thể bổ sung thêm logic khác tại đây, ví dụ mã hóa mật khẩu, kiểm tra điều kiện khác, v.v.
            return userDAL.RegisterUser(serverName, databaseName, user);
        }

        public bool CheckUserInfo(string serverName, string databaseName, string userName, string email, string phoneNumber)
        {
            return userDAL.CheckUserInfo(serverName, databaseName, userName, email, phoneNumber);
        }

        public bool UpdatePassword(string serverName, string databaseName, string userName, string newPassword)
        {
            return userDAL.UpdatePassword(serverName, databaseName, userName, newPassword);
        }
    }
}
