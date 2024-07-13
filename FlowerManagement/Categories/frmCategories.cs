//using BusinessObjects;
//using Repositories.Impls;
//using Repositories.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace FlowerManagement.Categories
//{
//    public partial class frmCategories : Form
//    {
//        private readonly IBaseRepository<Category> _baseRepository;
//        public frmCategories()
//        {
//            InitializeComponent();
//            _baseRepository = new BaseRepository<Category>();
//            Reload();
//        }
//        private void Reload()
//        {
//            dataGridViewCategory.DataSource = GetAll();
//            textBoxId.Text = string.Empty;
//            textBoxDes.Text = string.Empty;
//            textBoxName.Text = string.Empty;
//            txtBoxNote.Text = string.Empty;
//        }
//        private List<CategoriesModelView> GetAll()
//        {
//            List<CategoriesModelView> categoriesModelViews = new List<CategoriesModelView>();

//            var list = _baseRepository.GetAll().ToList();

//            categoriesModelViews = list.Select(category => CategoryMapper.MapToViewModel(category)).ToList();

//            return categoriesModelViews;
//        }
//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(textBoxName.Text))
//            {
//                // Hiển thị thông báo lỗi nếu CategoryName để trống
//                MessageBox.Show("Vui lòng nhập tên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }

//            _baseRepository.Add(new Category
//            {
//                CategoryDescription = textBoxDes.Text,
//                CategoryName = textBoxName.Text,
//                CategoryNote = txtBoxNote.Text,
//            });
//            Reload();
//        }

//        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            // Kiểm tra xem người dùng có nhấp vào một ô hợp lệ hay không
//            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
//            {
//                // Lấy dữ liệu của dòng được chọn
//                DataGridViewRow selectedRow = dataGridViewCategory.Rows[e.RowIndex];

//                // Lấy giá trị của các cột trong dòng được chọn
//                int categoryId = (int)selectedRow.Cells["CategoryId"].Value;
//                string categoryName = selectedRow.Cells["CategoryName"].Value.ToString();
//                string categoryDescription = selectedRow.Cells["CategoryDescription"].Value.ToString();
//                string categoryNote = selectedRow.Cells["CategoryNote"].Value.ToString();

//                // Cập nhật các giá trị vào các control tương ứng
//                textBoxId.Text = categoryId.ToString();
//                textBoxName.Text = categoryName;
//                textBoxDes.Text = categoryDescription;
//                txtBoxNote.Text = categoryNote;
//            }
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(textBoxName.Text))
//            {
//                // Hiển thị thông báo lỗi nếu CategoryName để trống
//                MessageBox.Show("Vui lòng nhập tên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }
//            var item = _baseRepository.GetById(int.Parse(textBoxId.Text));
//            if(item is null)
//            {
//                // Hiển thị thông báo lỗi nếu CategoryName để trống
//                MessageBox.Show("Đã xảy ra lỗi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }
          
//            // Hiển thị thông báo xác nhận trước khi xóa
//            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

//            // Nếu người dùng chọn "Yes", thực hiện xóa
//            if (result == DialogResult.Yes)
//            {
//                item.CategoryDescription = textBoxDes.Text;
//                item.CategoryName = textBoxName.Text;
//                item.CategoryNote = txtBoxNote.Text;
//                _baseRepository.Update(item);
//                Reload();
//            }
//        }

//        private void label1_Click_1(object sender, EventArgs e)
//        {

//        }

//        private void textBoxId_TextChanged(object sender, EventArgs e)
//        {
//            textBoxId.ReadOnly = true;
//        }

//        private void button4_Click(object sender, EventArgs e)
//        {
//            Reload();
//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            var item = _baseRepository.GetById(int.Parse(textBoxId.Text));
//            if (item is null)
//            {
//                // Hiển thị thông báo lỗi nếu CategoryName để trống
//                MessageBox.Show("Đã xảy ra lỗi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }
//            // Hiển thị thông báo xác nhận trước khi xóa
//            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

//            // Nếu người dùng chọn "Yes", thực hiện xóa
//            if (result == DialogResult.Yes)
//            {
//                _baseRepository.Delete(item);
//                Reload();
//            }
//        }
//    }
//}
