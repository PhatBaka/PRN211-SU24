using System;
using System.Linq;
using System.Windows.Forms;
using BusinessObjects;
using Repositories.Impls;
using Repositories.Interfaces;

namespace FlowerManagement.Suppliers
{
    public partial class frmSupplierDetail : Form
    {
        private readonly ISupplierRepository _supplierRepository = new SupplierRepository();
        private Supplier Supplier { get; set; }

        public bool InsertOrUpdate { get; set; }
        public Supplier supplier { get; set; }
        public frmSupplier frmSupplier { get; set; }

        public frmSupplierDetail()
        {
            InitializeComponent();
        }

        private void frmSupplierDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate)
            {
                lblTitle.Text = "UPDATE SUPPLIER";
                Supplier = supplier;
                if (Supplier != null)
                {
                    txtSupplierId.Text = Supplier.SupplierID.ToString();
                    txtSupplierName.Text = Supplier.SupplierName;
                    txtSupplierAddress.Text = Supplier.SupplierAddress;
                    txtTelephone.Text = Supplier.Telephone;
                }
            }
            else
            {
                lblSupplierId.Visible = false;
                txtSupplierId.Visible = false;
                lblTitle.Text = "CREATE SUPPLIER";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierName.Text) ||
                string.IsNullOrEmpty(txtSupplierAddress.Text) ||
                string.IsNullOrEmpty(txtTelephone.Text))
            {
                MessageBox.Show("Please provide valid inputs.");
                return;
            }

            try
            {
                if (InsertOrUpdate)
                {
                    Supplier supplier = _supplierRepository.GetById(Int32.Parse(txtSupplierId.Text));

                    supplier.SupplierName = txtSupplierName.Text;
                    supplier.SupplierAddress = txtSupplierAddress.Text;
                    supplier.Telephone = txtTelephone.Text;
                    _supplierRepository.Update(supplier);
                    MessageBox.Show("Supplier updated successfully.");
                }
                else
                {
                    var supplier = new Supplier
                    {
                        SupplierName = txtSupplierName.Text,
                        SupplierAddress = txtSupplierAddress.Text,
                        Telephone = txtTelephone.Text
                    };
                    _supplierRepository.Add(supplier);
                    MessageBox.Show("Supplier added successfully.");
                }
                frmSupplier.LoadEntities();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
