namespace Northwind.WebFormUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwProducts = new DataGridView();
            gbxCategory = new GroupBox();
            cbxCategories = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tbxSearchByName = new TextBox();
            label2 = new Label();
            lblCategoryIdAdd = new Label();
            groupBox3 = new GroupBox();
            btnAdd = new Button();
            tbxQuantityPerUnitAdd = new TextBox();
            tbxStockAmountAdd = new TextBox();
            cbxCategoryAdd = new ComboBox();
            label3 = new Label();
            lblStockAmount = new Label();
            lblProductPriceAdd = new Label();
            lblProdcutNameAdd = new Label();
            tbxProductAddPrice = new TextBox();
            tbxProductAddName = new TextBox();
            groupBox1 = new GroupBox();
            btnUpdate = new Button();
            tbxQuantityPerUnitUpdate = new TextBox();
            tbxStockAmountUpdate = new TextBox();
            cbxCategoryUpdate = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbxPriceUpdate = new TextBox();
            tbxNameUpdate = new TextBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxCategory.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(6, 9);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(782, 247);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick;
            // 
            // gbxCategory
            // 
            gbxCategory.Controls.Add(cbxCategories);
            gbxCategory.Controls.Add(label1);
            gbxCategory.Location = new Point(10, 270);
            gbxCategory.Name = "gbxCategory";
            gbxCategory.Size = new Size(428, 59);
            gbxCategory.TabIndex = 1;
            gbxCategory.TabStop = false;
            gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategories
            // 
            cbxCategories.FormattingEnabled = true;
            cbxCategories.Location = new Point(76, 25);
            cbxCategories.Name = "cbxCategories";
            cbxCategories.Size = new Size(121, 23);
            cbxCategories.TabIndex = 1;
            cbxCategories.SelectedIndexChanged += cbxCategories_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategoriler";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbxSearchByName);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(502, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 59);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ada Göre Ara";
            // 
            // tbxSearchByName
            // 
            tbxSearchByName.Location = new Point(105, 25);
            tbxSearchByName.Name = "tbxSearchByName";
            tbxSearchByName.Size = new Size(175, 23);
            tbxSearchByName.TabIndex = 1;
            tbxSearchByName.TextChanged += tbxSearchByName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 33);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 0;
            label2.Text = "Ada Göre Ara";
            // 
            // lblCategoryIdAdd
            // 
            lblCategoryIdAdd.AutoSize = true;
            lblCategoryIdAdd.Location = new Point(15, 88);
            lblCategoryIdAdd.Name = "lblCategoryIdAdd";
            lblCategoryIdAdd.Size = new Size(51, 15);
            lblCategoryIdAdd.TabIndex = 3;
            lblCategoryIdAdd.Text = "Kategori";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(tbxQuantityPerUnitAdd);
            groupBox3.Controls.Add(tbxStockAmountAdd);
            groupBox3.Controls.Add(cbxCategoryAdd);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(lblStockAmount);
            groupBox3.Controls.Add(lblCategoryIdAdd);
            groupBox3.Controls.Add(lblProductPriceAdd);
            groupBox3.Controls.Add(lblProdcutNameAdd);
            groupBox3.Controls.Add(tbxProductAddPrice);
            groupBox3.Controls.Add(tbxProductAddName);
            groupBox3.Location = new Point(12, 335);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(426, 121);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ürün Ekle";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(273, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxQuantityPerUnitAdd
            // 
            tbxQuantityPerUnitAdd.Location = new Point(299, 56);
            tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            tbxQuantityPerUnitAdd.Size = new Size(100, 23);
            tbxQuantityPerUnitAdd.TabIndex = 6;
            // 
            // tbxStockAmountAdd
            // 
            tbxStockAmountAdd.Location = new Point(290, 27);
            tbxStockAmountAdd.Name = "tbxStockAmountAdd";
            tbxStockAmountAdd.Size = new Size(100, 23);
            tbxStockAmountAdd.TabIndex = 5;
            // 
            // cbxCategoryAdd
            // 
            cbxCategoryAdd.FormattingEnabled = true;
            cbxCategoryAdd.Location = new Point(95, 85);
            cbxCategoryAdd.Name = "cbxCategoryAdd";
            cbxCategoryAdd.Size = new Size(121, 23);
            cbxCategoryAdd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 59);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Koli İçi Adet";
            // 
            // lblStockAmount
            // 
            lblStockAmount.AutoSize = true;
            lblStockAmount.Location = new Point(223, 30);
            lblStockAmount.Name = "lblStockAmount";
            lblStockAmount.Size = new Size(61, 15);
            lblStockAmount.TabIndex = 3;
            lblStockAmount.Text = "StokAdedi";
            // 
            // lblProductPriceAdd
            // 
            lblProductPriceAdd.AutoSize = true;
            lblProductPriceAdd.Location = new Point(15, 59);
            lblProductPriceAdd.Name = "lblProductPriceAdd";
            lblProductPriceAdd.Size = new Size(32, 15);
            lblProductPriceAdd.TabIndex = 3;
            lblProductPriceAdd.Text = "Fiyat";
            // 
            // lblProdcutNameAdd
            // 
            lblProdcutNameAdd.AutoSize = true;
            lblProdcutNameAdd.Location = new Point(15, 30);
            lblProdcutNameAdd.Name = "lblProdcutNameAdd";
            lblProdcutNameAdd.Size = new Size(25, 15);
            lblProdcutNameAdd.TabIndex = 3;
            lblProdcutNameAdd.Text = "Ad:";
            // 
            // tbxProductAddPrice
            // 
            tbxProductAddPrice.Location = new Point(95, 51);
            tbxProductAddPrice.Name = "tbxProductAddPrice";
            tbxProductAddPrice.Size = new Size(100, 23);
            tbxProductAddPrice.TabIndex = 1;
            // 
            // tbxProductAddName
            // 
            tbxProductAddName.Location = new Point(95, 22);
            tbxProductAddName.Name = "tbxProductAddName";
            tbxProductAddName.Size = new Size(100, 23);
            tbxProductAddName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(tbxQuantityPerUnitUpdate);
            groupBox1.Controls.Add(tbxStockAmountUpdate);
            groupBox1.Controls.Add(cbxCategoryUpdate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbxPriceUpdate);
            groupBox1.Controls.Add(tbxNameUpdate);
            groupBox1.Location = new Point(444, 335);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 121);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Ekle";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(273, 88);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxQuantityPerUnitUpdate
            // 
            tbxQuantityPerUnitUpdate.Location = new Point(290, 56);
            tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            tbxQuantityPerUnitUpdate.Size = new Size(100, 23);
            tbxQuantityPerUnitUpdate.TabIndex = 6;
            // 
            // tbxStockAmountUpdate
            // 
            tbxStockAmountUpdate.Location = new Point(290, 27);
            tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            tbxStockAmountUpdate.Size = new Size(100, 23);
            tbxStockAmountUpdate.TabIndex = 5;
            // 
            // cbxCategoryUpdate
            // 
            cbxCategoryUpdate.FormattingEnabled = true;
            cbxCategoryUpdate.Location = new Point(95, 85);
            cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            cbxCategoryUpdate.Size = new Size(121, 23);
            cbxCategoryUpdate.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 59);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 4;
            label4.Text = "Koli İçi Adet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 30);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 3;
            label5.Text = "StokAdedi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 88);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 3;
            label6.Text = "Kategori";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 59);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 3;
            label7.Text = "Fiyat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 30);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 3;
            label8.Text = "Ad:";
            // 
            // tbxPriceUpdate
            // 
            tbxPriceUpdate.Location = new Point(95, 51);
            tbxPriceUpdate.Name = "tbxPriceUpdate";
            tbxPriceUpdate.Size = new Size(100, 23);
            tbxPriceUpdate.TabIndex = 1;
            // 
            // tbxNameUpdate
            // 
            tbxNameUpdate.Location = new Point(95, 22);
            tbxNameUpdate.Name = "tbxNameUpdate";
            tbxNameUpdate.Size = new Size(100, 23);
            tbxNameUpdate.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(789, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 54);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Seçili Ürünü Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 465);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(gbxCategory);
            Controls.Add(dgwProducts);
            Name = "Form1";
            Text = "Ürünler";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            gbxCategory.ResumeLayout(false);
            gbxCategory.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProducts;
        private GroupBox gbxCategory;
        private ComboBox cbxCategories;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox tbxSearchByName;
        private Label label2;
        private Label lblCategoryIdAdd;
        private GroupBox groupBox3;
        private Button btnAdd;
        private TextBox tbxQuantityPerUnitAdd;
        private TextBox tbxStockAmountAdd;
        private ComboBox cbxCategoryAdd;
        private Label label3;
        private Label lblStockAmount;
        private Label lblProductPriceAdd;
        private Label lblProdcutNameAdd;
        private TextBox tbxProductAddPrice;
        private TextBox tbxProductAddName;
        private GroupBox groupBox1;
        private Button btnUpdate;
        private TextBox tbxQuantityPerUnitUpdate;
        private TextBox tbxStockAmountUpdate;
        private ComboBox cbxCategoryUpdate;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbxPriceUpdate;
        private TextBox tbxNameUpdate;
        private Button btnDelete;
    }
}