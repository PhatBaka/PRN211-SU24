namespace FlowerManagement.Orders
{
    partial class frmCheckOutDetail
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
            dgvCheckOut = new DataGridView();
            txtCustomerEmail = new TextBox();
            label1 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            label2 = new Label();
            txtTotalPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).BeginInit();
            SuspendLayout();
            // 
            // dgvCheckOut
            // 
            dgvCheckOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckOut.Location = new Point(41, 37);
            dgvCheckOut.Name = "dgvCheckOut";
            dgvCheckOut.RowHeadersWidth = 51;
            dgvCheckOut.RowTemplate.Height = 29;
            dgvCheckOut.Size = new Size(757, 310);
            dgvCheckOut.TabIndex = 0;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(199, 455);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(311, 27);
            txtCustomerEmail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 462);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 2;
            label1.Text = "Customer's email";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(690, 390);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(690, 458);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 390);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 8;
            label2.Text = "TotalPrice";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(199, 390);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(311, 27);
            txtTotalPrice.TabIndex = 7;
            // 
            // frmCheckOutDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 544);
            Controls.Add(label2);
            Controls.Add(txtTotalPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label1);
            Controls.Add(txtCustomerEmail);
            Controls.Add(dgvCheckOut);
            Name = "frmCheckOutDetail";
            Text = "CheckOutDetail";
            Load += frmCheckOutDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCheckOut;
        private TextBox txtCustomerEmail;
        private Label label1;
        private Button btnOK;
        private Button btnCancel;
        private Label label2;
        private TextBox txtTotalPrice;
    }
}