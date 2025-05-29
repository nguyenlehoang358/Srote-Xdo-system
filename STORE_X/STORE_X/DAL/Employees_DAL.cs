using STORE_X.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace STORE_X.Modify
{
    internal class Employees_DAL
    {
        Connection_Database conn = new Connection_Database();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable data = new DataTable();
            cmd.CommandText = "SELECT * FROM dbo.EMPLOYEES";
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

        public bool AddData(Employee employee)
        {
            cmd.CommandText = "INSERT INTO dbo.EMPLOYEES VALUES ('" + employee.IdE + "', '" + employee.NameE + "', '" + employee.PhoneE + "', '" + employee.EmailE + "', '" + employee.AddressE + "')";
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

        public bool UPDATEData(Employee employee)
        {
            cmd.CommandText = "UPDATE dbo.EMPLOYEES SET EmployeeName = '" + employee.NameE + "', EmployeePhone = '" + employee.PhoneE + "', EmployeeEmail = '" + employee.EmailE + "', EmployeeAddress = '" + employee.AddressE + "' WHERE EmployeesID = '" + employee.IdE + "' ";
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

        public bool DELETEData(String IDE)
        {
            cmd.CommandText = "DELETE dbo.EMPLOYEES WHERE EmployeesID = '" + IDE + "' ";
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
