namespace GUI
{
    partial class frmSubTrainModel
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProgressPercentage = new System.Windows.Forms.Label();
            this.progressBarTrainAndCluster = new System.Windows.Forms.ProgressBar();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.btnSaveModel = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumPrdCmt = new System.Windows.Forms.Label();
            this.lblNumSerCmt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.txtRecall = new System.Windows.Forms.TextBox();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtTestSentiment = new System.Windows.Forms.RichTextBox();
            this.txtSentimentModelName = new System.Windows.Forms.TextBox();
            this.txtTrainRate = new System.Windows.Forms.TextBox();
            this.pictureBoxPos = new System.Windows.Forms.PictureBox();
            this.btnSaveModelSentiment = new System.Windows.Forms.Button();
            this.btnTrainSentiment = new System.Windows.Forms.Button();
            this.btnSentimentAnalize = new System.Windows.Forms.Button();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.pictureBoxNeg = new System.Windows.Forms.PictureBox();
            this.checkboxNegative = new System.Windows.Forms.CheckBox();
            this.checkboxPositive = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPercentPos = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPercentNeg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvCmt = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDataset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNeg)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 579);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 579);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 302);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 277);
            this.splitContainer1.SplitterDistance = 490;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProgressPercentage);
            this.groupBox1.Controls.Add(this.progressBarTrainAndCluster);
            this.groupBox1.Controls.Add(this.txtModelName);
            this.groupBox1.Controls.Add(this.btnSaveModel);
            this.groupBox1.Controls.Add(this.btnTrain);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblNumPrdCmt);
            this.groupBox1.Controls.Add(this.lblNumSerCmt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clustering comment topics";
            // 
            // lblProgressPercentage
            // 
            this.lblProgressPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressPercentage.AutoSize = true;
            this.lblProgressPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressPercentage.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblProgressPercentage.Location = new System.Drawing.Point(453, 55);
            this.lblProgressPercentage.Name = "lblProgressPercentage";
            this.lblProgressPercentage.Size = new System.Drawing.Size(23, 13);
            this.lblProgressPercentage.TabIndex = 4;
            this.lblProgressPercentage.Text = "0%";
            // 
            // progressBarTrainAndCluster
            // 
            this.progressBarTrainAndCluster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarTrainAndCluster.Location = new System.Drawing.Point(158, 29);
            this.progressBarTrainAndCluster.Name = "progressBarTrainAndCluster";
            this.progressBarTrainAndCluster.Size = new System.Drawing.Size(326, 23);
            this.progressBarTrainAndCluster.TabIndex = 2;
            // 
            // txtModelName
            // 
            this.txtModelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtModelName.Location = new System.Drawing.Point(119, 228);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(248, 26);
            this.txtModelName.TabIndex = 1;
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveModel.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSaveModel.Image = global::GUI.Properties.Resources.save;
            this.btnSaveModel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveModel.Location = new System.Drawing.Point(384, 230);
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.Size = new System.Drawing.Size(100, 26);
            this.btnSaveModel.TabIndex = 1;
            this.btnSaveModel.Text = "Save Model";
            this.btnSaveModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveModel.UseVisualStyleBackColor = true;
            this.btnSaveModel.Click += new System.EventHandler(this.btnSaveModel_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.Bisque;
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTrain.Image = global::GUI.Properties.Resources.cluster2;
            this.btnTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrain.Location = new System.Drawing.Point(12, 22);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(140, 35);
            this.btnTrain.TabIndex = 1;
            this.btnTrain.Text = "Train and Cluster";
            this.btnTrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(34, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Service Comments";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(8, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Model Name:";
            // 
            // lblNumPrdCmt
            // 
            this.lblNumPrdCmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNumPrdCmt.AutoSize = true;
            this.lblNumPrdCmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPrdCmt.Location = new System.Drawing.Point(349, 137);
            this.lblNumPrdCmt.Name = "lblNumPrdCmt";
            this.lblNumPrdCmt.Size = new System.Drawing.Size(18, 20);
            this.lblNumPrdCmt.TabIndex = 0;
            this.lblNumPrdCmt.Text = "0";
            // 
            // lblNumSerCmt
            // 
            this.lblNumSerCmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNumSerCmt.AutoSize = true;
            this.lblNumSerCmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerCmt.Location = new System.Drawing.Point(91, 137);
            this.lblNumSerCmt.Name = "lblNumSerCmt";
            this.lblNumSerCmt.Size = new System.Drawing.Size(18, 20);
            this.lblNumSerCmt.TabIndex = 0;
            this.lblNumSerCmt.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(278, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Comments";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtF1);
            this.groupBox2.Controls.Add(this.txtRecall);
            this.groupBox2.Controls.Add(this.txtAcc);
            this.groupBox2.Controls.Add(this.txtTestSentiment);
            this.groupBox2.Controls.Add(this.txtSentimentModelName);
            this.groupBox2.Controls.Add(this.txtTrainRate);
            this.groupBox2.Controls.Add(this.pictureBoxPos);
            this.groupBox2.Controls.Add(this.btnSaveModelSentiment);
            this.groupBox2.Controls.Add(this.btnTrainSentiment);
            this.groupBox2.Controls.Add(this.btnSentimentAnalize);
            this.groupBox2.Controls.Add(this.txtPre);
            this.groupBox2.Controls.Add(this.pictureBoxNeg);
            this.groupBox2.Controls.Add(this.checkboxNegative);
            this.groupBox2.Controls.Add(this.checkboxPositive);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblPercentPos);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblPercentNeg);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 277);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sentiment Analysis";
            // 
            // txtF1
            // 
            this.txtF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtF1.Location = new System.Drawing.Point(165, 178);
            this.txtF1.Name = "txtF1";
            this.txtF1.Size = new System.Drawing.Size(78, 26);
            this.txtF1.TabIndex = 7;
            // 
            // txtRecall
            // 
            this.txtRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecall.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtRecall.Location = new System.Drawing.Point(18, 178);
            this.txtRecall.Name = "txtRecall";
            this.txtRecall.Size = new System.Drawing.Size(78, 26);
            this.txtRecall.TabIndex = 6;
            // 
            // txtAcc
            // 
            this.txtAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcc.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAcc.Location = new System.Drawing.Point(18, 114);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(78, 26);
            this.txtAcc.TabIndex = 5;
            // 
            // txtTestSentiment
            // 
            this.txtTestSentiment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestSentiment.Location = new System.Drawing.Point(300, 62);
            this.txtTestSentiment.Name = "txtTestSentiment";
            this.txtTestSentiment.Size = new System.Drawing.Size(126, 113);
            this.txtTestSentiment.TabIndex = 4;
            this.txtTestSentiment.Text = "";
            // 
            // txtSentimentModelName
            // 
            this.txtSentimentModelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSentimentModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSentimentModelName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSentimentModelName.Location = new System.Drawing.Point(10, 232);
            this.txtSentimentModelName.Name = "txtSentimentModelName";
            this.txtSentimentModelName.Size = new System.Drawing.Size(172, 23);
            this.txtSentimentModelName.TabIndex = 1;
            this.txtSentimentModelName.Text = "Enter your model name";
            // 
            // txtTrainRate
            // 
            this.txtTrainRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrainRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainRate.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTrainRate.Location = new System.Drawing.Point(99, 29);
            this.txtTrainRate.Name = "txtTrainRate";
            this.txtTrainRate.Size = new System.Drawing.Size(92, 26);
            this.txtTrainRate.TabIndex = 1;
            // 
            // pictureBoxPos
            // 
            this.pictureBoxPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPos.Image = global::GUI.Properties.Resources.positive48;
            this.pictureBoxPos.Location = new System.Drawing.Point(432, 62);
            this.pictureBoxPos.Name = "pictureBoxPos";
            this.pictureBoxPos.Size = new System.Drawing.Size(126, 113);
            this.pictureBoxPos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPos.TabIndex = 3;
            this.pictureBoxPos.TabStop = false;
            // 
            // btnSaveModelSentiment
            // 
            this.btnSaveModelSentiment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveModelSentiment.Image = global::GUI.Properties.Resources.save;
            this.btnSaveModelSentiment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveModelSentiment.Location = new System.Drawing.Point(188, 232);
            this.btnSaveModelSentiment.Name = "btnSaveModelSentiment";
            this.btnSaveModelSentiment.Size = new System.Drawing.Size(100, 26);
            this.btnSaveModelSentiment.TabIndex = 1;
            this.btnSaveModelSentiment.Text = "Save Model";
            this.btnSaveModelSentiment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveModelSentiment.UseVisualStyleBackColor = true;
            this.btnSaveModelSentiment.Click += new System.EventHandler(this.btnSaveModelSentiment_Click);
            // 
            // btnTrainSentiment
            // 
            this.btnTrainSentiment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrainSentiment.Image = global::GUI.Properties.Resources.train_sentiment;
            this.btnTrainSentiment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainSentiment.Location = new System.Drawing.Point(197, 29);
            this.btnTrainSentiment.Name = "btnTrainSentiment";
            this.btnTrainSentiment.Size = new System.Drawing.Size(70, 27);
            this.btnTrainSentiment.TabIndex = 1;
            this.btnTrainSentiment.Text = "Train";
            this.btnTrainSentiment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrainSentiment.UseVisualStyleBackColor = true;
            this.btnTrainSentiment.Click += new System.EventHandler(this.btnTrainSentiment_Click);
            // 
            // btnSentimentAnalize
            // 
            this.btnSentimentAnalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSentimentAnalize.Image = global::GUI.Properties.Resources.sentiment;
            this.btnSentimentAnalize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSentimentAnalize.Location = new System.Drawing.Point(300, 28);
            this.btnSentimentAnalize.Name = "btnSentimentAnalize";
            this.btnSentimentAnalize.Size = new System.Drawing.Size(100, 28);
            this.btnSentimentAnalize.TabIndex = 1;
            this.btnSentimentAnalize.Text = "Analize";
            this.btnSentimentAnalize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSentimentAnalize.UseVisualStyleBackColor = true;
            this.btnSentimentAnalize.Click += new System.EventHandler(this.btnSentimentAnalize_Click);
            // 
            // txtPre
            // 
            this.txtPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPre.Location = new System.Drawing.Point(165, 114);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(78, 26);
            this.txtPre.TabIndex = 1;
            // 
            // pictureBoxNeg
            // 
            this.pictureBoxNeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNeg.Image = global::GUI.Properties.Resources.negative48;
            this.pictureBoxNeg.Location = new System.Drawing.Point(432, 62);
            this.pictureBoxNeg.Name = "pictureBoxNeg";
            this.pictureBoxNeg.Size = new System.Drawing.Size(126, 113);
            this.pictureBoxNeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNeg.TabIndex = 2;
            this.pictureBoxNeg.TabStop = false;
            // 
            // checkboxNegative
            // 
            this.checkboxNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxNegative.AutoSize = true;
            this.checkboxNegative.ForeColor = System.Drawing.Color.DeepPink;
            this.checkboxNegative.Location = new System.Drawing.Point(456, 186);
            this.checkboxNegative.Name = "checkboxNegative";
            this.checkboxNegative.Size = new System.Drawing.Size(77, 17);
            this.checkboxNegative.TabIndex = 1;
            this.checkboxNegative.Text = "Negative";
            this.checkboxNegative.UseVisualStyleBackColor = true;
            // 
            // checkboxPositive
            // 
            this.checkboxPositive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxPositive.AutoSize = true;
            this.checkboxPositive.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkboxPositive.Location = new System.Drawing.Point(348, 186);
            this.checkboxPositive.Name = "checkboxPositive";
            this.checkboxPositive.Size = new System.Drawing.Size(71, 17);
            this.checkboxPositive.TabIndex = 1;
            this.checkboxPositive.Text = "Positive";
            this.checkboxPositive.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(167, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "F1-Score";
            // 
            // lblPercentPos
            // 
            this.lblPercentPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentPos.AutoSize = true;
            this.lblPercentPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentPos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPercentPos.Location = new System.Drawing.Point(368, 206);
            this.lblPercentPos.Name = "lblPercentPos";
            this.lblPercentPos.Size = new System.Drawing.Size(32, 20);
            this.lblPercentPos.TabIndex = 0;
            this.lblPercentPos.Text = "0%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(29, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Recall";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(167, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Precision";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(19, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Accuracy";
            // 
            // lblPercentNeg
            // 
            this.lblPercentNeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentNeg.AutoSize = true;
            this.lblPercentNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentNeg.ForeColor = System.Drawing.Color.DeepPink;
            this.lblPercentNeg.Location = new System.Drawing.Point(479, 206);
            this.lblPercentNeg.Name = "lblPercentNeg";
            this.lblPercentNeg.Size = new System.Drawing.Size(32, 20);
            this.lblPercentNeg.TabIndex = 0;
            this.lblPercentNeg.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Train Rate:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvCmt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1064, 210);
            this.panel4.TabIndex = 1;
            // 
            // lvCmt
            // 
            this.lvCmt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvCmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCmt.FullRowSelect = true;
            this.lvCmt.GridLines = true;
            this.lvCmt.HideSelection = false;
            this.lvCmt.Location = new System.Drawing.Point(0, 0);
            this.lvCmt.Name = "lvCmt";
            this.lvCmt.Size = new System.Drawing.Size(1064, 210);
            this.lvCmt.TabIndex = 0;
            this.lvCmt.UseCompatibleStateImageBehavior = false;
            this.lvCmt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Comments";
            this.columnHeader2.Width = 500;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sentiment";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Content";
            this.columnHeader4.Width = 200;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtDataset);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 92);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GUI.Properties.Resources.choose_data;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(800, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dataset";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDataset
            // 
            this.txtDataset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataset.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDataset.Location = new System.Drawing.Point(313, 40);
            this.txtDataset.Name = "txtDataset";
            this.txtDataset.Size = new System.Drawing.Size(478, 26);
            this.txtDataset.TabIndex = 1;
            this.txtDataset.Text = "Sample dataset 1";
            this.txtDataset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose dataset to train:";
            // 
            // frmSubTrainModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 579);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubTrainModel";
            this.Text = "frmSubTrainModel";
            this.Load += new System.EventHandler(this.frmSubTrainModel_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNeg)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDataset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvCmt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBarTrainAndCluster;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumPrdCmt;
        private System.Windows.Forms.Label lblNumSerCmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Button btnSaveModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPercentPos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPercentNeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkboxNegative;
        private System.Windows.Forms.CheckBox checkboxPositive;
        private System.Windows.Forms.PictureBox pictureBoxNeg;
        private System.Windows.Forms.RichTextBox txtTestSentiment;
        private System.Windows.Forms.PictureBox pictureBoxPos;
        private System.Windows.Forms.Button btnSaveModelSentiment;
        private System.Windows.Forms.Button btnSentimentAnalize;
        private System.Windows.Forms.Button btnTrainSentiment;
        private System.Windows.Forms.TextBox txtSentimentModelName;
        private System.Windows.Forms.TextBox txtTrainRate;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.Label lblProgressPercentage;
        private System.Windows.Forms.TextBox txtF1;
        private System.Windows.Forms.TextBox txtRecall;
        private System.Windows.Forms.TextBox txtAcc;
    }
}