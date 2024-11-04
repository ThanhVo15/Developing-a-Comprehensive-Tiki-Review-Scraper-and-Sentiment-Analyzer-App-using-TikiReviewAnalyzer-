namespace GUI
{
    partial class ResetPassForm
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.txt_RepeatPassWord = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forget Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(39, 63);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(314, 20);
            this.txtUserName.TabIndex = 8;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(39, 101);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(314, 20);
            this.txt_Email.TabIndex = 9;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(39, 141);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(314, 20);
            this.txt_PhoneNumber.TabIndex = 10;
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Location = new System.Drawing.Point(39, 180);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(314, 20);
            this.txt_PassWord.TabIndex = 11;
            // 
            // txt_RepeatPassWord
            // 
            this.txt_RepeatPassWord.Location = new System.Drawing.Point(39, 222);
            this.txt_RepeatPassWord.Name = "txt_RepeatPassWord";
            this.txt_RepeatPassWord.Size = new System.Drawing.Size(314, 20);
            this.txt_RepeatPassWord.TabIndex = 12;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(121, 276);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(140, 62);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Reset password";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // ResetPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 384);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_RepeatPassWord);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Name = "ResetPassForm";
            this.Text = "ResetPassForm";
            this.Load += new System.EventHandler(this.ResetPassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.TextBox txt_RepeatPassWord;
        private System.Windows.Forms.Button btn_reset;
    }
}