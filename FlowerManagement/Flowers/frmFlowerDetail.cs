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
        private Flower Flower { get; set; }

        public bool InsertOrUpdate { get; set; }
        public Flower flower { get; set; }
        public frmFlower frmFlower { get; set; }

        public frmFlowerDetail()
        {
            InitializeComponent();
        }

        private void frmFlowerDetail_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = _categoryRepository.GetAll().ToList();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";

            cbSupplier.DataSource = _supplierRepository.GetAll().ToList();
            cbSupplier.DisplayMember = "SupplierName";
            cbSupplier.ValueMember = "SupplierID";

            if (InsertOrUpdate)
            {
                lblTitle.Text = "UPDATE FLOWER";
                Flower = flower;
                if (Flower != null)
                {
                    txtId.Text = Flower.FlowerBouquetID.ToString();
                    txtDescription.Text = Flower.Description;
                    txtFlowerBouquetName.Text = Flower.FlowerBouquetName;
                    txtMorphology.Text = Flower.Morphology;
                    txtUnitPrice.Text = Flower.UnitPrice.ToString();
                    txtUnitsInStock.Text = Flower.UnitsInStock.ToString();
                    cbCategory.SelectedValue = Flower.CategoryID;
                    cbSupplier.SelectedValue = Flower.SupplierID;
                    if (Flower.Image != null)
                    {
                        using (var ms = new MemoryStream(Flower.Image))
                        {
                            imgFlower.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
            else
            {
                lblTitle.Text = "CREATE FLOWER";
            }
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
            if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) ||
                    !int.TryParse(txtUnitsInStock.Text, out int unitsInStock) ||
                    string.IsNullOrEmpty(txtFlowerBouquetName.Text) ||
                    cbCategory.SelectedValue == null ||
                    cbSupplier.SelectedValue == null)
            {
                MessageBox.Show("Please provide valid inputs.");
                return;
            }

            if (imgFlower.Image == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            // Check if the image is in PNG format
            if (!imgFlower.Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
            {
                MessageBox.Show("The image must be in PNG format.");
                return;
            }

            byte[] imageBytes;
            using (var ms = new MemoryStream())
            {
                // Save the image as PNG format
                imgFlower.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageBytes = ms.ToArray();
            }

            // Proceed with saving the imageBytes to the database or further processing

            var flower = new Flower
            {
                FlowerBouquetName = txtFlowerBouquetName.Text,
                Description = txtDescription.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                UnitsInStock = Int32.Parse(txtUnitsInStock.Text),
                Morphology = txtMorphology.Text,
                SupplierID = (int)cbSupplier.SelectedValue,
                CategoryID = (int)cbCategory.SelectedValue,
                Image = imageBytes
            };

            try
            {
                if (InsertOrUpdate)
                {
                    flower.FlowerBouquetID = Int32.Parse(txtId.Text);
                    _flowerRepository.Update(flower);
                    MessageBox.Show("Flower updated successfully.");
                }
                else
                {
                    _flowerRepository.Add(flower);
                    MessageBox.Show("Flower added successfully.");
                }
                frmFlower.LoadEntities();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
