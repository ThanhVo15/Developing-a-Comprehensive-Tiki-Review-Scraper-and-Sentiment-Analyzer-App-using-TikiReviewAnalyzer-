namespace GUI
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.txt_RepeatPassword = new System.Windows.Forms.TextBox();
            this.btn_Signup = new System.Windows.Forms.Button();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoneNumber = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserName = new System.Windows.Forms.PictureBox();
            this.pictureBoxRepeatPassword = new System.Windows.Forms.PictureBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeatPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign up";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(35, 48);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(147, 20);
            this.txt_FirstName.TabIndex = 2;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(202, 48);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(147, 20);
            this.txt_LastName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date of birth";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(35, 140);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(314, 20);
            this.txt_Email.TabIndex = 17;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(35, 175);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(314, 20);
            this.txt_PhoneNumber.TabIndex = 18;
            this.txt_PhoneNumber.TextChanged += new System.EventHandler(this.txt_PhoneNumber_TextChanged);
            this.txt_PhoneNumber.Leave += new System.EventHandler(this.txt_PhoneNumber_Leave);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(35, 212);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(314, 20);
            this.txt_UserName.TabIndex = 19;
            this.txt_UserName.Leave += new System.EventHandler(this.txt_UserName_Leave);
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Location = new System.Drawing.Point(35, 247);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(314, 20);
            this.txt_PassWord.TabIndex = 20;
            // 
            // txt_RepeatPassword
            // 
            this.txt_RepeatPassword.Location = new System.Drawing.Point(35, 289);
            this.txt_RepeatPassword.Name = "txt_RepeatPassword";
            this.txt_RepeatPassword.Size = new System.Drawing.Size(314, 20);
            this.txt_RepeatPassword.TabIndex = 21;
            this.txt_RepeatPassword.Validated += new System.EventHandler(this.txt_RepeatPassword_Validated);
            // 
            // btn_Signup
            // 
            this.btn_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signup.Location = new System.Drawing.Point(132, 344);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(118, 53);
            this.btn_Signup.TabIndex = 22;
            this.btn_Signup.Text = "SIGN UP";
            this.btn_Signup.UseVisualStyleBackColor = true;
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.Location = new System.Drawing.Point(356, 140);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmail.TabIndex = 23;
            this.pictureBoxEmail.TabStop = false;
            // 
            // pictureBoxPhoneNumber
            // 
            this.pictureBoxPhoneNumber.Location = new System.Drawing.Point(356, 177);
            this.pictureBoxPhoneNumber.Name = "pictureBoxPhoneNumber";
            this.pictureBoxPhoneNumber.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxPhoneNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoneNumber.TabIndex = 24;
            this.pictureBoxPhoneNumber.TabStop = false;
            // 
            // pictureBoxUserName
            // 
            this.pictureBoxUserName.Location = new System.Drawing.Point(356, 212);
            this.pictureBoxUserName.Name = "pictureBoxUserName";
            this.pictureBoxUserName.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserName.TabIndex = 25;
            this.pictureBoxUserName.TabStop = false;
            // 
            // pictureBoxRepeatPassword
            // 
            this.pictureBoxRepeatPassword.Location = new System.Drawing.Point(356, 291);
            this.pictureBoxRepeatPassword.Name = "pictureBoxRepeatPassword";
            this.pictureBoxRepeatPassword.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxRepeatPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRepeatPassword.TabIndex = 26;
            this.pictureBoxRepeatPassword.TabStop = false;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Location = new System.Drawing.Point(35, 104);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDay.TabIndex = 27;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(141, 103);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMonth.TabIndex = 28;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(249, 103);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(100, 21);
            this.comboBoxYear.TabIndex = 29;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 479);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.pictureBoxRepeatPassword);
            this.Controls.Add(this.pictureBoxUserName);
            this.Controls.Add(this.pictureBoxPhoneNumber);
            this.Controls.Add(this.pictureBoxEmail);
            this.Controls.Add(this.btn_Signup);
            this.Controls.Add(this.txt_RepeatPassword);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeatPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.TextBox txt_RepeatPassword;
        private System.Windows.Forms.Button btn_Signup;
        private System.Windows.Forms.PictureBox pictureBoxEmail;
        private System.Windows.Forms.PictureBox pictureBoxPhoneNumber;
        private System.Windows.Forms.PictureBox pictureBoxUserName;
        private System.Windows.Forms.PictureBox pictureBoxRepeatPassword;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
    }
}