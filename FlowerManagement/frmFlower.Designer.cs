namespace FlowerManagement
{
    partial class FlowerBouquetID
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
            txtFlowerBouquetID = new TextBox();
            txtFlowerBouquetName = new TextBox();
            txtDescription = new TextBox();
            txtUnitPrice = new TextBox();
            txtMorphology = new TextBox();
            txtUnitsInStock = new TextBox();
            txtCategoryID = new TextBox();
            txtSupplierID = new TextBox();
            chkFlowerBouquetStatus = new CheckBox();
            picImage = new PictureBox();
            btnLoad = new Button();
            btnsave = new Button();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // txtFlowerBouquetID
            // 
            txtFlowerBouquetID.Location = new Point(289, 60);
            txtFlowerBouquetID.Name = "txtFlowerBouquetID";
            txtFlowerBouquetID.Size = new Size(230, 27);
            txtFlowerBouquetID.TabIndex = 0;
            txtFlowerBouquetID.TextChanged += txtFlowerBouquetID_TextChanged;
            // 
            // txtFlowerBouquetName
            // 
            txtFlowerBouquetName.Location = new Point(289, 93);
            txtFlowerBouquetName.Name = "txtFlowerBouquetName";
            txtFlowerBouquetName.Size = new Size(230, 27);
            txtFlowerBouquetName.TabIndex = 1;
            txtFlowerBouquetName.TextChanged += txtFlowerBouquetName_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(289, 126);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(230, 27);
            txtDescription.TabIndex = 2;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(289, 159);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(230, 27);
            txtUnitPrice.TabIndex = 3;
            txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
            // 
            // txtMorphology
            // 
            txtMorphology.Location = new Point(525, 93);
            txtMorphology.Name = "txtMorphology";
            txtMorphology.Size = new Size(230, 27);
            txtMorphology.TabIndex = 4;
            txtMorphology.TextChanged += txtMorphology_TextChanged;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(525, 60);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(230, 27);
            txtUnitsInStock.TabIndex = 5;
            txtUnitsInStock.TextChanged += txtUnitsInStock_TextChanged;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(525, 126);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(230, 27);
            txtCategoryID.TabIndex = 6;
            txtCategoryID.TextChanged += txtCategoryID_TextChanged;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new Point(525, 159);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(230, 27);
            txtSupplierID.TabIndex = 7;
            txtSupplierID.TextChanged += txtSupplierID_TextChanged;
            // 
            // chkFlowerBouquetStatus
            // 
            chkFlowerBouquetStatus.AutoSize = true;
            chkFlowerBouquetStatus.Location = new Point(326, 195);
            chkFlowerBouquetStatus.Name = "chkFlowerBouquetStatus";
            chkFlowerBouquetStatus.Size = new Size(171, 24);
            chkFlowerBouquetStatus.TabIndex = 8;
            chkFlowerBouquetStatus.Text = "FlowerBouquetStatus";
            chkFlowerBouquetStatus.UseVisualStyleBackColor = true;
            chkFlowerBouquetStatus.CheckedChanged += chkFlowerBouquetStatus_CheckedChanged;
            // 
            // picImage
            // 
            picImage.Location = new Point(81, 46);
            picImage.Name = "picImage";
            picImage.Size = new Size(202, 140);
            picImage.TabIndex = 9;
            picImage.TabStop = false;
            picImage.Click += picImage_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(534, 192);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(649, 194);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(82, 25);
            btnsave.TabIndex = 11;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // FlowerBouquetID
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsave);
            Controls.Add(btnLoad);
            Controls.Add(picImage);
            Controls.Add(chkFlowerBouquetStatus);
            Controls.Add(txtSupplierID);
            Controls.Add(txtCategoryID);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtMorphology);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtFlowerBouquetName);
            Controls.Add(txtFlowerBouquetID);
            Name = "FlowerBouquetID";
            Text = "Flower";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFlowerBouquetID;
        private TextBox txtFlowerBouquetName;
        private TextBox txtDescription;
        private TextBox txtUnitPrice;
        private TextBox txtMorphology;
        private TextBox txtUnitsInStock;
        private TextBox txtCategoryID;
        private TextBox txtSupplierID;
        private CheckBox chkFlowerBouquetStatus;
        private PictureBox picImage;
        private Button btnLoad;
        private Button btnsave;
    }
}