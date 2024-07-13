namespace FlowerManagement.Flowers
{
    partial class frmFlower
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
            label6 = new Label();
            Supplier = new Label();
            cbCategory = new ComboBox();
            cbSupplier = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            imgFlower = new PictureBox();
            txtUnitsInStock = new TextBox();
            label7 = new Label();
            txtUnitPrice = new TextBox();
            txtMorphology = new TextBox();
            txtDescription = new RichTextBox();
            txtFlowerBouquetName = new TextBox();
            btnCreate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label8 = new Label();
            label9 = new Label();
            txtID = new TextBox();
            dgvFlower = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)imgFlower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFlower).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(376, -42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 20);
            lblTitle.TabIndex = 40;
            lblTitle.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(621, 268);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 39;
            label6.Text = "Category";
            // 
            // Supplier
            // 
            Supplier.AutoSize = true;
            Supplier.Location = new Point(374, 268);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(64, 20);
            Supplier.TabIndex = 38;
            Supplier.Text = "Supplier";
            // 
            // cbCategory
            // 
            cbCategory.Enabled = false;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(696, 265);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 37;
            // 
            // cbSupplier
            // 
            cbSupplier.Enabled = false;
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(444, 265);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(151, 28);
            cbSupplier.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 183);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 34;
            label5.Text = "Morphology";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 224);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 33;
            label4.Text = "Unit Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 124);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 31;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(600, 228);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 30;
            label2.Text = "Unit in stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 79);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 29;
            label1.Text = "Name";
            // 
            // imgFlower
            // 
            imgFlower.BorderStyle = BorderStyle.FixedSingle;
            imgFlower.Enabled = false;
            imgFlower.Location = new Point(25, 76);
            imgFlower.Name = "imgFlower";
            imgFlower.Size = new Size(306, 267);
            imgFlower.SizeMode = PictureBoxSizeMode.Zoom;
            imgFlower.TabIndex = 27;
            imgFlower.TabStop = false;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(696, 225);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.ReadOnly = true;
            txtUnitsInStock.Size = new Size(151, 27);
            txtUnitsInStock.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 9);
            label7.Name = "label7";
            label7.Size = new Size(170, 20);
            label7.TabIndex = 41;
            label7.Text = "FLOWER MANAGEMENT";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(444, 221);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(151, 27);
            txtUnitPrice.TabIndex = 25;
            // 
            // txtMorphology
            // 
            txtMorphology.Location = new Point(444, 180);
            txtMorphology.Name = "txtMorphology";
            txtMorphology.ReadOnly = true;
            txtMorphology.Size = new Size(403, 27);
            txtMorphology.TabIndex = 35;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(444, 109);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(403, 57);
            txtDescription.TabIndex = 32;
            txtDescription.Text = "";
            // 
            // txtFlowerBouquetName
            // 
            txtFlowerBouquetName.Location = new Point(444, 76);
            txtFlowerBouquetName.Name = "txtFlowerBouquetName";
            txtFlowerBouquetName.ReadOnly = true;
            txtFlowerBouquetName.Size = new Size(403, 27);
            txtFlowerBouquetName.TabIndex = 24;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(444, 314);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 42;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(544, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(644, 314);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 44;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(313, 379);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(307, 27);
            txtSearch.TabIndex = 45;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(641, 379);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 46;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(257, 386);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 47;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 45);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 48;
            label9.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(444, 42);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(403, 27);
            txtID.TabIndex = 49;
            // 
            // dgvFlower
            // 
            dgvFlower.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlower.Location = new Point(25, 434);
            dgvFlower.Name = "dgvFlower";
            dgvFlower.RowHeadersWidth = 51;
            dgvFlower.RowTemplate.Height = 29;
            dgvFlower.Size = new Size(881, 221);
            dgvFlower.TabIndex = 50;
            dgvFlower.CellDoubleClick += dgvFlower_CellDoubleClick;
            // 
            // frmFlower
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 667);
            Controls.Add(dgvFlower);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
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
            Controls.Add(imgFlower);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtFlowerBouquetName);
            Name = "frmFlower";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFlower";
            Load += frmFlower_Load;
            ((System.ComponentModel.ISupportInitialize)imgFlower).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFlower).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Label label6;
        private Label Supplier;
        private ComboBox cbCategory;
        private ComboBox cbSupplier;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox imgFlower;
        private TextBox txtUnitsInStock;
        private Label label7;
        private TextBox txtUnitPrice;
        private TextBox txtMorphology;
        private RichTextBox txtDescription;
        private TextBox txtFlowerBouquetName;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnLoad;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label8;
        private Label label9;
        private TextBox txtID;
        private DataGridView dgvFlower;
    }
}
