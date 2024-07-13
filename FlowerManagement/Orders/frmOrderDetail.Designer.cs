namespace FlowerManagement.Orders
{
    partial class frmOrderDetail
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
            dgvOrderDetailList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetailList
            // 
            dgvOrderDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetailList.Location = new Point(47, 51);
            dgvOrderDetailList.Name = "dgvOrderDetailList";
            dgvOrderDetailList.RowHeadersWidth = 51;
            dgvOrderDetailList.RowTemplate.Height = 29;
            dgvOrderDetailList.Size = new Size(795, 437);
            dgvOrderDetailList.TabIndex = 0;
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 529);
            Controls.Add(dgvOrderDetailList);
            Name = "frmOrderDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderDetail";
            Load += frmOrderDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrderDetailList;
    }
}