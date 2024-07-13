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
using FlowerManagement.Orders;
using Repositories.Impls;
using Repositories.Interfaces;

namespace FlowerManagement
{
    public partial class frmCustomer : Form
    {
        public Customer Customer { get; set; } = null;
        public frmLogin frmLogin = null;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            frmOrder orderForm = new frmOrder();
            orderForm.Customer = Customer;
            orderForm.ShowDialog();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            frmOrderHistory orderHistoryForm = new frmOrderHistory();
            orderHistoryForm.Customer = Customer;
            orderHistoryForm.ShowDialog();
        }
    }
}
