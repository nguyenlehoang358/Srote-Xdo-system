namespace STORE_X
{
    partial class frmPRODUCTS
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
            this.dgvPEODUCTS = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtChoose = new System.Windows.Forms.Button();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.txtSEARCHP = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.lbProductName = new System.Windows.Forms.Label();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.lbProductCompany = new System.Windows.Forms.Label();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.lbProductPrice = new System.Windows.Forms.Label();
            this.btnMODIFY = new System.Windows.Forms.Button();
            this.lbProductQuatity = new System.Windows.Forms.Label();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductQuatity = new System.Windows.Forms.TextBox();
            this.txtProductCompany = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPEODUCTS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPEODUCTS
            // 
            this.dgvPEODUCTS.AllowUserToAddRows = false;
            this.dgvPEODUCTS.AllowUserToDeleteRows = false;
            this.dgvPEODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPEODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPEODUCTS.Location = new System.Drawing.Point(4, 233);
            this.dgvPEODUCTS.Name = "dgvPEODUCTS";
            this.dgvPEODUCTS.ReadOnly = true;
            this.dgvPEODUCTS.Size = new System.Drawing.Size(1249, 408);
            this.dgvPEODUCTS.TabIndex = 0;
            this.dgvPEODUCTS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPEODUCTS_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.txtChoose);
            this.panel1.Controls.Add(this.pbProductImage);
            this.panel1.Controls.Add(this.lbProductID);
            this.panel1.Controls.Add(this.txtSEARCHP);
            this.panel1.Controls.Add(this.txtProductID);
            this.panel1.Controls.Add(this.btnADD);
            this.panel1.Controls.Add(this.btnCANCEL);
            this.panel1.Controls.Add(this.lbProductName);
            this.panel1.Controls.Add(this.btnEXIT);
            this.panel1.Controls.Add(this.lbProductCompany);
            this.panel1.Controls.Add(this.btnSAVE);
            this.panel1.Controls.Add(this.lbProductPrice);
            this.panel1.Controls.Add(this.btnMODIFY);
            this.panel1.Controls.Add(this.lbProductQuatity);
            this.panel1.Controls.Add(this.btnDELETE);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.txtProductQuatity);
            this.panel1.Controls.Add(this.txtProductCompany);
            this.panel1.Controls.Add(this.txtProductPrice);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 230);
            this.panel1.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(431, 105);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 82;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(710, 186);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 81;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtChoose
            // 
            this.txtChoose.Location = new System.Drawing.Point(710, 145);
            this.txtChoose.Name = "txtChoose";
            this.txtChoose.Size = new System.Drawing.Size(75, 23);
            this.txtChoose.TabIndex = 80;
            this.txtChoose.Text = "Choose";
            this.txtChoose.UseVisualStyleBackColor = true;
            this.txtChoose.Click += new System.EventHandler(this.txtChoose_Click);
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbProductImage.Location = new System.Drawing.Point(833, 9);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(399, 200);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductImage.TabIndex = 76;
            this.pbProductImage.TabStop = false;
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(32, 32);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(55, 13);
            this.lbProductID.TabIndex = 59;
            this.lbProductID.Text = "ProductID";
            // 
            // txtSEARCHP
            // 
            this.txtSEARCHP.Location = new System.Drawing.Point(430, 64);
            this.txtSEARCHP.Name = "txtSEARCHP";
            this.txtSEARCHP.Size = new System.Drawing.Size(230, 20);
            this.txtSEARCHP.TabIndex = 75;
            this.txtSEARCHP.TextChanged += new System.EventHandler(this.txtSEARCHP_TextChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(126, 22);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(230, 20);
            this.txtProductID.TabIndex = 60;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(431, 19);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 61;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(710, 64);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(75, 23);
            this.btnCANCEL.TabIndex = 74;
            this.btnCANCEL.Text = "CANCEL";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(32, 64);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(72, 13);
            this.lbProductName.TabIndex = 62;
            this.lbProductName.Text = "ProductName";
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(710, 105);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(75, 23);
            this.btnEXIT.TabIndex = 73;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // lbProductCompany
            // 
            this.lbProductCompany.AutoSize = true;
            this.lbProductCompany.Location = new System.Drawing.Point(32, 105);
            this.lbProductCompany.Name = "lbProductCompany";
            this.lbProductCompany.Size = new System.Drawing.Size(88, 13);
            this.lbProductCompany.TabIndex = 63;
            this.lbProductCompany.Text = "ProductCompany";
            // 
            // btnSAVE
            // 
            this.btnSAVE.Location = new System.Drawing.Point(710, 24);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(75, 23);
            this.btnSAVE.TabIndex = 72;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = true;
            // 
            // lbProductPrice
            // 
            this.lbProductPrice.AutoSize = true;
            this.lbProductPrice.Location = new System.Drawing.Point(32, 145);
            this.lbProductPrice.Name = "lbProductPrice";
            this.lbProductPrice.Size = new System.Drawing.Size(68, 13);
            this.lbProductPrice.TabIndex = 64;
            this.lbProductPrice.Text = "ProductPrice";
            // 
            // btnMODIFY
            // 
            this.btnMODIFY.Location = new System.Drawing.Point(617, 22);
            this.btnMODIFY.Name = "btnMODIFY";
            this.btnMODIFY.Size = new System.Drawing.Size(75, 23);
            this.btnMODIFY.TabIndex = 71;
            this.btnMODIFY.Text = "MODIFY";
            this.btnMODIFY.UseVisualStyleBackColor = true;
            this.btnMODIFY.Click += new System.EventHandler(this.btnMODIFY_Click);
            // 
            // lbProductQuatity
            // 
            this.lbProductQuatity.AutoSize = true;
            this.lbProductQuatity.Location = new System.Drawing.Point(32, 179);
            this.lbProductQuatity.Name = "lbProductQuatity";
            this.lbProductQuatity.Size = new System.Drawing.Size(77, 13);
            this.lbProductQuatity.TabIndex = 65;
            this.lbProductQuatity.Text = "ProductQuatity";
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(524, 19);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(75, 23);
            this.btnDELETE.TabIndex = 70;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(126, 61);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(230, 20);
            this.txtProductName.TabIndex = 66;
            // 
            // txtProductQuatity
            // 
            this.txtProductQuatity.Location = new System.Drawing.Point(126, 176);
            this.txtProductQuatity.Name = "txtProductQuatity";
            this.txtProductQuatity.Size = new System.Drawing.Size(230, 20);
            this.txtProductQuatity.TabIndex = 69;
            // 
            // txtProductCompany
            // 
            this.txtProductCompany.Location = new System.Drawing.Point(126, 102);
            this.txtProductCompany.Name = "txtProductCompany";
            this.txtProductCompany.Size = new System.Drawing.Size(230, 20);
            this.txtProductCompany.TabIndex = 67;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(126, 142);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(230, 20);
            this.txtProductPrice.TabIndex = 68;
            // 
            // frmPRODUCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPEODUCTS);
            this.Name = "frmPRODUCTS";
            this.Text = "frmPRODUCTS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPEODUCTS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPEODUCTS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.TextBox txtSEARCHP;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label lbProductCompany;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Label lbProductPrice;
        private System.Windows.Forms.Button btnMODIFY;
        private System.Windows.Forms.Label lbProductQuatity;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductQuatity;
        private System.Windows.Forms.TextBox txtProductCompany;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Button txtChoose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
    }
}