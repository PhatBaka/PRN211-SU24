using BusinessObjects;
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
using System.Xml.Linq;

namespace UI.Customers
{
    public partial class frmCustomers : Form
    {
        BindingSource source;
        private readonly IGenericRepository<Customer> _genericRepository;

        public frmCustomers(IGenericRepository<Customer> genericRepository)
        {
            InitializeComponent();
            _genericRepository = genericRepository;
        }

        private async void frmCustomers_Load(object sender, EventArgs e) => await LoadCustomerList();

        public async Task LoadCustomerList()
        {
            var customers = await _genericRepository.GetAllAsync();
            try
            {
                source = new BindingSource();
                source.DataSource = customers;

                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load customer list");
            }
        }
    }
}
