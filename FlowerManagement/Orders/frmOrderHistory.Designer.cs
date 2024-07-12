namespace FlowerManagement.Orders
{
    partial class frmOrderHistory
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
            dgvOrderList = new DataGridView();
            btnReload = new Button();
            btnViewDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(30, 46);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.Size = new Size(812, 439);
            dgvOrderList.TabIndex = 0;
            dgvOrderList.SelectionChanged += dgvOrderList_SelectionChanged;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(865, 153);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(94, 29);
            btnReload.TabIndex = 1;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnViewDetail
            // 
            btnViewDetail.Location = new Point(865, 46);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new Size(94, 29);
            btnViewDetail.TabIndex = 2;
            btnViewDetail.Text = "View Detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // frmOrderHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 542);
            Controls.Add(btnViewDetail);
            Controls.Add(btnReload);
            Controls.Add(dgvOrderList);
            Name = "frmOrderHistory";
            Text = "OrderHistory";
            Load += frmOrderHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrderList;
        private Button btnReload;
        private Button btnViewDetail;
    }
}