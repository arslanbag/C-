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
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxSave = new System.Windows.Forms.GroupBox();
            this.lblSaveName = new System.Windows.Forms.Label();
            this.lblSaveCategory = new System.Windows.Forms.Label();
            this.lblSavePrice = new System.Windows.Forms.Label();
            this.lblSaveStock = new System.Windows.Forms.Label();
            this.lblSaveQuantity = new System.Windows.Forms.Label();
            this.txtSaveName = new System.Windows.Forms.TextBox();
            this.txtSavePrice = new System.Windows.Forms.TextBox();
            this.txtSaveStock = new System.Windows.Forms.TextBox();
            this.txtSaveQuantity = new System.Windows.Forms.TextBox();
            this.btnSaveSave = new System.Windows.Forms.Button();
            this.btnSaveX = new System.Windows.Forms.Button();
            this.cbxSaveCategory = new System.Windows.Forms.ComboBox();
            this.btnNewSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.btnUpdateX = new System.Windows.Forms.Button();
            this.btnUpdateUpdate = new System.Windows.Forms.Button();
            this.txtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.txtUpdateStock = new System.Windows.Forms.TextBox();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateQuantity = new System.Windows.Forms.Label();
            this.lblUpdateStock = new System.Windows.Forms.Label();
            this.lblUpdatePrice = new System.Windows.Forms.Label();
            this.lblUpdateCategory = new System.Windows.Forms.Label();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxSave.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(109, 51);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(351, 24);
            this.cbxCategory.TabIndex = 3;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(28, 51);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(76, 16);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Kategori ☰";
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxSearch.Controls.Add(this.cbxCategory);
            this.gbxSearch.Controls.Add(this.lblCategory);
            this.gbxSearch.Controls.Add(this.txtSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearch.Location = new System.Drawing.Point(18, 16);
            this.gbxSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxSearch.Size = new System.Drawing.Size(676, 154);
            this.gbxSearch.TabIndex = 4;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürünlerde Ara";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(109, 99);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(457, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(37, 107);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(69, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Arama 🔎";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(18, 182);
            this.dgwProducts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgwProducts.MultiSelect = false;
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.ReadOnly = true;
            this.dgwProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProducts.Size = new System.Drawing.Size(674, 297);
            this.dgwProducts.TabIndex = 5;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // gbxSave
            // 
            this.gbxSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxSave.Controls.Add(this.cbxSaveCategory);
            this.gbxSave.Controls.Add(this.btnSaveX);
            this.gbxSave.Controls.Add(this.btnSaveSave);
            this.gbxSave.Controls.Add(this.txtSaveQuantity);
            this.gbxSave.Controls.Add(this.txtSaveStock);
            this.gbxSave.Controls.Add(this.txtSavePrice);
            this.gbxSave.Controls.Add(this.txtSaveName);
            this.gbxSave.Controls.Add(this.lblSaveQuantity);
            this.gbxSave.Controls.Add(this.lblSaveStock);
            this.gbxSave.Controls.Add(this.lblSavePrice);
            this.gbxSave.Controls.Add(this.lblSaveCategory);
            this.gbxSave.Controls.Add(this.lblSaveName);
            this.gbxSave.Location = new System.Drawing.Point(18, 526);
            this.gbxSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxSave.Name = "gbxSave";
            this.gbxSave.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxSave.Size = new System.Drawing.Size(676, 197);
            this.gbxSave.TabIndex = 6;
            this.gbxSave.TabStop = false;
            this.gbxSave.Text = "Ürün Kayıt Formu";
            // 
            // lblSaveName
            // 
            this.lblSaveName.AutoSize = true;
            this.lblSaveName.Location = new System.Drawing.Point(19, 47);
            this.lblSaveName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaveName.Name = "lblSaveName";
            this.lblSaveName.Size = new System.Drawing.Size(73, 16);
            this.lblSaveName.TabIndex = 0;
            this.lblSaveName.Text = "Ürün Adı :";
            // 
            // lblSaveCategory
            // 
            this.lblSaveCategory.AutoSize = true;
            this.lblSaveCategory.Location = new System.Drawing.Point(22, 93);
            this.lblSaveCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaveCategory.Name = "lblSaveCategory";
            this.lblSaveCategory.Size = new System.Drawing.Size(69, 16);
            this.lblSaveCategory.TabIndex = 1;
            this.lblSaveCategory.Text = "Kategori :";
            // 
            // lblSavePrice
            // 
            this.lblSavePrice.AutoSize = true;
            this.lblSavePrice.Location = new System.Drawing.Point(48, 138);
            this.lblSavePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSavePrice.Name = "lblSavePrice";
            this.lblSavePrice.Size = new System.Drawing.Size(46, 16);
            this.lblSavePrice.TabIndex = 2;
            this.lblSavePrice.Text = "Fiyat :";
            // 
            // lblSaveStock
            // 
            this.lblSaveStock.AutoSize = true;
            this.lblSaveStock.Location = new System.Drawing.Point(414, 50);
            this.lblSaveStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaveStock.Name = "lblSaveStock";
            this.lblSaveStock.Size = new System.Drawing.Size(77, 16);
            this.lblSaveStock.TabIndex = 3;
            this.lblSaveStock.Text = "Stok Adet :";
            // 
            // lblSaveQuantity
            // 
            this.lblSaveQuantity.AutoSize = true;
            this.lblSaveQuantity.Location = new System.Drawing.Point(414, 92);
            this.lblSaveQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaveQuantity.Name = "lblSaveQuantity";
            this.lblSaveQuantity.Size = new System.Drawing.Size(84, 16);
            this.lblSaveQuantity.TabIndex = 4;
            this.lblSaveQuantity.Text = "Birim Adet :";
            // 
            // txtSaveName
            // 
            this.txtSaveName.Location = new System.Drawing.Point(116, 47);
            this.txtSaveName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaveName.Name = "txtSaveName";
            this.txtSaveName.Size = new System.Drawing.Size(252, 27);
            this.txtSaveName.TabIndex = 5;
            // 
            // txtSavePrice
            // 
            this.txtSavePrice.Location = new System.Drawing.Point(116, 131);
            this.txtSavePrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSavePrice.Name = "txtSavePrice";
            this.txtSavePrice.Size = new System.Drawing.Size(140, 27);
            this.txtSavePrice.TabIndex = 6;
            // 
            // txtSaveStock
            // 
            this.txtSaveStock.Location = new System.Drawing.Point(514, 46);
            this.txtSaveStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaveStock.Name = "txtSaveStock";
            this.txtSaveStock.Size = new System.Drawing.Size(125, 27);
            this.txtSaveStock.TabIndex = 7;
            // 
            // txtSaveQuantity
            // 
            this.txtSaveQuantity.Location = new System.Drawing.Point(514, 92);
            this.txtSaveQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaveQuantity.Name = "txtSaveQuantity";
            this.txtSaveQuantity.Size = new System.Drawing.Size(146, 27);
            this.txtSaveQuantity.TabIndex = 8;
            // 
            // btnSaveSave
            // 
            this.btnSaveSave.BackColor = System.Drawing.Color.LightCyan;
            this.btnSaveSave.Location = new System.Drawing.Point(417, 138);
            this.btnSaveSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveSave.Name = "btnSaveSave";
            this.btnSaveSave.Size = new System.Drawing.Size(253, 42);
            this.btnSaveSave.TabIndex = 9;
            this.btnSaveSave.Text = "Kaydet ⭕";
            this.btnSaveSave.UseVisualStyleBackColor = false;
            this.btnSaveSave.Click += new System.EventHandler(this.btnSaveSave_Click);
            // 
            // btnSaveX
            // 
            this.btnSaveX.BackColor = System.Drawing.Color.LightCyan;
            this.btnSaveX.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveX.Location = new System.Drawing.Point(638, 14);
            this.btnSaveX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveX.Name = "btnSaveX";
            this.btnSaveX.Size = new System.Drawing.Size(32, 26);
            this.btnSaveX.TabIndex = 10;
            this.btnSaveX.Text = "🧹";
            this.btnSaveX.UseVisualStyleBackColor = false;
            this.btnSaveX.Click += new System.EventHandler(this.btnSaveX_Click);
            // 
            // cbxSaveCategory
            // 
            this.cbxSaveCategory.FormattingEnabled = true;
            this.cbxSaveCategory.Location = new System.Drawing.Point(116, 90);
            this.cbxSaveCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxSaveCategory.Name = "cbxSaveCategory";
            this.cbxSaveCategory.Size = new System.Drawing.Size(252, 24);
            this.cbxSaveCategory.TabIndex = 4;
            // 
            // btnNewSave
            // 
            this.btnNewSave.BackColor = System.Drawing.Color.LightCyan;
            this.btnNewSave.Location = new System.Drawing.Point(544, 488);
            this.btnNewSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(148, 32);
            this.btnNewSave.TabIndex = 11;
            this.btnNewSave.Text = "Yeni Kayıt Ekle ➕ ";
            this.btnNewSave.UseVisualStyleBackColor = false;
            this.btnNewSave.Click += new System.EventHandler(this.btnNewSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(473, 488);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Sil ✖️";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxUpdate.Controls.Add(this.cbxUpdateCategory);
            this.gbxUpdate.Controls.Add(this.btnUpdateX);
            this.gbxUpdate.Controls.Add(this.btnUpdateUpdate);
            this.gbxUpdate.Controls.Add(this.txtUpdateQuantity);
            this.gbxUpdate.Controls.Add(this.txtUpdateStock);
            this.gbxUpdate.Controls.Add(this.txtUpdatePrice);
            this.gbxUpdate.Controls.Add(this.txtUpdateName);
            this.gbxUpdate.Controls.Add(this.lblUpdateQuantity);
            this.gbxUpdate.Controls.Add(this.lblUpdateStock);
            this.gbxUpdate.Controls.Add(this.lblUpdatePrice);
            this.gbxUpdate.Controls.Add(this.lblUpdateCategory);
            this.gbxUpdate.Controls.Add(this.lblUpdateName);
            this.gbxUpdate.Location = new System.Drawing.Point(18, 527);
            this.gbxUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxUpdate.Size = new System.Drawing.Size(676, 197);
            this.gbxUpdate.TabIndex = 11;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Ürün Güncelleme Formu";
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(116, 90);
            this.cbxUpdateCategory.Margin = new System.Windows.Forms.Padding(6);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(252, 24);
            this.cbxUpdateCategory.TabIndex = 4;
            // 
            // btnUpdateX
            // 
            this.btnUpdateX.BackColor = System.Drawing.Color.LightYellow;
            this.btnUpdateX.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateX.Location = new System.Drawing.Point(638, 12);
            this.btnUpdateX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateX.Name = "btnUpdateX";
            this.btnUpdateX.Size = new System.Drawing.Size(32, 26);
            this.btnUpdateX.TabIndex = 10;
            this.btnUpdateX.Text = "🧹";
            this.btnUpdateX.UseVisualStyleBackColor = false;
            this.btnUpdateX.Click += new System.EventHandler(this.btnUpdateX_Click);
            // 
            // btnUpdateUpdate
            // 
            this.btnUpdateUpdate.BackColor = System.Drawing.Color.LightYellow;
            this.btnUpdateUpdate.Location = new System.Drawing.Point(417, 138);
            this.btnUpdateUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateUpdate.Name = "btnUpdateUpdate";
            this.btnUpdateUpdate.Size = new System.Drawing.Size(253, 42);
            this.btnUpdateUpdate.TabIndex = 9;
            this.btnUpdateUpdate.Text = "Güncelle 🔃 ";
            this.btnUpdateUpdate.UseVisualStyleBackColor = false;
            this.btnUpdateUpdate.Click += new System.EventHandler(this.btnUpdateUpdate_Click);
            // 
            // txtUpdateQuantity
            // 
            this.txtUpdateQuantity.Location = new System.Drawing.Point(514, 90);
            this.txtUpdateQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdateQuantity.Name = "txtUpdateQuantity";
            this.txtUpdateQuantity.Size = new System.Drawing.Size(146, 27);
            this.txtUpdateQuantity.TabIndex = 8;
            // 
            // txtUpdateStock
            // 
            this.txtUpdateStock.Location = new System.Drawing.Point(514, 44);
            this.txtUpdateStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdateStock.Name = "txtUpdateStock";
            this.txtUpdateStock.Size = new System.Drawing.Size(125, 27);
            this.txtUpdateStock.TabIndex = 7;
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(116, 131);
            this.txtUpdatePrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(140, 27);
            this.txtUpdatePrice.TabIndex = 6;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(116, 47);
            this.txtUpdateName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(252, 27);
            this.txtUpdateName.TabIndex = 5;
            // 
            // lblUpdateQuantity
            // 
            this.lblUpdateQuantity.AutoSize = true;
            this.lblUpdateQuantity.Location = new System.Drawing.Point(414, 90);
            this.lblUpdateQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateQuantity.Name = "lblUpdateQuantity";
            this.lblUpdateQuantity.Size = new System.Drawing.Size(84, 16);
            this.lblUpdateQuantity.TabIndex = 4;
            this.lblUpdateQuantity.Text = "Birim Adet :";
            // 
            // lblUpdateStock
            // 
            this.lblUpdateStock.AutoSize = true;
            this.lblUpdateStock.Location = new System.Drawing.Point(414, 48);
            this.lblUpdateStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateStock.Name = "lblUpdateStock";
            this.lblUpdateStock.Size = new System.Drawing.Size(77, 16);
            this.lblUpdateStock.TabIndex = 3;
            this.lblUpdateStock.Text = "Stok Adet :";
            // 
            // lblUpdatePrice
            // 
            this.lblUpdatePrice.AutoSize = true;
            this.lblUpdatePrice.Location = new System.Drawing.Point(48, 138);
            this.lblUpdatePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdatePrice.Name = "lblUpdatePrice";
            this.lblUpdatePrice.Size = new System.Drawing.Size(46, 16);
            this.lblUpdatePrice.TabIndex = 2;
            this.lblUpdatePrice.Text = "Fiyat :";
            // 
            // lblUpdateCategory
            // 
            this.lblUpdateCategory.AutoSize = true;
            this.lblUpdateCategory.Location = new System.Drawing.Point(22, 93);
            this.lblUpdateCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateCategory.Name = "lblUpdateCategory";
            this.lblUpdateCategory.Size = new System.Drawing.Size(69, 16);
            this.lblUpdateCategory.TabIndex = 1;
            this.lblUpdateCategory.Text = "Kategori :";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(19, 47);
            this.lblUpdateName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(73, 16);
            this.lblUpdateName.TabIndex = 0;
            this.lblUpdateName.Text = "Ürün Adı :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(703, 746);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewSave);
            this.Controls.Add(this.gbxSave);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.dgwProducts);
            this.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Ürün Yöneticisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxSave.ResumeLayout(false);
            this.gbxSave.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbxSave;
        private System.Windows.Forms.TextBox txtSaveQuantity;
        private System.Windows.Forms.TextBox txtSaveStock;
        private System.Windows.Forms.TextBox txtSavePrice;
        private System.Windows.Forms.TextBox txtSaveName;
        private System.Windows.Forms.Label lblSaveQuantity;
        private System.Windows.Forms.Label lblSaveStock;
        private System.Windows.Forms.Label lblSavePrice;
        private System.Windows.Forms.Label lblSaveCategory;
        private System.Windows.Forms.Label lblSaveName;
        private System.Windows.Forms.Button btnSaveSave;
        private System.Windows.Forms.Button btnSaveX;
        private System.Windows.Forms.ComboBox cbxSaveCategory;
        private System.Windows.Forms.Button btnNewSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.ComboBox cbxUpdateCategory;
        private System.Windows.Forms.Button btnUpdateX;
        private System.Windows.Forms.Button btnUpdateUpdate;
        private System.Windows.Forms.TextBox txtUpdateQuantity;
        private System.Windows.Forms.TextBox txtUpdateStock;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label lblUpdateQuantity;
        private System.Windows.Forms.Label lblUpdateStock;
        private System.Windows.Forms.Label lblUpdatePrice;
        private System.Windows.Forms.Label lblUpdateCategory;
        private System.Windows.Forms.Label lblUpdateName;
    }
}

