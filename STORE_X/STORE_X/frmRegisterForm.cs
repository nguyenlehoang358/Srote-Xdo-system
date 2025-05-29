using Microsoft.Office.Interop.Excel;
using STORE_X.Ctrl;
using STORE_X.LOGIN;
using STORE_X.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace STORE_X
{
    public partial class frmRegisterForm : Form
    {
        private string connectionString = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog=STORE_X;Integrated Security=True";
        public frmRegisterForm()
        {
            InitializeComponent();
            LoadRoles();
            LoadData();
           /* bingding();*/
        }

        private void LoadRoles()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT RoleID, RoleName FROM Roles";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable roles = new DataTable();
                    adapter.Fill(roles);
                    cboRoleId.DataSource = roles;
                    cboRoleId.DisplayMember = "RoleName";
                    cboRoleId.ValueMember = "RoleID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading roles: " + ex.Message);
            }
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Users.UserID, Users.Username, Users.Password, Roles.RoleName FROM Users JOIN Roles ON Users.RoleID = Roles.RoleID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable users = new DataTable();
                    adapter.Fill(users);
                    dgvRegister.DataSource = users;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        void bingding()
        {
            cboRoleId.DataBindings.Clear();
            cboRoleId.DataBindings.Add("TEXT", dgvRegister.DataSource, "RoleId");
            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add("TEXT", dgvRegister.DataSource, "Username");
            txtPassword.DataBindings.Clear();
            txtPassword.DataBindings.Add("TEXT", dgvRegister.DataSource, "Password");
            txtUserID.DataBindings.Clear();
            txtUserID.DataBindings.Add("TEXT", dgvRegister.DataSource, "UserID");
        }
        void loadControl()
        {
            cboRoleId.Items.Add("2");
            cboRoleId.Items.Add("3");
        }
        private void cleardata()
        {
            cboRoleId.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        void dis_en(bool em)
        {
            cboRoleId.Enabled = em;
            txtUsername.Enabled = em;
            txtPassword.Enabled = em;
            btnCreate.Enabled = !em;
            btnDelete.Enabled = !em;
            btnModify.Enabled = !em;
            btnSave.Enabled = em;
            btnCancel.Enabled = em;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, Password, RoleID) VALUES (@Username, @Password, @RoleID)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@RoleID", cboRoleId.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("User added successfully.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET Username = @Username, Password = @Password, RoleID = @RoleID WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@RoleID", cboRoleId.SelectedValue);
                        cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("User updated successfully.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Users WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("User deleted successfully.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
        }
    }
}
