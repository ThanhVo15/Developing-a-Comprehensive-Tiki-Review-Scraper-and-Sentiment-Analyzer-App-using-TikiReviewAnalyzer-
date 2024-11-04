namespace GUI
{
    partial class fmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnHomepage = new System.Windows.Forms.Panel();
            this.ManageDataContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ManageModelContainer = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnExit = new System.Windows.Forms.Panel();
            this.ManageModelTransition = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ManageDataTransition = new System.Windows.Forms.Timer(this.components);
            this.SideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.btnDataManagement = new System.Windows.Forms.Button();
            this.btnCrawlData = new System.Windows.Forms.Button();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.btnManageModel = new System.Windows.Forms.Button();
            this.btnTrainModel = new System.Windows.Forms.Button();
            this.btnUsingModel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.picSidebar = new System.Windows.Forms.PictureBox();
            this.ProfileSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.GrBoxEditProfile = new System.Windows.Forms.GroupBox();
            this.radCheck = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProfileTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnHomepage.SuspendLayout();
            this.ManageDataContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.ManageModelContainer.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnExit.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSidebar)).BeginInit();
            this.ProfileSideBar.SuspendLayout();
            this.panel6.SuspendLayout();
            this.GrBoxEditProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.picProfile);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel1.Size = new System.Drawing.Size(1141, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.picSidebar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.panel3.Size = new System.Drawing.Size(397, 52);
            this.panel3.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(58, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 29);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Tiki Review Analyzer App";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnHomepage
            // 
            this.pnHomepage.Controls.Add(this.btnHomepage);
            this.pnHomepage.Location = new System.Drawing.Point(3, 3);
            this.pnHomepage.Name = "pnHomepage";
            this.pnHomepage.Size = new System.Drawing.Size(227, 75);
            this.pnHomepage.TabIndex = 3;
            // 
            // ManageDataContainer
            // 
            this.ManageDataContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageDataContainer.Controls.Add(this.panel2);
            this.ManageDataContainer.Controls.Add(this.panel4);
            this.ManageDataContainer.Controls.Add(this.panel5);
            this.ManageDataContainer.Location = new System.Drawing.Point(3, 84);
            this.ManageDataContainer.Name = "ManageDataContainer";
            this.ManageDataContainer.Size = new System.Drawing.Size(227, 75);
            this.ManageDataContainer.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDataManagement);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 75);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.btnCrawlData);
            this.panel4.Location = new System.Drawing.Point(10, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 75);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Controls.Add(this.btnDatabase);
            this.panel5.Location = new System.Drawing.Point(10, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 75);
            this.panel5.TabIndex = 3;
            // 
            // ManageModelContainer
            // 
            this.ManageModelContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageModelContainer.Controls.Add(this.panel7);
            this.ManageModelContainer.Controls.Add(this.panel8);
            this.ManageModelContainer.Controls.Add(this.panel9);
            this.ManageModelContainer.Location = new System.Drawing.Point(3, 165);
            this.ManageModelContainer.Name = "ManageModelContainer";
            this.ManageModelContainer.Size = new System.Drawing.Size(227, 75);
            this.ManageModelContainer.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnManageModel);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(227, 75);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel8.Controls.Add(this.btnTrainModel);
            this.panel8.Location = new System.Drawing.Point(10, 81);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(227, 75);
            this.panel8.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel9.Controls.Add(this.btnUsingModel);
            this.panel9.Location = new System.Drawing.Point(10, 162);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(227, 75);
            this.panel9.TabIndex = 3;
            // 
            // pnExit
            // 
            this.pnExit.Controls.Add(this.btnExit);
            this.pnExit.Location = new System.Drawing.Point(3, 246);
            this.pnExit.Name = "pnExit";
            this.pnExit.Size = new System.Drawing.Size(227, 75);
            this.pnExit.TabIndex = 3;
            // 
            // ManageModelTransition
            // 
            this.ManageModelTransition.Interval = 10;
            this.ManageModelTransition.Tick += new System.EventHandler(this.ManageModelTransition_Tick);
            // 
            // ManageDataTransition
            // 
            this.ManageDataTransition.Interval = 10;
            this.ManageDataTransition.Tick += new System.EventHandler(this.ManageDataTransition_Tick);
            // 
            // SideBarTransition
            // 
            this.SideBarTransition.Interval = 10;
            this.SideBarTransition.Tick += new System.EventHandler(this.SideBarTransition_Tick);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sidebar.Controls.Add(this.pnHomepage);
            this.Sidebar.Controls.Add(this.ManageDataContainer);
            this.Sidebar.Controls.Add(this.ManageModelContainer);
            this.Sidebar.Controls.Add(this.pnExit);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 52);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(64, 656);
            this.Sidebar.TabIndex = 5;
            // 
            // btnHomepage
            // 
            this.btnHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomepage.Image = global::GUI.Properties.Resources.ic_homepage;
            this.btnHomepage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomepage.Location = new System.Drawing.Point(-10, -24);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnHomepage.Size = new System.Drawing.Size(246, 124);
            this.btnHomepage.TabIndex = 0;
            this.btnHomepage.Text = "          Homepage";
            this.btnHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomepage.UseVisualStyleBackColor = true;
            this.btnHomepage.Click += new System.EventHandler(this.btnHomepage_Click);
            // 
            // btnDataManagement
            // 
            this.btnDataManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataManagement.Image = global::GUI.Properties.Resources.ic_manage;
            this.btnDataManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataManagement.Location = new System.Drawing.Point(-10, -24);
            this.btnDataManagement.Name = "btnDataManagement";
            this.btnDataManagement.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnDataManagement.Size = new System.Drawing.Size(246, 124);
            this.btnDataManagement.TabIndex = 0;
            this.btnDataManagement.Text = "          Manage Data";
            this.btnDataManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataManagement.UseVisualStyleBackColor = true;
            this.btnDataManagement.Click += new System.EventHandler(this.btnDataManagement_Click);
            // 
            // btnCrawlData
            // 
            this.btnCrawlData.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrawlData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrawlData.Image = global::GUI.Properties.Resources.ic_crawl;
            this.btnCrawlData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrawlData.Location = new System.Drawing.Point(-10, -24);
            this.btnCrawlData.Name = "btnCrawlData";
            this.btnCrawlData.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnCrawlData.Size = new System.Drawing.Size(246, 124);
            this.btnCrawlData.TabIndex = 0;
            this.btnCrawlData.Text = "          Crawl Data";
            this.btnCrawlData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrawlData.UseVisualStyleBackColor = false;
            this.btnCrawlData.Click += new System.EventHandler(this.btnCrawlData_Click);
            // 
            // btnDatabase
            // 
            this.btnDatabase.BackColor = System.Drawing.SystemColors.Control;
            this.btnDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatabase.Image = global::GUI.Properties.Resources.ic_data;
            this.btnDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatabase.Location = new System.Drawing.Point(-10, -24);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnDatabase.Size = new System.Drawing.Size(246, 124);
            this.btnDatabase.TabIndex = 0;
            this.btnDatabase.Text = "          Database";
            this.btnDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatabase.UseVisualStyleBackColor = false;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // btnManageModel
            // 
            this.btnManageModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageModel.Image = global::GUI.Properties.Resources.ic_model;
            this.btnManageModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageModel.Location = new System.Drawing.Point(-10, -24);
            this.btnManageModel.Name = "btnManageModel";
            this.btnManageModel.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnManageModel.Size = new System.Drawing.Size(246, 124);
            this.btnManageModel.TabIndex = 0;
            this.btnManageModel.Text = "          Manage Model";
            this.btnManageModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageModel.UseVisualStyleBackColor = true;
            this.btnManageModel.Click += new System.EventHandler(this.btnManageModel_Click);
            // 
            // btnTrainModel
            // 
            this.btnTrainModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrainModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainModel.Image = global::GUI.Properties.Resources.ic_train;
            this.btnTrainModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainModel.Location = new System.Drawing.Point(-10, -24);
            this.btnTrainModel.Name = "btnTrainModel";
            this.btnTrainModel.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnTrainModel.Size = new System.Drawing.Size(246, 124);
            this.btnTrainModel.TabIndex = 0;
            this.btnTrainModel.Text = "          Train Model";
            this.btnTrainModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainModel.UseVisualStyleBackColor = false;
            this.btnTrainModel.Click += new System.EventHandler(this.btnTrainModel_Click);
            // 
            // btnUsingModel
            // 
            this.btnUsingModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsingModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsingModel.Image = global::GUI.Properties.Resources.ic_using;
            this.btnUsingModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsingModel.Location = new System.Drawing.Point(-10, -24);
            this.btnUsingModel.Name = "btnUsingModel";
            this.btnUsingModel.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnUsingModel.Size = new System.Drawing.Size(246, 124);
            this.btnUsingModel.TabIndex = 0;
            this.btnUsingModel.Text = "          Using Model";
            this.btnUsingModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsingModel.UseVisualStyleBackColor = false;
            this.btnUsingModel.Click += new System.EventHandler(this.btnUsingModel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::GUI.Properties.Resources.ic_close;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-10, -24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(246, 124);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picProfile
            // 
            this.picProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.picProfile.Image = global::GUI.Properties.Resources.ic_profile;
            this.picProfile.Location = new System.Drawing.Point(1090, 0);
            this.picProfile.Name = "picProfile";
            this.picProfile.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.picProfile.Size = new System.Drawing.Size(46, 52);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 4;
            this.picProfile.TabStop = false;
            this.picProfile.Click += new System.EventHandler(this.picProfile_Click);
            // 
            // picSidebar
            // 
            this.picSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.picSidebar.Image = global::GUI.Properties.Resources.ic_sidebar;
            this.picSidebar.Location = new System.Drawing.Point(10, 5);
            this.picSidebar.Name = "picSidebar";
            this.picSidebar.Padding = new System.Windows.Forms.Padding(5);
            this.picSidebar.Size = new System.Drawing.Size(42, 42);
            this.picSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSidebar.TabIndex = 3;
            this.picSidebar.TabStop = false;
            this.picSidebar.Click += new System.EventHandler(this.picSidebar_Click);
            // 
            // ProfileSideBar
            // 
            this.ProfileSideBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfileSideBar.Controls.Add(this.panel6);
            this.ProfileSideBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProfileSideBar.Location = new System.Drawing.Point(1131, 52);
            this.ProfileSideBar.Name = "ProfileSideBar";
            this.ProfileSideBar.Size = new System.Drawing.Size(10, 656);
            this.ProfileSideBar.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.GrBoxEditProfile);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(216, 529);
            this.panel6.TabIndex = 8;
            // 
            // GrBoxEditProfile
            // 
            this.GrBoxEditProfile.AutoSize = true;
            this.GrBoxEditProfile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrBoxEditProfile.Controls.Add(this.radCheck);
            this.GrBoxEditProfile.Controls.Add(this.btnUpdate);
            this.GrBoxEditProfile.Controls.Add(this.DateOfBirth);
            this.GrBoxEditProfile.Controls.Add(this.lblRepeatPassword);
            this.GrBoxEditProfile.Controls.Add(this.lblOldPassword);
            this.GrBoxEditProfile.Controls.Add(this.lblNewPassword);
            this.GrBoxEditProfile.Controls.Add(this.lblUserName);
            this.GrBoxEditProfile.Controls.Add(this.lblLastName);
            this.GrBoxEditProfile.Controls.Add(this.lblDateOfBirth);
            this.GrBoxEditProfile.Controls.Add(this.lblFirstName);
            this.GrBoxEditProfile.Controls.Add(this.lblEmail);
            this.GrBoxEditProfile.Controls.Add(this.lblPhoneNumber);
            this.GrBoxEditProfile.Controls.Add(this.textBox2);
            this.GrBoxEditProfile.Controls.Add(this.textBox5);
            this.GrBoxEditProfile.Controls.Add(this.textBox4);
            this.GrBoxEditProfile.Controls.Add(this.textBox3);
            this.GrBoxEditProfile.Controls.Add(this.txtLastName);
            this.GrBoxEditProfile.Controls.Add(this.txtFirstName);
            this.GrBoxEditProfile.Controls.Add(this.txtEmail);
            this.GrBoxEditProfile.Controls.Add(this.textBox1);
            this.GrBoxEditProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrBoxEditProfile.Location = new System.Drawing.Point(0, 0);
            this.GrBoxEditProfile.Name = "GrBoxEditProfile";
            this.GrBoxEditProfile.Size = new System.Drawing.Size(216, 529);
            this.GrBoxEditProfile.TabIndex = 9;
            this.GrBoxEditProfile.TabStop = false;
            this.GrBoxEditProfile.Text = "Edit Profile:";
            // 
            // radCheck
            // 
            this.radCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radCheck.AutoSize = true;
            this.radCheck.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radCheck.Location = new System.Drawing.Point(21, 462);
            this.radCheck.Name = "radCheck";
            this.radCheck.Size = new System.Drawing.Size(144, 17);
            this.radCheck.TabIndex = 44;
            this.radCheck.TabStop = true;
            this.radCheck.Text = "Check this box to confirm";
            this.radCheck.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(40, 485);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 23);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfBirth.Location = new System.Drawing.Point(21, 239);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(171, 20);
            this.DateOfBirth.TabIndex = 42;
            this.DateOfBirth.Value = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Location = new System.Drawing.Point(21, 414);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(94, 13);
            this.lblRepeatPassword.TabIndex = 40;
            this.lblRepeatPassword.Text = "Repeat Password:";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(21, 316);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(75, 13);
            this.lblOldPassword.TabIndex = 41;
            this.lblOldPassword.Text = "Old Password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(21, 365);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 13);
            this.lblNewPassword.TabIndex = 41;
            this.lblNewPassword.Text = "New Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(21, 267);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 39;
            this.lblUserName.Text = "Username:";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(21, 71);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 34;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(21, 218);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.lblDateOfBirth.TabIndex = 35;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(21, 22);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 36;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(21, 169);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 38;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(21, 435);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 32;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(21, 337);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(171, 20);
            this.textBox5.TabIndex = 33;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(21, 386);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(171, 20);
            this.textBox4.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(21, 288);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 20);
            this.textBox3.TabIndex = 31;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(21, 92);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(171, 20);
            this.txtLastName.TabIndex = 27;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(20, 44);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(171, 20);
            this.txtFirstName.TabIndex = 28;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(21, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 20);
            this.txtEmail.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(21, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 30;
            // 
            // ProfileTransition
            // 
            this.ProfileTransition.Interval = 10;
            this.ProfileTransition.Tick += new System.EventHandler(this.ProfileTransition_Tick);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 708);
            this.Controls.Add(this.ProfileSideBar);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TikiReviewAnalyzer App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnHomepage.ResumeLayout(false);
            this.ManageDataContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ManageModelContainer.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.pnExit.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSidebar)).EndInit();
            this.ProfileSideBar.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.GrBoxEditProfile.ResumeLayout(false);
            this.GrBoxEditProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnHomepage;
        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.Panel pnExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDataManagement;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCrawlData;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.Panel ManageDataContainer;
        private System.Windows.Forms.Panel ManageModelContainer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnManageModel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnTrainModel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnUsingModel;
        private System.Windows.Forms.Timer ManageModelTransition;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer ManageDataTransition;
        private System.Windows.Forms.Timer SideBarTransition;
        private System.Windows.Forms.PictureBox picSidebar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.FlowLayoutPanel ProfileSideBar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox GrBoxEditProfile;
        private System.Windows.Forms.RadioButton radCheck;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer ProfileTransition;
    }
}