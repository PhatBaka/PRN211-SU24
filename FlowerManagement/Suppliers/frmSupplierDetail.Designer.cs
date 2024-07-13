namespace FlowerManagement.Suppliers
{
    partial class frmSupplierDetail
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtSupplierId = new TextBox();
            txtSupplierName = new TextBox();
            txtSupplierAddress = new TextBox();
            txtTelephone = new TextBox();
            btnSave = new Button();
            lblTitle = new Label();
            lblSupplierId = new Label();
            lblSupplierName = new Label();
            lblSupplierAddress = new Label();
            lblTelephone = new Label();
            SuspendLayout();
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(159, 60);
            txtSupplierId.Margin = new Padding(2, 3, 2, 3);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.ReadOnly = true;
            txtSupplierId.Size = new Size(161, 27);
            txtSupplierId.TabIndex = 0;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(159, 100);
            txtSupplierName.Margin = new Padding(2, 3, 2, 3);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.PlaceholderText = "Supplier Name";
            txtSupplierName.Size = new Size(161, 27);
            txtSupplierName.TabIndex = 2;
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(159, 140);
            txtSupplierAddress.Margin = new Padding(2, 3, 2, 3);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.PlaceholderText = "Supplier Address";
            txtSupplierAddress.Size = new Size(161, 27);
            txtSupplierAddress.TabIndex = 3;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(159, 180);
            txtTelephone.Margin = new Padding(2, 3, 2, 3);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.PlaceholderText = "Telephone";
            txtTelephone.Size = new Size(161, 27);
            txtTelephone.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 220);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(120, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 32);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "Create/Update";
            // 
            // lblSupplierId
            // 
            lblSupplierId.AutoSize = true;
            lblSupplierId.Location = new Point(20, 63);
            lblSupplierId.Name = "lblSupplierId";
            lblSupplierId.Size = new Size(83, 20);
            lblSupplierId.TabIndex = 1;
            lblSupplierId.Text = "Supplier ID";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(20, 103);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(108, 20);
            lblSupplierName.TabIndex = 3;
            lblSupplierName.Text = "Supplier Name";
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.Location = new Point(20, 143);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(121, 20);
            lblSupplierAddress.TabIndex = 5;
            lblSupplierAddress.Text = "Supplier Address";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(20, 183);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(78, 20);
            lblTelephone.TabIndex = 7;
            lblTelephone.Text = "Telephone";
            // 
            // frmSupplierDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 270);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(txtTelephone);
            Controls.Add(txtSupplierAddress);
            Controls.Add(txtSupplierName);
            Controls.Add(txtSupplierId);
            Controls.Add(lblTelephone);
            Controls.Add(lblSupplierAddress);
            Controls.Add(lblSupplierName);
            Controls.Add(lblSupplierId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmSupplierDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier Details";
            Load += frmSupplierDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblTelephone;
    }
}
