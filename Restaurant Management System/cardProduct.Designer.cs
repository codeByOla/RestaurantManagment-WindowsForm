﻿namespace Restaurant_Management_System
{
    partial class cardProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.productname = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 168);
            this.panel1.TabIndex = 0;
            // 
            // productname
            // 
            this.productname.AutoSize = true;
            this.productname.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.Location = new System.Drawing.Point(3, 171);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(95, 16);
            this.productname.TabIndex = 1;
            this.productname.Text = "Product Name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(3, 187);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(34, 16);
            this.price.TabIndex = 2;
            this.price.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock:";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.Location = new System.Drawing.Point(38, 203);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(13, 16);
            this.stock.TabIndex = 4;
            this.stock.Text = "0";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(43, 215);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(80, 20);
            this.quantity.TabIndex = 5;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(56)))), ((int)(((byte)(75)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(132, 215);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(60, 20);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "QTY:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cardProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.panel1);
            this.Name = "cardProduct";
            this.Size = new System.Drawing.Size(195, 240);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label productname;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label5;
    }
}
