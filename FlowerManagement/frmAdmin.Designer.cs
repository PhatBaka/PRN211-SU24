namespace FlowerManagement
{
    partial class frmAdmin
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
            btnFlower = new Button();
            btnSupplier = new Button();
            btnCategory = new Button();
            dgvOrder = new DataGridView();
            txtStartDate = new DateTimePicker();
            txtEnddate = new DateTimePicker();
            btnSearch = new Button();
            btnReload = new Button();
            btnAccount = new Button();
            label1 = new Label();
            label2 = new Label();
            btnDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // btnFlower
            // 
            btnFlower.Location = new Point(210, 12);
            btnFlower.Name = "btnFlower";
            btnFlower.Size = new Size(94, 29);
            btnFlower.TabIndex = 0;
            btnFlower.Text = "Flower";
            btnFlower.UseVisualStyleBackColor = true;
            btnFlower.Click += btnFlower_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.Location = new Point(410, 12);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(94, 29);
            btnSupplier.TabIndex = 2;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = true;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(510, 12);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(94, 29);
            btnCategory.TabIndex = 3;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(12, 148);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(774, 285);
            dgvOrder.TabIndex = 4;
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new Point(210, 61);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(250, 27);
            txtStartDate.TabIndex = 5;
            // 
            // txtEnddate
            // 
            txtEnddate.Location = new Point(210, 94);
            txtEnddate.Name = "txtEnddate";
            txtEnddate.Size = new Size(250, 27);
            txtEnddate.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(479, 62);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(479, 97);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(94, 29);
            btnReload.TabIndex = 8;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnAccount
            // 
            btnAccount.FlatStyle = FlatStyle.System;
            btnAccount.Location = new Point(110, 12);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(94, 29);
            btnAccount.TabIndex = 9;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 62);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 10;
            label1.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 97);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 11;
            label2.Text = "End Date";
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(596, 94);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(94, 29);
            btnDetail.TabIndex = 12;
            btnDetail.Text = "View detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 458);
            Controls.Add(btnDetail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAccount);
            Controls.Add(btnReload);
            Controls.Add(btnSearch);
            Controls.Add(txtEnddate);
            Controls.Add(txtStartDate);
            Controls.Add(dgvOrder);
            Controls.Add(btnCategory);
            Controls.Add(btnSupplier);
            Controls.Add(btnFlower);
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdmin";
            Load += frmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFlower;
        private Button btnSupplier;
        private Button btnCategory;
        private DataGridView dgvOrder;
        private DateTimePicker txtStartDate;
        private DateTimePicker txtEnddate;
        private Button btnSearch;
        private Button btnReload;
        private Button btnAccount;
        private Label label1;
        private Label label2;
        private Button btnDetail;
    }
}