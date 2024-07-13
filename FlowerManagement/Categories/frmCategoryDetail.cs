using BusinessObjects;
using Repositories.Impls;
using Repositories.Interfaces;
using System;
using System.Windows.Forms;

namespace FlowerManagement.Categories
{
    public partial class frmCategoryDetail : Form
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public frmCategory frmCategory { get; set; }
        public Category Category { get; set; }
        public bool InsertOrUpdate { get; set; }

        public frmCategoryDetail()
        {
            InitializeComponent();
        }

        private void frmCategoryDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate)
            {
                txtCategoryID.Text = Category.CategoryID.ToString();
                txtCategoryName.Text = Category.CategoryName;
                txtCategoryDescription.Text = Category.CategoryDescription;
                txtCategoryNote.Text = Category.CategoryNote;
                btnSave.Text = "Update";
            }
            else
            {
                btnSave.Text = "Create";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertOrUpdate)
                {
                    Category category = _categoryRepository.GetById(Int32.Parse(txtCategoryID.Text));

                    category.CategoryName = txtCategoryName.Text;
                    category.CategoryDescription = txtCategoryDescription.Text;
                    category.CategoryNote = txtCategoryNote.Text;

                    _categoryRepository.Update(category);
                    MessageBox.Show($"Category {category.CategoryName} updated successfully.");
                    frmCategory.LoadEntities();
                }
                else
                {
                    Category newCategory = new Category()
                    {
                        CategoryName = txtCategoryName.Text,
                        CategoryDescription = txtCategoryDescription.Text,
                        CategoryNote = txtCategoryNote.Text
                    };
                    _categoryRepository.Add(newCategory);
                    MessageBox.Show($"Category {newCategory.CategoryName} created successfully.");
                    frmCategory.LoadEntities();
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
