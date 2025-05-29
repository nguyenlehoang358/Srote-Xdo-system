namespace STORE_X
{
    partial class frmORDER
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboCustomerID = new System.Windows.Forms.ComboBox();
            this.cboEmployeesID = new System.Windows.Forms.ComboBox();
            this.dtOrderSoldDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lbCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lbCustomerPhone = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbEmployeesID = new System.Windows.Forms.Label();
            this.lbOrderSoldDate = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboProductID = new System.Windows.Forms.ComboBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.lbOrderTotal = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lbProductPrice = new System.Windows.Forms.Label();
            this.txtProductQuatity = new System.Windows.Forms.TextBox();
            this.lbProductQuatity = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.dgvORDER = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDER)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.cboCustomerID);
            this.panel1.Controls.Add(this.cboEmployeesID);
            this.panel1.Controls.Add(this.dtOrderSoldDate);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtCustomerAddress);
            this.panel1.Controls.Add(this.lbCustomerAddress);
            this.panel1.Controls.Add(this.txtCustomerPhone);
            this.panel1.Controls.Add(this.lbCustomerPhone);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.lbCustomerName);
            this.panel1.Controls.Add(this.lbCustomerID);
            this.panel1.Controls.Add(this.txtEmployeeName);
            this.panel1.Controls.Add(this.lbEmployeeName);
            this.panel1.Controls.Add(this.lbEmployeesID);
            this.panel1.Controls.Add(this.lbOrderSoldDate);
            this.panel1.Controls.Add(this.txtOrderID);
            this.panel1.Controls.Add(this.lbOrderID);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 192);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1100, 113);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1100, 66);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboCustomerID
            // 
            this.cboCustomerID.FormattingEnabled = true;
            this.cboCustomerID.Location = new System.Drawing.Point(487, 19);
            this.cboCustomerID.Name = "cboCustomerID";
            this.cboCustomerID.Size = new System.Drawing.Size(219, 21);
            this.cboCustomerID.TabIndex = 23;
            // 
            // cboEmployeesID
            // 
            this.cboEmployeesID.FormattingEnabled = true;
            this.cboEmployeesID.Location = new System.Drawing.Point(146, 106);
            this.cboEmployeesID.Name = "cboEmployeesID";
            this.cboEmployeesID.Size = new System.Drawing.Size(219, 21);
            this.cboEmployeesID.TabIndex = 22;
            // 
            // dtOrderSoldDate
            // 
            this.dtOrderSoldDate.Location = new System.Drawing.Point(146, 59);
            this.dtOrderSoldDate.Name = "dtOrderSoldDate";
            this.dtOrderSoldDate.Size = new System.Drawing.Size(219, 20);
            this.dtOrderSoldDate.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1100, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1004, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(905, 16);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "MODIFY";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(807, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(715, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(487, 152);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(219, 20);
            this.txtCustomerAddress.TabIndex = 15;
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.AutoSize = true;
            this.lbCustomerAddress.Location = new System.Drawing.Point(387, 159);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(89, 13);
            this.lbCustomerAddress.TabIndex = 14;
            this.lbCustomerAddress.Text = "CustomerAddress";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(487, 106);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(219, 20);
            this.txtCustomerPhone.TabIndex = 13;
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.AutoSize = true;
            this.lbCustomerPhone.Location = new System.Drawing.Point(387, 113);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(82, 13);
            this.lbCustomerPhone.TabIndex = 12;
            this.lbCustomerPhone.Text = "CustomerPhone";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(487, 59);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(219, 20);
            this.txtCustomerName.TabIndex = 11;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(387, 66);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(79, 13);
            this.lbCustomerName.TabIndex = 10;
            this.lbCustomerName.Text = "CustomerName";
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Location = new System.Drawing.Point(387, 26);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(62, 13);
            this.lbCustomerID.TabIndex = 8;
            this.lbCustomerID.Text = "CustomerID";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(146, 152);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(219, 20);
            this.txtEmployeeName.TabIndex = 7;
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(48, 152);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(81, 13);
            this.lbEmployeeName.TabIndex = 6;
            this.lbEmployeeName.Text = "EmployeeName";
            // 
            // lbEmployeesID
            // 
            this.lbEmployeesID.AutoSize = true;
            this.lbEmployeesID.Location = new System.Drawing.Point(48, 109);
            this.lbEmployeesID.Name = "lbEmployeesID";
            this.lbEmployeesID.Size = new System.Drawing.Size(69, 13);
            this.lbEmployeesID.TabIndex = 4;
            this.lbEmployeesID.Text = "EmployeesID";
            // 
            // lbOrderSoldDate
            // 
            this.lbOrderSoldDate.AutoSize = true;
            this.lbOrderSoldDate.Location = new System.Drawing.Point(48, 62);
            this.lbOrderSoldDate.Name = "lbOrderSoldDate";
            this.lbOrderSoldDate.Size = new System.Drawing.Size(77, 13);
            this.lbOrderSoldDate.TabIndex = 2;
            this.lbOrderSoldDate.Text = "OrderSoldDate";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(146, 19);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(219, 20);
            this.txtOrderID.TabIndex = 1;
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(48, 22);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(44, 13);
            this.lbOrderID.TabIndex = 0;
            this.lbOrderID.Text = "OrderID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboProductID);
            this.panel2.Controls.Add(this.txtOrderTotal);
            this.panel2.Controls.Add(this.lbOrderTotal);
            this.panel2.Controls.Add(this.txtProductPrice);
            this.panel2.Controls.Add(this.lbProductPrice);
            this.panel2.Controls.Add(this.txtProductQuatity);
            this.panel2.Controls.Add(this.lbProductQuatity);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.lbProductName);
            this.panel2.Controls.Add(this.lbProductID);
            this.panel2.Location = new System.Drawing.Point(1, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 104);
            this.panel2.TabIndex = 1;
            // 
            // cboProductID
            // 
            this.cboProductID.FormattingEnabled = true;
            this.cboProductID.Location = new System.Drawing.Point(146, 14);
            this.cboProductID.Name = "cboProductID";
            this.cboProductID.Size = new System.Drawing.Size(219, 21);
            this.cboProductID.TabIndex = 28;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(849, 21);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(219, 20);
            this.txtOrderTotal.TabIndex = 25;
            // 
            // lbOrderTotal
            // 
            this.lbOrderTotal.AutoSize = true;
            this.lbOrderTotal.Location = new System.Drawing.Point(749, 24);
            this.lbOrderTotal.Name = "lbOrderTotal";
            this.lbOrderTotal.Size = new System.Drawing.Size(57, 13);
            this.lbOrderTotal.TabIndex = 24;
            this.lbOrderTotal.Text = "OrderTotal";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(487, 67);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(219, 20);
            this.txtProductPrice.TabIndex = 23;
            // 
            // lbProductPrice
            // 
            this.lbProductPrice.AutoSize = true;
            this.lbProductPrice.Location = new System.Drawing.Point(387, 70);
            this.lbProductPrice.Name = "lbProductPrice";
            this.lbProductPrice.Size = new System.Drawing.Size(68, 13);
            this.lbProductPrice.TabIndex = 22;
            this.lbProductPrice.Text = "ProductPrice";
            // 
            // txtProductQuatity
            // 
            this.txtProductQuatity.Location = new System.Drawing.Point(487, 18);
            this.txtProductQuatity.Name = "txtProductQuatity";
            this.txtProductQuatity.Size = new System.Drawing.Size(219, 20);
            this.txtProductQuatity.TabIndex = 21;
            // 
            // lbProductQuatity
            // 
            this.lbProductQuatity.AutoSize = true;
            this.lbProductQuatity.Location = new System.Drawing.Point(387, 21);
            this.lbProductQuatity.Name = "lbProductQuatity";
            this.lbProductQuatity.Size = new System.Drawing.Size(77, 13);
            this.lbProductQuatity.TabIndex = 20;
            this.lbProductQuatity.Text = "ProductQuatity";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(146, 63);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(219, 20);
            this.txtProductName.TabIndex = 19;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(48, 66);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(72, 13);
            this.lbProductName.TabIndex = 18;
            this.lbProductName.Text = "ProductName";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(48, 17);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(55, 13);
            this.lbProductID.TabIndex = 16;
            this.lbProductID.Text = "ProductID";
            // 
            // dgvORDER
            // 
            this.dgvORDER.AllowUserToAddRows = false;
            this.dgvORDER.AllowUserToDeleteRows = false;
            this.dgvORDER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvORDER.Location = new System.Drawing.Point(1, 318);
            this.dgvORDER.Name = "dgvORDER";
            this.dgvORDER.ReadOnly = true;
            this.dgvORDER.Size = new System.Drawing.Size(1205, 271);
            this.dgvORDER.TabIndex = 2;
            // 
            // frmORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 601);
            this.Controls.Add(this.dgvORDER);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmORDER";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lbCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lbCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label lbEmployeesID;
        private System.Windows.Forms.Label lbOrderSoldDate;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.DataGridView dgvORDER;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lbProductPrice;
        private System.Windows.Forms.TextBox txtProductQuatity;
        private System.Windows.Forms.Label lbProductQuatity;
        private System.Windows.Forms.DateTimePicker dtOrderSoldDate;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label lbOrderTotal;
        private System.Windows.Forms.ComboBox cboCustomerID;
        private System.Windows.Forms.ComboBox cboEmployeesID;
        private System.Windows.Forms.ComboBox cboProductID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}