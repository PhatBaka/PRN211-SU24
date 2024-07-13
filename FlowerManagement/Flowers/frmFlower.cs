using BusinessObjects;
using FlowerManagement.ViewModels;
using Repositories.Impls;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FlowerManagement.Flowers
{
    public partial class frmFlower : Form
    {
        private readonly IFlowerRepository _flowerRepository = new FlowerRepository();
        private readonly ISupplierRepository _supplierRepository = new SupplierRepository();
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();

        public frmFlower()
        {
            InitializeComponent();
        }

        private BindingSource source;

        private void frmFlower_Load(object sender, EventArgs e)
        {
            LoadEntities();
        }

        public void LoadEntities()
        {
            cbCategory.DataSource = _categoryRepository.GetAll().ToList();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";

            cbSupplier.DataSource = _supplierRepository.GetAll().ToList();
            cbSupplier.DisplayMember = "SupplierName";
            cbSupplier.ValueMember = "SupplierID";

            source = new BindingSource();
            IList<FlowerViewModel> list = new List<FlowerViewModel>();

            var flowers = _flowerRepository.GetAll().ToList();

            foreach (Flower flower in flowers)
            {
                var entity = new FlowerViewModel()
                {
                    CategoryName = flower.Category.CategoryName,
                    Description = flower.Description,
                    FlowerBouquetID = flower.FlowerBouquetID,
                    FlowerBouquetName = flower.FlowerBouquetName,
                    Image = flower.Image,
                    Morphology = flower.Morphology,
                    SupplierName = flower.Supplier.SupplierName,
                    UnitPrice = flower.UnitPrice,
                    UnitsInStock = flower.UnitsInStock
                };
                list.Add(entity);
            }

            source.DataSource = list;

            BindControls();

            dgvFlower.DataSource = null;
            dgvFlower.DataSource = source;

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

        private void BindControls()
        {
            txtID.DataBindings.Clear();
            txtFlowerBouquetName.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtUnitsInStock.DataBindings.Clear();
            txtMorphology.DataBindings.Clear();
            txtDescription.DataBindings.Clear();
            cbSupplier.DataBindings.Clear();
            cbCategory.DataBindings.Clear();
            imgFlower.DataBindings.Clear();

            txtID.DataBindings.Add("Text", source, "FlowerBouquetID");
            txtFlowerBouquetName.DataBindings.Add("Text", source, "FlowerBouquetName");
            txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
            txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
            txtMorphology.DataBindings.Add("Text", source, "Morphology");
            txtDescription.DataBindings.Add("Text", source, "Description");
            cbSupplier.DataBindings.Add("Text", source, "SupplierName");
            cbCategory.DataBindings.Add("Text", source, "CategoryName");

            Binding imageBinding = new Binding("Image", source, "Image", true);
            imageBinding.Format += new ConvertEventHandler(ImageBinding_Format);
            imgFlower.DataBindings.Add(imageBinding);
        }

        private void ClearText()
        {
            txtID.Text = string.Empty;
            txtFlowerBouquetName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
            txtMorphology.Text = string.Empty;
            cbSupplier.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmFlowerDetail frmFlowerDetail = new frmFlowerDetail()
            {
                frmFlower = this,
                InsertOrUpdate = false
            };
            frmFlowerDetail.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var flower = _flowerRepository.GetById(Int32.Parse(txtID.Text));
                if (_flowerRepository.Delete(flower))
                {
                    MessageBox.Show($"Delete {flower.FlowerBouquetName} successfully");
                }
                LoadEntities();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a flower");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEntities();
        }

        private void ImageBinding_Format(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType != typeof(Image) || e.Value == null)
            {
                e.Value = null;
            }
            else
            {
                byte[] imageBytes = (byte[])e.Value;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    e.Value = Image.FromStream(ms);
                }
            }
        }

        private void dgvFlower_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmFlowerDetail frmFlowerDetail = new frmFlowerDetail()
            {
                Text = "Update flower",
                InsertOrUpdate = true,
                flower = GetFlower(),
                frmFlower = this
            };
            frmFlowerDetail.ShowDialog();
        }

        private Flower GetFlower()
        {
            Flower flower = new Flower()
            {
                FlowerBouquetID = Int32.Parse(txtID.Text),
                CategoryID = Int32.Parse(cbCategory.SelectedValue.ToString()),
                SupplierID = Int32.Parse(cbSupplier.SelectedValue.ToString()),
                Description = txtDescription.Text,
                FlowerBouquetName = txtFlowerBouquetName.Text,
                Image = Utils.Utils.ImageToByteArray(imgFlower.Image),
                Morphology = txtMorphology.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                UnitsInStock = Int32.Parse(txtUnitsInStock.Text)
            };
            return flower;
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchName.Text.ToLower();
            var filteredList = _flowerRepository.GetAll().Where(f => f.FlowerBouquetName.ToLower().Contains(searchValue)).ToList();
            UpdateBindingSource(filteredList);
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text, out int searchId))
            {
                var filteredList = _flowerRepository.GetAll().Where(f => f.FlowerBouquetID == searchId).ToList();
                UpdateBindingSource(filteredList);
            }
            else
            {
                MessageBox.Show("Please enter a valid ID", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBindingSource(IEnumerable<Flower> flowers)
        {
            IList<FlowerViewModel> list = new List<FlowerViewModel>();

            foreach (Flower flower in flowers)
            {
                var entity = new FlowerViewModel()
                {
                    CategoryName = flower.Category.CategoryName,
                    Description = flower.Description,
                    FlowerBouquetID = flower.FlowerBouquetID,
                    FlowerBouquetName = flower.FlowerBouquetName,
                    Image = flower.Image,
                    Morphology = flower.Morphology,
                    SupplierName = flower.Supplier.SupplierName,
                    UnitPrice = flower.UnitPrice,
                    UnitsInStock = flower.UnitsInStock
                };
                list.Add(entity);
            }

            source.DataSource = list;
            BindControls();

            dgvFlower.DataSource = null;
            dgvFlower.DataSource = source;

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
    }
}
