namespace FlowerManagement.Orders
{
    partial class frmCart
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
            dgvCartList = new DataGridView();
            btnDelete = new Button();
            btnCheckOut = new Button();
            btnDeleteAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCartList).BeginInit();
            SuspendLayout();
            // 
            // dgvCartList
            // 
            dgvCartList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCartList.Location = new Point(42, 57);
            dgvCartList.Name = "dgvCartList";
            dgvCartList.RowHeadersWidth = 51;
            dgvCartList.RowTemplate.Height = 29;
            dgvCartList.Size = new Size(525, 329);
            dgvCartList.TabIndex = 0;
            dgvCartList.CellValueChanged += dgvCartList_CellValueChanged;
            dgvCartList.SelectionChanged += dgvCartList_SelectionChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(628, 68);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(628, 311);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(113, 29);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(628, 184);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(113, 29);
            btnDeleteAll.TabIndex = 4;
            btnDeleteAll.Text = "Delete All";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // frmCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnCheckOut);
            Controls.Add(btnDelete);
            Controls.Add(dgvCartList);
            Name = "frmCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart";
            Load += frmCart_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCartList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCartList;
        private Button btnDelete;
        private Button btnCheckOut;
        private Button btnDeleteAll;
    }
}