using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObjects;
using DataAccessObjects.Impls;

namespace FlowerManagement
{
    public partial class Supplier : Form
    {
        private BusinessObjects.Supplier currentSupplier;
        private BaseDAO<BusinessObjects.Supplier> supplierDAO;

        public Supplier()
        {
            InitializeComponent();
            supplierDAO = BaseDAO<BusinessObjects.Supplier>.Instance;

            // Wire up the Load event
            this.Load += Supplier_Load;

            // Add event handler for DataGridView selection change
            dataGridViewSuppliers.SelectionChanged += dataGridViewSuppliers_SelectionChanged;
        }

        private void txtSupplierID_TextChanged(object sender, EventArgs e)
        {
            if (currentSupplier != null)
            {
                int supplierID;
                if (int.TryParse(txtSupplierID.Text, out supplierID))
                {
                    currentSupplier.SupplierID = supplierID;
                }
            }
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            if (currentSupplier != null)
            {
                currentSupplier.SupplierName = txtSupplierName.Text;
            }
        }

        private void txtSupplierAddress_TextChanged(object sender, EventArgs e)
        {
            if (currentSupplier != null)
            {
                currentSupplier.SupplierAddress = txtSupplierAddress.Text;
            }
        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {
            if (currentSupplier != null)
            {
                currentSupplier.Telephone = txtTelephone.Text;
            }
        }
        private void btnLoadAllSuppliers_Click_1(object sender, EventArgs e)
        {
            LoadAllSuppliers();
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            if (currentSupplier != null)
            {
                // Update the Supplier data from the form controls
                currentSupplier.SupplierName = txtSupplierName.Text;
                currentSupplier.SupplierAddress = txtSupplierAddress.Text;
                currentSupplier.Telephone = txtTelephone.Text;

                // Save the updated Supplier data
                if (currentSupplier.SupplierID == 0)
                {
                    supplierDAO.Add(currentSupplier);
                }
                else
                {
                    supplierDAO.Update(currentSupplier);
                }

                MessageBox.Show("Supplier data saved successfully.");
                LoadAllSuppliers();
            }
            else
            {
                MessageBox.Show("No Supplier data to save.");
            }
        }
        private void btnDeleteSupplier_Click_1(object sender, EventArgs e)
        {
            if (currentSupplier != null && currentSupplier.SupplierID != 0)
            {
                if (supplierDAO.Delete(currentSupplier))
                {
                    MessageBox.Show("Supplier deleted successfully.");
                    ClearForm();
                    LoadAllSuppliers();
                }
                else
                {
                    MessageBox.Show("Error deleting supplier.");
                }
            }
            else
            {
                MessageBox.Show("No Supplier data to delete.");
            }

        }

        private void ClearForm()
        {
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            txtSupplierAddress.Text = "";
            txtTelephone.Text = "";
            currentSupplier = null;
        }

        private void LoadAllSuppliers()
        {
            var suppliers = supplierDAO.GetAll().ToList();
            dataGridViewSuppliers.DataSource = suppliers;
        }

        private void dataGridViewSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                int supplierID = Convert.ToInt32(dataGridViewSuppliers.SelectedRows[0].Cells["SupplierID"].Value);
                currentSupplier = supplierDAO.GetById(supplierID);

                if (currentSupplier != null)
                {
                    txtSupplierID.Text = currentSupplier.SupplierID.ToString();
                    txtSupplierName.Text = currentSupplier.SupplierName;
                    txtSupplierAddress.Text = currentSupplier.SupplierAddress;
                    txtTelephone.Text = currentSupplier.Telephone;
                }
            }
        }
    }
}
