using STORE_X.Ctrl;
using STORE_X.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STORE_X
{
    public partial class frmEMPLOYEES : Form
    {
        Employees_BLL employees_CTRL = new Employees_BLL();
        Employee employee = new Employee();
        private int flag = 0;
        public frmEMPLOYEES()
        {
            InitializeComponent();
        }

        private void frmEMPLOYEES_Load(object sender, EventArgs e)
        {
            DataTable dataCustomer = new DataTable();
            dataCustomer = employees_CTRL.getData();
            dgvEMPLOYEES.DataSource = dataCustomer;
            bingding();
        }
        void bingding()
        {
            txtEmployeesID.DataBindings.Clear();
            txtEmployeesID.DataBindings.Add("TEXT", dgvEMPLOYEES.DataSource, "EmployeesID");
            txtEmployeeName.DataBindings.Clear();
            txtEmployeeName.DataBindings.Add("TEXT", dgvEMPLOYEES.DataSource, "EmployeeName");
            txtEmployeePhone.DataBindings.Clear();
            txtEmployeePhone.DataBindings.Add("TEXT", dgvEMPLOYEES.DataSource, "EmployeePhone");
            txtEmployeeEmail.DataBindings.Clear();
            txtEmployeeEmail.DataBindings.Add("TEXT", dgvEMPLOYEES.DataSource, "EmployeeEmail");
            txtEmployeeAddress.DataBindings.Clear();
            txtEmployeeAddress.DataBindings.Add("TEXT", dgvEMPLOYEES.DataSource, "EmployeeAddress");
        }

        void dis_en(bool em)
        {
            txtEmployeesID.Enabled = em;
            txtEmployeeName.Enabled = em;
            txtEmployeePhone.Enabled = em;
            txtEmployeeEmail.Enabled = em;
            txtEmployeeAddress.Enabled = em;
            btnADD.Enabled = !em;
            btnDELETE.Enabled = !em;
            btnMODIFY.Enabled = !em;
            btnSAVE.Enabled = em;
            btnCANCEL.Enabled = em;
        }
        //assign data
        void assignData(Employee employee)
        {
            employee.IdE = txtEmployeesID.Text.Trim();
            employee.NameE = txtEmployeeName.Text.Trim();
            employee.PhoneE = txtEmployeePhone.Text.Trim();
            employee.EmailE = txtEmployeeEmail.Text.Trim();
            employee.AddressE = txtEmployeeAddress.Text.Trim();

        }
        void loadControl()
        {
            cboEmployeeRole.Items.Add("seller");
            cboEmployeeRole.Items.Add("warehouse");

            cboEmployeePasswordHash.Items.Add("1234");
            cboEmployeePasswordHash.Items.Add("123");
        }
        private void cleardata()
        {
            txtEmployeesID.Text = "";
            txtEmployeeName.Text = "";
            txtEmployeePhone.Text = "";
            txtEmployeeEmail.Text = "";
            txtEmployeeAddress.Text = "";
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            flag = 0;
            cleardata();
            dis_en(true);
            loadControl();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            DialogResult dele = MessageBox.Show("Are you sure you want to delete!!!", "YES", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dele == DialogResult.Yes)
            {
                //DELETE
                if (employees_CTRL.deleteData(txtEmployeesID.Text.Trim()))
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
            frmEMPLOYEES_Load(sender, e);
        }

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
            frmEMPLOYEES_Load(sender, e);
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            frmEMPLOYEES_Load(sender, e);
            dis_en(false);
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            assignData(employee);
            if (flag == 0)
            {
                //ADD
                if (employees_CTRL.addData(employee))
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
                if (employees_CTRL.updataData(employee))
                {
                    MessageBox.Show("Modify successful", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmEMPLOYEES_Load(sender, e);
            dis_en(false);
        }

        private void btnEXITE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSEARCHE_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "EmployeeName", "*" + txtSEARCHE.Text + "*");
            (dgvEMPLOYEES.DataSource as DataTable).DefaultView.RowFilter = rowFilter;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain_Admin frmMain_Admin = new frmMain_Admin();
            this.Hide();
            frmMain_Admin.Show();
        }
    }
}
