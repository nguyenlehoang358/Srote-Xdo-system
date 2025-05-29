using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using STORE_X.Modify;
using STORE_X.Object;


namespace STORE_X.Modify
{
    internal class Customers_DAL
    {
        Connection_Database conn = new Connection_Database();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable data = new DataTable();
            cmd.CommandText = "SELECT * FROM dbo.CUSTOMERS";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.openCon();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.closeCon();
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
                cmd.Dispose();
                conn.closeCon();
            }
            return data;
        }

        public bool AddData(Customer customer)
        {
            cmd.CommandText = "INSERT INTO dbo.CUSTOMERS VALUES ('"+ customer.Id +"', '"+ customer.Name +"', '"+ customer.Phone +"', '"+ customer.Email +"', '"+ customer.Address +"')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.openCon();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
                cmd.Dispose();
                conn.closeCon();
            }
            return false;
        }

        public bool UPDATEData(Customer customer)
        {
            cmd.CommandText = "UPDATE dbo.CUSTOMERS SET CustomerName = '" + customer.Name + "', CustomerPhone = '" + customer.Phone + "', CustomerEmail = '" + customer.Email + "', CustomerAddress = '" + customer.Address + "' WHERE CustomerID = '" + customer.Id + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.openCon();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
                cmd.Dispose();
                conn.closeCon();
            }
            return false;
        }

        public bool DELETEData(String IDC)
        {
            cmd.CommandText = "DELETE dbo.CUSTOMERS WHERE CustomerID = '" + IDC + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.openCon();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
                cmd.Dispose();
                conn.closeCon();
            }
            return false;
        }
    }
}
