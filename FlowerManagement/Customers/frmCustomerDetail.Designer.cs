namespace FlowerManagement.Customers
{
    partial class frmCustomerDetail
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
            txtCustomerId = new TextBox();
            txtCustomerName = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            txtCustomerStatus = new TextBox();
            txtPoint = new TextBox();
            btnSave = new Button();
            lblTitle = new Label();
            lblCustomerId = new Label();
            lblCustomerName = new Label();
            lblEmail = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            lblPassword = new Label();
            lblCustomerStatus = new Label();
            lblPoint = new Label();

            SuspendLayout();
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(120, 60);
            txtCustomerId.Margin = new Padding(2, 3, 2, 3);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.ReadOnly = true;
            txtCustomerId.Size = new Size(161, 27);
            txtCustomerId.TabIndex = 0;
            txtCustomerId.Visible = false;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(20, 63);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(85, 20);
            lblCustomerId.TabIndex = 1;
            lblCustomerId.Text = "Customer ID";
            lblCustomerId.Visible = false;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(120, 100);
            txtCustomerName.Margin = new Padding(2, 3, 2, 3);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Customer Name";
            txtCustomerName.Size = new Size(161, 27);
            txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(20, 103);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(114, 20);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "Customer Name";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 140);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(161, 27);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 143);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(120, 180);
            txtCity.Margin = new Padding(2, 3, 2, 3);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "City";
            txtCity.Size = new Size(161, 27);
            txtCity.TabIndex = 4;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(20, 183);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 20);
            lblCity.TabIndex = 7;
            lblCity.Text = "City";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(120, 220);
            txtCountry.Margin = new Padding(2, 3, 2, 3);
            txtCountry.Name = "txtCountry";
            txtCountry.PlaceholderText = "Country";
            txtCountry.Size = new Size(161, 27);
            txtCountry.TabIndex = 5;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(20, 223);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(63, 20);
            lblCountry.TabIndex = 9;
            lblCountry.Text = "Country";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 260);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(161, 27);
            txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 263);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 20);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // txtCustomerStatus
            // 
            txtCustomerStatus.Location = new Point(120, 300);
            txtCustomerStatus.Margin = new Padding(2, 3, 2, 3);
            txtCustomerStatus.Name = "txtCustomerStatus";
            txtCustomerStatus.PlaceholderText = "Customer Status";
            txtCustomerStatus.Size = new Size(161, 27);
            txtCustomerStatus.TabIndex = 7;
            // 
            // lblCustomerStatus
            // 
            lblCustomerStatus.AutoSize = true;
            lblCustomerStatus.Location = new Point(20, 303);
            lblCustomerStatus.Name = "lblCustomerStatus";
            lblCustomerStatus.Size = new Size(119, 20);
            lblCustomerStatus.TabIndex = 13;
            lblCustomerStatus.Text = "Customer Status";
            // 
            // txtPoint
            // 
            txtPoint.Location = new Point(120, 340);
            txtPoint.Margin = new Padding(2, 3, 2, 3);
            txtPoint.Name = "txtPoint";
            txtPoint.PlaceholderText = "Points";
            txtPoint.Size = new Size(161, 27);
            txtPoint.TabIndex = 8;
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Location = new Point(20, 343);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(41, 20);
            lblPoint.TabIndex = 15;
            lblPoint.Text = "Points";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 380);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 9;
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
            lblTitle.Size = new Size(149, 32);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "Create/Update";
            // 
            // frmCustomerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 430);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmCustomerDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Customer Details";
            Load += frmCustomerDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCustomerStatus;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCustomerStatus;
        private System.Windows.Forms.Label lblPoint;
    }
}
