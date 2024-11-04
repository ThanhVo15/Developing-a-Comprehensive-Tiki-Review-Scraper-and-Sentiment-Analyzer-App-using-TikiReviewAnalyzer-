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
    public partial class frmSignUp : Form
    {
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
    }
}
