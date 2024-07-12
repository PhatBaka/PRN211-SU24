namespace FlowerManagement.Orders
{
    partial class frmOrder
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
            btnAddToCart = new Button();
            btnViewCart = new Button();
            dgvFlowerList = new DataGridView();
            lblName = new Label();
            btnSearch = new Button();
            txtName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFlowerList).BeginInit();
            SuspendLayout();
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(1101, 213);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(114, 29);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.Location = new Point(1101, 114);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(114, 29);
            btnViewCart.TabIndex = 1;
            btnViewCart.Text = "View Cart";
            btnViewCart.UseVisualStyleBackColor = true;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // dgvFlowerList
            // 
            dgvFlowerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlowerList.Location = new Point(33, 114);
            dgvFlowerList.Name = "dgvFlowerList";
            dgvFlowerList.RowHeadersWidth = 51;
            dgvFlowerList.RowTemplate.Height = 29;
            dgvFlowerList.Size = new Size(1041, 565);
            dgvFlowerList.TabIndex = 0;
            dgvFlowerList.SelectionChanged += dgvFlowerList_SelectionChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(42, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(710, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(147, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(495, 27);
            txtName.TabIndex = 6;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 707);
            Controls.Add(txtName);
            Controls.Add(btnSearch);
            Controls.Add(lblName);
            Controls.Add(btnAddToCart);
            Controls.Add(btnViewCart);
            Controls.Add(dgvFlowerList);
            Name = "frmOrder";
            Text = "Order";
            Load += Order_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFlowerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddToCart;
        private Button btnViewCart;
        private DataGridView dgvFlowerList;
        private Label lblName;
        private Button btnSearch;
        private TextBox txtName;
    }
}