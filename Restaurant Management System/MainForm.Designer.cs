namespace Restaurant_Management_System
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.customers_btn = new System.Windows.Forms.Button();
            this.Categories_btn = new System.Windows.Forms.Button();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.shop_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customersForm1 = new Restaurant_Management_System.customersForm();
            this.categoriesForm1 = new Restaurant_Management_System.categoriesForm();
            this.inventoryForm1 = new Restaurant_Management_System.inventoryForm();
            this.shopForm1 = new Restaurant_Management_System.shopForm();
            this.dashboardForm1 = new Restaurant_Management_System.dashboardForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 35);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Restaurant Managment System";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.IndianRed;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.close.Location = new System.Drawing.Point(1165, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(45, 29);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.customers_btn);
            this.panel2.Controls.Add(this.Categories_btn);
            this.panel2.Controls.Add(this.inventory_btn);
            this.panel2.Controls.Add(this.shop_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 631);
            this.panel2.TabIndex = 2;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logout_btn.Location = new System.Drawing.Point(31, 582);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(221, 37);
            this.logout_btn.TabIndex = 7;
            this.logout_btn.Text = "LogOut";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // customers_btn
            // 
            this.customers_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.customers_btn.FlatAppearance.BorderSize = 0;
            this.customers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.customers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.customers_btn.Location = new System.Drawing.Point(12, 454);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(267, 37);
            this.customers_btn.TabIndex = 6;
            this.customers_btn.Text = "Customers";
            this.customers_btn.UseVisualStyleBackColor = false;
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click);
            // 
            // Categories_btn
            // 
            this.Categories_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.Categories_btn.FlatAppearance.BorderSize = 0;
            this.Categories_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.Categories_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.Categories_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categories_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Categories_btn.Location = new System.Drawing.Point(12, 396);
            this.Categories_btn.Name = "Categories_btn";
            this.Categories_btn.Size = new System.Drawing.Size(267, 37);
            this.Categories_btn.TabIndex = 5;
            this.Categories_btn.Text = "Categories";
            this.Categories_btn.UseVisualStyleBackColor = false;
            this.Categories_btn.Click += new System.EventHandler(this.Categories_btn_Click);
            // 
            // inventory_btn
            // 
            this.inventory_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.inventory_btn.FlatAppearance.BorderSize = 0;
            this.inventory_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.inventory_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inventory_btn.Location = new System.Drawing.Point(12, 341);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(267, 37);
            this.inventory_btn.TabIndex = 4;
            this.inventory_btn.Text = "Inventory";
            this.inventory_btn.UseVisualStyleBackColor = false;
            this.inventory_btn.Click += new System.EventHandler(this.inventory_btn_Click);
            // 
            // shop_btn
            // 
            this.shop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.shop_btn.FlatAppearance.BorderSize = 0;
            this.shop_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.shop_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.shop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shop_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.shop_btn.Location = new System.Drawing.Point(12, 287);
            this.shop_btn.Name = "shop_btn";
            this.shop_btn.Size = new System.Drawing.Size(267, 37);
            this.shop_btn.TabIndex = 3;
            this.shop_btn.Text = "Shop";
            this.shop_btn.UseVisualStyleBackColor = false;
            this.shop_btn.Click += new System.EventHandler(this.shop_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 233);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(267, 37);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(70, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Admin!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Management_System.Properties.Resources.Profile_pic;
            this.pictureBox1.Location = new System.Drawing.Point(43, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 192);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customersForm1);
            this.panel3.Controls.Add(this.categoriesForm1);
            this.panel3.Controls.Add(this.inventoryForm1);
            this.panel3.Controls.Add(this.shopForm1);
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(288, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 631);
            this.panel3.TabIndex = 3;
            // 
            // customersForm1
            // 
            this.customersForm1.Location = new System.Drawing.Point(0, 0);
            this.customersForm1.Name = "customersForm1";
            this.customersForm1.Size = new System.Drawing.Size(934, 631);
            this.customersForm1.TabIndex = 4;
            // 
            // categoriesForm1
            // 
            this.categoriesForm1.Location = new System.Drawing.Point(-3, 0);
            this.categoriesForm1.Name = "categoriesForm1";
            this.categoriesForm1.Size = new System.Drawing.Size(934, 631);
            this.categoriesForm1.TabIndex = 3;
            // 
            // inventoryForm1
            // 
            this.inventoryForm1.Location = new System.Drawing.Point(-3, 0);
            this.inventoryForm1.Name = "inventoryForm1";
            this.inventoryForm1.Size = new System.Drawing.Size(934, 631);
            this.inventoryForm1.TabIndex = 2;
            // 
            // shopForm1
            // 
            this.shopForm1.Location = new System.Drawing.Point(0, 0);
            this.shopForm1.Name = "shopForm1";
            this.shopForm1.Size = new System.Drawing.Size(934, 631);
            this.shopForm1.TabIndex = 1;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(-3, 0);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(934, 631);
            this.dashboardForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 666);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button Categories_btn;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.Button shop_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button customers_btn;
        private System.Windows.Forms.Panel panel3;
        private dashboardForm dashboardForm1;
        private shopForm shopForm1;
        private inventoryForm inventoryForm1;
        private categoriesForm categoriesForm1;
        private customersForm customersForm1;
    }
}