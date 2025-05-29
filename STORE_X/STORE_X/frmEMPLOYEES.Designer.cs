namespace STORE_X
{
    partial class frmEMPLOYEES
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboEmployeePasswordHash = new System.Windows.Forms.ComboBox();
            this.cboEmployeeRole = new System.Windows.Forms.ComboBox();
            this.btnEXITE = new System.Windows.Forms.Button();
            this.lbEmployeesID = new System.Windows.Forms.Label();
            this.txtSEARCHE = new System.Windows.Forms.TextBox();
            this.txtEmployeesID = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbEmployeePhone = new System.Windows.Forms.Label();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.lbEmployeeEmail = new System.Windows.Forms.Label();
            this.btnMODIFY = new System.Windows.Forms.Button();
            this.lbEmployeeAddress = new System.Windows.Forms.Label();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.dgvEMPLOYEES = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMPLOYEES)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.cboEmployeePasswordHash);
            this.panel1.Controls.Add(this.cboEmployeeRole);
            this.panel1.Controls.Add(this.btnEXITE);
            this.panel1.Controls.Add(this.lbEmployeesID);
            this.panel1.Controls.Add(this.txtSEARCHE);
            this.panel1.Controls.Add(this.txtEmployeesID);
            this.panel1.Controls.Add(this.btnADD);
            this.panel1.Controls.Add(this.btnCANCEL);
            this.panel1.Controls.Add(this.lbEmployeeName);
            this.panel1.Controls.Add(this.lbEmployeePhone);
            this.panel1.Controls.Add(this.btnSAVE);
            this.panel1.Controls.Add(this.lbEmployeeEmail);
            this.panel1.Controls.Add(this.btnMODIFY);
            this.panel1.Controls.Add(this.lbEmployeeAddress);
            this.panel1.Controls.Add(this.btnDELETE);
            this.panel1.Controls.Add(this.txtEmployeeName);
            this.panel1.Controls.Add(this.txtEmployeeAddress);
            this.panel1.Controls.Add(this.txtEmployeePhone);
            this.panel1.Controls.Add(this.txtEmployeeEmail);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 242);
            this.panel1.TabIndex = 0;
            // 
            // cboEmployeePasswordHash
            // 
            this.cboEmployeePasswordHash.FormattingEnabled = true;
            this.cboEmployeePasswordHash.Location = new System.Drawing.Point(421, 135);
            this.cboEmployeePasswordHash.Name = "cboEmployeePasswordHash";
            this.cboEmployeePasswordHash.Size = new System.Drawing.Size(121, 21);
            this.cboEmployeePasswordHash.TabIndex = 41;
            // 
            // cboEmployeeRole
            // 
            this.cboEmployeeRole.FormattingEnabled = true;
            this.cboEmployeeRole.Location = new System.Drawing.Point(421, 95);
            this.cboEmployeeRole.Name = "cboEmployeeRole";
            this.cboEmployeeRole.Size = new System.Drawing.Size(121, 21);
            this.cboEmployeeRole.TabIndex = 40;
            // 
            // btnEXITE
            // 
            this.btnEXITE.Location = new System.Drawing.Point(1159, 14);
            this.btnEXITE.Name = "btnEXITE";
            this.btnEXITE.Size = new System.Drawing.Size(75, 23);
            this.btnEXITE.TabIndex = 39;
            this.btnEXITE.Text = "EXIT";
            this.btnEXITE.UseVisualStyleBackColor = true;
            this.btnEXITE.Click += new System.EventHandler(this.btnEXITE_Click);
            // 
            // lbEmployeesID
            // 
            this.lbEmployeesID.AutoSize = true;
            this.lbEmployeesID.Location = new System.Drawing.Point(23, 22);
            this.lbEmployeesID.Name = "lbEmployeesID";
            this.lbEmployeesID.Size = new System.Drawing.Size(69, 13);
            this.lbEmployeesID.TabIndex = 21;
            this.lbEmployeesID.Text = "EmployeesID";
            // 
            // txtSEARCHE
            // 
            this.txtSEARCHE.Location = new System.Drawing.Point(421, 54);
            this.txtSEARCHE.Name = "txtSEARCHE";
            this.txtSEARCHE.Size = new System.Drawing.Size(230, 20);
            this.txtSEARCHE.TabIndex = 38;
            this.txtSEARCHE.TextChanged += new System.EventHandler(this.txtSEARCHE_TextChanged);
            // 
            // txtEmployeesID
            // 
            this.txtEmployeesID.Location = new System.Drawing.Point(117, 12);
            this.txtEmployeesID.Name = "txtEmployeesID";
            this.txtEmployeesID.Size = new System.Drawing.Size(230, 20);
            this.txtEmployeesID.TabIndex = 22;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(422, 9);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 23;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(813, 14);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(75, 23);
            this.btnCANCEL.TabIndex = 36;
            this.btnCANCEL.Text = "CANCEL";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(23, 54);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(81, 13);
            this.lbEmployeeName.TabIndex = 24;
            this.lbEmployeeName.Text = "EmployeeName";
            // 
            // lbEmployeePhone
            // 
            this.lbEmployeePhone.AutoSize = true;
            this.lbEmployeePhone.Location = new System.Drawing.Point(23, 95);
            this.lbEmployeePhone.Name = "lbEmployeePhone";
            this.lbEmployeePhone.Size = new System.Drawing.Size(84, 13);
            this.lbEmployeePhone.TabIndex = 25;
            this.lbEmployeePhone.Text = "EmployeePhone";
            // 
            // btnSAVE
            // 
            this.btnSAVE.Location = new System.Drawing.Point(701, 14);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(75, 23);
            this.btnSAVE.TabIndex = 34;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // lbEmployeeEmail
            // 
            this.lbEmployeeEmail.AutoSize = true;
            this.lbEmployeeEmail.Location = new System.Drawing.Point(23, 135);
            this.lbEmployeeEmail.Name = "lbEmployeeEmail";
            this.lbEmployeeEmail.Size = new System.Drawing.Size(78, 13);
            this.lbEmployeeEmail.TabIndex = 26;
            this.lbEmployeeEmail.Text = "EmployeeEmail";
            // 
            // btnMODIFY
            // 
            this.btnMODIFY.Location = new System.Drawing.Point(608, 12);
            this.btnMODIFY.Name = "btnMODIFY";
            this.btnMODIFY.Size = new System.Drawing.Size(75, 23);
            this.btnMODIFY.TabIndex = 33;
            this.btnMODIFY.Text = "MODIFY";
            this.btnMODIFY.UseVisualStyleBackColor = true;
            this.btnMODIFY.Click += new System.EventHandler(this.btnMODIFY_Click);
            // 
            // lbEmployeeAddress
            // 
            this.lbEmployeeAddress.AutoSize = true;
            this.lbEmployeeAddress.Location = new System.Drawing.Point(23, 169);
            this.lbEmployeeAddress.Name = "lbEmployeeAddress";
            this.lbEmployeeAddress.Size = new System.Drawing.Size(91, 13);
            this.lbEmployeeAddress.TabIndex = 27;
            this.lbEmployeeAddress.Text = "EmployeeAddress";
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(515, 9);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(75, 23);
            this.btnDELETE.TabIndex = 32;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(117, 51);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(230, 20);
            this.txtEmployeeName.TabIndex = 28;
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(117, 166);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(230, 20);
            this.txtEmployeeAddress.TabIndex = 31;
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Location = new System.Drawing.Point(117, 92);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(230, 20);
            this.txtEmployeePhone.TabIndex = 29;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Location = new System.Drawing.Point(117, 132);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(230, 20);
            this.txtEmployeeEmail.TabIndex = 30;
            // 
            // dgvEMPLOYEES
            // 
            this.dgvEMPLOYEES.AllowUserToAddRows = false;
            this.dgvEMPLOYEES.AllowUserToDeleteRows = false;
            this.dgvEMPLOYEES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEMPLOYEES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMPLOYEES.Location = new System.Drawing.Point(9, 262);
            this.dgvEMPLOYEES.Name = "dgvEMPLOYEES";
            this.dgvEMPLOYEES.ReadOnly = true;
            this.dgvEMPLOYEES.Size = new System.Drawing.Size(1263, 398);
            this.dgvEMPLOYEES.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1159, 54);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmEMPLOYEES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 659);
            this.Controls.Add(this.dgvEMPLOYEES);
            this.Controls.Add(this.panel1);
            this.Name = "frmEMPLOYEES";
            this.Text = "frmEMPLOYEES";
            this.Load += new System.EventHandler(this.frmEMPLOYEES_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMPLOYEES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEmployeesID;
        private System.Windows.Forms.TextBox txtSEARCHE;
        private System.Windows.Forms.TextBox txtEmployeesID;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label lbEmployeePhone;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Label lbEmployeeEmail;
        private System.Windows.Forms.Button btnMODIFY;
        private System.Windows.Forms.Label lbEmployeeAddress;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.DataGridView dgvEMPLOYEES;
        private System.Windows.Forms.Button btnEXITE;
        private System.Windows.Forms.ComboBox cboEmployeePasswordHash;
        private System.Windows.Forms.ComboBox cboEmployeeRole;
        private System.Windows.Forms.Button btnBack;
    }
}