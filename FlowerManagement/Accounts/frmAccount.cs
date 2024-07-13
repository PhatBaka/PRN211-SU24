using BusinessObjects;
using Repositories.Impls;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FlowerManagement.Customers
{
    public partial class frmAccount : Form
    {
        private readonly ICustomerRepository _customerRepository = new CustomerRepository();

        public frmAccount()
        {
            InitializeComponent();
        }

        private BindingSource source;

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadEntities();
        }

        public void LoadEntities()
        {
            source = new BindingSource();
            var customers = _customerRepository.GetAll().ToList();

            if (!String.IsNullOrEmpty(txtSearchId.Text))
            {
                customers = customers.Where(x => x.CustomerName.Contains(txtSearchId.Text)).ToList();
            }

            source.DataSource = customers;

            txtCustomerId.DataBindings.Clear();
            txtCustomerName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtCustomerStatus.DataBindings.Clear();
            txtPoint.DataBindings.Clear();

            txtCustomerId.DataBindings.Add("Text", source, "CustomerId");
            txtCustomerName.DataBindings.Add("Text", source, "CustomerName");
            txtEmail.DataBindings.Add("Text", source, "Email");
            txtCity.DataBindings.Add("Text", source, "City");
            txtCountry.DataBindings.Add("Text", source, "Country");
            txtPassword.DataBindings.Add("Text", source, "Password");
            txtCustomerStatus.DataBindings.Add("Text", source, "CustomerStatus");
            txtPoint.DataBindings.Add("Text", source, "Point");

            dgvCustomer.DataSource = null;
            dgvCustomer.DataSource = source;

            btnDelete.Enabled = customers.Count > 0;
        }

        private void ClearText()
        {
            txtCustomerId.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCustomerStatus.Text = string.Empty;
            txtPoint.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmAccountDetail frmCustomerDetail = new frmAccountDetail()
            {
                frmCustomer = this,
                InsertOrUpdate = false
            };
            frmCustomerDetail.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = _customerRepository.GetById(Int32.Parse(txtCustomerId.Text));
                if (_customerRepository.Delete(customer))
                {
                    MessageBox.Show($"Delete {customer.CustomerName} successfully");
                }
                LoadEntities();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Customer");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEntities();
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAccountDetail frmCustomerDetail = new frmAccountDetail()
            {
                Text = "Update Customer",
                InsertOrUpdate = true,
                customer = GetCustomer(),
                frmCustomer = this
            };
            frmCustomerDetail.ShowDialog();
        }

        private Customer GetCustomer()
        {
            return new Customer()
            {
                CustomerId = Int32.Parse(txtCustomerId.Text),
                CustomerName = txtCustomerName.Text,
                Email = txtEmail.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Text,
                CustomerStatus = txtCustomerStatus.Text,
                Point = decimal.Parse(txtPoint.Text)
            };
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            int customerId;
            if (int.TryParse(txtSearchId.Text, out customerId))
            {
                var customer = _customerRepository.GetById(customerId);
                if (customer != null)
                {
                    source.DataSource = new List<Customer> { customer };
                }
                else
                {
                    MessageBox.Show("Customer not found");
                    source.DataSource = new List<Customer>();
                }
            }
            else
            {
                MessageBox.Show("Invalid Customer ID");
            }

            dgvCustomer.DataSource = null;
            dgvCustomer.DataSource = source;
        }

        private void btnSearchByEmail_Click(object sender, EventArgs e)
        {
            var email = txtSearchEmail.Text;
            var customers = _customerRepository.GetAll().Where(x => x.Email.Contains(email)).ToList();

            if (customers.Count > 0)
            {
                source.DataSource = customers;
            }
            else
            {
                MessageBox.Show("Customer not found");
                source.DataSource = new List<Customer>();
            }

            dgvCustomer.DataSource = null;
            dgvCustomer.DataSource = source;
        }
    }
}
