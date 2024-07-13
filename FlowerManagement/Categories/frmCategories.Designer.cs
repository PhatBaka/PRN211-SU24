namespace FlowerManagement.Categories
{
    partial class frmCategories
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
            dataGridViewCategory = new DataGridView();
            textBoxName = new TextBox();
            textBoxDes = new TextBox();
            txtBoxNote = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBoxId = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategory.Location = new Point(26, 22);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.RowTemplate.Height = 25;
            dataGridViewCategory.Size = new Size(431, 346);
            dataGridViewCategory.TabIndex = 0;
            dataGridViewCategory.CellClick += dataGridViewCategory_CellClick;
            dataGridViewCategory.CellContentClick += dataGridViewCategory_CellContentClick;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(536, 133);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(117, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxDes
            // 
            textBoxDes.Location = new Point(536, 172);
            textBoxDes.Name = "textBoxDes";
            textBoxDes.Size = new Size(117, 23);
            textBoxDes.TabIndex = 3;
            // 
            // txtBoxNote
            // 
            txtBoxNote.Location = new Point(536, 209);
            txtBoxNote.Name = "txtBoxNote";
            txtBoxNote.Size = new Size(117, 23);
            txtBoxNote.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 131);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 172);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(469, 209);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "Note";
            // 
            // button1
            // 
            button1.Location = new Point(688, 50);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(688, 121);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 10;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(688, 186);
            button3.Name = "button3";
            button3.Size = new Size(100, 35);
            button3.TabIndex = 11;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(688, 239);
            button4.Name = "button4";
            button4.Size = new Size(100, 35);
            button4.TabIndex = 12;
            button4.Text = "Clear Field";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(531, 79);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(117, 23);
            textBoxId.TabIndex = 13;
            textBoxId.TextChanged += textBoxId_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 82);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 14;
            label1.Text = "Id";
            label1.Click += label1_Click_1;
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBoxId);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxNote);
            Controls.Add(textBoxDes);
            Controls.Add(textBoxName);
            Controls.Add(dataGridViewCategory);
            Name = "frmCategories";
            Text = "frmCategories";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCategory;
        private TextBox textBoxName;
        private TextBox textBoxDes;
        private TextBox txtBoxNote;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBoxId;
        private Label label1;
    }
}