using System;

namespace DTO
{
    public class UserDTO
    {
        public int AccID { get; set; }
        public string AccFirstName { get; set; }
        public string AccLastName { get; set; }
        public string AccEmail { get; set; }
        public string AccPhoneNumber { get; set; }
        public DateTime AccDateOfBirth { get; set; }
        public string AccUserName { get; set; }
        public string AccPassword { get; set; }

        // Constructor không tham số (nếu cần thiết)
        public UserDTO() { }

        // Constructor đầy đủ tham số (nếu muốn khởi tạo với dữ liệu ngay khi tạo đối tượng)
        public UserDTO(int accID, string accFirstName, string accLastName, string accEmail,
                       string accPhoneNumber, DateTime accDateOfBirth, string accUserName, string accPassword)
        {
            AccID = accID;
            AccFirstName = accFirstName;
            AccLastName = accLastName;
            AccEmail = accEmail;
            AccPhoneNumber = accPhoneNumber;
            AccDateOfBirth = accDateOfBirth;
            AccUserName = accUserName;
            AccPassword = accPassword;
        }
    }
}