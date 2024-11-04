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
using BLL;
using DTO;

namespace GUI
{
    public partial class RegisterForm : Form
    {
        private bool isEmailValid = false;
        private bool isPhoneNumberValid = false;
        private bool isUserNameValid = false;
        private bool isRepeatPasswordValid = false;

        public RegisterForm()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            comboBoxDay.Items.Add("Day");
            comboBoxMonth.Items.Add("Month");
            comboBoxYear.Items.Add("Year");

            // Điền dữ liệu vào ComboBox ngày
            for (int i = 1; i <= 31; i++)
            {
                comboBoxDay.Items.Add(i.ToString());
            }

            // Điền dữ liệu vào ComboBox tháng
            for (int i = 1; i <= 12; i++)
            {
                comboBoxMonth.Items.Add(i.ToString());
            }

            // Điền dữ liệu vào ComboBox năm
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= 1900; i--)
            {
                comboBoxYear.Items.Add(i.ToString());
            }

            // Đặt giá trị mặc định
            comboBoxDay.SelectedIndex = 0;
            comboBoxMonth.SelectedIndex = 0;
            comboBoxYear.SelectedIndex = 0;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            SetPlacholder(txt_FirstName, "First Name");
            SetPlacholder(txt_LastName, "Last Name");
            SetPlacholder(txt_Email, "Email");
            SetPlacholder(txt_PhoneNumber, "Phone Number");
            SetPlacholder(txt_UserName, "User Name");
            SetPlacholder(txt_PassWord, "Password");
            SetPlacholder(txt_RepeatPassword, "Repeat Password");
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
                    if (textBox == txt_PassWord || textBox == txt_RepeatPassword)
                    {
                        textBox.UseSystemPasswordChar = true;
                    }
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (textBox.Text == "")
                {
                    if (textBox == txt_PassWord || textBox == txt_RepeatPassword)
                    {
                        textBox.UseSystemPasswordChar = false;
                    }
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        // Hàm kiểm tra định dạng Email
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_PhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (IsValidEmail(txt_Email.Text))
            {
                isEmailValid = true;
                pictureBoxEmail.Visible = true;
                pictureBoxEmail.Image = Properties.Resources.right;
            }
            else
            {
                isEmailValid = false;
                pictureBoxEmail.Visible = true;
                pictureBoxEmail.Image = Properties.Resources.wrong;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\d{10}$"; // 10 chữ số
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void txt_PhoneNumber_Leave(object sender, EventArgs e)
        {
            if (IsValidPhoneNumber(txt_PhoneNumber.Text))
            {
                isPhoneNumberValid = true;
                pictureBoxPhoneNumber.Visible = true;
                pictureBoxPhoneNumber.Image = Properties.Resources.right;
            }
            else
            {
                isPhoneNumberValid = false;
                pictureBoxPhoneNumber.Visible = true;
                pictureBoxPhoneNumber.Image = Properties.Resources.wrong;
            }
        }

        private void txt_UserName_Leave(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            string serverName = "IAMCUBE\\IAMCUBE"; // Replace with actual server name
            string databaseName = "TikiReviewAnalyzer"; // Replace with actual database name
            if (userBLL.CheckUsernameExist(serverName, databaseName, txt_UserName.Text))
            {
                isUserNameValid = false;
                pictureBoxUserName.Visible = true;
                pictureBoxUserName.Image = Properties.Resources.wrong;
            }
            else
            {
                isUserNameValid = true;
                pictureBoxUserName.Visible = true;
                pictureBoxUserName.Image = Properties.Resources.right;
            }
        }

        private void txt_RepeatPassword_Validated(object sender, EventArgs e)
        {
            if (txt_PassWord.Text == txt_RepeatPassword.Text)
            {
                isRepeatPasswordValid = true;
                pictureBoxRepeatPassword.Visible = true;
                pictureBoxRepeatPassword.Image = Properties.Resources.right;
            }
            else
            {
                isRepeatPasswordValid = false;
                pictureBoxRepeatPassword.Visible = true;
                pictureBoxRepeatPassword.Image = Properties.Resources.wrong;
            }
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            // Kiểm tra tất cả các biến boolean
            if (!isEmailValid || !isPhoneNumberValid || !isUserNameValid || !isRepeatPasswordValid)
            {
                MessageBox.Show("Some fields are incorrect. Please fix them before registering.");
                return;
            }

            // Tạo đối tượng UserDTO từ dữ liệu nhập
            UserDTO newUser = new UserDTO
            {
                AccFirstName = txt_FirstName.Text,
                AccLastName = txt_LastName.Text,
                AccEmail = txt_Email.Text,
                AccPhoneNumber = txt_PhoneNumber.Text,
                AccDateOfBirth = new DateTime(
                    int.Parse(comboBoxYear.SelectedItem.ToString()),
                    int.Parse(comboBoxMonth.SelectedItem.ToString()),
                    int.Parse(comboBoxDay.SelectedItem.ToString())),
                AccUserName = txt_UserName.Text,
                AccPassword = txt_PassWord.Text
            };

            UserBLL userBLL = new UserBLL();
            string serverName = "IAMCUBE\\IAMCUBE"; // Thay thế bằng tên server thực tế
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
        }
    }
}
