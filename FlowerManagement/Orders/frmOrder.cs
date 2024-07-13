using System;
using System.Collections.Generic;
using System.Linq;
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
        public Customer Customer { get; set; } = null;
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
            _frmCart.Customer = Customer;
        }

        private List<FlowerDetailDTO> GetAllFlowerDetail()
        {
            var flowerDetailList = new List<FlowerDetailDTO>();
            var flowerList = _flowerRepo.GetAll();
            foreach (var f in flowerList)
            {
                if (f.UnitsInStock > 0)
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
            }
            return flowerDetailList;
        }

        public void FillDataGridView()
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

            if (_selectedFlower == null || _selectedFlower.UnitsInStock <= 0)
            {
                MessageBox.Show("Sản phẩm đã hết hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_frmCart.selectedFlowers.ContainsKey(_selectedFlower))
            {
                if (_frmCart.selectedFlowers[_selectedFlower] < _selectedFlower.UnitsInStock)
                {
                    _frmCart.selectedFlowers[_selectedFlower]++;
                }
                else
                {
                    MessageBox.Show("Số lượng vượt quá số lượng có sẵn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                _frmCart.selectedFlowers.Add(_selectedFlower, 1);
            }

            // Decrease the UnitsInStock for the selected flower
            _selectedFlower.UnitsInStock--;
            FillDataGridView();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            if (_frmCart.selectedFlowers.Count() == 0)
            {
                MessageBox.Show("Giỏ hàng rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _frmCart.frmOrder = this;
            _frmCart.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvFlowerList.DataSource = GetAllFlowerDetail().Where(f => f.FlowerBouquetName.ToLower().Contains(txtName.Text.ToLower().Trim())).ToList();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
