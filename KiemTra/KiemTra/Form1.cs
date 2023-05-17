using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace KiemTra
{
    public partial class Form1 : Form
    {
        private static string stringketnoi = @"Data Source=DESKTOP-QE5H4U6\SQLEXPRESS;Initial Catalog=KiemTra;Integrated Security=True";
        SqlConnection Con = new SqlConnection(stringketnoi);

        public Form1()
        {
            InitializeComponent();
        }


        // khóa phần nhập dữ liệu đầu vào
        private void LockControlInput()
        {
            txtMaSanPham.Enabled = false;
            txtTenSanPham.Enabled = false;
            txtGia.Enabled = false;
            txtSoLuong.Enabled = false;

            cbbNhaCungCap.DropDownStyle = ComboBoxStyle.DropDown;
            cbbNhaCungCap.Enabled = false;

        }


        // mở khóa phần nhập dữ liệu đầu vào.
        private void UnLockControlInput()
        {
            txtMaSanPham.Enabled = true;
            txtTenSanPham.Enabled = true;
            txtGia.Enabled = true;
            txtSoLuong.Enabled = true;

            cbbNhaCungCap.DropDownStyle = ComboBoxStyle.DropDown;
            cbbNhaCungCap.Enabled = true;
        }

        // khóa
        private void LockControl()
        {
            // khóa button
            // btnThem.Enabled = true;

            // mở button
            btnLuu.Enabled = false;
            btnCapNhap.Enabled = false;
            btnXoa.Enabled = false;
        }

        // mở khóa
        private void UnLockControl()
        {
            // khóa button
            // btnThem.Enabled = false;

            // mở button
            btnLuu.Enabled = true;
            btnCapNhap.Enabled = true;
            btnXoa.Enabled = true;

            UnLockControlInput();
        }

        private void btnLamMoi()
        {
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
            cbbNhaCungCap.Text = "";
        }

        public void ConnecSanpham()
        {
            Con.Open();
            string query = "SELECT * FROM Sanpham";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            SanphamGV.DataSource = dataTable;
            Con.Close();
        }


        // load tất cả TenBN lên combobox
        private void LoadDataToComboBoxNhaCungCap()
        {
            string query = "SELECT mancc FROM Nhacungcap";

            using (SqlConnection connection = new SqlConnection(stringketnoi))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbbNhaCungCap.Items.Add(reader.GetString(0));
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text == "" || txtTenSanPham.Text == "" || txtGia.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
                return;
            }
            else
            {

                Con.Open();

                string query = "SELECT COUNT(*) FROM Sanpham WHERE masp = @masp";
                SqlCommand command = new SqlCommand(query, Con);

                command.Parameters.AddWithValue("@masp", txtMaSanPham.Text);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0) // Kiểm tra xem mã bệnh nhân đã tồn tại hay chưa
                {
                    MessageBox.Show("Mã bệnh nhân đã tồn tại. Hãy nhập lại mã khác.",
                        "Xác Nhận",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {

                    query = "INSERT INTO Sanpham (masp, tensp, gia, soluong, mancc) VALUES (@masp, @tensp, @gia, @soluong, @mancc)";
                    command = new SqlCommand(query, Con);
                    command = new SqlCommand(query, Con);

                    command.Parameters.AddWithValue("@masp", txtMaSanPham.Text);
                    command.Parameters.AddWithValue("@tensp", txtTenSanPham.Text);
                    command.Parameters.AddWithValue("@gia", txtGia.Text);
                    command.Parameters.AddWithValue("@soluong", txtSoLuong.Text);
                    string maNhaCungCap = string.IsNullOrEmpty(cbbNhaCungCap.Text) ? cbbNhaCungCap.SelectedItem.ToString() : cbbNhaCungCap.Text;
                    command.Parameters.AddWithValue("@mancc", maNhaCungCap);


                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm Sản Phẩm Thành Công");
                    
                }

                Con.Close();
                ConnecSanpham();
            }

            LockControl(); // khóa button thêm bệnh nhân
            LockControlInput();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLockControl();
            btnLamMoi();
            ConnecSanpham();
            UnLockControlInput();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LockControl();
            LockControlInput();
            LoadDataToComboBoxNhaCungCap();
            LoadDataToComboBoxTimKiem();
            ConnecSanpham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text == "")
            {
                MessageBox.Show("Hãy chọn bệnh nhân cần xóa!!!");
            }
            else
            {
                Con.Open();

                DialogResult dialog = MessageBox.Show("Bạn Có Muốn Xóa Sản phẩm.",
                    "Xác Nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    string query = "DELETE FROM Sanpham WHERE masp = @masp";
                    SqlCommand command = new SqlCommand(query, Con);

                    // Truyền tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@masp", txtMaSanPham.Text);

                    // Thực thi câu lệnh SQL để xóa thông tin bệnh nhân
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa thông tin bệnh nhân thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bệnh nhân có mã " + txtMaSanPham.Text);
                    }

                    Con.Close(); // Đóng kết nối
                    ConnecSanpham(); // Cập nhật lại datagridview hiển thị danh sách bệnh nhân
                    btnLamMoi(); // xóa tất cả thông tin show ra ở phần nhập thông tin
                    return;
                }

                Con.Close();
            }
        }

        private void SanphamGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // DataGridViewRow row = BenhNhanGV.Rows[e.RowIndex];
                DataGridViewRow row = SanphamGV.CurrentRow;

                txtMaSanPham.Text = row.Cells["masp"].Value.ToString();
                txtTenSanPham.Text = row.Cells["tensp"].Value.ToString();
                txtGia.Text = row.Cells["gia"].Value.ToString();
                txtSoLuong.Text = row.Cells["soluong"].Value.ToString();
                cbbNhaCungCap.Text = row.Cells["mancc"].Value.ToString();
               
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            Con.Open();

            string query = "UPDATE Sanpham SET masp = @masp, tensp = @tensp, gia = @gia, soluong = @soluong, mancc = @mancc WHERE masp = @masp";
            SqlCommand command = new SqlCommand(query, Con);

            command.Parameters.AddWithValue("@masp", txtMaSanPham.Text);
            command.Parameters.AddWithValue("@tensp", txtTenSanPham.Text);
            command.Parameters.AddWithValue("@gia", txtGia.Text);
            command.Parameters.AddWithValue("@soluong", txtSoLuong.Text);
            command.Parameters.AddWithValue("@mancc", cbbNhaCungCap.Text);

            command.ExecuteNonQuery(); // thực hiện câu truy vấn

            MessageBox.Show("Sửa Thông Tin Bệnh Nhân Thành Công.");
            Con.Close();
            ConnecSanpham();
        }


        // load tất cả thoong tin tim kiem
        private void LoadDataToComboBoxTimKiem()
        {
            string query = "SELECT tensp FROM Sanpham";

            using (SqlConnection connection = new SqlConnection(stringketnoi))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbbTimKiem.Items.Add(reader.GetString(0));
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Con.Open();
            // dấu '%' là wildcard character (đại diện cho bất kỳ ký tự nào).
            string query = "SELECT * FROM Sanpham WHERE tensp LIKE '%' + @cbbTimKiem + '%'";
            SqlCommand command = new SqlCommand(query, Con);

            string TKSP = string.IsNullOrEmpty(cbbTimKiem.Text) ? cbbTimKiem.SelectedItem.ToString() : cbbTimKiem.Text;
            command.Parameters.AddWithValue("@cbbTimKiem", TKSP); // Thêm giá trị của TextBox vào Parameter

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            SanphamGV.DataSource = table;
            Con.Close();
        }
    }
}
