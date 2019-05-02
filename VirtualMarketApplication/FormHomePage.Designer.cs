namespace VirtualMarketApplication
{
    partial class FormHomePage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboRanking = new System.Windows.Forms.ComboBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
			this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAddToMyBasket = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnExitMyAccount = new System.Windows.Forms.Button();
			this.labelUserInformation = new System.Windows.Forms.Label();
			this.btnShowToMyBasket = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 58);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(243, 31);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(12, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(259, 44);
			this.label6.TabIndex = 3;
			this.label6.Text = "VIRTUAL MARKET";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSearch.Location = new System.Drawing.Point(383, 58);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(177, 30);
			this.txtSearch.TabIndex = 4;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSearch.Location = new System.Drawing.Point(566, 58);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(92, 30);
			this.btnSearch.TabIndex = 5;
			this.btnSearch.Text = "SEARCH";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(379, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Ranking :";
			// 
			// comboRanking
			// 
			this.comboRanking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboRanking.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.comboRanking.FormattingEnabled = true;
			this.comboRanking.Items.AddRange(new object[] {
            "Increase By Price",
            "Declining By Price"});
			this.comboRanking.Location = new System.Drawing.Point(450, 105);
			this.comboRanking.Name = "comboRanking";
			this.comboRanking.Size = new System.Drawing.Size(208, 31);
			this.comboRanking.TabIndex = 7;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblUsername.Location = new System.Drawing.Point(379, 21);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(0, 24);
			this.lblUsername.TabIndex = 8;
			// 
			// dataGridViewProducts
			// 
			this.dataGridViewProducts.AllowUserToAddRows = false;
			this.dataGridViewProducts.AllowUserToDeleteRows = false;
			this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCategory,
            this.ColumnProductType,
            this.ColumnID,
            this.ColumnBrand,
            this.ColumnModel,
            this.ColumnDescription,
            this.ColumnStock,
            this.ColumnQuantity,
            this.ColumnPrice,
            this.ColumnAddToMyBasket});
			this.dataGridViewProducts.Location = new System.Drawing.Point(12, 142);
			this.dataGridViewProducts.Name = "dataGridViewProducts";
			this.dataGridViewProducts.Size = new System.Drawing.Size(646, 222);
			this.dataGridViewProducts.TabIndex = 9;
			this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
			// 
			// ColumnCategory
			// 
			this.ColumnCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ColumnCategory.HeaderText = "Category";
			this.ColumnCategory.Name = "ColumnCategory";
			this.ColumnCategory.ReadOnly = true;
			this.ColumnCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnCategory.Width = 78;
			// 
			// ColumnProductType
			// 
			this.ColumnProductType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ColumnProductType.HeaderText = "Type";
			this.ColumnProductType.Name = "ColumnProductType";
			this.ColumnProductType.ReadOnly = true;
			this.ColumnProductType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnProductType.Width = 60;
			// 
			// ColumnID
			// 
			this.ColumnID.HeaderText = "ID";
			this.ColumnID.Name = "ColumnID";
			this.ColumnID.ReadOnly = true;
			this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// ColumnBrand
			// 
			this.ColumnBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ColumnBrand.HeaderText = "Brand";
			this.ColumnBrand.Name = "ColumnBrand";
			this.ColumnBrand.ReadOnly = true;
			this.ColumnBrand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnBrand.Width = 64;
			// 
			// ColumnModel
			// 
			this.ColumnModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ColumnModel.HeaderText = "Model";
			this.ColumnModel.Name = "ColumnModel";
			this.ColumnModel.ReadOnly = true;
			this.ColumnModel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnModel.Width = 65;
			// 
			// ColumnDescription
			// 
			this.ColumnDescription.HeaderText = "Description";
			this.ColumnDescription.Name = "ColumnDescription";
			this.ColumnDescription.ReadOnly = true;
			this.ColumnDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// ColumnStock
			// 
			this.ColumnStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.ColumnStock.DefaultCellStyle = dataGridViewCellStyle5;
			this.ColumnStock.HeaderText = "Stock";
			this.ColumnStock.Name = "ColumnStock";
			this.ColumnStock.ReadOnly = true;
			this.ColumnStock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnStock.Width = 64;
			// 
			// ColumnQuantity
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Format = "N0";
			this.ColumnQuantity.DefaultCellStyle = dataGridViewCellStyle6;
			this.ColumnQuantity.HeaderText = "Quantity";
			this.ColumnQuantity.Name = "ColumnQuantity";
			// 
			// ColumnPrice
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Format = "C2";
			dataGridViewCellStyle7.NullValue = null;
			this.ColumnPrice.DefaultCellStyle = dataGridViewCellStyle7;
			this.ColumnPrice.HeaderText = "Price";
			this.ColumnPrice.Name = "ColumnPrice";
			this.ColumnPrice.ReadOnly = true;
			this.ColumnPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// ColumnAddToMyBasket
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.NullValue = "BUY";
			this.ColumnAddToMyBasket.DefaultCellStyle = dataGridViewCellStyle8;
			this.ColumnAddToMyBasket.HeaderText = "Add To My Basket";
			this.ColumnAddToMyBasket.Name = "ColumnAddToMyBasket";
			// 
			// btnExitMyAccount
			// 
			this.btnExitMyAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExitMyAccount.Font = new System.Drawing.Font("Segoe Print", 9F);
			this.btnExitMyAccount.Location = new System.Drawing.Point(533, 370);
			this.btnExitMyAccount.Name = "btnExitMyAccount";
			this.btnExitMyAccount.Size = new System.Drawing.Size(125, 30);
			this.btnExitMyAccount.TabIndex = 10;
			this.btnExitMyAccount.Text = "Exit My Account";
			this.btnExitMyAccount.UseVisualStyleBackColor = true;
			this.btnExitMyAccount.Click += new System.EventHandler(this.btnExitMyAccount_Click);
			// 
			// labelUserInformation
			// 
			this.labelUserInformation.AutoSize = true;
			this.labelUserInformation.Font = new System.Drawing.Font("Segoe Print", 9F);
			this.labelUserInformation.Location = new System.Drawing.Point(12, 108);
			this.labelUserInformation.Name = "labelUserInformation";
			this.labelUserInformation.Size = new System.Drawing.Size(51, 24);
			this.labelUserInformation.TabIndex = 11;
			this.labelUserInformation.Text = "label2";
			// 
			// btnShowToMyBasket
			// 
			this.btnShowToMyBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnShowToMyBasket.Font = new System.Drawing.Font("Segoe Print", 9F);
			this.btnShowToMyBasket.Location = new System.Drawing.Point(12, 370);
			this.btnShowToMyBasket.Name = "btnShowToMyBasket";
			this.btnShowToMyBasket.Size = new System.Drawing.Size(157, 30);
			this.btnShowToMyBasket.TabIndex = 12;
			this.btnShowToMyBasket.Text = "Show To My Basket";
			this.btnShowToMyBasket.UseVisualStyleBackColor = true;
			this.btnShowToMyBasket.Click += new System.EventHandler(this.btnShowToMyBasket_Click);
			// 
			// FormHomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(670, 412);
			this.Controls.Add(this.btnShowToMyBasket);
			this.Controls.Add(this.labelUserInformation);
			this.Controls.Add(this.btnExitMyAccount);
			this.Controls.Add(this.dataGridViewProducts);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.comboRanking);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox1);
			this.Name = "FormHomePage";
			this.Text = "FormHomePage";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHomePage_FormClosing);
			this.Load += new System.EventHandler(this.FormHomePage_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRanking;
        private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private System.Windows.Forms.Button btnExitMyAccount;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductType;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrand;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModel;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
		private System.Windows.Forms.DataGridViewButtonColumn ColumnAddToMyBasket;
		private System.Windows.Forms.Label labelUserInformation;
		private System.Windows.Forms.Button btnShowToMyBasket;
	}
}