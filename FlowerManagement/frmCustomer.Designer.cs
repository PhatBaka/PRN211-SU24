namespace FlowerManagement
{
    partial class frmCustomer
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
            btnOrderHistory = new Button();
            btnMakeOrder = new Button();
            SuspendLayout();
            // 
            // btnOrderHistory
            // 
            btnOrderHistory.Location = new Point(12, 12);
            btnOrderHistory.Name = "btnOrderHistory";
            btnOrderHistory.Size = new Size(117, 42);
            btnOrderHistory.TabIndex = 0;
            btnOrderHistory.Text = "Order History";
            btnOrderHistory.UseVisualStyleBackColor = true;
            btnOrderHistory.Click += btnOrderHistory_Click;
            // 
            // btnMakeOrder
            // 
            btnMakeOrder.Location = new Point(135, 12);
            btnMakeOrder.Name = "btnMakeOrder";
            btnMakeOrder.Size = new Size(117, 42);
            btnMakeOrder.TabIndex = 1;
            btnMakeOrder.Text = "Make Order";
            btnMakeOrder.UseVisualStyleBackColor = true;
            btnMakeOrder.Click += btnMakeOrder_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 80);
            Controls.Add(btnMakeOrder);
            Controls.Add(btnOrderHistory);
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomer";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOrderHistory;
        private Button btnMakeOrder;
    }
}