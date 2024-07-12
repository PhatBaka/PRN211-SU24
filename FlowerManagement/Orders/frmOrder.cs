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
    public partial class frmOrder : Form
    {
        private readonly IBaseRepository<Flower> _flowerRepo;
        private readonly IBaseRepository<Category> _categoryRepo;
        private readonly IBaseRepository<Supplier> _suppilierRepo;
        private FlowerDetailDTO _selectedFlower = null;
        private readonly frmCart _frmCart = new();
        public frmOrder()
        {
            InitializeComponent();
            _flowerRepo = new BaseRepository<Flower>();
            _categoryRepo = new BaseRepository<Category>();
            _suppilierRepo = new BaseRepository<Supplier>();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private List<FlowerDetailDTO> GetAllFlowerDetail()
        {
            var flowerDetailList = new List<FlowerDetailDTO>();
            var flowerList = _flowerRepo.GetAll();
            foreach (var f in flowerList)
            {
                var flowerDetail = new FlowerDetailDTO()
                {
                    FlowerBouquetID = f.FlowerBouquetID,
                    FlowerBouquetName = f.FlowerBouquetName,
                    Description = f.Description,
                    UnitPrice = f.UnitPrice,
                    UnitsInStock = f.UnitsInStock,
                    FlowerBouquetStatus = f.FlowerBouquetStatus,
                    Morphology = f.Morphology,
                    Image = f.Image,
                    CategoryName = _categoryRepo.GetFirstOrDefault(c => c.CategoryID == f.CategoryID).CategoryName,
                    SupplierName = _suppilierRepo.GetFirstOrDefault(s => s.SupplierID == f.SupplierID).SupplierName
                };
                flowerDetailList.Add(flowerDetail);
            }
            return flowerDetailList;
        }

        private void FillDataGridView()
        {
            dgvFlowerList.DataSource = null;
            dgvFlowerList.DataSource = GetAllFlowerDetail();
        }

        private void dgvFlowerList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFlowerList.SelectedRows.Count > 0)
            {
                _selectedFlower = (FlowerDetailDTO)dgvFlowerList.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvFlowerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có hàng nào được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_frmCart.selectedFlowers.ContainsKey(_selectedFlower))
            {
                _frmCart.selectedFlowers[_selectedFlower]++;
            }
            else
            {
                _frmCart.selectedFlowers.Add(_selectedFlower, 1);
            }

        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            if (_frmCart.selectedFlowers.Count() == 0)
            {
                MessageBox.Show("Giỏ hàng rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _frmCart.ShowDialog();
        }
    }
}
