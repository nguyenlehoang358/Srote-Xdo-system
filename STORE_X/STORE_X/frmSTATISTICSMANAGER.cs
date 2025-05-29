using STORE_X.Modify;
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
    public partial class frmSTATISTICSMANAGER : Form
    {
        private StatisticsManager_DAL statisticsManager_DAL = new StatisticsManager_DAL();

        public frmSTATISTICSMANAGER()
        {
            InitializeComponent();
            LoadControl();
        }

        private void btnProductImportStats_Click(object sender, EventArgs e)
        {
            DataTable data = statisticsManager_DAL.GetProductImportStatistics();
            dgvStatistics.DataSource = data;
        }

        private void btnRevenueStats_Click(object sender, EventArgs e)
        {
            LoadControl();
            if (cmbPeriod.SelectedItem == null)
            {
                MessageBox.Show("Please select a period from the dropdown.");
                return;
            }
            string period = cmbPeriod.SelectedItem.ToString();
            DataTable data = statisticsManager_DAL.GetRevenueStatistics(period);
            dgvStatistics.DataSource = data;
            
        }

        private void btnProfitStats_Click(object sender, EventArgs e)
        {
            DataTable data = statisticsManager_DAL.GetProfitStatistics();
            dgvStatistics.DataSource = data;
        }

        private void btnInvoiceDetails_Click(object sender, EventArgs e)
        {
            DataTable data = statisticsManager_DAL.GetInvoiceDetails();
            dgvStatistics.DataSource = data;
        }

        private void btnInvoiceInfo_Click(object sender, EventArgs e)
        {
            DataTable data = statisticsManager_DAL.GetInvoiceInfo();
            dgvStatistics.DataSource = data;
        }

        void LoadControl()
        {
            cmbPeriod.Items.Add("day");
            cmbPeriod.Items.Add("month");
            cmbPeriod.Items.Add("year");
        }

        private void frmSTATISTICSMANAGER_Load(object sender, EventArgs e)
        {

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
