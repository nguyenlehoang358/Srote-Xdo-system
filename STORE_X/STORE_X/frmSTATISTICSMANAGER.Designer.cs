namespace STORE_X
{
    partial class frmSTATISTICSMANAGER
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.btnProductImportStats = new System.Windows.Forms.Button();
            this.btnRevenueStats = new System.Windows.Forms.Button();
            this.btnProfitStats = new System.Windows.Forms.Button();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.AllowUserToAddRows = false;
            this.dgvStatistics.AllowUserToDeleteRows = false;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Location = new System.Drawing.Point(29, 153);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.ReadOnly = true;
            this.dgvStatistics.Size = new System.Drawing.Size(586, 193);
            this.dgvStatistics.TabIndex = 0;
            // 
            // btnProductImportStats
            // 
            this.btnProductImportStats.Location = new System.Drawing.Point(443, 24);
            this.btnProductImportStats.Name = "btnProductImportStats";
            this.btnProductImportStats.Size = new System.Drawing.Size(172, 23);
            this.btnProductImportStats.TabIndex = 1;
            this.btnProductImportStats.Text = "ProductImportStats";
            this.btnProductImportStats.UseVisualStyleBackColor = true;
            this.btnProductImportStats.Click += new System.EventHandler(this.btnProductImportStats_Click);
            // 
            // btnRevenueStats
            // 
            this.btnRevenueStats.Location = new System.Drawing.Point(443, 70);
            this.btnRevenueStats.Name = "btnRevenueStats";
            this.btnRevenueStats.Size = new System.Drawing.Size(172, 23);
            this.btnRevenueStats.TabIndex = 2;
            this.btnRevenueStats.Text = "RevenueStats";
            this.btnRevenueStats.UseVisualStyleBackColor = true;
            this.btnRevenueStats.Click += new System.EventHandler(this.btnRevenueStats_Click);
            // 
            // btnProfitStats
            // 
            this.btnProfitStats.Location = new System.Drawing.Point(443, 109);
            this.btnProfitStats.Name = "btnProfitStats";
            this.btnProfitStats.Size = new System.Drawing.Size(172, 23);
            this.btnProfitStats.TabIndex = 3;
            this.btnProfitStats.Text = "ProfitStats";
            this.btnProfitStats.UseVisualStyleBackColor = true;
            this.btnProfitStats.Click += new System.EventHandler(this.btnProfitStats_Click);
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Location = new System.Drawing.Point(29, 24);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(183, 21);
            this.cmbPeriod.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(344, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(344, 70);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSTATISTICSMANAGER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 359);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.btnProfitStats);
            this.Controls.Add(this.btnRevenueStats);
            this.Controls.Add(this.btnProductImportStats);
            this.Controls.Add(this.dgvStatistics);
            this.Name = "frmSTATISTICSMANAGER";
            this.Text = "frmSTATISTICSMANAGER";
            this.Load += new System.EventHandler(this.frmSTATISTICSMANAGER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.Button btnProductImportStats;
        private System.Windows.Forms.Button btnRevenueStats;
        private System.Windows.Forms.Button btnProfitStats;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}