namespace Restaurant_Management_System
{
    partial class inventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inventory_clearBtn = new System.Windows.Forms.Button();
            this.inventory_deleteBtn = new System.Windows.Forms.Button();
            this.inventory_updateBtn = new System.Windows.Forms.Button();
            this.inventory_addBtn = new System.Windows.Forms.Button();
            this.inventory_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inventory_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inventory_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inventory_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inventory_category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inventory_productName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inventory_productID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(18, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 388);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(864, 348);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "All Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.inventory_clearBtn);
            this.panel2.Controls.Add(this.inventory_deleteBtn);
            this.panel2.Controls.Add(this.inventory_updateBtn);
            this.panel2.Controls.Add(this.inventory_addBtn);
            this.panel2.Controls.Add(this.inventory_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.inventory_status);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.inventory_price);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.inventory_stock);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.inventory_category);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.inventory_productName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.inventory_productID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(18, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 206);
            this.panel2.TabIndex = 1;
            // 
            // inventory_clearBtn
            // 
            this.inventory_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.inventory_clearBtn.FlatAppearance.BorderSize = 0;
            this.inventory_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.inventory_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.inventory_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_clearBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inventory_clearBtn.Location = new System.Drawing.Point(517, 150);
            this.inventory_clearBtn.Name = "inventory_clearBtn";
            this.inventory_clearBtn.Size = new System.Drawing.Size(111, 33);
            this.inventory_clearBtn.TabIndex = 17;
            this.inventory_clearBtn.Text = "CLEAR";
            this.inventory_clearBtn.UseVisualStyleBackColor = false;
            this.inventory_clearBtn.Click += new System.EventHandler(this.inventory_clearBtn_Click);
            // 
            // inventory_deleteBtn
            // 
            this.inventory_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.inventory_deleteBtn.FlatAppearance.BorderSize = 0;
            this.inventory_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.inventory_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.inventory_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_deleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inventory_deleteBtn.Location = new System.Drawing.Point(366, 150);
            this.inventory_deleteBtn.Name = "inventory_deleteBtn";
            this.inventory_deleteBtn.Size = new System.Drawing.Size(111, 33);
            this.inventory_deleteBtn.TabIndex = 16;
            this.inventory_deleteBtn.Text = "DELETE";
            this.inventory_deleteBtn.UseVisualStyleBackColor = false;
            this.inventory_deleteBtn.Click += new System.EventHandler(this.inventory_deleteBtn_Click);
            // 
            // inventory_updateBtn
            // 
            this.inventory_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.inventory_updateBtn.FlatAppearance.BorderSize = 0;
            this.inventory_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.inventory_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.inventory_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_updateBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inventory_updateBtn.Location = new System.Drawing.Point(201, 150);
            this.inventory_updateBtn.Name = "inventory_updateBtn";
            this.inventory_updateBtn.Size = new System.Drawing.Size(111, 33);
            this.inventory_updateBtn.TabIndex = 15;
            this.inventory_updateBtn.Text = "UPDATE";
            this.inventory_updateBtn.UseVisualStyleBackColor = false;
            this.inventory_updateBtn.Click += new System.EventHandler(this.inventory_updateBtn_Click);
            // 
            // inventory_addBtn
            // 
            this.inventory_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.inventory_addBtn.FlatAppearance.BorderSize = 0;
            this.inventory_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.inventory_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.inventory_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_addBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inventory_addBtn.Location = new System.Drawing.Point(50, 150);
            this.inventory_addBtn.Name = "inventory_addBtn";
            this.inventory_addBtn.Size = new System.Drawing.Size(111, 33);
            this.inventory_addBtn.TabIndex = 14;
            this.inventory_addBtn.Text = "ADD";
            this.inventory_addBtn.UseVisualStyleBackColor = false;
            this.inventory_addBtn.Click += new System.EventHandler(this.inventory_addBtn_Click);
            // 
            // inventory_importBtn
            // 
            this.inventory_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.inventory_importBtn.FlatAppearance.BorderSize = 0;
            this.inventory_importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.inventory_importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(78)))), ((int)(((byte)(62)))));
            this.inventory_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_importBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_importBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inventory_importBtn.Location = new System.Drawing.Point(750, 134);
            this.inventory_importBtn.Name = "inventory_importBtn";
            this.inventory_importBtn.Size = new System.Drawing.Size(111, 33);
            this.inventory_importBtn.TabIndex = 13;
            this.inventory_importBtn.Text = "IMPORT";
            this.inventory_importBtn.UseVisualStyleBackColor = false;
            this.inventory_importBtn.Click += new System.EventHandler(this.inventory_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(750, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 112);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // inventory_status
            // 
            this.inventory_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_status.FormattingEnabled = true;
            this.inventory_status.Items.AddRange(new object[] {
            "Active",
            "Not  Active"});
            this.inventory_status.Location = new System.Drawing.Point(418, 101);
            this.inventory_status.Name = "inventory_status";
            this.inventory_status.Size = new System.Drawing.Size(169, 26);
            this.inventory_status.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category: ";
            // 
            // inventory_price
            // 
            this.inventory_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_price.Location = new System.Drawing.Point(418, 58);
            this.inventory_price.Name = "inventory_price";
            this.inventory_price.Size = new System.Drawing.Size(169, 24);
            this.inventory_price.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price ($):";
            // 
            // inventory_stock
            // 
            this.inventory_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_stock.Location = new System.Drawing.Point(418, 15);
            this.inventory_stock.Name = "inventory_stock";
            this.inventory_stock.Size = new System.Drawing.Size(169, 24);
            this.inventory_stock.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stock:";
            // 
            // inventory_category
            // 
            this.inventory_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_category.FormattingEnabled = true;
            this.inventory_category.Location = new System.Drawing.Point(126, 101);
            this.inventory_category.Name = "inventory_category";
            this.inventory_category.Size = new System.Drawing.Size(169, 26);
            this.inventory_category.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status: ";
            // 
            // inventory_productName
            // 
            this.inventory_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_productName.Location = new System.Drawing.Point(126, 58);
            this.inventory_productName.Name = "inventory_productName";
            this.inventory_productName.Size = new System.Drawing.Size(169, 24);
            this.inventory_productName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name:";
            // 
            // inventory_productID
            // 
            this.inventory_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_productID.Location = new System.Drawing.Point(126, 15);
            this.inventory_productID.Name = "inventory_productID";
            this.inventory_productID.Size = new System.Drawing.Size(169, 24);
            this.inventory_productID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID:";
            // 
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "inventoryForm";
            this.Size = new System.Drawing.Size(934, 631);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inventory_productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inventory_productID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inventory_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inventory_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inventory_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox inventory_category;
        private System.Windows.Forms.Button inventory_importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button inventory_clearBtn;
        private System.Windows.Forms.Button inventory_deleteBtn;
        private System.Windows.Forms.Button inventory_updateBtn;
        private System.Windows.Forms.Button inventory_addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
