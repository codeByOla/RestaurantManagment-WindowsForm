using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    internal class categoriesList
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\source\repos\Restaurant Management System\Restaurant Management System\SQLQuery1.sql.mdf"";Integrated Security=True;Connect Timeout=30";


        public int ID { get; set; }
        public string category {  get; set; }
        public string status { get; set; }
        public string DataInsert { get; set; }  

        public List<categoriesList> categoriesListData()
        {
            List<categoriesList> listData = new List<categoriesList>();
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        categoriesList cData = new categoriesList();
                        cData.ID = (int)reader["id"];
                        cData.category = (string)reader["category"];
                        cData.status = (string)reader["status"];
                        cData.DataInsert = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);
                    }
                }
            }
            return listData;
        }
    }
}
