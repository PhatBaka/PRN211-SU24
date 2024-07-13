
namespace FlowerManagement.Flowers
{
    partial class frmFlowerDetail
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
            txtFlowerBouquetName = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitsInStock = new TextBox();
            imgFlower = new PictureBox();
            btnsave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDescription = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            txtMorphology = new TextBox();
            cbSupplier = new ComboBox();
            cbCategory = new ComboBox();
            Supplier = new Label();
            label6 = new Label();
            lblTitle = new Label();
            label7 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imgFlower).BeginInit();
            SuspendLayout();
            // 
            // txtFlowerBouquetName
            // 
            txtFlowerBouquetName.Location = new Point(438, 86);
            txtFlowerBouquetName.Name = "txtFlowerBouquetName";
            txtFlowerBouquetName.Size = new Size(403, 27);
            txtFlowerBouquetName.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(438, 231);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(151, 27);
            txtUnitPrice.TabIndex = 3;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(690, 235);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(151, 27);
            txtUnitsInStock.TabIndex = 5;
            // 
            // imgFlower
            // 
            imgFlower.BorderStyle = BorderStyle.FixedSingle;
            imgFlower.Location = new Point(19, 63);
            imgFlower.Name = "imgFlower";
            imgFlower.Size = new Size(306, 267);
            imgFlower.SizeMode = PictureBoxSizeMode.Zoom;
            imgFlower.TabIndex = 9;
            imgFlower.TabStop = false;
            imgFlower.Click += picImage_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(576, 324);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(82, 25);
            btnsave.TabIndex = 11;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 89);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 238);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 13;
            label2.Text = "Unit in stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 134);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 14;
            label3.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(438, 119);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(403, 57);
            txtDescription.TabIndex = 15;
            txtDescription.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 234);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 16;
            label4.Text = "Unit Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 193);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 17;
            label5.Text = "Morphology";
            // 
            // txtMorphology
            // 
            txtMorphology.Location = new Point(438, 190);
            txtMorphology.Name = "txtMorphology";
            txtMorphology.Size = new Size(403, 27);
            txtMorphology.TabIndex = 18;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(438, 275);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(151, 28);
            cbSupplier.TabIndex = 19;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(690, 275);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 20;
            // 
            // Supplier
            // 
            Supplier.AutoSize = true;
            Supplier.Location = new Point(368, 278);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(64, 20);
            Supplier.TabIndex = 21;
            Supplier.Text = "Supplier";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(615, 278);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 22;
            label6.Text = "Category";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(383, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 20);
            lblTitle.TabIndex = 23;
            lblTitle.Text = "label7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(408, 56);
            label7.Name = "label7";
            label7.Size = new Size(24, 20);
            label7.TabIndex = 24;
            label7.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(438, 53);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 25;
            txtId.ReadOnly = true;
            // 
            // frmFlowerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 373);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(lblTitle);
            Controls.Add(label6);
            Controls.Add(Supplier);
            Controls.Add(cbCategory);
            Controls.Add(cbSupplier);
            Controls.Add(txtMorphology);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsave);
            Controls.Add(imgFlower);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtFlowerBouquetName);
            Name = "frmFlowerDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flower";
            Load += frmFlowerDetail_Load;
            ((System.ComponentModel.ISupportInitialize)imgFlower).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFlowerBouquetName;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private PictureBox imgFlower;
        private Button btnsave;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox txtDescription;
        private Label label4;
        private Label label5;
        private TextBox txtMorphology;
        private ComboBox cbSupplier;
        private ComboBox cbCategory;
        private Label Supplier;
        private Label label6;
        private Label lblTitle;
        private Label label7;
        private TextBox txtId;
    }
}