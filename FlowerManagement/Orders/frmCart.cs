using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerManagement.Orders
{
    public partial class frmCart : Form
    {
        public Dictionary<FlowerDetailDTO, int> selectedFlowers;
        public CartDisplay selectedCartDisplay = null;
        public frmCart()
        {
            InitializeComponent();
            selectedFlowers = new();
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
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }


        private void dgvCartList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCartList.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị mới từ DataGridView
                int newQuantity = Convert.ToInt32(dgvCartList.Rows[e.RowIndex].Cells["Quantity"].Value);

                // Lấy FlowerBouquetID từ DataGridView
                int flowerBouquetID = Convert.ToInt32(dgvCartList.Rows[e.RowIndex].Cells["FlowerBouquetID"].Value);

                // Tìm khóa tương ứng trong Dictionary
                var key = selectedFlowers.Keys.FirstOrDefault(k => k.FlowerBouquetID == flowerBouquetID);

                if (key != null)
                {
                    // Cập nhật giá trị mới trong Dictionary
                    selectedFlowers[key] = newQuantity;
                }
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
    }
}
