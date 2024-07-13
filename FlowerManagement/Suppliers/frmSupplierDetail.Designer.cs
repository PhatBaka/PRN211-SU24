namespace FlowerManagement.Suppliers
{
    partial class frmSupplierDetail
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
            lblTitle = new Label();
            txtTelephone = new TextBox();
            Telephone = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnSave = new Button();
            txtAddress = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(229, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 20);
            lblTitle.TabIndex = 40;
            lblTitle.Text = "label7";
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(133, 145);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(350, 27);
            txtTelephone.TabIndex = 35;
            // 
            // Telephone
            // 
            Telephone.AutoSize = true;
            Telephone.Location = new Point(49, 148);
            Telephone.Name = "Telephone";
            Telephone.Size = new Size(78, 20);
            Telephone.TabIndex = 34;
            Telephone.Text = "Telephone";
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(350, 27);
            txtName.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 98);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 31;
            label3.Text = "Supplier Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 48);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 29;
            label1.Text = "Supplier Name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(215, 191);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 25);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(133, 95);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(350, 27);
            txtAddress.TabIndex = 41;
            // 
            // frmSupplierDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 232);
            Controls.Add(txtAddress);
            Controls.Add(lblTitle);
            Controls.Add(txtTelephone);
            Controls.Add(Telephone);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Name = "frmSupplierDetail";
            Text = "Supplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTelephone;
        private Label Telephone;
        private Label label3;
        private Label label1;
        private Button btnSave;
        private TextBox txtName;
        private TextBox txtAddress;
    }
}