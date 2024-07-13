using FlowerManagement.Flowers;
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
    public partial class frmAdmin : Form
    {
        private readonly IOrderRepository _orderRepository;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }

        private void btnFlower_Click(object sender, EventArgs e)
        {
            frmFlower frmFlower = new frmFlower();
            frmFlower.Show();
        }
    }
}
