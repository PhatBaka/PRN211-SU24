namespace FlowerManagement.Orders
{
    partial class Order
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
            ((System.ComponentModel.ISupportInitialize)dgvFlowerList).BeginInit();
            SuspendLayout();
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(737, 193);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(114, 29);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // btnViewCart
            // 
            btnViewCart.Location = new Point(737, 86);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(114, 29);
            btnViewCart.TabIndex = 1;
            btnViewCart.Text = "View Cart";
            btnViewCart.UseVisualStyleBackColor = true;
            // 
            // dgvFlowerList
            // 
            dgvFlowerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlowerList.Location = new Point(26, 61);
            dgvFlowerList.Name = "dgvFlowerList";
            dgvFlowerList.RowHeadersWidth = 51;
            dgvFlowerList.RowTemplate.Height = 29;
            dgvFlowerList.Size = new Size(690, 423);
            dgvFlowerList.TabIndex = 0;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 528);
            Controls.Add(btnAddToCart);
            Controls.Add(btnViewCart);
            Controls.Add(dgvFlowerList);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dgvFlowerList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddToCart;
        private Button btnViewCart;
        private DataGridView dgvFlowerList;
    }
}