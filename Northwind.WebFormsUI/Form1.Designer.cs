
namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxAddQuantity = new System.Windows.Forms.TextBox();
            this.tbxAddStock = new System.Windows.Forms.TextBox();
            this.cbxAddCategory = new System.Windows.Forms.ComboBox();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.lblAddQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.lblAddUnitPrice = new System.Windows.Forms.Label();
            this.lblAddCategoryId = new System.Windows.Forms.Label();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitsInStock = new System.Windows.Forms.TextBox();
            this.cbxUpdateCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(13, 162);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(776, 225);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(776, 64);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(75, 27);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(154, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 30);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(13, 82);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(775, 64);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adına Göre Ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(74, 28);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(154, 20);
            this.tbxProductName.TabIndex = 2;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(17, 31);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxAddQuantity);
            this.gbxProductAdd.Controls.Add(this.tbxAddStock);
            this.gbxProductAdd.Controls.Add(this.cbxAddCategory);
            this.gbxProductAdd.Controls.Add(this.tbxAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxAddProductName);
            this.gbxProductAdd.Controls.Add(this.lblAddQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblAddStock);
            this.gbxProductAdd.Controls.Add(this.lblAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblAddCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblAddProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 429);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(775, 156);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(473, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxAddQuantity
            // 
            this.tbxAddQuantity.Location = new System.Drawing.Point(473, 79);
            this.tbxAddQuantity.Name = "tbxAddQuantity";
            this.tbxAddQuantity.Size = new System.Drawing.Size(156, 20);
            this.tbxAddQuantity.TabIndex = 8;
            // 
            // tbxAddStock
            // 
            this.tbxAddStock.Location = new System.Drawing.Point(473, 38);
            this.tbxAddStock.Name = "tbxAddStock";
            this.tbxAddStock.Size = new System.Drawing.Size(156, 20);
            this.tbxAddStock.TabIndex = 7;
            // 
            // cbxAddCategory
            // 
            this.cbxAddCategory.FormattingEnabled = true;
            this.cbxAddCategory.Location = new System.Drawing.Point(112, 71);
            this.cbxAddCategory.Name = "cbxAddCategory";
            this.cbxAddCategory.Size = new System.Drawing.Size(158, 21);
            this.cbxAddCategory.TabIndex = 6;
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(112, 110);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(158, 20);
            this.tbxAddUnitPrice.TabIndex = 5;
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(112, 38);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(158, 20);
            this.tbxAddProductName.TabIndex = 4;
            // 
            // lblAddQuantityPerUnit
            // 
            this.lblAddQuantityPerUnit.AutoSize = true;
            this.lblAddQuantityPerUnit.Location = new System.Drawing.Point(375, 79);
            this.lblAddQuantityPerUnit.Name = "lblAddQuantityPerUnit";
            this.lblAddQuantityPerUnit.Size = new System.Drawing.Size(54, 13);
            this.lblAddQuantityPerUnit.TabIndex = 4;
            this.lblAddQuantityPerUnit.Text = "Birim Adet";
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Location = new System.Drawing.Point(375, 41);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(59, 13);
            this.lblAddStock.TabIndex = 3;
            this.lblAddStock.Text = "Stok Adedi";
            // 
            // lblAddUnitPrice
            // 
            this.lblAddUnitPrice.AutoSize = true;
            this.lblAddUnitPrice.Location = new System.Drawing.Point(17, 117);
            this.lblAddUnitPrice.Name = "lblAddUnitPrice";
            this.lblAddUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblAddUnitPrice.TabIndex = 2;
            this.lblAddUnitPrice.Text = "Fiyat";
            // 
            // lblAddCategoryId
            // 
            this.lblAddCategoryId.AutoSize = true;
            this.lblAddCategoryId.Location = new System.Drawing.Point(17, 79);
            this.lblAddCategoryId.Name = "lblAddCategoryId";
            this.lblAddCategoryId.Size = new System.Drawing.Size(46, 13);
            this.lblAddCategoryId.TabIndex = 1;
            this.lblAddCategoryId.Text = "Kategori";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(17, 41);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(48, 13);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Ürün Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.groupBox1.Controls.Add(this.tbxUpdateUnitsInStock);
            this.groupBox1.Controls.Add(this.cbxUpdateCategoryId);
            this.groupBox1.Controls.Add(this.tbxUpdateUnitPrice);
            this.groupBox1.Controls.Add(this.tbxUpdateProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 591);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(473, 112);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 27);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(473, 79);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(156, 20);
            this.tbxUpdateQuantityPerUnit.TabIndex = 8;
            // 
            // tbxUpdateUnitsInStock
            // 
            this.tbxUpdateUnitsInStock.Location = new System.Drawing.Point(473, 38);
            this.tbxUpdateUnitsInStock.Name = "tbxUpdateUnitsInStock";
            this.tbxUpdateUnitsInStock.Size = new System.Drawing.Size(156, 20);
            this.tbxUpdateUnitsInStock.TabIndex = 7;
            // 
            // cbxUpdateCategoryId
            // 
            this.cbxUpdateCategoryId.FormattingEnabled = true;
            this.cbxUpdateCategoryId.Location = new System.Drawing.Point(112, 71);
            this.cbxUpdateCategoryId.Name = "cbxUpdateCategoryId";
            this.cbxUpdateCategoryId.Size = new System.Drawing.Size(158, 21);
            this.cbxUpdateCategoryId.TabIndex = 6;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(112, 110);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(158, 20);
            this.tbxUpdateUnitPrice.TabIndex = 5;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(112, 38);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(158, 20);
            this.tbxUpdateProductName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birim Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Adı";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(678, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 757);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.Label lblAddUnitPrice;
        private System.Windows.Forms.Label lblAddCategoryId;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.Label lblAddQuantityPerUnit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxAddQuantity;
        private System.Windows.Forms.TextBox tbxAddStock;
        private System.Windows.Forms.ComboBox cbxAddCategory;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateUnitsInStock;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryId;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
    }
}

