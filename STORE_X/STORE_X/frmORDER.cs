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
using COMExecl = Microsoft.Office.Interop.Excel;

namespace STORE_X
{
    public partial class frmORDER : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        public frmORDER()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=STORE_X;Integrated Security=True");
            LoadCustomerIDs();
            LoadEmployeeIDs();
            LoadProductIDs();
            LoadOrders();
            
        }

        void bingding()
        {
            txtOrderID.DataBindings.Clear();
            txtOrderID.DataBindings.Add("TEXT", dgvORDER.DataSource, "OrderID");
            dtOrderSoldDate.DataBindings.Clear();
            dtOrderSoldDate.DataBindings.Add("TEXT", dgvORDER.DataSource, "OrderSoldDate");
            txtCustomerName.DataBindings.Clear();
            txtCustomerName.DataBindings.Add("TEXT", dgvORDER.DataSource, "CustomerName");
            txtEmployeeName.DataBindings.Clear();
            txtEmployeeName.DataBindings.Add("TEXT", dgvORDER.DataSource, "EmployeeName");
            txtCustomerPhone.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtProductName.DataBindings.Add("TEXT", dgvORDER.DataSource, "ProductName");
            txtProductQuatity.DataBindings.Clear();
            txtProductQuatity.DataBindings.Add("TEXT", dgvORDER.DataSource, "ProductQuatity");
            txtProductPrice.DataBindings.Clear();
            txtProductPrice.DataBindings.Add("TEXT", dgvORDER.DataSource, "ProductPrice");
            txtOrderTotal.DataBindings.Clear();
            txtOrderTotal.DataBindings.Add("TEXT", dgvORDER.DataSource, "OrderTotal");
        }
        private void LoadOrders()
        {
            try
            {
                con.Open();
                string query = @"
            SELECT 
                o.OrderID, 
                o.OrderSoldDate, 
                c.CustomerName, 
                e.EmployeeName, 
                p.ProductName, 
                od.OrderQuantity, 
                od.OrderUnitPrice, 
                od.OrderTotal
            FROM ORDERS o
            JOIN CUSTOMERS c ON o.CustomerID = c.CustomerID
            JOIN EMPLOYEES e ON o.EmployeesID = e.EmployeesID
            JOIN ORDERDETAIL od ON o.OrderID = od.OrderID
            JOIN PRODUCTS p ON od.ProductID = p.ProductID";

                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                dgvORDER.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadCustomerIDs()
        {
            da = new SqlDataAdapter("SELECT CustomerID FROM CUSTOMERS", con);
            dt = new DataTable();
            da.Fill(dt);
            cboCustomerID.DataSource = dt;
            cboCustomerID.DisplayMember = "CustomerID";
            cboCustomerID.ValueMember = "CustomerID";
        }

        private void LoadEmployeeIDs()
        {
            da = new SqlDataAdapter("SELECT EmployeesID FROM EMPLOYEES", con);
            dt = new DataTable();
            da.Fill(dt);
            cboEmployeesID.DataSource = dt;
            cboEmployeesID.DisplayMember = "EmployeesID";
            cboEmployeesID.ValueMember = "EmployeesID";
        }

        private void LoadProductIDs()
        {
            da = new SqlDataAdapter("SELECT ProductID FROM PRODUCTS", con);
            dt = new DataTable();
            da.Fill(dt);
            cboProductID.DataSource = dt;
            cboProductID.DisplayMember = "ProductID";
            cboProductID.ValueMember = "ProductID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string insertOrder = "INSERT INTO ORDERS (OrderSoldDate, CustomerID, EmployeesID) VALUES (@date, @customerID, @employeeID); SELECT SCOPE_IDENTITY();";
                cmd = new SqlCommand(insertOrder, con);
                cmd.Parameters.AddWithValue("@date", dtOrderSoldDate.Value);
                cmd.Parameters.AddWithValue("@employeeID", cboEmployeesID.SelectedValue);
                cmd.Parameters.AddWithValue("@customerID", cboCustomerID.SelectedValue);
                int orderID = Convert.ToInt32(cmd.ExecuteScalar());

                string insertDetail = "INSERT INTO ORDERDETAIL (OrderID, ProductID, OrderQuantity, OrderUnitPrice) VALUES (@orderID, @productID, @quantity, @price)";
                cmd = new SqlCommand(insertDetail, con);
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@productID", cboProductID.SelectedValue);
                cmd.Parameters.AddWithValue("@quantity", txtProductQuatity.Text);
                cmd.Parameters.AddWithValue("@price", txtProductPrice.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Order Added Successfully!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain_Admin frmMain_Admin = new frmMain_Admin();
            this.Hide();
            frmMain_Admin.Show();
        }
    }
}
