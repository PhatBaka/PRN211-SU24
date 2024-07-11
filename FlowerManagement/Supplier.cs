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

        private void btnLoadSupplier_Click(object sender, EventArgs e)
        {
            int supplierID;
            if (int.TryParse(txtSupplierID.Text, out supplierID))
            {
                currentSupplier = supplierDAO.GetById(supplierID);

                if (currentSupplier != null)
                {
                    txtSupplierName.Text = currentSupplier.SupplierName;
                    txtSupplierAddress.Text = currentSupplier.SupplierAddress;
                    txtTelephone.Text = currentSupplier.Telephone;
                }
                else
                {
                    MessageBox.Show("Supplier not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Supplier ID.");
            }
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            if (currentSupplier != null)
            {
                currentSupplier.SupplierName = txtSupplierName.Text;
                currentSupplier.SupplierAddress = txtSupplierAddress.Text;
                currentSupplier.Telephone = txtTelephone.Text;

                if (currentSupplier.SupplierID == 0)
                {
                    supplierDAO.Add(currentSupplier);
                }
                else
                {
                    supplierDAO.Update(currentSupplier);
                }

                MessageBox.Show("Supplier data saved successfully.");
            }
            else
            {
                MessageBox.Show("No Supplier data to save.");
            }
        }

    }
}
