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
using Repositories.Impls;
using Repositories.Interfaces;

namespace FlowerManagement.Suppliers
{
    public partial class frmSupplierDetail : Form
    {
        private readonly ISupplierRepository _supplierRepository = new SupplierRepository();

        public frmSupplierDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Supplier supplier = new()
            {
                SupplierName = txtName.Text,
                Telephone = txtName.Text,
                SupplierAddress = txtAddress.Text
            };
            if (_supplierRepository.Add(supplier) != null)
            {
                MessageBox.Show("Create successfully");
            }
        }
    }
}
