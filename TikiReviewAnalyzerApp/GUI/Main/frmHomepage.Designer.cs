﻿namespace GUI
{
    partial class frmHomepage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrBoxViewAll = new System.Windows.Forms.GroupBox();
            this.lvLeft = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStep = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPage = new System.Windows.Forms.ComboBox();
            this.radViewModel = new System.Windows.Forms.RadioButton();
            this.radViewData = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSumary = new System.Windows.Forms.RichTextBox();
            this.lvCoAuthor = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radModel = new System.Windows.Forms.RadioButton();
            this.radData = new System.Windows.Forms.RadioButton();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtEvenue = new System.Windows.Forms.TextBox();
            this.txtArticleName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.GrBoxViewAll.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 63);
            this.panel1.TabIndex = 11;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(83, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(453, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Hello  {UserName} , welcome back to Tiki Review Analyzer App!\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::GUI.Properties.Resources.ic_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrBoxViewAll);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1120, 617);
            this.splitContainer1.SplitterDistance = 532;
            this.splitContainer1.TabIndex = 12;
            // 
            // GrBoxViewAll
            // 
            this.GrBoxViewAll.Controls.Add(this.lvLeft);
            this.GrBoxViewAll.Controls.Add(this.panel2);
            this.GrBoxViewAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrBoxViewAll.Location = new System.Drawing.Point(0, 0);
            this.GrBoxViewAll.Name = "GrBoxViewAll";
            this.GrBoxViewAll.Size = new System.Drawing.Size(532, 617);
            this.GrBoxViewAll.TabIndex = 1;
            this.GrBoxViewAll.TabStop = false;
            this.GrBoxViewAll.Text = "View All Lists:";
            // 
            // lvLeft
            // 
            this.lvLeft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6});
            this.lvLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLeft.FullRowSelect = true;
            this.lvLeft.GridLines = true;
            this.lvLeft.HideSelection = false;
            this.lvLeft.Location = new System.Drawing.Point(3, 84);
            this.lvLeft.Name = "lvLeft";
            this.lvLeft.Size = new System.Drawing.Size(526, 530);
            this.lvLeft.TabIndex = 2;
            this.lvLeft.UseCompatibleStateImageBehavior = false;
            this.lvLeft.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "By";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStep);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboPage);
            this.panel2.Controls.Add(this.radViewModel);
            this.panel2.Controls.Add(this.radViewData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 68);
            this.panel2.TabIndex = 1;
            // 
            // lblStep
            // 
            this.lblStep.Location = new System.Drawing.Point(359, 43);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(95, 18);
            this.lblStep.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Choose Dataset:";
            // 
            // cboPage
            // 
            this.cboPage.FormattingEnabled = true;
            this.cboPage.Location = new System.Drawing.Point(141, 41);
            this.cboPage.Name = "cboPage";
            this.cboPage.Size = new System.Drawing.Size(212, 21);
            this.cboPage.TabIndex = 41;
            // 
            // radViewModel
            // 
            this.radViewModel.AutoSize = true;
            this.radViewModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radViewModel.Location = new System.Drawing.Point(354, 7);
            this.radViewModel.Name = "radViewModel";
            this.radViewModel.Size = new System.Drawing.Size(145, 24);
            this.radViewModel.TabIndex = 0;
            this.radViewModel.Text = "View Model Lists";
            this.radViewModel.UseVisualStyleBackColor = true;
            // 
            // radViewData
            // 
            this.radViewData.AutoSize = true;
            this.radViewData.Checked = true;
            this.radViewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radViewData.Location = new System.Drawing.Point(16, 7);
            this.radViewData.Name = "radViewData";
            this.radViewData.Size = new System.Drawing.Size(137, 24);
            this.radViewData.TabIndex = 0;
            this.radViewData.TabStop = true;
            this.radViewData.Text = "View Data Lists";
            this.radViewData.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 617);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Detail:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 598);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSumary);
            this.panel4.Controls.Add(this.lvCoAuthor);
            this.panel4.Controls.Add(this.radModel);
            this.panel4.Controls.Add(this.radData);
            this.panel4.Controls.Add(this.txtAuthor);
            this.panel4.Controls.Add(this.txtEvenue);
            this.panel4.Controls.Add(this.txtArticleName);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(578, 598);
            this.panel4.TabIndex = 1;
            // 
            // txtSumary
            // 
            this.txtSumary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSumary.Location = new System.Drawing.Point(9, 423);
            this.txtSumary.Name = "txtSumary";
            this.txtSumary.Size = new System.Drawing.Size(560, 166);
            this.txtSumary.TabIndex = 67;
            this.txtSumary.Text = "";
            // 
            // lvCoAuthor
            // 
            this.lvCoAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvCoAuthor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvCoAuthor.FullRowSelect = true;
            this.lvCoAuthor.GridLines = true;
            this.lvCoAuthor.HideSelection = false;
            this.lvCoAuthor.Location = new System.Drawing.Point(9, 229);
            this.lvCoAuthor.Name = "lvCoAuthor";
            this.lvCoAuthor.Size = new System.Drawing.Size(560, 169);
            this.lvCoAuthor.TabIndex = 66;
            this.lvCoAuthor.UseCompatibleStateImageBehavior = false;
            this.lvCoAuthor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thứ tự đóng góp";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tác giả";
            this.columnHeader5.Width = 500;
            // 
            // radModel
            // 
            this.radModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radModel.AutoSize = true;
            this.radModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radModel.Location = new System.Drawing.Point(138, 173);
            this.radModel.Name = "radModel";
            this.radModel.Size = new System.Drawing.Size(70, 24);
            this.radModel.TabIndex = 55;
            this.radModel.Text = "Model";
            this.radModel.UseVisualStyleBackColor = true;
            // 
            // radData
            // 
            this.radData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radData.AutoSize = true;
            this.radData.Checked = true;
            this.radData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radData.Location = new System.Drawing.Point(17, 173);
            this.radData.Name = "radData";
            this.radData.Size = new System.Drawing.Size(62, 24);
            this.radData.TabIndex = 56;
            this.radData.TabStop = true;
            this.radData.Text = "Data";
            this.radData.UseVisualStyleBackColor = true;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAuthor.Location = new System.Drawing.Point(12, 125);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(392, 20);
            this.txtAuthor.TabIndex = 63;
            // 
            // txtEvenue
            // 
            this.txtEvenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEvenue.Location = new System.Drawing.Point(12, 77);
            this.txtEvenue.Name = "txtEvenue";
            this.txtEvenue.Size = new System.Drawing.Size(392, 20);
            this.txtEvenue.TabIndex = 64;
            // 
            // txtArticleName
            // 
            this.txtArticleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArticleName.Location = new System.Drawing.Point(12, 29);
            this.txtArticleName.Name = "txtArticleName";
            this.txtArticleName.Size = new System.Drawing.Size(392, 20);
            this.txtArticleName.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "Descriptions:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Others Products by Creators:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Type:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Creators:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Time Created:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Name:";
            // 
            // frmHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::GUI.Properties.Resources.ic_background;
            this.ClientSize = new System.Drawing.Size(1120, 680);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomepage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmHomepage";
            this.Load += new System.EventHandler(this.frmHomepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.GrBoxViewAll.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox GrBoxViewAll;
        private System.Windows.Forms.ListView lvLeft;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPage;
        private System.Windows.Forms.RadioButton radViewModel;
        private System.Windows.Forms.RadioButton radViewData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox txtSumary;
        private System.Windows.Forms.ListView lvCoAuthor;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.RadioButton radModel;
        private System.Windows.Forms.RadioButton radData;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtEvenue;
        private System.Windows.Forms.TextBox txtArticleName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}