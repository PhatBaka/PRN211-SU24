namespace FlowerManagement.Categories
{
    partial class frmCategory
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
            dgvCategory = new DataGridView();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryDescription = new TextBox();
            txtCategoryNote = new TextBox();
            lblCategoryID = new Label();
            lblCategoryName = new Label();
            lblCategoryDescription = new Label();
            lblCategoryNote = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            txtSearchName = new TextBox();
            txtSearchId = new TextBox();
            btnSearchName = new Button();
            btnSearchById = new Button();
            lblSearchById = new Label();
            lblSearchByName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(17, 12);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowTemplate.Height = 24;
            dgvCategory.Size = new Size(891, 206);
            dgvCategory.TabIndex = 0;
            dgvCategory.CellDoubleClick += dgvCategory_CellDoubleClick;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(174, 238);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(200, 27);
            txtCategoryID.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(174, 266);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(200, 27);
            txtCategoryName.TabIndex = 2;
            // 
            // txtCategoryDescription
            // 
            txtCategoryDescription.Location = new Point(174, 294);
            txtCategoryDescription.Multiline = true;
            txtCategoryDescription.Name = "txtCategoryDescription";
            txtCategoryDescription.Size = new Size(200, 50);
            txtCategoryDescription.TabIndex = 3;
            // 
            // txtCategoryNote
            // 
            txtCategoryNote.Location = new Point(174, 350);
            txtCategoryNote.Name = "txtCategoryNote";
            txtCategoryNote.Size = new Size(200, 27);
            txtCategoryNote.TabIndex = 4;
            // 
            // lblCategoryID
            // 
            lblCategoryID.AutoSize = true;
            lblCategoryID.Location = new Point(24, 241);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(88, 20);
            lblCategoryID.TabIndex = 5;
            lblCategoryID.Text = "Category ID";
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(24, 269);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(113, 20);
            lblCategoryName.TabIndex = 6;
            lblCategoryName.Text = "Category Name";
            // 
            // lblCategoryDescription
            // 
            lblCategoryDescription.AutoSize = true;
            lblCategoryDescription.Location = new Point(24, 297);
            lblCategoryDescription.Name = "lblCategoryDescription";
            lblCategoryDescription.Size = new Size(149, 20);
            lblCategoryDescription.TabIndex = 7;
            lblCategoryDescription.Text = "Category Description";
            // 
            // lblCategoryNote
            // 
            lblCategoryNote.AutoSize = true;
            lblCategoryNote.Location = new Point(24, 353);
            lblCategoryNote.Name = "lblCategoryNote";
            lblCategoryNote.Size = new Size(106, 20);
            lblCategoryNote.TabIndex = 8;
            lblCategoryNote.Text = "Category Note";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(394, 238);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(90, 31);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(394, 273);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(394, 311);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 33);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(394, 350);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(90, 27);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(613, 242);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(200, 27);
            txtSearchName.TabIndex = 13;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(613, 294);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new Size(100, 27);
            txtSearchId.TabIndex = 14;
            // 
            // btnSearchName
            // 
            btnSearchName.Location = new Point(819, 242);
            btnSearchName.Name = "btnSearchName";
            btnSearchName.Size = new Size(89, 27);
            btnSearchName.TabIndex = 15;
            btnSearchName.Text = "Search Name";
            btnSearchName.UseVisualStyleBackColor = true;
            btnSearchName.Click += btnSearchName_Click;
            // 
            // btnSearchById
            // 
            btnSearchById.Location = new Point(719, 290);
            btnSearchById.Name = "btnSearchById";
            btnSearchById.Size = new Size(75, 34);
            btnSearchById.TabIndex = 16;
            btnSearchById.Text = "Search ID";
            btnSearchById.UseVisualStyleBackColor = true;
            btnSearchById.Click += btnSearchById_Click;
            // 
            // lblSearchById
            // 
            lblSearchById.AutoSize = true;
            lblSearchById.Location = new Point(490, 297);
            lblSearchById.Name = "lblSearchById";
            lblSearchById.Size = new Size(92, 20);
            lblSearchById.TabIndex = 17;
            lblSearchById.Text = "Search by ID";
            // 
            // lblSearchByName
            // 
            lblSearchByName.AutoSize = true;
            lblSearchByName.Location = new Point(490, 245);
            lblSearchByName.Name = "lblSearchByName";
            lblSearchByName.Size = new Size(117, 20);
            lblSearchByName.TabIndex = 18;
            lblSearchByName.Text = "Search by Name";
            // 
            // frmCategory
            // 
            ClientSize = new Size(920, 404);
            Controls.Add(lblSearchByName);
            Controls.Add(lblSearchById);
            Controls.Add(btnSearchById);
            Controls.Add(btnSearchName);
            Controls.Add(txtSearchId);
            Controls.Add(txtSearchName);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(lblCategoryNote);
            Controls.Add(lblCategoryDescription);
            Controls.Add(lblCategoryName);
            Controls.Add(lblCategoryID);
            Controls.Add(txtCategoryNote);
            Controls.Add(txtCategoryDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(dgvCategory);
            Name = "frmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Management";
            Load += frmCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.TextBox txtCategoryNote;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.Label lblCategoryNote;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.Label lblSearchById;
        private System.Windows.Forms.Label lblSearchByName;
    }
}
