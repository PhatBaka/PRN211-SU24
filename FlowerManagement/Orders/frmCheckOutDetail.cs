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
    public partial class frmCheckOutDetail : Form
    {
        private readonly IBaseRepository<Order> _orderRepo;
        private readonly IBaseRepository<OrderDetail> _orderDetailRepo;
        private readonly IBaseRepository<Customer> _customerRepo;
        private readonly IBaseRepository<Flower> _flowerRepo;
        public List<CheckOutDetail> checkOutDetailList;
        public frmCart frmCart = null;
        public frmCheckOutDetail()
        {
            InitializeComponent();
            _orderRepo = new BaseRepository<Order>();
            _orderDetailRepo = new BaseRepository<OrderDetail>();
            _customerRepo = new BaseRepository<Customer>();
            _flowerRepo = new BaseRepository<Flower>();
            checkOutDetailList = new();
        }

        private void frmCheckOutDetail_Load(object sender, EventArgs e)
        {
            dgvCheckOut.DataSource = checkOutDetailList;
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Text = checkOutDetailList.Sum(x => x.Price).ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn tạo đơn hàng?", "Tạo đơn hàng?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                return;
            }
            var customer = _customerRepo.GetFirstOrDefault(c => c.Email == txtCustomerEmail.Text.Trim());
            if (customer == null)
            {
                return;
            }
            var order = new Order()
            {
                OrderDate = DateTime.Now,
                TotalPrice = decimal.Parse(txtTotalPrice.Text),
                OrderStatus = "Pending",
                CustomerId = customer.CustomerId
            };
            float discount = 0;//lấy dữ liệu từ ô discount rate hiển thị trên form CheckOutDetail
            //check đk point ở đây
            order.FinalPrice = discount == 0 ? order.TotalPrice : order.TotalPrice * (1 - (decimal)discount);
            order.Discount = discount;
            var createdOrder = _orderRepo.Add(order);
            foreach (var f in checkOutDetailList)
            {
                var flower = _flowerRepo.GetFirstOrDefault(fl => fl.FlowerBouquetID == f.FlowerBouquetID);
                if (flower != null)
                {
                    _orderDetailRepo.Add(new OrderDetail()
                    {
                        OrderID = createdOrder.OrderId,
                        FlowerBouquetID = f.FlowerBouquetID,
                        UnitPrice = (decimal)f.UnitPrice,
                        Quantity = (int)f.Quantity,
                    });
                    flower.UnitsInStock -= (int)f.Quantity;
                    _flowerRepo.Update(flower);
                }
            }
            MessageBox.Show("Tạo đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmCart.selectedFlowers.Clear();
            this.Close();
            frmCart.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCart.Close();
        }
    }
}
