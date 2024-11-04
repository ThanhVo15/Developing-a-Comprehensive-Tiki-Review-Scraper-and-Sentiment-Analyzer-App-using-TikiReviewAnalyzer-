using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class ResetPassForm : Form
    {
        public ResetPassForm()
        {
            InitializeComponent();
            SetPlaceholder(txt_PassWord, "Password");
            SetPlaceholder(txtUserName, "User Name");
            SetPlaceholder(txt_Email, "Email");
            SetPlaceholder(txt_PhoneNumber, "Phone Number");
            SetPlaceholder(txt_RepeatPassWord, "Repeat Password");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            textBox.UseSystemPasswordChar = false;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                    if (textBox == txt_PassWord || textBox == txt_RepeatPassWord)
                    {
                        textBox.UseSystemPasswordChar = true;
                    }
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (textBox.Text == "")
                {
                    if (textBox == txt_PassWord || textBox == txt_RepeatPassWord)
                    {
                        textBox.UseSystemPasswordChar = false;
                    }
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void ResetPassForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường nhập liệu
            if (txt_PassWord.Text != txt_RepeatPassWord.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            string serverName = "IAMCUBE\\IAMCUBE"; // Thay thế bằng tên server thực tế
            string databaseName = "TikiReviewAnalyzer"; // Thay thế bằng tên database thực tế

            UserBLL userBLL = new UserBLL();

            // Kiểm tra thông tin người dùng
            bool isUserValid = userBLL.CheckUserInfo(serverName, databaseName, txtUserName.Text, txt_Email.Text, txt_PhoneNumber.Text);

            if (isUserValid)
            {
                // Cập nhật mật khẩu mới
                bool isPasswordUpdated = userBLL.UpdatePassword(serverName, databaseName, txtUserName.Text, txt_PassWord.Text);

                if (isPasswordUpdated)
                {
                    MessageBox.Show("Password reset successful!");
                }
                else
                {
                    MessageBox.Show("Password reset failed. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("User information is incorrect. Please try again.");
            }
        }
    }
}
