namespace GUI
{
    partial class frmSubCrawlData
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateCrawl = new System.Windows.Forms.TextBox();
            this.txtDataDescription = new System.Windows.Forms.TextBox();
            this.txtDataName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveToDatabases = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnCrawlNow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rtxtURL = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.lblLoadingPercent = new System.Windows.Forms.Label();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberofPageTo = new System.Windows.Forms.TextBox();
            this.txtNumberofPageFrom = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductOriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantitySold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatingAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EarliestDeliveryEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StandardDeliveryEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tikiReviewAnalyzerDataSet = new GUI.TikiReviewAnalyzerDataSet();
            this.listView1 = new System.Windows.Forms.ListView();
            this.productsTableAdapter = new GUI.TikiReviewAnalyzerDataSetTableAdapters.ProductsTableAdapter();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tikiReviewAnalyzerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::GUI.Properties.Resources.ic_background1;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1142, 182);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtDateCrawl);
            this.panel5.Controls.Add(this.txtDataDescription);
            this.panel5.Controls.Add(this.txtDataName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(793, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(174, 182);
            this.panel5.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Date Crawl:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Data Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Data Name:";
            // 
            // txtDateCrawl
            // 
            this.txtDateCrawl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateCrawl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCrawl.Location = new System.Drawing.Point(10, 152);
            this.txtDateCrawl.Name = "txtDateCrawl";
            this.txtDateCrawl.Size = new System.Drawing.Size(139, 26);
            this.txtDateCrawl.TabIndex = 0;
            // 
            // txtDataDescription
            // 
            this.txtDataDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataDescription.Location = new System.Drawing.Point(10, 94);
            this.txtDataDescription.Name = "txtDataDescription";
            this.txtDataDescription.Size = new System.Drawing.Size(139, 26);
            this.txtDataDescription.TabIndex = 0;
            // 
            // txtDataName
            // 
            this.txtDataName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataName.Location = new System.Drawing.Point(10, 36);
            this.txtDataName.Name = "txtDataName";
            this.txtDataName.Size = new System.Drawing.Size(139, 26);
            this.txtDataName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveToDatabases);
            this.panel3.Controls.Add(this.btnExportExcel);
            this.panel3.Controls.Add(this.btnCrawlNow);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(967, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 182);
            this.panel3.TabIndex = 8;
            // 
            // btnSaveToDatabases
            // 
            this.btnSaveToDatabases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveToDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToDatabases.Image = global::GUI.Properties.Resources.ic_crawl1;
            this.btnSaveToDatabases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveToDatabases.Location = new System.Drawing.Point(9, 70);
            this.btnSaveToDatabases.Name = "btnSaveToDatabases";
            this.btnSaveToDatabases.Size = new System.Drawing.Size(157, 39);
            this.btnSaveToDatabases.TabIndex = 5;
            this.btnSaveToDatabases.Text = "Save Database";
            this.btnSaveToDatabases.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveToDatabases.UseVisualStyleBackColor = true;
            this.btnSaveToDatabases.Click += new System.EventHandler(this.btnSaveToDatabases_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = global::GUI.Properties.Resources.ic_crawl1;
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(9, 117);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(157, 39);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnCrawlNow
            // 
            this.btnCrawlNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrawlNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrawlNow.Image = global::GUI.Properties.Resources.ic_crawl1;
            this.btnCrawlNow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrawlNow.Location = new System.Drawing.Point(9, 23);
            this.btnCrawlNow.Name = "btnCrawlNow";
            this.btnCrawlNow.Size = new System.Drawing.Size(157, 39);
            this.btnCrawlNow.TabIndex = 5;
            this.btnCrawlNow.Text = "Crawl Now";
            this.btnCrawlNow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrawlNow.UseVisualStyleBackColor = true;
            this.btnCrawlNow.Click += new System.EventHandler(this.btnCrawlNow_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.rtxtURL);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblNotification);
            this.panel2.Controls.Add(this.lblLoadingPercent);
            this.panel2.Controls.Add(this.radNo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.radYes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNumberofPageTo);
            this.panel2.Controls.Add(this.txtNumberofPageFrom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 182);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(222, 136);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(219, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // rtxtURL
            // 
            this.rtxtURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtURL.Location = new System.Drawing.Point(78, 32);
            this.rtxtURL.Name = "rtxtURL";
            this.rtxtURL.Size = new System.Drawing.Size(632, 55);
            this.rtxtURL.TabIndex = 0;
            this.rtxtURL.Text = "Enter you URL link here...";
            this.rtxtURL.TextChanged += new System.EventHandler(this.rtxtURL_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Page:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "From";
            // 
            // lblNotification
            // 
            this.lblNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.Location = new System.Drawing.Point(458, 139);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(21, 20);
            this.lblNotification.TabIndex = 1;
            this.lblNotification.Text = "...";
            // 
            // lblLoadingPercent
            // 
            this.lblLoadingPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoadingPercent.AutoSize = true;
            this.lblLoadingPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingPercent.Location = new System.Drawing.Point(81, 136);
            this.lblLoadingPercent.Name = "lblLoadingPercent";
            this.lblLoadingPercent.Size = new System.Drawing.Size(137, 20);
            this.lblLoadingPercent.TabIndex = 1;
            this.lblLoadingPercent.Text = "Loading Percent...";
            // 
            // radNo
            // 
            this.radNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radNo.AutoSize = true;
            this.radNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNo.Location = new System.Drawing.Point(663, 101);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(47, 24);
            this.radNo.TabIndex = 4;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "to";
            // 
            // radYes
            // 
            this.radYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radYes.AutoSize = true;
            this.radYes.Checked = true;
            this.radYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radYes.Location = new System.Drawing.Point(601, 101);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(55, 24);
            this.radYes.TabIndex = 4;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save to Database:";
            // 
            // txtNumberofPageTo
            // 
            this.txtNumberofPageTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberofPageTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberofPageTo.Location = new System.Drawing.Point(376, 97);
            this.txtNumberofPageTo.Name = "txtNumberofPageTo";
            this.txtNumberofPageTo.Size = new System.Drawing.Size(65, 26);
            this.txtNumberofPageTo.TabIndex = 3;
            // 
            // txtNumberofPageFrom
            // 
            this.txtNumberofPageFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberofPageFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberofPageFrom.Location = new System.Drawing.Point(276, 97);
            this.txtNumberofPageFrom.Name = "txtNumberofPageFrom";
            this.txtNumberofPageFrom.Size = new System.Drawing.Size(65, 26);
            this.txtNumberofPageFrom.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 455);
            this.panel1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductCategoryID,
            this.ProductID,
            this.ProductSKU,
            this.ProductName,
            this.ProductOriginalPrice,
            this.ProductPrice,
            this.ProductQuantitySold,
            this.RatingAverage,
            this.ReviewCount,
            this.EarliestDeliveryEstimate,
            this.StandardDeliveryEstimate,
            this.UrlPath,
            this.AccID,
            this.IDData});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1142, 455);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // ProductCategoryID
            // 
            this.ProductCategoryID.DataPropertyName = "ProductCategoryID";
            this.ProductCategoryID.HeaderText = "ProductCategoryID";
            this.ProductCategoryID.Name = "ProductCategoryID";
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            // 
            // ProductSKU
            // 
            this.ProductSKU.DataPropertyName = "ProductSKU";
            this.ProductSKU.HeaderText = "ProductSKU";
            this.ProductSKU.Name = "ProductSKU";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            // 
            // ProductOriginalPrice
            // 
            this.ProductOriginalPrice.DataPropertyName = "ProductOriginalPrice";
            this.ProductOriginalPrice.HeaderText = "ProductOriginalPrice";
            this.ProductOriginalPrice.Name = "ProductOriginalPrice";
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "ProductPrice";
            this.ProductPrice.HeaderText = "ProductPrice";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // ProductQuantitySold
            // 
            this.ProductQuantitySold.DataPropertyName = "ProductQuantitySold";
            this.ProductQuantitySold.HeaderText = "ProductQuantitySold";
            this.ProductQuantitySold.Name = "ProductQuantitySold";
            // 
            // RatingAverage
            // 
            this.RatingAverage.DataPropertyName = "RatingAverage";
            this.RatingAverage.HeaderText = "RatingAverage";
            this.RatingAverage.Name = "RatingAverage";
            // 
            // ReviewCount
            // 
            this.ReviewCount.DataPropertyName = "ReviewCount";
            this.ReviewCount.HeaderText = "ReviewCount";
            this.ReviewCount.Name = "ReviewCount";
            // 
            // EarliestDeliveryEstimate
            // 
            this.EarliestDeliveryEstimate.DataPropertyName = "EarliestDeliveryEstimate";
            this.EarliestDeliveryEstimate.HeaderText = "EarliestDeliveryEstimate";
            this.EarliestDeliveryEstimate.Name = "EarliestDeliveryEstimate";
            // 
            // StandardDeliveryEstimate
            // 
            this.StandardDeliveryEstimate.DataPropertyName = "StandardDeliveryEstimate";
            this.StandardDeliveryEstimate.HeaderText = "StandardDeliveryEstimate";
            this.StandardDeliveryEstimate.Name = "StandardDeliveryEstimate";
            // 
            // UrlPath
            // 
            this.UrlPath.DataPropertyName = "UrlPath";
            this.UrlPath.HeaderText = "UrlPath";
            this.UrlPath.Name = "UrlPath";
            // 
            // AccID
            // 
            this.AccID.DataPropertyName = "AccID";
            this.AccID.HeaderText = "AccID";
            this.AccID.Name = "AccID";
            // 
            // IDData
            // 
            this.IDData.DataPropertyName = "IDData";
            this.IDData.HeaderText = "IDData";
            this.IDData.Name = "IDData";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.tikiReviewAnalyzerDataSet;
            // 
            // tikiReviewAnalyzerDataSet
            // 
            this.tikiReviewAnalyzerDataSet.DataSetName = "TikiReviewAnalyzerDataSet";
            this.tikiReviewAnalyzerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1142, 455);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // frmSubCrawlData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubCrawlData";
            this.Text = "frmSubCrawlData";
            this.Load += new System.EventHandler(this.frmSubCrawlData_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tikiReviewAnalyzerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtURL;
        private System.Windows.Forms.TextBox txtNumberofPageFrom;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.Button btnCrawlNow;
        private System.Windows.Forms.Label lblLoadingPercent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TikiReviewAnalyzerDataSet tikiReviewAnalyzerDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TikiReviewAnalyzerDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnSaveToDatabases;
        private System.Windows.Forms.TextBox txtNumberofPageTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDataDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDateCrawl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductOriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantitySold;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatingAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarliestDeliveryEstimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StandardDeliveryEstimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDData;
        private System.Windows.Forms.Label lblNotification;
    }
}