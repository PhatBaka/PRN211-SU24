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
    public partial class frmAccountDetail : Form
    {
        private readonly ICustomerRepository _customerRepository = new CustomerRepository();
        private Customer Customer { get; set; }

        public bool InsertOrUpdate { get; set; }
        public Customer customer { get; set; }
        public frmAccount frmCustomer { get; set; }

        public frmAccountDetail()
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
                }
            }
            else
            {
                lblCustomerId.Visible = false;
                txtCustomerId.Visible = false;
                lblTitle.Text = "CREATE CUSTOMER";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtCity.Text) ||
                string.IsNullOrEmpty(txtCountry.Text) ||
                string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please provide valid inputs.");
                return;
            }

            try
            {
                if (InsertOrUpdate)
                {
                    Customer customer = _customerRepository.GetById(Int32.Parse(txtCustomerId.Text));

                    // If the email is different from the current email
                    if (!txtEmail.Text.Equals(customer.Email))
                    {
                        // Check if the new email is "admin@gmail.com" or if it already exists in the repository
                        if (txtEmail.Text.Equals("admin@gmail.com") ||
                            _customerRepository.GetFirstOrDefault(x => x.Email.Equals(txtEmail.Text)) != null)
                        {
                            MessageBox.Show("Email already exists");
                            return;
                        }
                    }

                    customer.CustomerName = txtCustomerName.Text;
                    customer.Country = txtCountry.Text;
                    customer.City = txtCity.Text;
                    customer.Email = txtEmail.Text;
                    customer.Password = txtPassword.Text;
                    _customerRepository.Update(customer);
                    MessageBox.Show("Customer updated successfully.");

                }
                else
                {
                    if (txtEmail.Text.Equals("admin@gmail.com")
                            || _customerRepository.GetFirstOrDefault(x => x.Email.Equals(txtEmail.Text)) != null)
                    {
                        MessageBox.Show("Email is existed");
                        return;
                    }

                    var customer = new Customer
                    {
                        CustomerName = txtCustomerName.Text,
                        Email = txtEmail.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text,
                        Password = txtPassword.Text
                    };
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
