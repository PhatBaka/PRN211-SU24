using BusinessObjects;
using FlowerManagement.ViewModels;
using Repositories.Impls;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FlowerManagement.Suppliers
{
    public partial class frmSupplier : Form
    {
        private readonly ISupplierRepository _supplierRepository = new SupplierRepository();

        public frmSupplier()
        {
            InitializeComponent();
        }

        private BindingSource source;

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoadEntities();
        }

        public void LoadEntities()
        {
            source = new BindingSource();
            IList<SupplierViewModel> list = new List<SupplierViewModel>();
            var suppliers = _supplierRepository.GetAll().ToList();

            foreach (Supplier supplier in suppliers)
            {
                var entity = new SupplierViewModel()
                {
                    SupplierAddress = supplier.SupplierAddress,
                    SupplierID = supplier.SupplierID,
                    SupplierName = supplier.SupplierName,
                    Telephone = supplier.Telephone
                };
                list.Add(entity);
            }

            source.DataSource = list;

            txtSupplierId.DataBindings.Clear();
            txtSupplierName.DataBindings.Clear();
            txtSupplierAddress.DataBindings.Clear();
            txtTelephone.DataBindings.Clear();

            txtSupplierId.DataBindings.Add("Text", source, "SupplierID");
            txtSupplierName.DataBindings.Add("Text", source, "SupplierName");
            txtSupplierAddress.DataBindings.Add("Text", source, "SupplierAddress");
            txtTelephone.DataBindings.Add("Text", source, "Telephone");

            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = source;

            btnDelete.Enabled = suppliers.Count > 0;
        }

        private void ClearText()
        {
            txtSupplierId.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            txtSupplierAddress.Text = string.Empty;
            txtTelephone.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmSupplierDetail frmSupplierDetail = new frmSupplierDetail()
            {
                frmSupplier = this,
                InsertOrUpdate = false
            };
            frmSupplierDetail.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var supplier = _supplierRepository.GetById(Int32.Parse(txtSupplierId.Text));
                if (_supplierRepository.Delete(supplier))
                {
                    MessageBox.Show($"Delete {supplier.SupplierName} successfully");
                }
                LoadEntities();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Supplier");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEntities();
        }

        private void dgvSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSupplierDetail frmSupplierDetail = new frmSupplierDetail()
            {
                Text = "Update Supplier",
                InsertOrUpdate = true,
                supplier = GetSupplier(),
                frmSupplier = this
            };
            frmSupplierDetail.ShowDialog();
        }

        private Supplier GetSupplier()
        {
            return new Supplier()
            {
                SupplierID = Int32.Parse(txtSupplierId.Text),
                SupplierName = txtSupplierName.Text,
                SupplierAddress = txtSupplierAddress.Text,
                Telephone = txtTelephone.Text
            };
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            var name = txtSearchName.Text;
            var suppliers = _supplierRepository.GetAll().Where(x => x.SupplierName.Contains(name)).ToList();

            if (suppliers.Count > 0)
            {
                source.DataSource = suppliers;
            }
            else
            {
                MessageBox.Show("Supplier not found");
                source.DataSource = new List<Supplier>();
            }

            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = source;
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            int supplierId;
            if (int.TryParse(txtSearchId.Text, out supplierId))
            {
                var supplier = _supplierRepository.GetById(supplierId);
                if (supplier != null)
                {
                    source.DataSource = new List<Supplier> { supplier };
                }
                else
                {
                    MessageBox.Show("Supplier not found");
                    source.DataSource = new List<Supplier>();
                }
            }
            else
            {
                MessageBox.Show("Invalid Supplier ID");
            }

            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = source;
        }
    }
}
