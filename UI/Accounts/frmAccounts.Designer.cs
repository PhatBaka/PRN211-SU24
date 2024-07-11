



namespace UI.Accounts
{
    partial class frmAccounts
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
            dgvAccount = new DataGridView();
            btnCreate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            txtSearch = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            SuspendLayout();
            // 
            // dgvAccount
            // 
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Location = new Point(12, 150);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 29;
            dgvAccount.Size = new Size(776, 288);
            dgvAccount.TabIndex = 0;
            dgvAccount.CellDoubleClick += dgvAccount_CellDoubleClick;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(400, 110);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 32;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(550, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(700, 110);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 38;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 16;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 17;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 18;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 19;
            label4.Text = "Role";
            // 
            // txtId
            // 
            txtId.Location = new Point(105, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 27;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(105, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 26;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(105, 78);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(89, 27);
            txtPassword.TabIndex = 28;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "ADMIN", "STAFF", "CUSTOMER" });
            cmbRole.Location = new Point(105, 114);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(151, 28);
            cmbRole.TabIndex = 39;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(528, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(89, 27);
            txtSearch.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 55);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 41;
            label5.Text = "Search";
            // 
            // frmAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtSearch);
            Controls.Add(cmbRole);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAccount);
            Name = "frmAccounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Management";
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccount;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
        private ComboBox cmbRole;
        private TextBox txtSearch;
        private Label label5;
    }
}