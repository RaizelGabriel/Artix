
namespace Artix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new CustomControls.RJControls.RJButton();
            this.btnRemove = new CustomControls.RJControls.RJButton();
            this.btnAddItems = new CustomControls.RJControls.RJButton();
            this.btnPlaceOrder = new CustomControls.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uc_RemoveItems1 = new Artix.uc_RemoveItems();
            this.uc_UpdateItems1 = new Artix.uc_UpdateItems();
            this.uc_PlaceOrder1 = new Artix.uc_PlaceOrder();
            this.ucAddItems1 = new Artix.ucAddItems();
            this.Time = new System.Windows.Forms.Label();
            this.labelBanner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMin.Location = new System.Drawing.Point(40, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(34, 29);
            this.btnMin.TabIndex = 7;
            this.btnMin.Text = "--";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.LinkColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(64, 458);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(65, 23);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.TabStop = true;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogOut_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(13, 141);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 41);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Items";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemove.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btnRemove.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemove.BorderRadius = 15;
            this.btnRemove.BorderSize = 0;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(13, 188);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(202, 41);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Items";
            this.btnRemove.TextColor = System.Drawing.Color.White;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddItems.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btnAddItems.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddItems.BorderRadius = 15;
            this.btnAddItems.BorderSize = 0;
            this.btnAddItems.FlatAppearance.BorderSize = 0;
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItems.Image")));
            this.btnAddItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItems.Location = new System.Drawing.Point(13, 94);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(202, 41);
            this.btnAddItems.TabIndex = 3;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.TextColor = System.Drawing.Color.White;
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPlaceOrder.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btnPlaceOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlaceOrder.BorderRadius = 15;
            this.btnPlaceOrder.BorderSize = 0;
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaceOrder.Image")));
            this.btnPlaceOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaceOrder.Location = new System.Drawing.Point(13, 47);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(202, 41);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.TextColor = System.Drawing.Color.White;
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.uc_RemoveItems1);
            this.panel2.Controls.Add(this.uc_UpdateItems1);
            this.panel2.Controls.Add(this.uc_PlaceOrder1);
            this.panel2.Controls.Add(this.ucAddItems1);
            this.panel2.Controls.Add(this.Time);
            this.panel2.Controls.Add(this.labelBanner);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(211, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 1;
            // 
            // uc_RemoveItems1
            // 
            this.uc_RemoveItems1.BackColor = System.Drawing.Color.Sienna;
            this.uc_RemoveItems1.Location = new System.Drawing.Point(-2, -2);
            this.uc_RemoveItems1.Name = "uc_RemoveItems1";
            this.uc_RemoveItems1.Size = new System.Drawing.Size(781, 514);
            this.uc_RemoveItems1.TabIndex = 5;
            // 
            // uc_UpdateItems1
            // 
            this.uc_UpdateItems1.BackColor = System.Drawing.Color.White;
            this.uc_UpdateItems1.Location = new System.Drawing.Point(-2, -1);
            this.uc_UpdateItems1.Name = "uc_UpdateItems1";
            this.uc_UpdateItems1.Size = new System.Drawing.Size(781, 514);
            this.uc_UpdateItems1.TabIndex = 2;
            // 
            // uc_PlaceOrder1
            // 
            this.uc_PlaceOrder1.BackColor = System.Drawing.Color.White;
            this.uc_PlaceOrder1.Location = new System.Drawing.Point(-2, -1);
            this.uc_PlaceOrder1.Name = "uc_PlaceOrder1";
            this.uc_PlaceOrder1.Size = new System.Drawing.Size(781, 510);
            this.uc_PlaceOrder1.TabIndex = 2;
            // 
            // ucAddItems1
            // 
            this.ucAddItems1.BackColor = System.Drawing.Color.Moccasin;
            this.ucAddItems1.Location = new System.Drawing.Point(-2, -2);
            this.ucAddItems1.Name = "ucAddItems1";
            this.ucAddItems1.Size = new System.Drawing.Size(781, 510);
            this.ucAddItems1.TabIndex = 4;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Time.Location = new System.Drawing.Point(195, 13);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(242, 35);
            this.Time.TabIndex = 3;
            this.Time.Text = "Local Clock";
            // 
            // labelBanner
            // 
            this.labelBanner.AutoSize = true;
            this.labelBanner.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBanner.Location = new System.Drawing.Point(299, 346);
            this.labelBanner.Name = "labelBanner";
            this.labelBanner.Size = new System.Drawing.Size(196, 44);
            this.labelBanner.TabIndex = 2;
            this.labelBanner.Text = "Artix Cafe";
            this.labelBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(374, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(306, 393);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private CustomControls.RJControls.RJButton btnUpdate;
        private CustomControls.RJControls.RJButton btnRemove;
        private CustomControls.RJControls.RJButton btnAddItems;
        private CustomControls.RJControls.RJButton btnPlaceOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBanner;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button btnMin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ucAddItems ucAddItems1;
        private uc_PlaceOrder uc_PlaceOrder1;
        private uc_UpdateItems uc_UpdateItems1;
        private uc_RemoveItems uc_RemoveItems1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}