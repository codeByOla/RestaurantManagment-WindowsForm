using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    public partial class Form1 : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\source\repos\Restaurant Management System\Restaurant Management System\SQLQuery1.sql.mdf"";Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to close this app?" , " Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                string query = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                     
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Login succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainForm mainForm = new MainForm();
                        mainForm.Show();

                        this.Hide();
                    } else
                    {
                        MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            signupForm signupForm = new signupForm();
            signupForm.Show();

            this.Hide();
        }

        private void login_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_ShowPassword.Checked ? '\0' : '*';
        }
    }
}
