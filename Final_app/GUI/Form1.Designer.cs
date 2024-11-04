namespace GUI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtSeverName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.chkBox_Remember = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_DontHave = new System.Windows.Forms.Label();
            this.linkLabel_signup = new System.Windows.Forms.LinkLabel();
            this.linkLabel_forget = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(466, 77);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(261, 20);
            this.txtDatabase.TabIndex = 1;
            this.txtDatabase.TextChanged += new System.EventHandler(this.txtDatabase_TextChanged);
            // 
            // txtSeverName
            // 
            this.txtSeverName.Location = new System.Drawing.Point(466, 118);
            this.txtSeverName.Name = "txtSeverName";
            this.txtSeverName.Size = new System.Drawing.Size(261, 20);
            this.txtSeverName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(466, 203);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(261, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(466, 158);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(261, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // chkBox_Remember
            // 
            this.chkBox_Remember.AutoSize = true;
            this.chkBox_Remember.Location = new System.Drawing.Point(466, 247);
            this.chkBox_Remember.Name = "chkBox_Remember";
            this.chkBox_Remember.Size = new System.Drawing.Size(125, 17);
            this.chkBox_Remember.TabIndex = 5;
            this.chkBox_Remember.Text = "Remember password";
            this.chkBox_Remember.UseVisualStyleBackColor = true;
            this.chkBox_Remember.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(540, 289);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(121, 44);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_DontHave
            // 
            this.lbl_DontHave.AutoSize = true;
            this.lbl_DontHave.Location = new System.Drawing.Point(463, 345);
            this.lbl_DontHave.Name = "lbl_DontHave";
            this.lbl_DontHave.Size = new System.Drawing.Size(116, 13);
            this.lbl_DontHave.TabIndex = 8;
            this.lbl_DontHave.Text = "Don\'t have a account?";
            // 
            // linkLabel_signup
            // 
            this.linkLabel_signup.AutoSize = true;
            this.linkLabel_signup.Location = new System.Drawing.Point(668, 345);
            this.linkLabel_signup.Name = "linkLabel_signup";
            this.linkLabel_signup.Size = new System.Drawing.Size(59, 13);
            this.linkLabel_signup.TabIndex = 10;
            this.linkLabel_signup.TabStop = true;
            this.linkLabel_signup.Text = "Create one";
            this.linkLabel_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_signup_LinkClicked);
            // 
            // linkLabel_forget
            // 
            this.linkLabel_forget.AutoSize = true;
            this.linkLabel_forget.Location = new System.Drawing.Point(636, 248);
            this.linkLabel_forget.Name = "linkLabel_forget";
            this.linkLabel_forget.Size = new System.Drawing.Size(91, 13);
            this.linkLabel_forget.TabIndex = 11;
            this.linkLabel_forget.TabStop = true;
            this.linkLabel_forget.Text = "Forget password?";
            this.linkLabel_forget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_forget_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Don\'t have a account?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel_forget);
            this.Controls.Add(this.linkLabel_signup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DontHave);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.chkBox_Remember);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtSeverName);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtSeverName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox chkBox_Remember;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lb_Forget;
        private System.Windows.Forms.Label lbl_DontHave;
        private System.Windows.Forms.LinkLabel linkLabel_signup;
        private System.Windows.Forms.LinkLabel linkLabel_forget;
        private System.Windows.Forms.Label label1;
    }
}

