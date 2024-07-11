using BusinessObjects;
using FlowerManagement.ViewModels;
using Repositories.Impls;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        private void LoadEntities()
        {
            cbSupplier.DataSource = _supplierRepository.GetAll().ToList();
            cbCategory.DataSource = _categoryRepository.GetAll().ToList();
            source = new BindingSource();
            IList<FlowerViewModel> list = new List<FlowerViewModel>();

            var flowers = _flowerRepository.GetAll().ToList();

            if (!String.IsNullOrEmpty(txtSearch.Text))
            {
                flowers = flowers.Where(x => x.FlowerBouquetName.Contains(txtSearch.Text)).ToList();
            }

            foreach (Flower flower in flowers)
            {
                var entity = new FlowerViewModel()
                {
                    CategoryName = flower.Category.CategoryName,
                    Description = flower.Description,
                    FlowerBouquetID = flower.FlowerBouquetID,
                    FlowerBouquetName = flower.FlowerBouquetName,
                    FlowerBouquetStatus = flower.FlowerBouquetStatus,
                    Image = flower.Image,
                    Morphology = flower.Morphology,
                    SupplierName = flower.Supplier.SupplierName,
                    UnitPrice = flower.UnitPrice,
                    UnitsInStock = flower.UnitsInStock
                };
                list.Add(entity);
            }

            source.DataSource = list;

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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

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
    }
}
