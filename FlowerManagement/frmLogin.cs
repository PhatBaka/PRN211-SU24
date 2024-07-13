using BusinessObjects;
using Microsoft.Extensions.Configuration;
using Repositories.Impls;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerManagement
{
    public partial class frmLogin : Form
    {
        private readonly ICustomerRepository _customerRepository = new CustomerRepository();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var adminEmail = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AdminAccount:Email").Value;
            var adminPassword = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AdminAccount:Password").Value;
        
            if (txtEmail.Text.Equals(adminEmail) 
                    && txtPassword.Text.Equals(adminPassword))
            {
                frmAdmin frmAdmin = new frmAdmin();
                frmAdmin.Show();
                return;
            }

            Customer customer = _customerRepository.GetFirstOrDefault(x => x.Email.Equals(txtEmail.Text)
                                                                        && x.Password.Equals(txtPassword.Text));

            if (customer != null)
            {
                frmCustomer frmCustomer = new frmCustomer();
                frmCustomer.Customer = customer;
                frmCustomer.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Login fail");
            }
        }
    }
}
