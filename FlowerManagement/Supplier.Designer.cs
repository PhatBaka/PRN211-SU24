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
            btnLoadSupplier = new Button();
            btnSaveSupplier = new Button();
            SuspendLayout();
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new Point(273, 122);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(217, 27);
            txtSupplierID.TabIndex = 0;
            txtSupplierID.TextChanged += txtSupplierID_TextChanged;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(273, 155);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(217, 27);
            txtSupplierName.TabIndex = 1;
            txtSupplierName.TextChanged += txtSupplierName_TextChanged;
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(273, 188);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(217, 27);
            txtSupplierAddress.TabIndex = 2;
            txtSupplierAddress.TextChanged += txtSupplierAddress_TextChanged;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(273, 221);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(217, 27);
            txtTelephone.TabIndex = 3;
            txtTelephone.TextChanged += txtTelephone_TextChanged;
            // 
            // btnLoadSupplier
            // 
            btnLoadSupplier.Location = new Point(254, 254);
            btnLoadSupplier.Name = "btnLoadSupplier";
            btnLoadSupplier.Size = new Size(127, 29);
            btnLoadSupplier.TabIndex = 4;
            btnLoadSupplier.Text = "Load Supplier";
            btnLoadSupplier.UseVisualStyleBackColor = true;
            btnLoadSupplier.Click += btnLoadSupplier_Click;
            // 
            // btnSaveSupplier
            // 
            btnSaveSupplier.Location = new Point(400, 254);
            btnSaveSupplier.Name = "btnSaveSupplier";
            btnSaveSupplier.Size = new Size(129, 29);
            btnSaveSupplier.TabIndex = 5;
            btnSaveSupplier.Text = "Save Supplier";
            btnSaveSupplier.UseVisualStyleBackColor = true;
            btnSaveSupplier.Click += btnSaveSupplier_Click;
            // 
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveSupplier);
            Controls.Add(btnLoadSupplier);
            Controls.Add(txtTelephone);
            Controls.Add(txtSupplierAddress);
            Controls.Add(txtSupplierName);
            Controls.Add(txtSupplierID);
            Name = "Supplier";
            Text = "Supplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSupplierID;
        private TextBox txtSupplierName;
        private TextBox txtSupplierAddress;
        private TextBox txtTelephone;
        private Button btnLoadSupplier;
        private Button btnSaveSupplier;
    }
}