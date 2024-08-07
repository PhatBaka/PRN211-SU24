﻿using BusinessObjects;
using Microsoft.Extensions.Configuration;
using Repositories.Impls;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
                frmCustomer.frmLogin = this;
                frmCustomer.FormClosed += FrmCustomer_FormClosed; // Handle the FormClosed event
                frmCustomer.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void FrmCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Show the login form again
        }
    }
}
