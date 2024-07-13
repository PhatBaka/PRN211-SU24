namespace FlowerManagement.Categories
{
    partial class frmCategoryDetail
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryDescription = new TextBox();
            txtCategoryNote = new TextBox();
            lblCategoryID = new Label();
            lblCategoryName = new Label();
            lblCategoryDescription = new Label();
            lblCategoryNote = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(185, 18);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(200, 27);
            txtCategoryID.TabIndex = 0;
            txtCategoryID.ReadOnly = true;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(185, 46);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(200, 27);
            txtCategoryName.TabIndex = 1;
            // 
            // txtCategoryDescription
            // 
            txtCategoryDescription.Location = new Point(185, 74);
            txtCategoryDescription.Multiline = true;
            txtCategoryDescription.Name = "txtCategoryDescription";
            txtCategoryDescription.Size = new Size(200, 50);
            txtCategoryDescription.TabIndex = 2;
            // 
            // txtCategoryNote
            // 
            txtCategoryNote.Location = new Point(185, 130);
            txtCategoryNote.Name = "txtCategoryNote";
            txtCategoryNote.Size = new Size(200, 27);
            txtCategoryNote.TabIndex = 3;
            // 
            // lblCategoryID
            // 
            lblCategoryID.AutoSize = true;
            lblCategoryID.Location = new Point(24, 18);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(88, 20);
            lblCategoryID.TabIndex = 4;
            lblCategoryID.Text = "Category ID";
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(24, 46);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(113, 20);
            lblCategoryName.TabIndex = 5;
            lblCategoryName.Text = "Category Name";
            // 
            // lblCategoryDescription
            // 
            lblCategoryDescription.AutoSize = true;
            lblCategoryDescription.Location = new Point(24, 74);
            lblCategoryDescription.Name = "lblCategoryDescription";
            lblCategoryDescription.Size = new Size(149, 20);
            lblCategoryDescription.TabIndex = 6;
            lblCategoryDescription.Text = "Category Description";
            // 
            // lblCategoryNote
            // 
            lblCategoryNote.AutoSize = true;
            lblCategoryNote.Location = new Point(24, 130);
            lblCategoryNote.Name = "lblCategoryNote";
            lblCategoryNote.Size = new Size(106, 20);
            lblCategoryNote.TabIndex = 7;
            lblCategoryNote.Text = "Category Note";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(185, 172);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 32);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmCategoryDetail
            // 
            ClientSize = new Size(465, 207);
            Controls.Add(btnSave);
            Controls.Add(lblCategoryNote);
            Controls.Add(lblCategoryDescription);
            Controls.Add(lblCategoryName);
            Controls.Add(lblCategoryID);
            Controls.Add(txtCategoryNote);
            Controls.Add(txtCategoryDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Name = "frmCategoryDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Details";
            Load += frmCategoryDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.TextBox txtCategoryNote;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.Label lblCategoryNote;
        private System.Windows.Forms.Button btnSave;
    }
}
