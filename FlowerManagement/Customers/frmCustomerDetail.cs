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

namespace FlowerManagement.Customers
{
    public partial class frmCustomerDetail : Form
    {
        private readonly ICustomerRepository _customerRepository = new CustomerRepository();
        private Customer Customer { get; set; }

        public bool InsertOrUpdate { get; set; }
        public Customer customer { get; set; }
        public frmCustomer frmCustomer { get; set; }

        public frmCustomerDetail()
        {
            InitializeComponent();
        }

        private void frmCustomerDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate)
            {
                lblTitle.Text = "UPDATE CUSTOMER";
                Customer = customer;
                if (Customer != null)
                {
                    txtCustomerId.Text = Customer.CustomerId.ToString();
                    txtCustomerName.Text = Customer.CustomerName;
                    txtEmail.Text = Customer.Email;
                    txtCity.Text = Customer.City;
                    txtCountry.Text = Customer.Country;
                    txtPassword.Text = Customer.Password;
                    txtCustomerStatus.Text = Customer.CustomerStatus;
                    txtPoint.Text = Customer.Point.ToString();
                }
            }
            else
            {
                lblTitle.Text = "CREATE CUSTOMER";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtCity.Text) ||
                string.IsNullOrEmpty(txtCountry.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtCustomerStatus.Text) ||
                !int.TryParse(txtPoint.Text, out int points))
            {
                MessageBox.Show("Please provide valid inputs.");
                return;
            }

            var customer = new Customer
            {
                CustomerName = txtCustomerName.Text,
                Email = txtEmail.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Text,
                CustomerStatus = txtCustomerStatus.Text,
                Point = points
            };

            try
            {
                if (InsertOrUpdate)
                {
                    customer.CustomerId = Int32.Parse(txtCustomerId.Text);
                    _customerRepository.Update(customer);
                    MessageBox.Show("Customer updated successfully.");
                }
                else
                {
                    _customerRepository.Add(customer);
                    MessageBox.Show("Customer added successfully.");
                }
                frmCustomer.LoadEntities();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
