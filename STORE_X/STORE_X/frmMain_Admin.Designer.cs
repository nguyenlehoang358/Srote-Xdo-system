namespace STORE_X
{
    partial class frmMain_Admin
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
            this.btnOlder = new System.Windows.Forms.Button();
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnRegisLogin = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnOlder);
            this.panel1.Controls.Add(this.btnStatic);
            this.panel1.Controls.Add(this.btnRegisLogin);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Location = new System.Drawing.Point(20, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 195);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(268, 42);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(268, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnOlder
            // 
            this.btnOlder.Location = new System.Drawing.Point(13, 158);
            this.btnOlder.Name = "btnOlder";
            this.btnOlder.Size = new System.Drawing.Size(130, 23);
            this.btnOlder.TabIndex = 5;
            this.btnOlder.Text = "OLDER";
            this.btnOlder.UseVisualStyleBackColor = true;
            this.btnOlder.Click += new System.EventHandler(this.btnOlder_Click);
            // 
            // btnStatic
            // 
            this.btnStatic.Location = new System.Drawing.Point(13, 129);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(130, 23);
            this.btnStatic.TabIndex = 4;
            this.btnStatic.Text = "STATIC";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // btnRegisLogin
            // 
            this.btnRegisLogin.Location = new System.Drawing.Point(13, 100);
            this.btnRegisLogin.Name = "btnRegisLogin";
            this.btnRegisLogin.Size = new System.Drawing.Size(130, 23);
            this.btnRegisLogin.TabIndex = 3;
            this.btnRegisLogin.Text = "REGISTER";
            this.btnRegisLogin.UseVisualStyleBackColor = true;
            this.btnRegisLogin.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(13, 71);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(130, 23);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(13, 42);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(130, 23);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "EMPLOYEE";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(13, 13);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(130, 23);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "CUSTOMER";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // frmMain_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 222);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain_Admin";
            this.Text = "frmMain_Admin";
            this.Load += new System.EventHandler(this.frmMain_Admin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOlder;
        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnRegisLogin;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnBack;
    }
}