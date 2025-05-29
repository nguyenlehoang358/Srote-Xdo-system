using STORE_X.Ctrl;
using STORE_X.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace STORE_X
{
    public partial class frmPRODUCTS : Form
    {
        private Products_BLL products_CTRL = new Products_BLL();
        private string productImage = string.Empty;
        public frmPRODUCTS()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dgvPEODUCTS.DataSource = products_CTRL.GetAllProducts();
        }
        private void clear()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtProductCompany.Text = "";
            txtProductPrice.Text = "";
            txtProductQuatity.Text = "";
        }
        private void btnADD_Click(object sender, EventArgs e)
        {

            Product product = new Product
            {
                ProductName = txtProductName.Text,
                ProductImage = productImage,
                ProductCompany = txtProductCompany.Text,
                ProductPrice = txtProductPrice.Text,
                ProductQuatity = int.Parse(txtProductQuatity.Text),
            };

            if (products_CTRL.AddProduct(product))
            {
                MessageBox.Show("Added successfully!");
                LoadData();

            }
        }

        private void btnMODIFY_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductID = int.Parse(txtProductID.Text),
                ProductName = txtProductName.Text,
                ProductImage = productImage,
                ProductCompany = txtProductCompany.Text,
                ProductPrice = txtProductPrice.Text,
                ProductQuatity = int.Parse(txtProductQuatity.Text),
            };

            if (products_CTRL.UpdateProduct(product))
            {
                MessageBox.Show("Updated successfully!");
                LoadData();
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            int productID = int.Parse(txtProductID.Text);

            if (products_CTRL.DeleteProduct(productID))
            {
                MessageBox.Show("Deleted successfully!");
                LoadData();
                /*ClearFields();*/
            }
        }

        private void dgvPEODUCTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPEODUCTS.Rows[e.RowIndex];
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                productImage = row.Cells["ProductImage"].Value.ToString();
                txtProductCompany.Text = row.Cells["ProductCompany"].Value.ToString();
                txtProductPrice.Text = row.Cells["ProductPrice"].Value.ToString();
                txtProductQuatity.Text = row.Cells["ProductQuatity"].Value.ToString();
                pbProductImage.ImageLocation = productImage;
            }
        }

        private void txtChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                productImage = openFileDialog.FileName;
                pbProductImage.ImageLocation = productImage;
            }
        }

        private void txtSEARCHP_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "ProductName", "*" + txtSEARCHP.Text + "*");
            (dgvPEODUCTS.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain_Admin frmMain_Admin = new frmMain_Admin();
            this.Hide();
            frmMain_Admin.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtProductCompany.Text = "";
            txtProductPrice.Text = "";
            txtProductQuatity.Text = "";
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
