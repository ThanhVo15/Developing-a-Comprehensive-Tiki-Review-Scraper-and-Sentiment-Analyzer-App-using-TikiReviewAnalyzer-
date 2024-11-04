using System;

namespace DTO
{
    public class LoginInfo
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool SaveInfor { get; set; }
        public bool IsTrustMode { get; set; }
    }
}
