namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxcategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.tbxProductAddQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxProductAddStockAmount = new System.Windows.Forms.TextBox();
            this.tbxProductAddUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxProductAddCategori = new System.Windows.Forms.ComboBox();
            this.tbxProductAddProductName = new System.Windows.Forms.TextBox();
            this.lblProductAddQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblProductAddStock = new System.Windows.Forms.Label();
            this.lblProductAddUnirPrice = new System.Windows.Forms.Label();
            this.lblProductAddCategoryId = new System.Windows.Forms.Label();
            this.lblProductAddName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.tbxProductUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxProductUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.tbxProductUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxProductUpdateCategory = new System.Windows.Forms.ComboBox();
            this.tbxProductUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblProductUpdateQuantityPerUnit = new System.Windows.Forms.Label();
            this.labelblProductUpdateStockAmount = new System.Windows.Forms.Label();
            this.lblProductUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lblProductUpdateCategory = new System.Windows.Forms.Label();
            this.lblProductUpdateProductName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxcategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 217);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(810, 160);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxcategory
            // 
            this.gbxcategory.Controls.Add(this.cbxCategory);
            this.gbxcategory.Controls.Add(this.lblCategory);
            this.gbxcategory.Location = new System.Drawing.Point(12, 12);
            this.gbxcategory.Name = "gbxcategory";
            this.gbxcategory.Size = new System.Drawing.Size(810, 80);
            this.gbxcategory.TabIndex = 1;
            this.gbxcategory.TabStop = false;
            this.gbxcategory.Text = "Kategoriye Göre Arama";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(80, 27);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(242, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 35);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori : ";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(12, 108);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(810, 85);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adına Göre Ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(80, 28);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(242, 20);
            this.tbxProductName.TabIndex = 2;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 35);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(54, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Ürün Adı :";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnProductAdd);
            this.gbxProductAdd.Controls.Add(this.tbxProductAddQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxProductAddStockAmount);
            this.gbxProductAdd.Controls.Add(this.tbxProductAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.cbxProductAddCategori);
            this.gbxProductAdd.Controls.Add(this.tbxProductAddProductName);
            this.gbxProductAdd.Controls.Add(this.lblProductAddQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblProductAddStock);
            this.gbxProductAdd.Controls.Add(this.lblProductAddUnirPrice);
            this.gbxProductAdd.Controls.Add(this.lblProductAddCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblProductAddName);
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 394);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(322, 234);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(173, 205);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductAdd.TabIndex = 10;
            this.btnProductAdd.Text = "Ürün Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // tbxProductAddQuantityPerUnit
            // 
            this.tbxProductAddQuantityPerUnit.Location = new System.Drawing.Point(89, 166);
            this.tbxProductAddQuantityPerUnit.Name = "tbxProductAddQuantityPerUnit";
            this.tbxProductAddQuantityPerUnit.Size = new System.Drawing.Size(159, 20);
            this.tbxProductAddQuantityPerUnit.TabIndex = 9;
            // 
            // tbxProductAddStockAmount
            // 
            this.tbxProductAddStockAmount.Location = new System.Drawing.Point(89, 130);
            this.tbxProductAddStockAmount.Name = "tbxProductAddStockAmount";
            this.tbxProductAddStockAmount.Size = new System.Drawing.Size(159, 20);
            this.tbxProductAddStockAmount.TabIndex = 8;
            // 
            // tbxProductAddUnitPrice
            // 
            this.tbxProductAddUnitPrice.Location = new System.Drawing.Point(89, 100);
            this.tbxProductAddUnitPrice.Name = "tbxProductAddUnitPrice";
            this.tbxProductAddUnitPrice.Size = new System.Drawing.Size(159, 20);
            this.tbxProductAddUnitPrice.TabIndex = 7;
            // 
            // cbxProductAddCategori
            // 
            this.cbxProductAddCategori.FormattingEnabled = true;
            this.cbxProductAddCategori.Location = new System.Drawing.Point(89, 64);
            this.cbxProductAddCategori.Name = "cbxProductAddCategori";
            this.cbxProductAddCategori.Size = new System.Drawing.Size(159, 21);
            this.cbxProductAddCategori.TabIndex = 6;
            // 
            // tbxProductAddProductName
            // 
            this.tbxProductAddProductName.Location = new System.Drawing.Point(89, 27);
            this.tbxProductAddProductName.Name = "tbxProductAddProductName";
            this.tbxProductAddProductName.Size = new System.Drawing.Size(159, 20);
            this.tbxProductAddProductName.TabIndex = 5;
            // 
            // lblProductAddQuantityPerUnit
            // 
            this.lblProductAddQuantityPerUnit.AutoSize = true;
            this.lblProductAddQuantityPerUnit.Location = new System.Drawing.Point(6, 173);
            this.lblProductAddQuantityPerUnit.Name = "lblProductAddQuantityPerUnit";
            this.lblProductAddQuantityPerUnit.Size = new System.Drawing.Size(62, 13);
            this.lblProductAddQuantityPerUnit.TabIndex = 4;
            this.lblProductAddQuantityPerUnit.Text = "Birim Adeti :";
            // 
            // lblProductAddStock
            // 
            this.lblProductAddStock.AutoSize = true;
            this.lblProductAddStock.Location = new System.Drawing.Point(6, 137);
            this.lblProductAddStock.Name = "lblProductAddStock";
            this.lblProductAddStock.Size = new System.Drawing.Size(62, 13);
            this.lblProductAddStock.TabIndex = 3;
            this.lblProductAddStock.Text = "Stok Adeti :";
            // 
            // lblProductAddUnirPrice
            // 
            this.lblProductAddUnirPrice.AutoSize = true;
            this.lblProductAddUnirPrice.Location = new System.Drawing.Point(6, 107);
            this.lblProductAddUnirPrice.Name = "lblProductAddUnirPrice";
            this.lblProductAddUnirPrice.Size = new System.Drawing.Size(35, 13);
            this.lblProductAddUnirPrice.TabIndex = 2;
            this.lblProductAddUnirPrice.Text = "Fiyat :";
            // 
            // lblProductAddCategoryId
            // 
            this.lblProductAddCategoryId.AutoSize = true;
            this.lblProductAddCategoryId.Location = new System.Drawing.Point(6, 72);
            this.lblProductAddCategoryId.Name = "lblProductAddCategoryId";
            this.lblProductAddCategoryId.Size = new System.Drawing.Size(55, 13);
            this.lblProductAddCategoryId.TabIndex = 1;
            this.lblProductAddCategoryId.Text = "Kategori : ";
            // 
            // lblProductAddName
            // 
            this.lblProductAddName.AutoSize = true;
            this.lblProductAddName.Location = new System.Drawing.Point(6, 27);
            this.lblProductAddName.Name = "lblProductAddName";
            this.lblProductAddName.Size = new System.Drawing.Size(54, 13);
            this.lblProductAddName.TabIndex = 0;
            this.lblProductAddName.Text = "Ürün Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProductUpdate);
            this.groupBox1.Controls.Add(this.tbxProductUpdateQuantityPerUnit);
            this.groupBox1.Controls.Add(this.tbxProductUpdateStockAmount);
            this.groupBox1.Controls.Add(this.tbxProductUpdateUnitPrice);
            this.groupBox1.Controls.Add(this.cbxProductUpdateCategory);
            this.groupBox1.Controls.Add(this.tbxProductUpdateProductName);
            this.groupBox1.Controls.Add(this.lblProductUpdateQuantityPerUnit);
            this.groupBox1.Controls.Add(this.labelblProductUpdateStockAmount);
            this.groupBox1.Controls.Add(this.lblProductUpdateUnitPrice);
            this.groupBox1.Controls.Add(this.lblProductUpdateCategory);
            this.groupBox1.Controls.Add(this.lblProductUpdateProductName);
            this.groupBox1.Location = new System.Drawing.Point(500, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 234);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(152, 205);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(96, 23);
            this.btnProductUpdate.TabIndex = 10;
            this.btnProductUpdate.Text = "Ürün Güncelle";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // tbxProductUpdateQuantityPerUnit
            // 
            this.tbxProductUpdateQuantityPerUnit.Location = new System.Drawing.Point(89, 166);
            this.tbxProductUpdateQuantityPerUnit.Name = "tbxProductUpdateQuantityPerUnit";
            this.tbxProductUpdateQuantityPerUnit.Size = new System.Drawing.Size(159, 20);
            this.tbxProductUpdateQuantityPerUnit.TabIndex = 9;
            // 
            // tbxProductUpdateStockAmount
            // 
            this.tbxProductUpdateStockAmount.Location = new System.Drawing.Point(89, 130);
            this.tbxProductUpdateStockAmount.Name = "tbxProductUpdateStockAmount";
            this.tbxProductUpdateStockAmount.Size = new System.Drawing.Size(159, 20);
            this.tbxProductUpdateStockAmount.TabIndex = 8;
            // 
            // tbxProductUpdateUnitPrice
            // 
            this.tbxProductUpdateUnitPrice.Location = new System.Drawing.Point(89, 100);
            this.tbxProductUpdateUnitPrice.Name = "tbxProductUpdateUnitPrice";
            this.tbxProductUpdateUnitPrice.Size = new System.Drawing.Size(159, 20);
            this.tbxProductUpdateUnitPrice.TabIndex = 7;
            // 
            // cbxProductUpdateCategory
            // 
            this.cbxProductUpdateCategory.FormattingEnabled = true;
            this.cbxProductUpdateCategory.Location = new System.Drawing.Point(89, 64);
            this.cbxProductUpdateCategory.Name = "cbxProductUpdateCategory";
            this.cbxProductUpdateCategory.Size = new System.Drawing.Size(159, 21);
            this.cbxProductUpdateCategory.TabIndex = 6;
            // 
            // tbxProductUpdateProductName
            // 
            this.tbxProductUpdateProductName.Location = new System.Drawing.Point(89, 27);
            this.tbxProductUpdateProductName.Name = "tbxProductUpdateProductName";
            this.tbxProductUpdateProductName.Size = new System.Drawing.Size(159, 20);
            this.tbxProductUpdateProductName.TabIndex = 5;
            // 
            // lblProductUpdateQuantityPerUnit
            // 
            this.lblProductUpdateQuantityPerUnit.AutoSize = true;
            this.lblProductUpdateQuantityPerUnit.Location = new System.Drawing.Point(6, 173);
            this.lblProductUpdateQuantityPerUnit.Name = "lblProductUpdateQuantityPerUnit";
            this.lblProductUpdateQuantityPerUnit.Size = new System.Drawing.Size(62, 13);
            this.lblProductUpdateQuantityPerUnit.TabIndex = 4;
            this.lblProductUpdateQuantityPerUnit.Text = "Birim Adeti :";
            // 
            // labelblProductUpdateStockAmount
            // 
            this.labelblProductUpdateStockAmount.AutoSize = true;
            this.labelblProductUpdateStockAmount.Location = new System.Drawing.Point(6, 137);
            this.labelblProductUpdateStockAmount.Name = "labelblProductUpdateStockAmount";
            this.labelblProductUpdateStockAmount.Size = new System.Drawing.Size(62, 13);
            this.labelblProductUpdateStockAmount.TabIndex = 3;
            this.labelblProductUpdateStockAmount.Text = "Stok Adeti :";
            // 
            // lblProductUpdateUnitPrice
            // 
            this.lblProductUpdateUnitPrice.AutoSize = true;
            this.lblProductUpdateUnitPrice.Location = new System.Drawing.Point(6, 107);
            this.lblProductUpdateUnitPrice.Name = "lblProductUpdateUnitPrice";
            this.lblProductUpdateUnitPrice.Size = new System.Drawing.Size(35, 13);
            this.lblProductUpdateUnitPrice.TabIndex = 2;
            this.lblProductUpdateUnitPrice.Text = "Fiyat :";
            // 
            // lblProductUpdateCategory
            // 
            this.lblProductUpdateCategory.AutoSize = true;
            this.lblProductUpdateCategory.Location = new System.Drawing.Point(6, 72);
            this.lblProductUpdateCategory.Name = "lblProductUpdateCategory";
            this.lblProductUpdateCategory.Size = new System.Drawing.Size(55, 13);
            this.lblProductUpdateCategory.TabIndex = 1;
            this.lblProductUpdateCategory.Text = "Kategori : ";
            // 
            // lblProductUpdateProductName
            // 
            this.lblProductUpdateProductName.AutoSize = true;
            this.lblProductUpdateProductName.Location = new System.Drawing.Point(6, 27);
            this.lblProductUpdateProductName.Name = "lblProductUpdateProductName";
            this.lblProductUpdateProductName.Size = new System.Drawing.Size(54, 13);
            this.lblProductUpdateProductName.TabIndex = 0;
            this.lblProductUpdateProductName.Text = "Ürün Adı :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(377, 599);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Ürün Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 640);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxcategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxcategory.ResumeLayout(false);
            this.gbxcategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxcategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblProductAddQuantityPerUnit;
        private System.Windows.Forms.Label lblProductAddStock;
        private System.Windows.Forms.Label lblProductAddUnirPrice;
        private System.Windows.Forms.Label lblProductAddCategoryId;
        private System.Windows.Forms.Label lblProductAddName;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox tbxProductAddQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxProductAddStockAmount;
        private System.Windows.Forms.TextBox tbxProductAddUnitPrice;
        private System.Windows.Forms.ComboBox cbxProductAddCategori;
        private System.Windows.Forms.TextBox tbxProductAddProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.TextBox tbxProductUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxProductUpdateStockAmount;
        private System.Windows.Forms.TextBox tbxProductUpdateUnitPrice;
        private System.Windows.Forms.ComboBox cbxProductUpdateCategory;
        private System.Windows.Forms.TextBox tbxProductUpdateProductName;
        private System.Windows.Forms.Label lblProductUpdateQuantityPerUnit;
        private System.Windows.Forms.Label labelblProductUpdateStockAmount;
        private System.Windows.Forms.Label lblProductUpdateUnitPrice;
        private System.Windows.Forms.Label lblProductUpdateCategory;
        private System.Windows.Forms.Label lblProductUpdateProductName;
        private System.Windows.Forms.Button btnDelete;
    }
}

