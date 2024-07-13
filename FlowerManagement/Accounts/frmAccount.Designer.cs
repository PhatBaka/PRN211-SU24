namespace FlowerManagement.Customers
{
    partial class frmAccount
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
            dgvCustomer = new DataGridView();
            txtCustomerId = new TextBox();
            txtCustomerName = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            txtCustomerStatus = new TextBox();
            txtPoint = new TextBox();
            btnCreate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            txtSearchId = new TextBox();
            lblCustomerId = new Label();
            lblCustomerName = new Label();
            lblEmail = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            lblPassword = new Label();
            lblCustomerStatus = new Label();
            lblPoint = new Label();
            btnSearchById = new Button();
            txtSearchEmail = new TextBox();
            btnSearchByEmail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(10, 12);
            dgvCustomer.Margin = new Padding(2, 3, 2, 3);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(608, 250);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellDoubleClick += dgvCustomer_CellDoubleClick;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(141, 284);
            txtCustomerId.Margin = new Padding(2, 3, 2, 3);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.ReadOnly = true;
            txtCustomerId.Size = new Size(161, 27);
            txtCustomerId.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(141, 317);
            txtCustomerName.Margin = new Padding(2, 3, 2, 3);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Customer Name";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(161, 27);
            txtCustomerName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 350);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(161, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(141, 383);
            txtCity.Margin = new Padding(2, 3, 2, 3);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "City";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(161, 27);
            txtCity.TabIndex = 4;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(141, 416);
            txtCountry.Margin = new Padding(2, 3, 2, 3);
            txtCountry.Name = "txtCountry";
            txtCountry.PlaceholderText = "Country";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(161, 27);
            txtCountry.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(141, 449);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(161, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtCustomerStatus
            // 
            txtCustomerStatus.Location = new Point(141, 482);
            txtCustomerStatus.Margin = new Padding(2, 3, 2, 3);
            txtCustomerStatus.Name = "txtCustomerStatus";
            txtCustomerStatus.PlaceholderText = "Customer Status";
            txtCustomerStatus.ReadOnly = true;
            txtCustomerStatus.Size = new Size(161, 27);
            txtCustomerStatus.TabIndex = 7;
            // 
            // txtPoint
            // 
            txtPoint.Location = new Point(141, 515);
            txtPoint.Margin = new Padding(2, 3, 2, 3);
            txtPoint.Name = "txtPoint";
            txtPoint.PlaceholderText = "Points";
            txtPoint.ReadOnly = true;
            txtPoint.Size = new Size(161, 27);
            txtPoint.TabIndex = 8;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(330, 287);
            btnCreate.Margin = new Padding(2, 3, 2, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(80, 29);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(330, 322);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(330, 357);
            btnLoad.Margin = new Padding(2, 3, 2, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(80, 29);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(330, 412);
            txtSearchId.Margin = new Padding(2, 3, 2, 3);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.PlaceholderText = "ID";
            txtSearchId.Size = new Size(161, 27);
            txtSearchId.TabIndex = 12;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(10, 287);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(91, 20);
            lblCustomerId.TabIndex = 13;
            lblCustomerId.Text = "Customer ID";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(10, 320);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(116, 20);
            lblCustomerName.TabIndex = 14;
            lblCustomerName.Text = "Customer Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 353);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(10, 386);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 20);
            lblCity.TabIndex = 16;
            lblCity.Text = "City";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(10, 419);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(60, 20);
            lblCountry.TabIndex = 17;
            lblCountry.Text = "Country";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(10, 452);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 18;
            lblPassword.Text = "Password";
            // 
            // lblCustomerStatus
            // 
            lblCustomerStatus.AutoSize = true;
            lblCustomerStatus.Location = new Point(10, 485);
            lblCustomerStatus.Name = "lblCustomerStatus";
            lblCustomerStatus.Size = new Size(116, 20);
            lblCustomerStatus.TabIndex = 19;
            lblCustomerStatus.Text = "Customer Status";
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Location = new Point(10, 518);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(48, 20);
            lblPoint.TabIndex = 20;
            lblPoint.Text = "Points";
            // 
            // btnSearchById
            // 
            btnSearchById.Location = new Point(507, 410);
            btnSearchById.Margin = new Padding(2, 3, 2, 3);
            btnSearchById.Name = "btnSearchById";
            btnSearchById.Size = new Size(80, 29);
            btnSearchById.TabIndex = 21;
            btnSearchById.Text = "Search";
            btnSearchById.UseVisualStyleBackColor = true;
            btnSearchById.Click += btnSearchById_Click;
            // 
            // txtSearchEmail
            // 
            txtSearchEmail.Location = new Point(330, 452);
            txtSearchEmail.Margin = new Padding(2, 3, 2, 3);
            txtSearchEmail.Name = "txtSearchEmail";
            txtSearchEmail.PlaceholderText = "Email";
            txtSearchEmail.Size = new Size(161, 27);
            txtSearchEmail.TabIndex = 22;
            // 
            // btnSearchByEmail
            // 
            btnSearchByEmail.Location = new Point(507, 452);
            btnSearchByEmail.Margin = new Padding(2, 3, 2, 3);
            btnSearchByEmail.Name = "btnSearchByEmail";
            btnSearchByEmail.Size = new Size(80, 29);
            btnSearchByEmail.TabIndex = 23;
            btnSearchByEmail.Text = "Search";
            btnSearchByEmail.UseVisualStyleBackColor = true;
            btnSearchByEmail.Click += btnSearchByEmail_Click;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 600);
            Controls.Add(btnSearchByEmail);
            Controls.Add(txtSearchEmail);
            Controls.Add(btnSearchById);
            Controls.Add(txtSearchId);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(txtPoint);
            Controls.Add(txtCustomerStatus);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerId);
            Controls.Add(lblPoint);
            Controls.Add(lblCustomerStatus);
            Controls.Add(lblPassword);
            Controls.Add(lblCountry);
            Controls.Add(lblCity);
            Controls.Add(lblEmail);
            Controls.Add(lblCustomerName);
            Controls.Add(lblCustomerId);
            Controls.Add(dgvCustomer);
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Management";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCustomerStatus;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtSearchId;

        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCustomerStatus;
        private System.Windows.Forms.Label lblPoint;
        private Button btnSearchById;
        private TextBox txtSearchEmail;
        private Button btnSearchByEmail;
    }
}
