namespace WooPharmacyPOS
{
    partial class Dashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbProductSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tabPag2 = new System.Windows.Forms.TabPage();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.txtNewProductStock = new System.Windows.Forms.TextBox();
            this.txtNewProductPrice = new System.Windows.Forms.TextBox();
            this.txtNewProductName = new System.Windows.Forms.TextBox();
            this.lblNewProductStock = new System.Windows.Forms.Label();
            this.lblNewProductPrice = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblNewProductName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerMonthlyReport = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDailyReport = new System.Windows.Forms.DateTimePicker();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimePickerExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPag2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPag2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 550);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            this.tabPage1.Controls.Add(this.cmbProductSearch);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnProcessPayment);
            this.tabPage1.Controls.Add(this.btnPrintReceipt);
            this.tabPage1.Controls.Add(this.txtPaymentAmount);
            this.tabPage1.Controls.Add(this.lblChange);
            this.tabPage1.Controls.Add(this.txtQuantity);
            this.tabPage1.Controls.Add(this.lblTotalPayment);
            this.tabPage1.Controls.Add(this.lblQuantity);
            this.tabPage1.Controls.Add(this.lblProductName);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sell";
            // 
            // cmbProductSearch
            // 
            this.cmbProductSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductSearch.FormattingEnabled = true;
            this.cmbProductSearch.Location = new System.Drawing.Point(138, 52);
            this.cmbProductSearch.Name = "cmbProductSearch";
            this.cmbProductSearch.Size = new System.Drawing.Size(381, 30);
            this.cmbProductSearch.TabIndex = 7;
            this.cmbProductSearch.SelectedIndexChanged += new System.EventHandler(this.cmbProductSearch_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recieve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Payment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Change:";
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.Color.PowderBlue;
            this.btnProcessPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProcessPayment.Location = new System.Drawing.Point(3, 440);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(855, 38);
            this.btnProcessPayment.TabIndex = 4;
            this.btnProcessPayment.Text = "Process Payment";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPrintReceipt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPrintReceipt.Location = new System.Drawing.Point(3, 478);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(855, 40);
            this.btnPrintReceipt.TabIndex = 3;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(189, 173);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(156, 30);
            this.txtPaymentAmount.TabIndex = 1;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(194, 251);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(45, 22);
            this.lblChange.TabIndex = 0;
            this.lblChange.Text = "0.00";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(138, 102);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(117, 30);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Location = new System.Drawing.Point(194, 216);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(45, 22);
            this.lblTotalPayment.TabIndex = 0;
            this.lblTotalPayment.Text = "0.00";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(39, 105);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(93, 22);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(39, 55);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(88, 22);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product :";
            // 
            // tabPag2
            // 
            this.tabPag2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            this.tabPag2.Controls.Add(this.dateTimePickerExpirationDate);
            this.tabPag2.Controls.Add(this.btnDeleteProduct);
            this.tabPag2.Controls.Add(this.btnEditProduct);
            this.tabPag2.Controls.Add(this.btnAddNewProduct);
            this.tabPag2.Controls.Add(this.dgvProductList);
            this.tabPag2.Controls.Add(this.txtNewProductStock);
            this.tabPag2.Controls.Add(this.txtNewProductPrice);
            this.tabPag2.Controls.Add(this.txtNewProductName);
            this.tabPag2.Controls.Add(this.label7);
            this.tabPag2.Controls.Add(this.lblNewProductStock);
            this.tabPag2.Controls.Add(this.lblNewProductPrice);
            this.tabPag2.Controls.Add(this.lblProductID);
            this.tabPag2.Controls.Add(this.lblNewProductName);
            this.tabPag2.Location = new System.Drawing.Point(4, 25);
            this.tabPag2.Name = "tabPag2";
            this.tabPag2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPag2.Size = new System.Drawing.Size(861, 521);
            this.tabPag2.TabIndex = 3;
            this.tabPag2.Text = "Manage Product";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.Location = new System.Drawing.Point(599, 93);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(85, 32);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditProduct.Location = new System.Drawing.Point(602, 55);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(78, 32);
            this.btnEditProduct.TabIndex = 6;
            this.btnEditProduct.Text = "Edit";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddNewProduct.Location = new System.Drawing.Point(583, 17);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(116, 32);
            this.btnAddNewProduct.TabIndex = 7;
            this.btnAddNewProduct.Text = "Add Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = false;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // dgvProductList
            // 
            this.dgvProductList.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(37, 162);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 24;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(733, 334);
            this.dgvProductList.TabIndex = 3;
            this.dgvProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellClick);
            // 
            // txtNewProductStock
            // 
            this.txtNewProductStock.Location = new System.Drawing.Point(212, 95);
            this.txtNewProductStock.Name = "txtNewProductStock";
            this.txtNewProductStock.Size = new System.Drawing.Size(109, 22);
            this.txtNewProductStock.TabIndex = 1;
            // 
            // txtNewProductPrice
            // 
            this.txtNewProductPrice.Location = new System.Drawing.Point(212, 69);
            this.txtNewProductPrice.Name = "txtNewProductPrice";
            this.txtNewProductPrice.Size = new System.Drawing.Size(99, 22);
            this.txtNewProductPrice.TabIndex = 1;
            // 
            // txtNewProductName
            // 
            this.txtNewProductName.Location = new System.Drawing.Point(212, 41);
            this.txtNewProductName.Name = "txtNewProductName";
            this.txtNewProductName.Size = new System.Drawing.Size(220, 22);
            this.txtNewProductName.TabIndex = 1;
            // 
            // lblNewProductStock
            // 
            this.lblNewProductStock.AutoSize = true;
            this.lblNewProductStock.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProductStock.Location = new System.Drawing.Point(131, 94);
            this.lblNewProductStock.Name = "lblNewProductStock";
            this.lblNewProductStock.Size = new System.Drawing.Size(63, 22);
            this.lblNewProductStock.TabIndex = 0;
            this.lblNewProductStock.Text = "Stock:";
            this.lblNewProductStock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNewProductPrice
            // 
            this.lblNewProductPrice.AutoSize = true;
            this.lblNewProductPrice.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProductPrice.Location = new System.Drawing.Point(135, 68);
            this.lblNewProductPrice.Name = "lblNewProductPrice";
            this.lblNewProductPrice.Size = new System.Drawing.Size(59, 22);
            this.lblNewProductPrice.TabIndex = 0;
            this.lblNewProductPrice.Text = "Price:";
            this.lblNewProductPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(18, 81);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(0, 22);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Visible = false;
            // 
            // lblNewProductName
            // 
            this.lblNewProductName.AutoSize = true;
            this.lblNewProductName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProductName.Location = new System.Drawing.Point(52, 39);
            this.lblNewProductName.Name = "lblNewProductName";
            this.lblNewProductName.Size = new System.Drawing.Size(142, 22);
            this.lblNewProductName.TabIndex = 0;
            this.lblNewProductName.Text = "Product Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dateTimePickerMonthlyReport);
            this.tabPage3.Controls.Add(this.dateTimePickerDailyReport);
            this.tabPage3.Controls.Add(this.dgvReport);
            this.tabPage3.Controls.Add(this.btnMonthlyReport);
            this.tabPage3.Controls.Add(this.btnDailyReport);
            this.tabPage3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(861, 521);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Report";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Select Date for Monthly Report";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Select Date for Daily Report";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerMonthlyReport
            // 
            this.dateTimePickerMonthlyReport.Location = new System.Drawing.Point(483, 86);
            this.dateTimePickerMonthlyReport.Name = "dateTimePickerMonthlyReport";
            this.dateTimePickerMonthlyReport.Size = new System.Drawing.Size(339, 30);
            this.dateTimePickerMonthlyReport.TabIndex = 2;
            // 
            // dateTimePickerDailyReport
            // 
            this.dateTimePickerDailyReport.Location = new System.Drawing.Point(31, 86);
            this.dateTimePickerDailyReport.Name = "dateTimePickerDailyReport";
            this.dateTimePickerDailyReport.Size = new System.Drawing.Size(339, 30);
            this.dateTimePickerDailyReport.TabIndex = 2;
            // 
            // dgvReport
            // 
            this.dgvReport.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(31, 140);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(791, 328);
            this.dgvReport.TabIndex = 1;
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.btnMonthlyReport.Location = new System.Drawing.Point(554, 29);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(191, 51);
            this.btnMonthlyReport.TabIndex = 0;
            this.btnMonthlyReport.Text = "Monthly Report";
            this.btnMonthlyReport.UseVisualStyleBackColor = false;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.btnDailyReport.Location = new System.Drawing.Point(117, 29);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(154, 51);
            this.btnDailyReport.TabIndex = 0;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.UseVisualStyleBackColor = false;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.btnLogout);
            this.tabPage4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(861, 521);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Logout";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 101);
            this.label4.TabIndex = 1;
            this.label4.Text = "When the cashier logs out of the POS system, all active sessions are securely ter" +
    "minated, ensuring that no sensitive data remains accessible.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLogout.Location = new System.Drawing.Point(352, 268);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(136, 56);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dateTimePickerExpirationDate
            // 
            this.dateTimePickerExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExpirationDate.Location = new System.Drawing.Point(212, 124);
            this.dateTimePickerExpirationDate.Name = "dateTimePickerExpirationDate";
            this.dateTimePickerExpirationDate.Size = new System.Drawing.Size(88, 22);
            this.dateTimePickerExpirationDate.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Expiration Date:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(869, 550);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Woo Pharmacy";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPag2.ResumeLayout(false);
            this.tabPag2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPag2;
        private System.Windows.Forms.Label lblNewProductName;
        private System.Windows.Forms.TextBox txtNewProductPrice;
        private System.Windows.Forms.TextBox txtNewProductName;
        private System.Windows.Forms.Label lblNewProductStock;
        private System.Windows.Forms.Label lblNewProductPrice;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.TextBox txtNewProductStock;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.ComboBox cmbProductSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerDailyReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerMonthlyReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpirationDate;
        private System.Windows.Forms.Label label7;
    }
}