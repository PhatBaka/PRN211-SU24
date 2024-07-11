using Services.Impls;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI.Accounts
{
    public partial class frmAccounts : Form
    {
        private readonly IAccountService _accountService = new AccountService();
        private BindingSource source;

        public frmAccounts()
        {
            InitializeComponent();
            LoadEntities();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void dgvAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void LoadEntities()
        {
            source = new BindingSource();

            var accounts = _accountService.GetAccounts().Result.ToList();

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                accounts = accounts.Where(x => x.Username.Contains(txtSearch.Text)).ToList();
            }

            source.DataSource = accounts;

            txtId.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtPassword.DataBindings.Clear();

            txtId.DataBindings.Add("Text", source, "AccountID");
            txtUsername.DataBindings.Add("Text", source, "Username");
            txtPassword.DataBindings.Add("Text", source, "Password");
            cmbRole.DataBindings.Add("Text", source, "Role");

            dgvAccount.DataSource = null;
            dgvAccount.DataSource = source;

            if (accounts.Count == 0)
            {
                ClearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void ClearText()
        {
            txtId.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
