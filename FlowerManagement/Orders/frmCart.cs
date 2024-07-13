using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessObjects;

namespace FlowerManagement.Orders
{
    public partial class frmCart : Form
    {
        public Dictionary<FlowerDetailDTO, int> selectedFlowers;
        private CartDisplay selectedCartDisplay = null;
        public frmOrder frmOrder = null;
        public Customer Customer { get; set; } = null;

        public frmCart()
        {
            InitializeComponent();
            selectedFlowers = new();
            btnCheckOut.Enabled = false; // Initially disable the Check Out button
            dgvCartList.DataError += dgvCartList_DataError; // Add this line to handle data errors
        }

        private List<CartDisplay> GetAllCartDisplays()
        {
            List<CartDisplay> cartDisplays = new();
            foreach (var f in selectedFlowers)
            {
                cartDisplays.Add(new CartDisplay()
                {
                    FlowerBouquetID = f.Key.FlowerBouquetID,
                    FlowerBouquetName = f.Key.FlowerBouquetName,
                    UnitPrice = f.Key.UnitPrice,
                    Quantity = f.Value
                });
            }
            return cartDisplays;
        }

        private void FillDataGridView()
        {
            dgvCartList.DataSource = null;
            dgvCartList.DataSource = GetAllCartDisplays();
            dgvCartList.Columns["Quantity"].ReadOnly = false;
            ValidateCart(); // Validate cart after filling data
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dgvCartList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCartList.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                var cellValue = dgvCartList.Rows[e.RowIndex].Cells["Quantity"].Value;
                string quantityValue = cellValue != null ? cellValue.ToString().Trim() : string.Empty;

                if (string.IsNullOrEmpty(quantityValue))
                {
                    MessageBox.Show("Số lượng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvCartList.Rows[e.RowIndex].Cells["Quantity"].Value = selectedFlowers.Values.ElementAt(e.RowIndex);
                    return;
                }

                int newQuantity;
                if (int.TryParse(quantityValue, out newQuantity) && newQuantity > 0)
                {
                    int flowerBouquetID = Convert.ToInt32(dgvCartList.Rows[e.RowIndex].Cells["FlowerBouquetID"].Value);
                    var key = selectedFlowers.Keys.FirstOrDefault(k => k.FlowerBouquetID == flowerBouquetID);
                    if (key != null && newQuantity <= key.UnitsInStock)
                    {
                        selectedFlowers[key] = newQuantity;
                    }
                    else
                    {
                        MessageBox.Show("Số lượng vượt quá số lượng có sẵn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvCartList.Rows[e.RowIndex].Cells["Quantity"].Value = selectedFlowers[key];
                    }
                }
                else if (!int.TryParse(quantityValue, out newQuantity))
                {
                    MessageBox.Show("Số lượng phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvCartList.Rows[e.RowIndex].Cells["Quantity"].Value = selectedFlowers.Values.ElementAt(e.RowIndex);
                }
                else
                {
                    MessageBox.Show("Số lượng phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvCartList.Rows[e.RowIndex].Cells["Quantity"].Value = selectedFlowers.Values.ElementAt(e.RowIndex);
                }

                ValidateCart(); // Validate cart after changing quantity
            }
        }

        private void dgvCartList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Vui lòng nhập số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
            if (e.ColumnIndex == dgvCartList.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                dgvCartList.Rows[e.RowIndex].Cells["Quantity"].Value = selectedFlowers.Values.ElementAt(e.RowIndex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCartList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có hàng nào được chọn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedFlowers.Remove(selectedFlowers.Keys.FirstOrDefault(k => k.FlowerBouquetID == selectedCartDisplay.FlowerBouquetID));
            FillDataGridView();
        }

        private void dgvCartList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCartList.SelectedRows.Count > 0)
            {
                selectedCartDisplay = (CartDisplay)dgvCartList.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            selectedFlowers.Clear();
            FillDataGridView();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            frmCheckOutDetail _frmCheckOutDetail = new();
            foreach (var f in selectedFlowers)
            {
                var flower = f.Key;
                _frmCheckOutDetail.checkOutDetailList.Add(new CheckOutDetail()
                {
                    FlowerBouquetID = flower.FlowerBouquetID,
                    FlowerBouquetName = flower.FlowerBouquetName,
                    UnitPrice = flower.UnitPrice,
                    Quantity = f.Value,
                    Price = f.Value * flower.UnitPrice
                });
            }
            _frmCheckOutDetail.frmCart = this;
            _frmCheckOutDetail.Customer = Customer;
            _frmCheckOutDetail.ShowDialog();
        }

        private void ValidateCart()
        {
            // Enable Check Out button if there are items in the cart
            btnCheckOut.Enabled = selectedFlowers.Count > 0;
        }
    }
}
