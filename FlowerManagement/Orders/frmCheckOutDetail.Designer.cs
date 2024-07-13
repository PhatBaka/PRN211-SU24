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
            btnOK = new Button();
            btnCancel = new Button();
            label2 = new Label();
            txtTotalPrice = new TextBox();
            chkDiscount = new CheckBox();
            lblFinalPirce = new Label();
            txtFinalPrice = new TextBox();
            label1 = new Label();
            txtDiscountRate = new TextBox();
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
            dgvCheckOut.Size = new Size(784, 310);
            dgvCheckOut.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(731, 387);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(731, 448);
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
            txtTotalPrice.Location = new Point(132, 387);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(215, 27);
            txtTotalPrice.TabIndex = 7;
            // 
            // chkDiscount
            // 
            chkDiscount.AutoSize = true;
            chkDiscount.Location = new Point(374, 444);
            chkDiscount.Name = "chkDiscount";
            chkDiscount.Size = new Size(132, 24);
            chkDiscount.TabIndex = 9;
            chkDiscount.Text = "Apply Discount";
            chkDiscount.UseVisualStyleBackColor = true;
            chkDiscount.CheckedChanged += chkDiscount_CheckedChanged;
            // 
            // lblFinalPirce
            // 
            lblFinalPirce.AutoSize = true;
            lblFinalPirce.Location = new Point(41, 448);
            lblFinalPirce.Name = "lblFinalPirce";
            lblFinalPirce.Size = new Size(72, 20);
            lblFinalPirce.TabIndex = 11;
            lblFinalPirce.Text = "FinalPirce";
            // 
            // txtFinalPrice
            // 
            txtFinalPrice.Location = new Point(132, 441);
            txtFinalPrice.Name = "txtFinalPrice";
            txtFinalPrice.Size = new Size(215, 27);
            txtFinalPrice.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 390);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 13;
            label1.Text = "DiscountRate";
            // 
            // txtDiscountRate
            // 
            txtDiscountRate.Location = new Point(474, 387);
            txtDiscountRate.Name = "txtDiscountRate";
            txtDiscountRate.Size = new Size(215, 27);
            txtDiscountRate.TabIndex = 12;
            // 
            // frmCheckOutDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 544);
            Controls.Add(label1);
            Controls.Add(txtDiscountRate);
            Controls.Add(lblFinalPirce);
            Controls.Add(txtFinalPrice);
            Controls.Add(chkDiscount);
            Controls.Add(label2);
            Controls.Add(txtTotalPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(dgvCheckOut);
            Name = "frmCheckOutDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckOutDetail";
            Load += frmCheckOutDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCheckOut;
        private Button btnOK;
        private Button btnCancel;
        private Label label2;
        private TextBox txtTotalPrice;
        private CheckBox chkDiscount;
        private Label lblFinalPirce;
        private TextBox txtFinalPrice;
        private Label label1;
        private TextBox txtDiscountRate;
    }
}