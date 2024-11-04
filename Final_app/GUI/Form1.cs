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
using System.Xml.Linq;
using GUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetPlacholder(txtDatabase, "Database");
            SetPlacholder(txtPassword, "Password");
            SetPlacholder(txtSeverName, "Server Name");
            SetPlacholder(txtUserName, "User Name");
        }

        private void SetPlacholder(TextBox textBox, string placeholder)
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
                    if (textBox == txtPassword)
                    {
                        textBox.UseSystemPasswordChar = true;
                    }
                        
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (textBox.Text == "")
                {
                    if(textBox == txtPassword)
                    {
                        textBox.UseSystemPasswordChar = false;
                    }
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
       
        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string serverName = txtSeverName.Text;       // Tên server từ giao diện
            string databaseName = txtDatabase.Text;   // Tên database từ giao diện
            string username = txtUserName.Text;           // Username từ giao diện
            string password = txtPassword.Text;

            UserBLL userBLL = new UserBLL();
            bool isLoggedIn = userBLL.Login(serverName, databaseName, username, password);

            if (isLoggedIn)
            {
                // Đăng nhập thành công
                MessageBox.Show("Login successful!");
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Login failed!");
            }
        }

        private void lbl_Create_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void linkLabel_forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassForm resetPassForm = new ResetPassForm();
            resetPassForm.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ResetPassForm resetPassForm = new ResetPassForm();
            resetPassForm.ShowDialog();
        }
    }
}
