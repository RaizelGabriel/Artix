
namespace Artix
{
    partial class ucAddItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddItems));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new CustomControls.RJControls.RJButton();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(362, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 603);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Item name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add New Item";
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCategory.ForeColor = System.Drawing.Color.White;
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Items.AddRange(new object[] {
            "Coffee",
            "Hot Drinks",
            "South Indian",
            "Thai",
            "Pastry",
            "Beverages"});
            this.txtCategory.Location = new System.Drawing.Point(39, 106);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(306, 23);
            this.txtCategory.TabIndex = 22;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Peru;
            this.btnAddItem.BackgroundColor = System.Drawing.Color.Peru;
            this.btnAddItem.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddItem.BorderRadius = 23;
            this.btnAddItem.BorderSize = 0;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(104, 338);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(150, 40);
            this.btnAddItem.TabIndex = 23;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.TextColor = System.Drawing.Color.White;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(39, 196);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(306, 25);
            this.txtItemName.TabIndex = 24;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(39, 283);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(306, 25);
            this.txtPrice.TabIndex = 25;
            // 
            // ucAddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucAddItems";
            this.Size = new System.Drawing.Size(777, 510);
            this.Leave += new System.EventHandler(this.ucAddItems_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox txtCategory;
        private CustomControls.RJControls.RJButton btnAddItem;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtPrice;
    }
}
