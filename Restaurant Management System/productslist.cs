﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant_Management_System
{
    internal class productsList
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\source\repos\Restaurant Management System\Restaurant Management System\SQLQuery1.sql.mdf"";Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; }
        public string ProductID { set; get; }
        
        public string ProductName { set; get; }

        public string Category { set; get; }
        public string stock { set; get; }
        public string price { set; get; }
        public string status { set; get; }
        public string image { set; get; }

        public string DateInsert { set; get; }
        public string DateUpdate { set; get; }


      
        public List<productsList> productListData()
        {
            List<productsList> listData = new List<productsList>();
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                       productsList pList = new productsList();

                        pList.ID = (int)reader["id"];
                        pList.ProductID = reader["productID"].ToString();
                        pList.ProductName = reader["productname"].ToString();
                        pList.Category = reader["category"].ToString();
                        pList.stock = reader["stock"].ToString();
                        pList.price = reader["price"].ToString();
                        pList.status = reader["status"].ToString();
                        pList.image = reader["image"].ToString();
                        pList.DateInsert= ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                       pList.DateUpdate = reader["date_update"] == DBNull.Value ? null : ((DateTime)reader["date_update"]).ToString("MM-dd-yyyy");
                        listData.Add(pList);
                    }
                }
            }
            return listData;
        }
    }

}

