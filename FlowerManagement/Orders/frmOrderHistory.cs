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
using Repositories.Impls;
using Repositories.Interfaces;

namespace FlowerManagement.Orders
{
    public partial class frmOrderHistory : Form
    {
        public Customer Customer { get; set; } = null;
        private readonly IBaseRepository<Order> _orderRepo = new BaseRepository<Order>();
        private OrderDTO _selectedOrderDTO = null;
        public frmOrderHistory()
        {
            InitializeComponent();
        }

        public List<OrderDTO> GetAllOrderDTOs()
        {
            var orderDTOlist = new List<OrderDTO>();
            var orderList = _orderRepo.GetAll().ToList();
            foreach (var o in orderList)
            {
                if (o.CustomerId == Customer.CustomerId)
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
            }
            return orderDTOlist;
        }

        private void frmOrderHistory_Load(object sender, EventArgs e)
        {
            dgvOrderList.DataSource = GetAllOrderDTOs();
        }

        private void dgvOrderList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrderList.SelectedRows.Count > 0)
            {
                _selectedOrderDTO = (OrderDTO)dgvOrderList.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvOrderList.DataSource = null;
            dgvOrderList.DataSource = GetAllOrderDTOs();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có hàng nào được chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmOrderDetail detailForm = new();
            detailForm.SelectedOrder = (OrderDTO)dgvOrderList.SelectedRows[0].DataBoundItem;
            detailForm.ShowDialog();
        }
    }
}
