namespace FlowerManagement
{
    partial class Supplier
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
            txtSupplierID = new TextBox();
            txtSupplierName = new TextBox();
            txtSupplierAddress = new TextBox();
            txtTelephone = new TextBox();
            btnSaveSupplier = new Button();
            dataGridViewSuppliers = new DataGridView();
            btnLoadAllSuppliers = new Button();
            btnDeleteSupplier = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            SuspendLayout();
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new Point(273, 122);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(233, 27);
            txtSupplierID.TabIndex = 0;
            txtSupplierID.TextChanged += txtSupplierID_TextChanged;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(273, 155);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(233, 27);
            txtSupplierName.TabIndex = 1;
            txtSupplierName.TextChanged += txtSupplierName_TextChanged;
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(267, 188);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(239, 27);
            txtSupplierAddress.TabIndex = 2;
            txtSupplierAddress.TextChanged += txtSupplierAddress_TextChanged;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(273, 221);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(233, 27);
            txtTelephone.TabIndex = 3;
            txtTelephone.TextChanged += txtTelephone_TextChanged;
            // 
            // btnSaveSupplier
            // 
            btnSaveSupplier.Location = new Point(377, 252);
            btnSaveSupplier.Name = "btnSaveSupplier";
            btnSaveSupplier.Size = new Size(129, 29);
            btnSaveSupplier.TabIndex = 5;
            btnSaveSupplier.Text = "Save Supplier";
            btnSaveSupplier.UseVisualStyleBackColor = true;
            btnSaveSupplier.Click += btnSaveSupplier_Click;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Location = new Point(11, 107);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.RowHeadersWidth = 51;
            dataGridViewSuppliers.RowTemplate.Height = 29;
            dataGridViewSuppliers.Size = new Size(250, 139);
            dataGridViewSuppliers.TabIndex = 6;
            dataGridViewSuppliers.CellContentClick += dataGridViewSuppliers_CellContentClick;
            // 
            // btnLoadAllSuppliers
            // 
            btnLoadAllSuppliers.Location = new Point(53, 252);
            btnLoadAllSuppliers.Name = "btnLoadAllSuppliers";
            btnLoadAllSuppliers.Size = new Size(149, 29);
            btnLoadAllSuppliers.TabIndex = 7;
            btnLoadAllSuppliers.Text = "Load All Suppliers";
            btnLoadAllSuppliers.UseVisualStyleBackColor = true;
            btnLoadAllSuppliers.Click += btnLoadAllSuppliers_Click_1;
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.Location = new Point(222, 252);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(140, 29);
            btnDeleteSupplier.TabIndex = 8;
            btnDeleteSupplier.Text = "Delete Supplier";
            btnDeleteSupplier.UseVisualStyleBackColor = true;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click_1;
            // 
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteSupplier);
            Controls.Add(btnLoadAllSuppliers);
            Controls.Add(dataGridViewSuppliers);
            Controls.Add(btnSaveSupplier);
            Controls.Add(txtTelephone);
            Controls.Add(txtSupplierAddress);
            Controls.Add(txtSupplierName);
            Controls.Add(txtSupplierID);
            Name = "Supplier";
            Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSupplierID;
        private TextBox txtSupplierName;
        private TextBox txtSupplierAddress;
        private TextBox txtTelephone;
        private Button btnSaveSupplier;
        private DataGridView dataGridViewSuppliers;
        private Button btnLoadAllSuppliers;
        private Button btnDeleteSupplier;
    }
}