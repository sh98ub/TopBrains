using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadProduct
{
    internal class ProductRead
    {
        string coneectionstring = "Data Source=PARADOX\\SQLEXPRESS;Initial Catalog=AdventureWorks2022;Integrated Security=True;";

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            SqlConnection connection = new SqlConnection(coneectionstring);
            connection.Open();
            string query = "Select ProductID,Name,ListPrice from Production.Product";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                products.Add(new Product
                {
                    ProductID = (int)sqlDataReader["ProductID"],
                    Name = sqlDataReader["Name"].ToString(),
                    ListPrice = (decimal)sqlDataReader["ListPrice"]


                });
            }
            connection.Close();

            return products;


        }
    }
}
