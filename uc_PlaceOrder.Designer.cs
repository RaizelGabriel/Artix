
namespace Artix
{
    partial class uc_PlaceOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_PlaceOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAddtoCart = new Sipaa.Framework.SButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemove = new Sipaa.Framework.SButton();
            this.btnPrint = new Sipaa.Framework.SButton();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Refresh = new Sipaa.Framework.SButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Coffee",
            "Hot Drinks",
            "South Indian",
            "Thai",
            "Pastry",
            "Beverages"});
            this.comboCategory.Location = new System.Drawing.Point(27, 110);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(143, 23);
            this.comboCategory.TabIndex = 2;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(267, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(267, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(502, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(500, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total";
            // 
            // txtQuantityUpDown
            // 
            this.txtQuantityUpDown.Location = new System.Drawing.Point(267, 111);
            this.txtQuantityUpDown.Name = "txtQuantityUpDown";
            this.txtQuantityUpDown.Size = new System.Drawing.Size(200, 23);
            this.txtQuantityUpDown.TabIndex = 9;
            this.txtQuantityUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantityUpDown.ValueChanged += new System.EventHandler(this.txtQuantityUpDown_ValueChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(267, 56);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(200, 23);
            this.txtItemName.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(500, 56);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 23);
            this.txtPrice.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(500, 110);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(200, 23);
            this.txtTotal.TabIndex = 12;
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAddtoCart.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddtoCart.BorderRadius = 20;
            this.btnAddtoCart.BorderSize = 0;
            this.btnAddtoCart.FlatAppearance.BorderSize = 0;
            this.btnAddtoCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddtoCart.ForeColor = System.Drawing.Color.White;
            this.btnAddtoCart.Location = new System.Drawing.Point(523, 148);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(177, 40);
            this.btnAddtoCart.TabIndex = 13;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = false;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(226, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(483, 165);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRemove.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRemove.BorderRadius = 20;
            this.btnRemove.BorderSize = 0;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(226, 436);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(158, 40);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnPrint.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.BorderRadius = 20;
            this.btnPrint.BorderSize = 0;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(551, 436);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(158, 40);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(262, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.BackColor = System.Drawing.Color.Sienna;
            this.labelTotalAmount.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTotalAmount.Location = new System.Drawing.Point(293, 176);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(91, 29);
            this.labelTotalAmount.TabIndex = 18;
            this.labelTotalAmount.Text = "Php: 00";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(27, 139);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 22);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(27, 176);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 276);
            this.listBox1.TabIndex = 20;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.BorderRadius = 6;
            this.btn_Refresh.BorderSize = 0;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(441, 430);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(53, 46);
            this.btn_Refresh.TabIndex = 21;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // uc_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtQuantityUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_PlaceOrder";
            this.Size = new System.Drawing.Size(777, 510);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtQuantityUpDown;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotal;
        private Sipaa.Framework.SButton btnAddtoCart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Sipaa.Framework.SButton btnRemove;
        private Sipaa.Framework.SButton btnPrint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listBox1;
        private Sipaa.Framework.SButton btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
