namespace FlowerManagement.Suppliers
{
    partial class frmSupplier
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
            dgvSuppliers = new DataGridView();
            txtSupplierId = new TextBox();
            txtSupplierName = new TextBox();
            txtSupplierAddress = new TextBox();
            txtTelephone = new TextBox();
            btnCreate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            lblTitle = new Label();
            lblSupplierId = new Label();
            lblSupplierName = new Label();
            lblSupplierAddress = new Label();
            lblTelephone = new Label();
            txtSearchName = new TextBox();
            btnSearchByName = new Button();
            btnSearchById = new Button();
            txtSearchId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AllowUserToDeleteRows = false;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(12, 54);
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.RowTemplate.Height = 29;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(776, 334);
            dgvSuppliers.TabIndex = 0;
            dgvSuppliers.CellDoubleClick += dgvSuppliers_CellDoubleClick;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(135, 400);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.ReadOnly = true;
            txtSupplierId.Size = new Size(125, 27);
            txtSupplierId.TabIndex = 1;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(135, 433);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(250, 27);
            txtSupplierName.TabIndex = 2;
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(135, 466);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(250, 27);
            txtSupplierAddress.TabIndex = 3;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(135, 499);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(250, 27);
            txtTelephone.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 536);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(112, 536);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(212, 536);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 32);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Supplier Details";
            // 
            // lblSupplierId
            // 
            lblSupplierId.AutoSize = true;
            lblSupplierId.Location = new Point(12, 407);
            lblSupplierId.Name = "lblSupplierId";
            lblSupplierId.Size = new Size(81, 20);
            lblSupplierId.TabIndex = 9;
            lblSupplierId.Text = "Supplier Id";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(12, 440);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(108, 20);
            lblSupplierName.TabIndex = 10;
            lblSupplierName.Text = "Supplier Name";
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.Location = new Point(12, 473);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(121, 20);
            lblSupplierAddress.TabIndex = 11;
            lblSupplierAddress.Text = "Supplier Address";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(12, 506);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(78, 20);
            lblTelephone.TabIndex = 12;
            lblTelephone.Text = "Telephone";
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(417, 400);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(200, 27);
            txtSearchName.TabIndex = 13;
            // 
            // btnSearchByName
            // 
            btnSearchByName.Location = new Point(623, 398);
            btnSearchByName.Name = "btnSearchByName";
            btnSearchByName.Size = new Size(176, 29);
            btnSearchByName.TabIndex = 14;
            btnSearchByName.Text = "Search By Name";
            btnSearchByName.UseVisualStyleBackColor = true;
            btnSearchByName.Click += btnSearchByName_Click;
            // 
            // btnSearchById
            // 
            btnSearchById.Location = new Point(623, 435);
            btnSearchById.Name = "btnSearchById";
            btnSearchById.Size = new Size(176, 29);
            btnSearchById.TabIndex = 16;
            btnSearchById.Text = "Search By ID";
            btnSearchById.UseVisualStyleBackColor = true;
            btnSearchById.Click += btnSearchById_Click;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(417, 437);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new Size(200, 27);
            txtSearchId.TabIndex = 15;
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(btnSearchById);
            Controls.Add(txtSearchId);
            Controls.Add(btnSearchByName);
            Controls.Add(txtSearchName);
            Controls.Add(lblTelephone);
            Controls.Add(lblSupplierAddress);
            Controls.Add(lblSupplierName);
            Controls.Add(lblSupplierId);
            Controls.Add(lblTitle);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(txtTelephone);
            Controls.Add(txtSupplierAddress);
            Controls.Add(txtSupplierName);
            Controls.Add(txtSupplierId);
            Controls.Add(dgvSuppliers);
            Name = "frmSupplier";
            Text = "Supplier Management";
            Load += frmSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchByName;
        private Button btnSearchById;
        private TextBox txtSearchId;
    }
}
