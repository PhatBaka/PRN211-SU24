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

namespace FlowerManagement
{
    public partial class FlowerBouquetID : Form
    {
        private Flower currentFlower;

        public FlowerBouquetID()
        {
            InitializeComponent();
        }

        private void chkFlowerBouquetStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (currentFlower != null)
            {
                currentFlower.FlowerBouquetStatus = chkFlowerBouquetStatus.Checked;
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
                currentFlower.Image = File.ReadAllBytes(imagePath);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int flowerBouquetID;
            if (int.TryParse(txtFlowerBouquetID.Text, out flowerBouquetID))
            {

                currentFlower = FlowerDataAccess.GetFlowerByID(flowerBouquetID);

                if (currentFlower != null)
                {
                    txtFlowerBouquetName.Text = currentFlower.FlowerBouquetName;
                    txtDescription.Text = currentFlower.Description;
                    txtUnitPrice.Text = currentFlower.UnitPrice.ToString();
                    txtUnitsInStock.Text = currentFlower.UnitsInStock.ToString();
                    chkFlowerBouquetStatus.Checked = currentFlower.FlowerBouquetStatus;
                    txtMorphology.Text = currentFlower.Morphology;
                    txtCategoryID.Text = currentFlower.CategoryID.ToString();
                    txtSupplierID.Text = currentFlower.SupplierID.ToString();

                    if (currentFlower.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(currentFlower.Image))
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (currentFlower != null)
            {

                currentFlower.FlowerBouquetName = txtFlowerBouquetName.Text;
                currentFlower.Description = txtDescription.Text;
                currentFlower.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                currentFlower.UnitsInStock = int.Parse(txtUnitsInStock.Text);
                currentFlower.FlowerBouquetStatus = chkFlowerBouquetStatus.Checked;
                currentFlower.Morphology = txtMorphology.Text;
                currentFlower.CategoryID = int.Parse(txtCategoryID.Text);
                currentFlower.SupplierID = int.Parse(txtSupplierID.Text);

                FlowerDataAccess.SaveFlower(currentFlower);
                MessageBox.Show("Flower data saved successfully.");
            }
            else
            {
                MessageBox.Show("No Flower data to save.");
            }

        }

        private void txtFlowerBouquetID_TextChanged(object sender, EventArgs e)
        {
            if (currentFlower != null)
            {
                int flowerBouquetID;
                if (int.TryParse(txtFlowerBouquetID.Text, out flowerBouquetID))
                {
                    currentFlower.FlowerBouquetID = flowerBouquetID;
                }
            }
        }

        private void txtFlowerBouquetName_TextChanged(object sender, EventArgs e)
        {
            if (currentFlower != null)
            {
                currentFlower.FlowerBouquetName = txtFlowerBouquetName.Text;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (currentFlower != null)
            {
                currentFlower.Description = txtDescription.Text;
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (currentFlower != null)
            {
                decimal unitPrice;
                if (decimal.TryParse(txtUnitPrice.Text, out unitPrice))
                {
                    currentFlower.UnitPrice = unitPrice;
                }
            }
        }

        private void txtUnitsInStock_TextChanged(object sender, EventArgs e)
        {
            if (currentFlower != null)
            {
                int unitsInStock;
                if (int.TryParse(txtUnitsInStock.Text, out unitsInStock))
                {
                    currentFlower.UnitsInStock = unitsInStock;
                }
            }
        }

        private void txtMorphology_TextChanged(object sender, EventArgs e)
        {
            if (currentFlower != null)
            {
                currentFlower.Morphology = txtMorphology.Text;
            }
        }

        private void txtCategoryID_TextChanged(object sender, EventArgs e)
        {
            if (currentFlower != null)
            {
                int categoryID;
                if (int.TryParse(txtCategoryID.Text, out categoryID))
                {
                    currentFlower.CategoryID = categoryID;
                }
            }
        }

        private void txtSupplierID_TextChanged(object sender, EventArgs e)
        {
            if (currentFlower != null)
            {
                int supplierID;
                if (int.TryParse(txtSupplierID.Text, out supplierID))
                {
                    currentFlower.SupplierID = supplierID;
                }
            }
        }


    }
}
