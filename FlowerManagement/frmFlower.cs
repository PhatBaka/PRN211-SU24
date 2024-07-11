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

namespace FlowerManagement
{
    public partial class frmFlower : Form
    {
        private Flower? Flower;
        private readonly IFlowerRepository _flowerRepository = new FlowerRepository();

        public frmFlower()
        {
            InitializeComponent();
        }

        private void chkFlowerBouquetStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (Flower != null)
            {
                Flower.FlowerBouquetStatus = chkFlowerBouquetStatus.Checked;
            }
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                picImage.Image = Image.FromFile(imagePath);
                Flower.Image = File.ReadAllBytes(imagePath);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int flowerBouquetID;
            if (int.TryParse(txtFlowerBouquetID.Text, out flowerBouquetID))
            {

                Flower = _flowerRepository.GetById(flowerBouquetID);

                if (Flower != null)
                {
                    txtFlowerBouquetName.Text = Flower.FlowerBouquetName;
                    txtDescription.Text = Flower.Description;
                    txtUnitPrice.Text = Flower.UnitPrice.ToString();
                    txtUnitsInStock.Text = Flower.UnitsInStock.ToString();
                    chkFlowerBouquetStatus.Checked = Flower.FlowerBouquetStatus;
                    txtMorphology.Text = Flower.Morphology;
                    txtCategoryID.Text = Flower.CategoryID.ToString();
                    txtSupplierID.Text = Flower.SupplierID.ToString();

                    if (Flower.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(Flower.Image))
                        {
                            picImage.Image = Image.FromStream(ms);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Flower not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Flower Bouquet ID.");
            }
        }

        private void txtFlowerBouquetID_TextChanged(object sender, EventArgs e)
        {
            if (Flower != null)
            {
                int flowerBouquetID;
                if (int.TryParse(txtFlowerBouquetID.Text, out flowerBouquetID))
                {
                    Flower.FlowerBouquetID = flowerBouquetID;
                }
            }
        }

        private void txtFlowerBouquetName_TextChanged(object sender, EventArgs e)
        {
            if (Flower != null)
            {
                Flower.FlowerBouquetName = txtFlowerBouquetName.Text;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (Flower != null)
            {
                Flower.Description = txtDescription.Text;
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (Flower != null)
            {
                decimal unitPrice;
                if (decimal.TryParse(txtUnitPrice.Text, out unitPrice))
                {
                    Flower.UnitPrice = unitPrice;
                }
            }
        }

        private void txtUnitsInStock_TextChanged(object sender, EventArgs e)
        {
            if (Flower != null)
            {
                int unitsInStock;
                if (int.TryParse(txtUnitsInStock.Text, out unitsInStock))
                {
                    Flower.UnitsInStock = unitsInStock;
                }
            }
        }

        private void txtMorphology_TextChanged(object sender, EventArgs e)
        {
            if (Flower != null)
            {
                Flower.Morphology = txtMorphology.Text;
            }
        }

        private void txtCategoryID_TextChanged(object sender, EventArgs e)
        {
            if (Flower != null)
            {
                int categoryID;
                if (int.TryParse(txtCategoryID.Text, out categoryID))
                {
                    Flower.CategoryID = categoryID;
                }
            }
        }

        private void txtSupplierID_TextChanged(object sender, EventArgs e)
        {
            if (Flower != null)
            {
                int supplierID;
                if (int.TryParse(txtSupplierID.Text, out supplierID))
                {
                    Flower.SupplierID = supplierID;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Flower != null)
            {

                Flower.FlowerBouquetName = txtFlowerBouquetName.Text;
                Flower.Description = txtDescription.Text;
                Flower.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                Flower.UnitsInStock = int.Parse(txtUnitsInStock.Text);
                Flower.FlowerBouquetStatus = chkFlowerBouquetStatus.Checked;
                Flower.Morphology = txtMorphology.Text;
                Flower.CategoryID = int.Parse(txtCategoryID.Text);
                Flower.SupplierID = int.Parse(txtSupplierID.Text);

                _flowerRepository.Add(Flower);
                MessageBox.Show("Flower data saved successfully.");
            }
            else
            {
                MessageBox.Show("No Flower data to save.");
            }
        }
    }
}
