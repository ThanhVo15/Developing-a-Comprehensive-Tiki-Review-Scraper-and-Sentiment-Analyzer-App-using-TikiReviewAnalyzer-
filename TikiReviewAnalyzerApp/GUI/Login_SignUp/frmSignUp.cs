using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Login_SignUp
{
    public partial class frmSignUp : Form
    {
        private bool isEmailValid = false;
        private bool isPhoneNumberValid = false;
        private bool isUserNameValid = false;
        private bool isRepeatPasswordValid = false;
        public frmSignUp()
        {
            InitializeComponent();

            lblSubTitle.BackColor = Color.Transparent;
            lblTitle.BackColor = Color.Transparent;
            lblFirstName.BackColor = Color.Transparent;
            lblLastName.BackColor = Color.Transparent;
            lblDateOfBirth.BackColor = Color.Transparent;
            lblEmail.BackColor = Color.Transparent;
            lblPhoneNumber.BackColor = Color.Transparent;
            lblUserName.BackColor = Color.Transparent;
            lblPassword.BackColor = Color.Transparent;
            lblRepeatPassword.BackColor = Color.Transparent;
            lblDontHaveAccount.BackColor = Color.Transparent;
            lblLogin.BackColor = Color.Transparent;
            pictureBoxEmail.BackColor = Color.Transparent;
            pictureBoxPhoneNumber.BackColor = Color.Transparent;
            pictureBoxUserName.BackColor = Color.Transparent;
            pictureBoxRepeatPass.BackColor = Color.Transparent;
            txtPassword.UseSystemPasswordChar = true;
            txtRepeatword.UseSystemPasswordChar = true;
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            isEmailValid = IsValidEmail(txtEmail.Text);
            if (isEmailValid)
            {
                pictureBoxEmail.Visible = true;
                pictureBoxEmail.Image = Properties.Resources.right;                
            }
            else
            {
                pictureBoxEmail.Visible = true;
                pictureBoxEmail.Image = Properties.Resources.wrong;
            }
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\d{10}$"; // 10 chữ số
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isPhoneNumberValid = IsValidPhoneNumber(txtPhoneNumber.Text);

            if (isPhoneNumberValid)
            {
                pictureBoxPhoneNumber.Visible = true;
                pictureBoxPhoneNumber.Image = Properties.Resources.right;
            }
            else
            {
                pictureBoxPhoneNumber.Visible = true;
                pictureBoxPhoneNumber.Image = Properties.Resources.wrong;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            string serverName = "THANH-OS\\MSSQLSERVER01"; // Replace with actual server name
            string databaseName = "TikiReviewAnalyzer"; // Replace with actual database name
            isUserNameValid = !userBLL.CheckUsernameExist(serverName, databaseName, txtUsername.Text);

            if (isUserNameValid)
            {
                pictureBoxUserName.Visible = true;
                pictureBoxUserName.Image = Properties.Resources.right;
            }
            else
            {
                pictureBoxUserName.Visible = true;
                pictureBoxUserName.Image = Properties.Resources.wrong;
            }
        }

        private void txtRepeatword_Leave(object sender, EventArgs e)
        {
            isRepeatPasswordValid = txtPassword.Text == txtRepeatword.Text;

            if (isRepeatPasswordValid)
            {
                pictureBoxRepeatPass.Visible = true;
                pictureBoxRepeatPass.Image = Properties.Resources.right;
            }
            else
            {
                pictureBoxRepeatPass.Visible = true;
                pictureBoxRepeatPass.Image = Properties.Resources.wrong;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!isEmailValid || !isPhoneNumberValid || !isUserNameValid || !isRepeatPasswordValid)
            {
                MessageBox.Show("Some fields are incorrect. Please fix them before registering.");
                return;
            }
            UserDTO newUser = new UserDTO
            {
                AccFirstName = txtFirstName.Text,
                AccLastName = txtLastName.Text,
                AccEmail = txtEmail.Text,
                AccPhoneNumber = txtPhoneNumber.Text,
                AccDateOfBirth = DateOfBirth.Value,
                AccUserName = txtUsername.Text,
                AccPassword = txtPassword.Text
            };

            UserBLL userBLL = new UserBLL();
            string serverName = "THANH-OS\\MSSQLSERVER01"; // Thay thế bằng tên server thực tế
            string databaseName = "TikiReviewAnalyzer"; // Thay thế bằng tên database thực tế
            bool result = userBLL.RegisterUser(serverName, databaseName, newUser);

            if (result)
            {
                MessageBox.Show("Registration successful!");
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
            frmLogin Main = new frmLogin();

            Main.FormClosed += (s, args) => this.Hide();

            Main.Show();
            this.Hide();
        }
    }
}
