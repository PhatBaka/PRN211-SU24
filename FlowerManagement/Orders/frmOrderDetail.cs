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
    public partial class frmOrderDetail : Form
    {
        public OrderDTO SelectedOrder { get; set; } = null;
        public readonly IBaseRepository<OrderDetail> _orderDetailRepo = new BaseRepository<OrderDetail>();
        public readonly IBaseRepository<Flower> _flowRepo = new BaseRepository<Flower>();
        public frmOrderDetail()
        {
            InitializeComponent();
        }


        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            var list = new List<CheckOutDetail>();
            var orderDetailList = _orderDetailRepo.GetAll().ToList();
            foreach (var od in orderDetailList)
            {
                list.Add(new CheckOutDetail()
                {
                    FlowerBouquetID = od.FlowerBouquetID,
                    FlowerBouquetName = _flowRepo.GetFirstOrDefault(f => f.FlowerBouquetID == od.FlowerBouquetID).FlowerBouquetName,
                    UnitPrice = od.UnitPrice,
                    Quantity = od.Quantity,
                    Price = od.UnitPrice * od.Quantity,
                });
            }
            dgvOrderDetailList.DataSource = list;
        }
    }
}
