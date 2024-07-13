using BusinessObjects;
using FlowerManagement.ViewModels;
using Repositories.Impls;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FlowerManagement.Categories
{
    public partial class frmCategory : Form
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        private BindingSource source;

        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadEntities();
        }

        public void LoadEntities()
        {
            source = new BindingSource();
            IList<CategoryViewModel> list = new List<CategoryViewModel>();

            var categories = _categoryRepository.GetAll().ToList();

            foreach (Category category in categories)
            {
                var entity = new CategoryViewModel()
                {
                    CategoryID = category.CategoryID,
                    CategoryName = category.CategoryName,
                    CategoryDescription = category.CategoryDescription,
                    CategoryNote = category.CategoryNote
                };
                list.Add(entity);
            }

            source.DataSource = list;

            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();
            txtCategoryDescription.DataBindings.Clear();
            txtCategoryNote.DataBindings.Clear();

            txtCategoryID.DataBindings.Add("Text", source, "CategoryID");
            txtCategoryName.DataBindings.Add("Text", source, "CategoryName");
            txtCategoryDescription.DataBindings.Add("Text", source, "CategoryDescription");
            txtCategoryNote.DataBindings.Add("Text", source, "CategoryNote");

            dgvCategory.DataSource = null;
            dgvCategory.DataSource = source;

            if (list.Count == 0)
            {
                ClearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void ClearText()
        {
            txtCategoryID.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            txtCategoryDescription.Text = string.Empty;
            txtCategoryNote.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCategoryDetail frmCategoryDetail = new frmCategoryDetail()
            {
                frmCategory = this,
                InsertOrUpdate = false
            };
            frmCategoryDetail.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCategoryDetail frmCategoryDetail = new frmCategoryDetail()
            {
                Text = "Update Category",
                InsertOrUpdate = true,
                Category = GetCategory(),
                frmCategory = this
            };
            frmCategoryDetail.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var category = _categoryRepository.GetById(Int32.Parse(txtCategoryID.Text));

                if (category.Flowers.Count > 0)
                {
                    MessageBox.Show("This category is in used. Can not delete");
                    return;
                }

                if (_categoryRepository.Delete(category))
                {
                    MessageBox.Show($"Delete {category.CategoryName} successfully");
                }
                LoadEntities();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Category");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEntities();
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchName.Text.ToLower();
            var filteredList = _categoryRepository.GetAll().Where(c => c.CategoryName.ToLower().Contains(searchValue)).ToList();
            UpdateBindingSource(filteredList);
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text, out int searchId))
            {
                var filteredList = _categoryRepository.GetAll().Where(c => c.CategoryID == searchId).ToList();
                UpdateBindingSource(filteredList);
            }
            else
            {
                MessageBox.Show("Please enter a valid ID", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBindingSource(IEnumerable<Category> categories)
        {
            IList<CategoryViewModel> list = new List<CategoryViewModel>();

            foreach (Category category in categories)
            {
                var entity = new CategoryViewModel()
                {
                    CategoryID = category.CategoryID,
                    CategoryName = category.CategoryName,
                    CategoryDescription = category.CategoryDescription,
                    CategoryNote = category.CategoryNote
                };
                list.Add(entity);
            }

            source.DataSource = list;

            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();
            txtCategoryDescription.DataBindings.Clear();
            txtCategoryNote.DataBindings.Clear();

            txtCategoryID.DataBindings.Add("Text", source, "CategoryID");
            txtCategoryName.DataBindings.Add("Text", source, "CategoryName");
            txtCategoryDescription.DataBindings.Add("Text", source, "CategoryDescription");
            txtCategoryNote.DataBindings.Add("Text", source, "CategoryNote");

            dgvCategory.DataSource = null;
            dgvCategory.DataSource = source;

            if (list.Count == 0)
            {
                ClearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private Category GetCategory()
        {
            Category category = new Category()
            {
                CategoryID = Int32.Parse(txtCategoryID.Text),
                CategoryName = txtCategoryName.Text,
                CategoryDescription = txtCategoryDescription.Text,
                CategoryNote = txtCategoryNote.Text
            };
            return category;
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is selected
            if (e.RowIndex >= 0)
            {
                // Get the selected category from the DataGridView
                var selectedCategory = dgvCategory.Rows[e.RowIndex].DataBoundItem as CategoryViewModel;

                if (selectedCategory != null)
                {
                    // Open the frmCategoryDetail form in update mode
                    frmCategoryDetail frmCategoryDetail = new frmCategoryDetail()
                    {
                        Text = "Update Category",
                        InsertOrUpdate = true,
                        Category = new Category()
                        {
                            CategoryID = selectedCategory.CategoryID,
                            CategoryName = selectedCategory.CategoryName,
                            CategoryDescription = selectedCategory.CategoryDescription,
                            CategoryNote = selectedCategory.CategoryNote
                        },
                        frmCategory = this
                    };
                    frmCategoryDetail.ShowDialog();
                }
            }
        }
    }
}
