using STORE_X.LOGIN;
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

namespace STORE_X
{
    public partial class frmLOGIN : Form
    {
        
        public frmLOGIN()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            using (SqlConnection conn = DatabaseLogin.GetConnection())
            {
                string query = "SELECT u.UserID, u.Username, r.RoleName FROM Users u INNER JOIN Roles r ON u.RoleID = r.RoleID WHERE u.Username = @username AND u.Password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string roleName = reader["RoleName"].ToString();
                    MessageBox.Show($"Login successful! Welcome {roleName}.");
                    // Redirect to the main form based on role
                    this.Hide();
                    if (roleName == "Admin")
                    {
                        frmMain_Admin adminForm = new frmMain_Admin();
                        this.Hide();
                        adminForm.Show();
                    }
                    else if (roleName == "Seller")
                    {
                        frmMain_Seller sellerForm = new frmMain_Seller();
                        this.Hide();
                        sellerForm.Show();
                    }
                    else if (roleName == "Warehouse")
                    {
                        frmMain_Warehouse warehouseForm = new frmMain_Warehouse();
                        this.Hide();
                        warehouseForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmRegisterForm frmRegisterForm = new frmRegisterForm();
            this.Hide();
            frmRegisterForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
