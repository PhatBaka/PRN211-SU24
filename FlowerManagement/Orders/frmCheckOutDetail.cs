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
        private readonly IBaseRepository<Order> _orderRepo = null;
        private readonly IBaseRepository<OrderDetail> _orderDetailRepo = null;
        private readonly IBaseRepository<Customer> _customerRepo = null;
        private readonly IBaseRepository<Flower> _flowerRepo =null;
        public List<CheckOutDetail> checkOutDetailList;
        public frmCart frmCart = null;
        public Customer Customer { get; set; } = null;
        public frmCheckOutDetail()
        {
            InitializeComponent();
            if (_orderRepo == null)
            {
                _orderRepo = new BaseRepository<Order>();
            }
            if (_orderDetailRepo == null)
            {
                _orderDetailRepo = new BaseRepository<OrderDetail>();
            }
            if(_customerRepo == null)
            {
                _customerRepo = new BaseRepository<Customer>();
            }
            if (_flowerRepo == null)
            {
                _flowerRepo = new BaseRepository<Flower>();
            }
            
            checkOutDetailList = new();
        }

        private void frmCheckOutDetail_Load(object sender, EventArgs e)
        {
            dgvCheckOut.DataSource = checkOutDetailList;
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Text = checkOutDetailList.Sum(x => x.Price).ToString();
            txtFinalPrice.Text = txtTotalPrice.Text;
            txtFinalPrice.Enabled = false;
            chkDiscount.Enabled = (Customer.Point >= 150000) ? true : false;
            txtDiscountRate.Enabled = false;
            txtDiscountRate.Text = (Customer.Point >= 150000) ? "0.05" : "0.00";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn tạo đơn hàng?", "Tạo đơn hàng?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                return;
            }

            decimal totalPrice = decimal.Parse(txtTotalPrice.Text);
            decimal finalPrice = decimal.Parse(txtFinalPrice.Text);
            decimal discountRate = decimal.Parse(txtDiscountRate.Text);
            bool applyDiscount = chkDiscount.Checked;


            var order = new Order()
            {
                OrderDate = DateTime.Now,
                TotalPrice = totalPrice,
                OrderStatus = "Pending",
                CustomerId = Customer.CustomerId,
                FinalPrice = finalPrice,
                Discount = (float)discountRate
            };
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

            if (applyDiscount && Customer.Point >= 150000)
            {
                Customer.Point -= 150000; 
            }
            Customer.Point += finalPrice; // Cộng điểm tích lũy
            var customerToUpdate = _customerRepo.GetFirstOrDefault(c => c.CustomerId == Customer.CustomerId);
            customerToUpdate.Point = Customer.Point;

            _customerRepo.Update(customerToUpdate);

            MessageBox.Show("Tạo đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmCart.selectedFlowers.Clear();
            this.Close();
            frmCart.Close();
            frmCart.frmOrder.FillDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCart.Close();
            frmCart.frmOrder = null;
        }

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            decimal totalPrice = decimal.Parse(txtTotalPrice.Text);
            if (chkDiscount.Checked)
            {
                decimal discountRate = decimal.Parse(txtDiscountRate.Text);
                var finalPrice = (1 - discountRate) * totalPrice;
                txtFinalPrice.Text = finalPrice.ToString();
            }
            else
            {
                txtFinalPrice.Text = txtTotalPrice.Text;
            }
        }
    }
}