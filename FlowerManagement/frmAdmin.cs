using BusinessObjects;
using FlowerManagement.Categories;
using FlowerManagement.Customers;
using FlowerManagement.Flowers;
using FlowerManagement.Orders;
using FlowerManagement.Suppliers;
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
    public partial class frmAdmin : Form
    {
        private readonly IOrderRepository _orderRepository = new OrderRepository();


        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Retrieve the start and end dates
            DateTime startDate = txtStartDate.Value.Date;
            DateTime endDate = txtEnddate.Value.Date;

            // Ensure the end date is after the start date
            if (startDate > endDate)
            {
                MessageBox.Show("End Date must be greater than or equal to Start Date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fetch orders within the date range
            var orders = GetAllOrderDTOs()
                            .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                            .ToList();

            dgvOrder.DataSource = orders;

            if (orders.Count == 0)
            {
                MessageBox.Show("No orders found for the selected date range.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvOrder.DataSource = GetAllOrderDTOs();
        }

        private void btnFlower_Click(object sender, EventArgs e)
        {
            frmFlower frmFlower = new frmFlower();
            frmFlower.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            frmAccount frmAccount = new frmAccount();
            frmAccount.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier frmSupplier = new frmSupplier();
            frmSupplier.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            frmCategory.Show();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            dgvOrder.DataSource = GetAllOrderDTOs();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có hàng nào được chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmOrderDetail detailForm = new();
            detailForm.SelectedOrder = (OrderDTO)dgvOrder.SelectedRows[0].DataBoundItem;
            detailForm.ShowDialog();
        }

        public List<OrderDTO> GetAllOrderDTOs()
        {
            var orderDTOlist = new List<OrderDTO>();
            var orderList = _orderRepository.GetAll().ToList();
            foreach (var o in orderList)
            {
                orderDTOlist.Add(new OrderDTO()
                {
                    OrderId = o.OrderId,
                    OrderDate = o.OrderDate,
                    ShippedDate = (o.ShippedDate.Year != 0001) ? o.ShippedDate : null,
                    TotalPrice = o.TotalPrice,
                    FinalPrice = o.FinalPrice,
                    Discount = o.Discount,
                    OrderStatus = o.OrderStatus,
                });
            }
            return orderDTOlist;
        }
    }
}
