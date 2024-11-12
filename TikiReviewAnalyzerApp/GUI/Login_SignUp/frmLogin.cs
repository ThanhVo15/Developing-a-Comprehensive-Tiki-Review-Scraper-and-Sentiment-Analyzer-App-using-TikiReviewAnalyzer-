using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Configuration;
using BLL;

namespace GUI.Login_SignUp
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
            LoadSettings();
            pictureBox1.BackColor = Color.Transparent;
            lblSubTitle.BackColor = Color.Transparent;
            lblTitle.BackColor = Color.Transparent;
            lblDatabase.BackColor = Color.Transparent;
            lblServerName.BackColor = Color.Transparent;
            lblUserName.BackColor = Color.Transparent;
            lblPassword.BackColor = Color.Transparent;
            lblDontHaveAccount.BackColor = Color.Transparent;
            lblCreateOne.BackColor = Color.Transparent;
            lblForgetPassword.BackColor = Color.Transparent;
            chkRememberPassword.BackColor = Color.Transparent;
            radSQLMode.BackColor = Color.Transparent;
            radTrustMode.BackColor = Color.Transparent;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSettings()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                txtSeverName.Text = Properties.Settings.Default.ServerName;
                txtDatabase.Text = Properties.Settings.Default.DatabaseName;
                txtUserName.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
                chkRememberPassword.Checked = true;
            }
        }
        private void SaveSettings()
        {
            if (chkRememberPassword.Checked)
            {
                Properties.Settings.Default.ServerName = txtSeverName.Text;
                Properties.Settings.Default.DatabaseName = txtDatabase.Text;
                Properties.Settings.Default.Username = txtUserName.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.RememberMe = true;
            }
            else
            {
                Properties.Settings.Default.ServerName = string.Empty;
                Properties.Settings.Default.DatabaseName = string.Empty;
                Properties.Settings.Default.Username = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.RememberMe = false;
            }
            Properties.Settings.Default.Save();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string serverName = txtSeverName.Text;      
            string databaseName = txtDatabase.Text;   
            string username = txtUserName.Text;           
            string password = txtPassword.Text;

            UserBLL userBLL = new UserBLL();
            bool isLoggedIn = userBLL.Login(serverName, databaseName, username, password);

            if (isLoggedIn)
            {
                // Đăng nhập thành công
                SaveSettings();
                MessageBox.Show("Login successful!");
                fmMain Main = new fmMain();
                Main.FormClosed += (s, args) => this.Hide();

                Main.Show();
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Login failed!");
            }
        }


        private void lblCreateOne_Click(object sender, EventArgs e)
        {
            frmSignUp signUpForm = new frmSignUp();

            signUpForm.FormClosed += (s, args) => this.Show();

            signUpForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword Main = new frmForgotPassword();

            Main.FormClosed += (s, args) => this.Hide();

            Main.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
