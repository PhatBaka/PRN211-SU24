namespace FlowerManagement.Customers
{
    partial class frmAccountDetail
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
            btnSave = new Button();
            lblTitle = new Label();
            lblCustomerId = new Label();
            lblCustomerName = new Label();
            lblEmail = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(198, 60);
            txtCustomerId.Margin = new Padding(2, 3, 2, 3);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.ReadOnly = true;
            txtCustomerId.Size = new Size(161, 27);
            txtCustomerId.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(198, 100);
            txtCustomerName.Margin = new Padding(2, 3, 2, 3);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Customer Name";
            txtCustomerName.Size = new Size(161, 27);
            txtCustomerName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(198, 140);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(161, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(198, 180);
            txtCity.Margin = new Padding(2, 3, 2, 3);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "City";
            txtCity.Size = new Size(161, 27);
            txtCity.TabIndex = 4;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(198, 220);
            txtCountry.Margin = new Padding(2, 3, 2, 3);
            txtCountry.Name = "txtCountry";
            txtCountry.PlaceholderText = "Country";
            txtCountry.Size = new Size(161, 27);
            txtCountry.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(198, 260);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(161, 27);
            txtPassword.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(143, 304);
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
            lblTitle.Location = new Point(94, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 32);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "Create/Update";
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(20, 63);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(91, 20);
            lblCustomerId.TabIndex = 1;
            lblCustomerId.Text = "Customer ID";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(20, 103);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(116, 20);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "Customer Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 143);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(20, 183);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 20);
            lblCity.TabIndex = 7;
            lblCity.Text = "City";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(20, 223);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(60, 20);
            lblCountry.TabIndex = 9;
            lblCountry.Text = "Country";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 263);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // frmAccountDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 352);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerId);
            Controls.Add(lblPassword);
            Controls.Add(lblCountry);
            Controls.Add(lblCity);
            Controls.Add(lblEmail);
            Controls.Add(lblCustomerName);
            Controls.Add(lblCustomerId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmAccountDetail";
            StartPosition = FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPassword;
    }
}
