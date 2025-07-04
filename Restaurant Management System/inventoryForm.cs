﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Restaurant_Management_System
{

    public partial class inventoryForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\source\repos\Restaurant Management System\Restaurant Management System\SQLQuery1.sql.mdf"";Integrated Security=True;Connect Timeout=30";

        public inventoryForm()
        {
            InitializeComponent();
            displayCategories();
            displayProducts();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void displayProducts()
        {
            productsList pList = new productsList();
            List<productsList> listData = pList.productListData();
            dataGridView1.DataSource = listData;

        }

        public void displayCategories()
        {
            inventory_category.Items.Clear();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectCat = "SELECT * FROM categories WHERE  status = 'Active' ";
                using (SqlCommand cmd = new SqlCommand(selectCat, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        inventory_category.Items.Add(reader["category"]);
                    }
                }
            }
        }
        private void inventory_addBtn_Click(object sender, EventArgs e)
        {
            if (inventory_productID.Text == "" || inventory_productName.Text == "" || inventory_category.SelectedIndex == -1 
                || inventory_stock.Text == "" || inventory_price.Text == "" || inventory_status.Text == "" || pictureBox1.Image == null )
            {
                MessageBox.Show("Empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string checkProductID = "SELECT * FROM products WHERE productid = @prodid";

                    using (SqlCommand checkProdId = new SqlCommand(checkProductID, connect))
                    {
                        checkProdId.Parameters.AddWithValue("@prodid", inventory_productID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkProdId);
                        DataTable table = new DataTable();

                        adapter.Fill(table);
                        if(table.Rows.Count != 0)
                        {
                            MessageBox.Show($" {inventory_productID.Text.Trim()} exists already", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        } else
                        {
                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                            string insertData = @"INSERT INTO products 
(productid, productname, category, stock, price, status, image, date_insert) 
VALUES (@productid, @productname, @category, @stock, @price, @status, @image, @date_insert)";

                            string relativePath = Path.Combine("products_directory", inventory_productID.Text.Trim() + ".jpg");
                            string path = Path.Combine(baseDirectory, relativePath);

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }
                            if (File.Exists(path))
                            {
                                pictureBox1.Image.Dispose(); // release the lock on the image
                                File.Delete(path); // delete the existing image
                            }
                            File.Copy(pictureBox1.ImageLocation, path, true);





                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@productid", inventory_productID.Text.Trim());
                                cmd.Parameters.AddWithValue("@productname", inventory_productName.Text.Trim());
                                cmd.Parameters.AddWithValue("@category", inventory_category.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@stock", inventory_stock.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", inventory_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", inventory_status.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@image", path);

                                cmd.Parameters.AddWithValue("@date_insert", DateTime.Now);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Added succesfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                    }
                }
            }
            displayProducts();
        }

        private void inventory_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = " Image Files (*.jpg, *.png| *.jpg;*.png)";

                string imagePath = "";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", " Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void clearFields()
        {
            inventory_productID.Clear();
            inventory_productName.Clear();
            inventory_category.SelectedIndex = -1;
            inventory_stock.Clear();
            inventory_price.Clear();
            inventory_status.SelectedIndex = -1;
            pictureBox1.Image = null;
            getID = 0;

        }

        private void inventory_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

               

                getID = (int)row.Cells[0].Value;
                inventory_productID.Text = row.Cells[1].Value.ToString();
                inventory_productName.Text = row.Cells[2].Value.ToString();
                inventory_category.Text = Convert.ToString(row.Cells[3].Value);
                inventory_stock.Text = row.Cells[4].Value.ToString();
                inventory_price.Text = row.Cells[5].Value.ToString();
                inventory_status.Text = row.Cells[6].Value.ToString();
             
                
                string imagePath = row.Cells[7].Value.ToString();

                try
                {
                    if(imagePath != null)
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);

                    }else
                    {
                        pictureBox1.Image = null;
                    }

                } catch(Exception ex) 
                {
                    MessageBox.Show($"Error: {ex}", "Error Message" , MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }

        private void inventory_updateBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Are you sure you want to update ID {getID}?", "Confirmation Message" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (getID == 0)
                {
                    MessageBox.Show("Error fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();

                        string checkProductId = "SELECT * FROM products WHERE productid = @prodid";

                        using (SqlCommand checkProd = new SqlCommand(checkProductId, connect))
                        {
                            checkProd.Parameters.AddWithValue("@prodid", inventory_productID.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkProd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count >= 2)
                            {
                                MessageBox.Show(inventory_productID.Text.Trim() + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                string upadateData = "UPDATE products SET productid = @prodid, productname = @prodname, category = @cat, stock = @stock, price = @price, status = @status, date_update = @date WHERE id = @id";
                                using (SqlCommand cmd = new SqlCommand(upadateData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@prodid", inventory_productID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodname", inventory_productName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cat", inventory_category.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@stock", inventory_stock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", inventory_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", inventory_status.SelectedItem.ToString());


                                    DateTime today = DateTime.Now;
                                    cmd.Parameters.AddWithValue("@date", today);
                                    cmd.Parameters.AddWithValue("@id", getID);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Updated succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                }
                            }

                        }
                    }
                }
            }

            displayProducts();
        }

        private void inventory_deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete ID {getID}?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (getID == 0)
                {
                    MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();


                        string upadateData = "DELETE FROM products WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(upadateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Deleted succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                        }
                    }
                }
            }

            displayProducts();
        }
    }
}
