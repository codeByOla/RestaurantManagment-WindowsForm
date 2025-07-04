﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Restaurant_Management_System
{
    public partial class signupForm : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\source\repos\Restaurant Management System\Restaurant Management System\SQLQuery1.sql.mdf"";Integrated Security=True;Connect Timeout=30";

        public signupForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this app?", " Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void signup_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_ShowPassword.Checked ? '\0' : '*';
            signup_confirmPassword.PasswordChar = signup_ShowPassword.Checked ? '\0' : '*';

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {

                connect.Open();

                string checkUsername = "SELECT * FROM users WHERE username = @usern";

                using (SqlCommand checkUsern = new SqlCommand(checkUsername, connect))
                {
                    checkUsern.Parameters.AddWithValue("usern", signup_username.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    if (table.Rows.Count != 0)
                    {
                        MessageBox.Show($"{signup_username.Text.Trim()} was taken already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (signup_password.Text.Trim().Length < 8)
                    {
                        MessageBox.Show("Invalid Password, at least 8 char required", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (signup_password.Text.Trim() != signup_confirmPassword.Text.Trim())
                    {
                        MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string insertData = "INSERT INTO users (username, password, status, date_created) VALUES (@usern, @pass, @status, @date) ";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", signup_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            DateTime today = DateTime.Now;

                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Registered!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            Form1 loginForm = new Form1();
                            loginForm.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
    }
}