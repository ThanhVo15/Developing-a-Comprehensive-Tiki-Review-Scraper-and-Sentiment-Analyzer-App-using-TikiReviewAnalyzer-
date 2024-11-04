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

namespace GUI.Login_SignUp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            fmMain signUpForm = new fmMain();

            signUpForm.FormClosed += (s, args) => this.Hide();

            signUpForm.Show();
            this.Hide();
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
    }
}
