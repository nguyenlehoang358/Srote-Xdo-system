namespace STORE_X
{
    partial class frmCUSTOMERS
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
            this.dgvCUSTOMER = new System.Windows.Forms.DataGridView();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.txtSEARCHC = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.lbCustomerPhone = new System.Windows.Forms.Label();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.lbCustomerEmail = new System.Windows.Forms.Label();
            this.btnMODIFY = new System.Windows.Forms.Button();
            this.lbCustomerAddress = new System.Windows.Forms.Label();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUSTOMER)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.dgvCUSTOMER);
            this.panel1.Controls.Add(this.lbCustomerID);
            this.panel1.Controls.Add(this.txtSEARCHC);
            this.panel1.Controls.Add(this.txtCustomerID);
            this.panel1.Controls.Add(this.btnADD);
            this.panel1.Controls.Add(this.btnCANCEL);
            this.panel1.Controls.Add(this.lbCustomerName);
            this.panel1.Controls.Add(this.btnEXIT);
            this.panel1.Controls.Add(this.lbCustomerPhone);
            this.panel1.Controls.Add(this.btnSAVE);
            this.panel1.Controls.Add(this.lbCustomerEmail);
            this.panel1.Controls.Add(this.btnMODIFY);
            this.panel1.Controls.Add(this.lbCustomerAddress);
            this.panel1.Controls.Add(this.btnDELETE);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.txtCustomerAddress);
            this.panel1.Controls.Add(this.txtCustomerPhone);
            this.panel1.Controls.Add(this.txtCustomerEmail);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 627);
            this.panel1.TabIndex = 0;
            // 
            // dgvCUSTOMER
            // 
            this.dgvCUSTOMER.AllowUserToAddRows = false;
            this.dgvCUSTOMER.AllowUserToDeleteRows = false;
            this.dgvCUSTOMER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCUSTOMER.Location = new System.Drawing.Point(22, 204);
            this.dgvCUSTOMER.Name = "dgvCUSTOMER";
            this.dgvCUSTOMER.ReadOnly = true;
            this.dgvCUSTOMER.Size = new System.Drawing.Size(1117, 410);
            this.dgvCUSTOMER.TabIndex = 60;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(14, 23);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(62, 13);
            this.lbCustomerID.TabIndex = 42;
            this.lbCustomerID.Text = "CustomerID";
            // 
            // txtSEARCHC
            // 
            this.txtSEARCHC.Location = new System.Drawing.Point(412, 55);
            this.txtSEARCHC.Name = "txtSEARCHC";
            this.txtSEARCHC.Size = new System.Drawing.Size(230, 20);
            this.txtSEARCHC.TabIndex = 58;
            this.txtSEARCHC.TextChanged += new System.EventHandler(this.txtSEARCHC_TextChanged);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(108, 13);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(230, 20);
            this.txtCustomerID.TabIndex = 43;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(413, 10);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 44;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(804, 15);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(75, 23);
            this.btnCANCEL.TabIndex = 57;
            this.btnCANCEL.Text = "CANCEL";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(14, 55);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(79, 13);
            this.lbCustomerName.TabIndex = 45;
            this.lbCustomerName.Text = "CustomerName";
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(1053, 15);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(57, 23);
            this.btnEXIT.TabIndex = 56;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.AutoSize = true;
            this.lbCustomerPhone.Location = new System.Drawing.Point(14, 96);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(82, 13);
            this.lbCustomerPhone.TabIndex = 46;
            this.lbCustomerPhone.Text = "CustomerPhone";
            // 
            // btnSAVE
            // 
            this.btnSAVE.Location = new System.Drawing.Point(692, 15);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(75, 23);
            this.btnSAVE.TabIndex = 55;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // lbCustomerEmail
            // 
            this.lbCustomerEmail.AutoSize = true;
            this.lbCustomerEmail.Location = new System.Drawing.Point(14, 136);
            this.lbCustomerEmail.Name = "lbCustomerEmail";
            this.lbCustomerEmail.Size = new System.Drawing.Size(76, 13);
            this.lbCustomerEmail.TabIndex = 47;
            this.lbCustomerEmail.Text = "CustomerEmail";
            // 
            // btnMODIFY
            // 
            this.btnMODIFY.Location = new System.Drawing.Point(599, 13);
            this.btnMODIFY.Name = "btnMODIFY";
            this.btnMODIFY.Size = new System.Drawing.Size(75, 23);
            this.btnMODIFY.TabIndex = 54;
            this.btnMODIFY.Text = "MODIFY";
            this.btnMODIFY.UseVisualStyleBackColor = true;
            this.btnMODIFY.Click += new System.EventHandler(this.btnMODIFY_Click);
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.AutoSize = true;
            this.lbCustomerAddress.Location = new System.Drawing.Point(14, 170);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(89, 13);
            this.lbCustomerAddress.TabIndex = 48;
            this.lbCustomerAddress.Text = "CustomerAddress";
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(506, 10);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(75, 23);
            this.btnDELETE.TabIndex = 53;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(108, 52);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(230, 20);
            this.txtCustomerName.TabIndex = 49;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(108, 167);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(230, 20);
            this.txtCustomerAddress.TabIndex = 52;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(108, 93);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(230, 20);
            this.txtCustomerPhone.TabIndex = 50;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(108, 133);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(230, 20);
            this.txtCustomerEmail.TabIndex = 51;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1035, 49);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 61;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCUSTOMERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 624);
            this.Controls.Add(this.panel1);
            this.Name = "frmCUSTOMERS";
            this.Text = "frmCUSTOMERS";
            this.Load += new System.EventHandler(this.frmCUSTOMERS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUSTOMER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.TextBox txtSEARCHC;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label lbCustomerPhone;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Label lbCustomerEmail;
        private System.Windows.Forms.Button btnMODIFY;
        private System.Windows.Forms.Label lbCustomerAddress;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.DataGridView dgvCUSTOMER;
        private System.Windows.Forms.Button btnBack;
    }
}