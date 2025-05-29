using STORE_X.Ctrl;
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
using STORE_X.Object;
using STORE_X.Modify;

namespace STORE_X
{
    public partial class frmCUSTOMERS : Form    
    {
        Customers_BLL customers_ctrl = new Customers_BLL();
        Customer customer = new Customer();
        private int flag = 0;
        public frmCUSTOMERS()
        {
            InitializeComponent();
        }

        private void frmCUSTOMERS_Load(object sender, EventArgs e)
        {
            DataTable dataCustomer = new DataTable();
            dataCustomer = customers_ctrl.getData();
            dgvCUSTOMER.DataSource = dataCustomer;
            bingding();
        }
        void bingding()
        {
            txtCustomerID.DataBindings.Clear();
            txtCustomerID.DataBindings.Add("TEXT", dgvCUSTOMER.DataSource, "CustomerID");
            txtCustomerName.DataBindings.Clear();
            txtCustomerName.DataBindings.Add("TEXT", dgvCUSTOMER.DataSource, "CustomerName");
            txtCustomerPhone.DataBindings.Clear();
            txtCustomerPhone.DataBindings.Add("TEXT", dgvCUSTOMER.DataSource, "CustomerPhone");
            txtCustomerEmail.DataBindings.Clear();
            txtCustomerEmail.DataBindings.Add("TEXT", dgvCUSTOMER.DataSource, "CustomerEmail");
            txtCustomerAddress.DataBindings.Clear();
            txtCustomerAddress.DataBindings.Add("TEXT", dgvCUSTOMER.DataSource, "CustomerAddress");
        }

        void dis_en(bool cus)
        {
            txtCustomerID.Enabled = cus;
            txtCustomerName.Enabled = cus;
            txtCustomerPhone.Enabled = cus;
            txtCustomerEmail.Enabled = cus;
            txtCustomerAddress.Enabled = cus;
            btnADD.Enabled =! cus;
            btnDELETE.Enabled =! cus;
            btnMODIFY.Enabled =! cus;
            btnSAVE.Enabled = cus;
            btnCANCEL.Enabled = cus;
        }
        //assign data
        void assignData(Customer customer)
        {
            customer.Id = txtCustomerID.Text.Trim();
            customer.Name = txtCustomerName.Text.Trim();
            customer.Phone = txtCustomerPhone.Text.Trim();
            customer.Email = txtCustomerEmail.Text.Trim();
            customer.Address = txtCustomerAddress.Text.Trim();

        }

        private void cleardata()
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerAddress.Text = "";
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            flag = 0;
            cleardata();
            dis_en(true);
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            DialogResult dele = MessageBox.Show("Are you sure you want to delete!!!", "YES", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dele == DialogResult.Yes)
            {
                //DELETE
                if (customers_ctrl.deleteData(txtCustomerID.Text.Trim()))
                {
                    MessageBox.Show("Delete successful", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;
            frmCUSTOMERS_Load(sender, e);
        }

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
            frmCUSTOMERS_Load(sender, e);
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            frmCUSTOMERS_Load(sender, e);
            dis_en(false);
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            assignData(customer);
            if (flag == 0)
            {
                //ADD
                if (customers_ctrl.addData(customer))
                {
                    MessageBox.Show("New addition successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("New addition failed", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MODIFY
                if (customers_ctrl.updataData(customer))
                {
                    MessageBox.Show("Modify successful", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmCUSTOMERS_Load(sender, e);
            dis_en(false);
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSEARCHC_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "CustomerName", "*" + txtSEARCHC.Text + "*");
            (dgvCUSTOMER.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain_Admin frmMain_Admin = new frmMain_Admin();
            this.Hide();
            frmMain_Admin.Show();
        }
    }
}
