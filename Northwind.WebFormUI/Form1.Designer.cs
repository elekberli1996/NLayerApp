
namespace Northwind.WebFormUI
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
            this.gbxUrun = new System.Windows.Forms.GroupBox();
            this.tbxUrun = new System.Windows.Forms.TextBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.gbxKatagory = new System.Windows.Forms.GroupBox();
            this.cbxKatagory = new System.Windows.Forms.ComboBox();
            this.lblKatagory = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName2 = new System.Windows.Forms.TextBox();
            this.cbxKatagoryAdd = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCatagoryId = new System.Windows.Forms.Label();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntUpdate = new System.Windows.Forms.Button();
            this.tbxUpdatePerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateStock = new System.Windows.Forms.TextBox();
            this.tbxUpdatePrice = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.cbxUpdateKatagory = new System.Windows.Forms.ComboBox();
            this.lblUpdatePerunit = new System.Windows.Forms.Label();
            this.lblStockUpdate = new System.Windows.Forms.Label();
            this.lblUpdateunitPrice = new System.Windows.Forms.Label();
            this.lblUpdateKatagory = new System.Windows.Forms.Label();
            this.lblUpdateurun = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUrun.SuspendLayout();
            this.gbxKatagory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUrun
            // 
            this.gbxUrun.Controls.Add(this.tbxUrun);
            this.gbxUrun.Controls.Add(this.lblUrun);
            this.gbxUrun.Location = new System.Drawing.Point(23, 272);
            this.gbxUrun.Name = "gbxUrun";
            this.gbxUrun.Size = new System.Drawing.Size(260, 63);
            this.gbxUrun.TabIndex = 5;
            this.gbxUrun.TabStop = false;
            this.gbxUrun.Text = "Urun ismine gore ara";
            // 
            // tbxUrun
            // 
            this.tbxUrun.Location = new System.Drawing.Point(83, 27);
            this.tbxUrun.Name = "tbxUrun";
            this.tbxUrun.Size = new System.Drawing.Size(121, 20);
            this.tbxUrun.TabIndex = 3;
            this.tbxUrun.TextChanged += new System.EventHandler(this.tbxUrun_TextChanged);
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(19, 34);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(50, 13);
            this.lblUrun.TabIndex = 3;
            this.lblUrun.Text = "Urun ismi";
            // 
            // gbxKatagory
            // 
            this.gbxKatagory.Controls.Add(this.cbxKatagory);
            this.gbxKatagory.Controls.Add(this.lblKatagory);
            this.gbxKatagory.Location = new System.Drawing.Point(23, 178);
            this.gbxKatagory.Name = "gbxKatagory";
            this.gbxKatagory.Size = new System.Drawing.Size(260, 64);
            this.gbxKatagory.TabIndex = 4;
            this.gbxKatagory.TabStop = false;
            this.gbxKatagory.Text = "Katagorye gore ara";
            // 
            // cbxKatagory
            // 
            this.cbxKatagory.FormattingEnabled = true;
            this.cbxKatagory.Location = new System.Drawing.Point(83, 26);
            this.cbxKatagory.Name = "cbxKatagory";
            this.cbxKatagory.Size = new System.Drawing.Size(121, 21);
            this.cbxKatagory.TabIndex = 3;
            this.cbxKatagory.SelectedIndexChanged += new System.EventHandler(this.cbxKatagory_SelectedIndexChanged);
            // 
            // lblKatagory
            // 
            this.lblKatagory.AutoSize = true;
            this.lblKatagory.Location = new System.Drawing.Point(19, 29);
            this.lblKatagory.Name = "lblKatagory";
            this.lblKatagory.Size = new System.Drawing.Size(49, 13);
            this.lblKatagory.TabIndex = 3;
            this.lblKatagory.Text = "Katagory";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(23, 22);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(509, 150);
            this.dgvProduct.TabIndex = 3;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbxQuantity);
            this.groupBox1.Controls.Add(this.tbxStockAmount);
            this.groupBox1.Controls.Add(this.tbxPrice);
            this.groupBox1.Controls.Add(this.tbxProductName2);
            this.groupBox1.Controls.Add(this.cbxKatagoryAdd);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblStockAmount);
            this.groupBox1.Controls.Add(this.lblUnitPrice);
            this.groupBox1.Controls.Add(this.lblCatagoryId);
            this.groupBox1.Controls.Add(this.lblProductNameAdd);
            this.groupBox1.Location = new System.Drawing.Point(565, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 234);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Urun Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(81, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(81, 158);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(121, 20);
            this.tbxQuantity.TabIndex = 9;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(81, 128);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(121, 20);
            this.tbxStockAmount.TabIndex = 8;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(81, 93);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(121, 20);
            this.tbxPrice.TabIndex = 7;
            this.tbxPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxProductName2
            // 
            this.tbxProductName2.Location = new System.Drawing.Point(81, 32);
            this.tbxProductName2.Name = "tbxProductName2";
            this.tbxProductName2.Size = new System.Drawing.Size(121, 20);
            this.tbxProductName2.TabIndex = 6;
            // 
            // cbxKatagoryAdd
            // 
            this.cbxKatagoryAdd.FormattingEnabled = true;
            this.cbxKatagoryAdd.Location = new System.Drawing.Point(81, 59);
            this.cbxKatagoryAdd.Name = "cbxKatagoryAdd";
            this.cbxKatagoryAdd.Size = new System.Drawing.Size(121, 21);
            this.cbxKatagoryAdd.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(16, 165);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(57, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "birim adedi";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(16, 131);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(62, 13);
            this.lblStockAmount.TabIndex = 3;
            this.lblStockAmount.Text = "Stok adedo";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(16, 96);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(54, 13);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Urun fiyati";
            // 
            // lblCatagoryId
            // 
            this.lblCatagoryId.AutoSize = true;
            this.lblCatagoryId.Location = new System.Drawing.Point(16, 62);
            this.lblCatagoryId.Name = "lblCatagoryId";
            this.lblCatagoryId.Size = new System.Drawing.Size(48, 13);
            this.lblCatagoryId.TabIndex = 1;
            this.lblCatagoryId.Text = "katagory";
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(16, 35);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(47, 13);
            this.lblProductNameAdd.TabIndex = 0;
            this.lblProductNameAdd.Text = "Urun adi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntUpdate);
            this.groupBox2.Controls.Add(this.tbxUpdatePerUnit);
            this.groupBox2.Controls.Add(this.tbxUpdateStock);
            this.groupBox2.Controls.Add(this.tbxUpdatePrice);
            this.groupBox2.Controls.Add(this.tbxProductNameUpdate);
            this.groupBox2.Controls.Add(this.cbxUpdateKatagory);
            this.groupBox2.Controls.Add(this.lblUpdatePerunit);
            this.groupBox2.Controls.Add(this.lblStockUpdate);
            this.groupBox2.Controls.Add(this.lblUpdateunitPrice);
            this.groupBox2.Controls.Add(this.lblUpdateKatagory);
            this.groupBox2.Controls.Add(this.lblUpdateurun);
            this.groupBox2.Location = new System.Drawing.Point(559, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 234);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "utun guncelle";
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(81, 205);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(75, 23);
            this.bntUpdate.TabIndex = 10;
            this.bntUpdate.Text = "update";
            this.bntUpdate.UseVisualStyleBackColor = true;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // tbxUpdatePerUnit
            // 
            this.tbxUpdatePerUnit.Location = new System.Drawing.Point(81, 158);
            this.tbxUpdatePerUnit.Name = "tbxUpdatePerUnit";
            this.tbxUpdatePerUnit.Size = new System.Drawing.Size(121, 20);
            this.tbxUpdatePerUnit.TabIndex = 9;
            // 
            // tbxUpdateStock
            // 
            this.tbxUpdateStock.Location = new System.Drawing.Point(81, 128);
            this.tbxUpdateStock.Name = "tbxUpdateStock";
            this.tbxUpdateStock.Size = new System.Drawing.Size(121, 20);
            this.tbxUpdateStock.TabIndex = 8;
            // 
            // tbxUpdatePrice
            // 
            this.tbxUpdatePrice.Location = new System.Drawing.Point(81, 93);
            this.tbxUpdatePrice.Name = "tbxUpdatePrice";
            this.tbxUpdatePrice.Size = new System.Drawing.Size(121, 20);
            this.tbxUpdatePrice.TabIndex = 7;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(81, 32);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(121, 20);
            this.tbxProductNameUpdate.TabIndex = 6;
            // 
            // cbxUpdateKatagory
            // 
            this.cbxUpdateKatagory.FormattingEnabled = true;
            this.cbxUpdateKatagory.Location = new System.Drawing.Point(81, 59);
            this.cbxUpdateKatagory.Name = "cbxUpdateKatagory";
            this.cbxUpdateKatagory.Size = new System.Drawing.Size(121, 21);
            this.cbxUpdateKatagory.TabIndex = 5;
            // 
            // lblUpdatePerunit
            // 
            this.lblUpdatePerunit.AutoSize = true;
            this.lblUpdatePerunit.Location = new System.Drawing.Point(16, 165);
            this.lblUpdatePerunit.Name = "lblUpdatePerunit";
            this.lblUpdatePerunit.Size = new System.Drawing.Size(57, 13);
            this.lblUpdatePerunit.TabIndex = 4;
            this.lblUpdatePerunit.Text = "birim adedi";
            // 
            // lblStockUpdate
            // 
            this.lblStockUpdate.AutoSize = true;
            this.lblStockUpdate.Location = new System.Drawing.Point(16, 131);
            this.lblStockUpdate.Name = "lblStockUpdate";
            this.lblStockUpdate.Size = new System.Drawing.Size(62, 13);
            this.lblStockUpdate.TabIndex = 3;
            this.lblStockUpdate.Text = "Stok adedo";
            // 
            // lblUpdateunitPrice
            // 
            this.lblUpdateunitPrice.AutoSize = true;
            this.lblUpdateunitPrice.Location = new System.Drawing.Point(16, 96);
            this.lblUpdateunitPrice.Name = "lblUpdateunitPrice";
            this.lblUpdateunitPrice.Size = new System.Drawing.Size(54, 13);
            this.lblUpdateunitPrice.TabIndex = 2;
            this.lblUpdateunitPrice.Text = "Urun fiyati";
            // 
            // lblUpdateKatagory
            // 
            this.lblUpdateKatagory.AutoSize = true;
            this.lblUpdateKatagory.Location = new System.Drawing.Point(16, 62);
            this.lblUpdateKatagory.Name = "lblUpdateKatagory";
            this.lblUpdateKatagory.Size = new System.Drawing.Size(48, 13);
            this.lblUpdateKatagory.TabIndex = 1;
            this.lblUpdateKatagory.Text = "katagory";
            // 
            // lblUpdateurun
            // 
            this.lblUpdateurun.AutoSize = true;
            this.lblUpdateurun.Location = new System.Drawing.Point(16, 35);
            this.lblUpdateurun.Name = "lblUpdateurun";
            this.lblUpdateurun.Size = new System.Drawing.Size(47, 13);
            this.lblUpdateurun.TabIndex = 0;
            this.lblUpdateurun.Text = "Urun adi";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(346, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxUrun);
            this.Controls.Add(this.gbxKatagory);
            this.Controls.Add(this.dgvProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUrun.ResumeLayout(false);
            this.gbxUrun.PerformLayout();
            this.gbxKatagory.ResumeLayout(false);
            this.gbxKatagory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUrun;
        private System.Windows.Forms.TextBox tbxUrun;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.GroupBox gbxKatagory;
        private System.Windows.Forms.ComboBox cbxKatagory;
        private System.Windows.Forms.Label lblKatagory;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxProductName2;
        private System.Windows.Forms.ComboBox cbxKatagoryAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCatagoryId;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.TextBox tbxUpdatePerUnit;
        private System.Windows.Forms.TextBox tbxUpdateStock;
        private System.Windows.Forms.TextBox tbxUpdatePrice;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.ComboBox cbxUpdateKatagory;
        private System.Windows.Forms.Label lblUpdatePerunit;
        private System.Windows.Forms.Label lblStockUpdate;
        private System.Windows.Forms.Label lblUpdateunitPrice;
        private System.Windows.Forms.Label lblUpdateKatagory;
        private System.Windows.Forms.Label lblUpdateurun;
        private System.Windows.Forms.Button btnDelete;
    }
}

