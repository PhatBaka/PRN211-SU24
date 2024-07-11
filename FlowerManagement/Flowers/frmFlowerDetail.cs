using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObjects;
using DataAccessObjects;
using Repositories.Impls;
using Repositories.Interfaces;

namespace FlowerManagement.Flowers
{
    public partial class frmFlowerDetail : Form
    {
        private readonly IFlowerRepository _flowerRepository = new FlowerRepository();
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        private readonly ISupplierRepository _supplierRepository = new SupplierRepository();

        public frmFlowerDetail()
        {
            InitializeComponent();

            cbCategory.DataSource = _categoryRepository.GetAll().ToList();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";

            cbSupplier.DataSource = _supplierRepository.GetAll().ToList();
            cbSupplier.DisplayMember = "SupplierName";
            cbSupplier.ValueMember = "SupplierID";
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imgFlower.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Flower flower = new Flower()
            {
                FlowerBouquetName = txtFlowerBouquetName.Text,
                Description = txtDescription.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                UnitsInStock = int.Parse(txtUnitPrice.Text),
                Morphology = txtMorphology.Text,
                SupplierID = Int32.Parse(cbSupplier.SelectedValue.ToString()),
                CategoryID = Int32.Parse(cbCategory.SelectedValue.ToString())
            };

            if (imgFlower.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imgFlower.Image.Save(ms, imgFlower.Image.RawFormat);
                    flower.Image = ms.ToArray();
                }
            }

            if (_flowerRepository.Add(flower) != null)
            {
                MessageBox.Show("Flower data saved successfully.");
            }
        }
    }
}
