using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Login_SignUp
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
            lblTitle.BackColor = Color.Transparent;
            lblSubTitle.BackColor = Color.Transparent;
            lblUserName.BackColor = Color.Transparent;
            lblEmail.BackColor = Color.Transparent;
            lblPhoneNumber.BackColor = Color.Transparent;
            lblPassword.BackColor = Color.Transparent;
            lblRepeatPassword.BackColor = Color.Transparent;
            lblDontHaveAccount.BackColor = Color.Transparent;
            lblLogin.BackColor = Color.Transparent;
            txt_PassWord.UseSystemPasswordChar = true;
            txt_Repeatword.UseSystemPasswordChar = true;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frmLogin Main = new frmLogin();

            Main.FormClosed += (s, args) => this.Hide();

            Main.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (txt_PassWord.Text != txt_Repeatword.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            string serverName = "THANH-OS\\MSSQLSERVER01"; // Thay thế bằng tên server thực tế
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
                    frmLogin Main = new frmLogin();

                    Main.FormClosed += (s, args) => this.Hide();

                    Main.Show();
                    this.Hide();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmLogin Main = new frmLogin();

            Main.FormClosed += (s, args) => this.Hide();

            Main.Show();
            this.Hide();
        }
    }
}
