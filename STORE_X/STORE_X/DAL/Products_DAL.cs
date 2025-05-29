using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STORE_X.Object;

namespace STORE_X.Modify
{
    public class Products_DAL
    {
        private readonly string connectionString = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog=STORE_X;Integrated Security=True";

        public DataTable GetAllProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PRODUCTS";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool AddProduct(Product product)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PRODUCTS (ProductName, ProductImage, ProductCompany, ProductPrice, ProductQuatity) VALUES (@productName, @productImage, @productCompany, @productPrice, @productQuatity)";
                SqlCommand cmd = new SqlCommand(query, conn);
                
                cmd.Parameters.AddWithValue("@productName", product.ProductName);
                cmd.Parameters.AddWithValue("@productImage", product.ProductImage);
                cmd.Parameters.AddWithValue("@productCompany", product.ProductCompany);
                cmd.Parameters.AddWithValue("@productPrice", product.ProductPrice);
                cmd.Parameters.AddWithValue("@productQuatity", product.ProductQuatity);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateProduct(Product product)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE PRODUCTS SET ProductName=@productname, ProductImage=@productImage, ProductCompany=@productCompany, ProductPrice=@productPrice, ProductQuatity=@productQuatity WHERE ProductID=@productID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@productID", product.ProductID);
                cmd.Parameters.AddWithValue("@productname", product.ProductName);
                cmd.Parameters.AddWithValue("@productImage", product.ProductImage);
                cmd.Parameters.AddWithValue("@productCompany", product.ProductCompany);
                cmd.Parameters.AddWithValue("@productPrice", product.ProductPrice);
                cmd.Parameters.AddWithValue("@productQuatity", product.ProductQuatity);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteProduct(int productID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM PRODUCTS WHERE ProductID=@productID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@productID", productID);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
