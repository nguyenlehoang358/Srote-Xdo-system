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
    public partial class frmMain_Admin : Form
    {
        public frmMain_Admin()
        {
            InitializeComponent();
        }

        private void frmMain_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCUSTOMERS admin = new frmCUSTOMERS();
            this.Hide();
            admin.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLOGIN admin = new frmLOGIN();
            this.Hide();
            admin.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEMPLOYEES admin = new frmEMPLOYEES();
            this.Hide();
            admin.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmPRODUCTS admin = new frmPRODUCTS();
            this.Hide();
            admin.Show();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            frmRegisterForm admin = new frmRegisterForm();
            this.Hide();
            admin.Show();
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            frmSTATISTICSMANAGER admin = new frmSTATISTICSMANAGER();
            this.Hide();
            admin.Show();
        }

        private void btnOlder_Click(object sender, EventArgs e)
        {
            frmORDER admin = new frmORDER();
            this.Hide();
            admin.Show();
        }
    }
}
