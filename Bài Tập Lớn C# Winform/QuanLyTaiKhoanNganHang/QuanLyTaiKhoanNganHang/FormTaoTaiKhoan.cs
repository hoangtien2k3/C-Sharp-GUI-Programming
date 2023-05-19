using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyTaiKhoanNganHang
{
    public partial class FormTaoTaiKhoan : Form
    {

        SqlConnection Con = Connection.getInstance().getConnection();

        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }


        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            ConnecTaiKhoan();
        }


        private string GenerateAccountNumber(string customerName)
        {
            long accountNumber = GenerateRandomNumber(); // Tạo số tài khoản ngân hàng ngẫu nhiên
            string accountNumberString = accountNumber.ToString("D14"); // Tạo chuỗi số tài khoản ngân hàng
            string result = $"{accountNumberString}"; // Kết hợp tên người dùng và số tài khoản ngân hàng
            return result; // Trả về chuỗi kết quả
        }

        // Hàm tạo số ngẫu nhiên có 14 chữ số
        private long GenerateRandomNumber()
        {
            var random = new Random();
            long number = 0;
            for (int i = 0; i < 14; i++)
            {
                number *= 10;
                number += random.Next(0, 10);
            }
            return number;
        }

        private void txtTenNguoiDung_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtTenTaiKhoan.Text;
            string accountNumber = GenerateAccountNumber(customerName);
            txtSoTaiKhoan.Text = accountNumber;
        }

        private void txtSoTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        public void ConnecTaiKhoan()
        {
            Con.Open();
            string query = "SELECT * FROM TaiKhoan";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DanhSachTaiKhoanGV.DataSource = dataTable;
            Con.Close();
        }


        // dùng để convert đường dẫn ảnh sang mảng byte[] để lưu trữ vào DB
        private byte[] convertImage(String txtImageData)
        {
            try
            {
                FileStream fileStream = new FileStream(txtImageData, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[fileStream.Length];
                fileStream.Read(data, 0, System.Convert.ToInt32(fileStream.Length));
                fileStream.Close();
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xảy ra khi đọc file: " + ex.Message); // Xử lý khi có lỗi xảy ra
                return null; // hoặc giá trị khác tùy theo logic của bạn
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {

            if (txtTenTaiKhoan.Text == "" || txtSoTaiKhoan.Text == "" || txtMatKhau.Text == "" || cbbLoaiTaiKhoan.Text == "" || txtDiaChiEmail.Text == "" || txtCCCD.Text == "" || txtSoDienThoai.Text == "" || txtNgaySinh.Text == "" || cbbQuocTich.Text == "" || cbbNgheNghiep.Text == "" || ptbTaiAnh.Image == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            else
            {
                Con.Open();

                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                SqlCommand command = new SqlCommand(query, Con);

                command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0) // Kiểm tra xem mã bệnh nhân đã tồn tại hay chưa
                {
                    MessageBox.Show("Tài khoản đã tồn tại. Vui lòng tạo tài khoản khác.",
                        "Xác Nhận",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        query = "INSERT INTO TaiKhoan (TenTaiKhoan, SoTaiKhoan, MatKhau, LoaiTaiKhoan, DiaChiEmail, GioiTinh, CCCD, SoDienThoai, NgaySinh, QuocTich, NgheNghiep, ImageData)"
                        + "VALUES (@TenTaiKhoan, @SoTaiKhoan, @MatKhau, @LoaiTaiKhoan, @DiaChiEmail, @GioiTinh, @CCCD, @SoDienThoai, @NgaySinh, @QuocTich, @NgheNghiep, @ImageData)";

                        command = new SqlCommand(query, Con);

                        command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                        command.Parameters.AddWithValue("@SoTaiKhoan", txtSoTaiKhoan.Text);
                        command.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);

                        string LoaiTaiKhoan = string.IsNullOrEmpty(cbbLoaiTaiKhoan.Text) ? cbbLoaiTaiKhoan.SelectedItem.ToString() : cbbLoaiTaiKhoan.Text;
                        command.Parameters.AddWithValue("@LoaiTaiKhoan", LoaiTaiKhoan);

                        command.Parameters.AddWithValue("@DiaChiEmail", txtDiaChiEmail.Text);

                        if (rdbNam.Checked)
                        {
                            command.Parameters.AddWithValue("@GioiTinh", "Nam");
                        }
                        else if (rdbNu.Checked)
                        {
                            command.Parameters.AddWithValue("@GioiTinh", "Nữ");
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@GioiTinh", "Khác");
                        }

                        command.Parameters.AddWithValue("@CCCD", txtCCCD.Text);

                        command.Parameters.AddWithValue("@SoDienThoai", (txtMVDT.Text != "") ? (txtMVDT.Text + txtSoDienThoai.Text) : txtSoDienThoai.Text);

                        DateTime ngaySinh = txtNgaySinh.Value;
                        string strNgaySinh = ngaySinh.ToString("yyyy-MM-dd"); // Chuyển đổi sang chuỗi theo định dạng yyyy-MM-dd
                        command.Parameters.AddWithValue("@NgaySinh", strNgaySinh);

                        string QuocTich = string.IsNullOrEmpty(cbbQuocTich.Text) ? cbbQuocTich.SelectedItem.ToString() : cbbQuocTich.Text;
                        command.Parameters.AddWithValue("@QuocTich", QuocTich);

                        string NgheNghiep = string.IsNullOrEmpty(cbbNgheNghiep.Text) ? cbbNgheNghiep.SelectedItem.ToString() : cbbNgheNghiep.Text;
                        command.Parameters.AddWithValue("@NgheNghiep", NgheNghiep);

                        command.Parameters.AddWithValue("@ImageData", convertImage(txtImageData.Text));

                        command.ExecuteNonQuery();

                        MessageBox.Show("Tạo Tài Khoản (" + txtTenTaiKhoan.Text + ") Thành Công.");
                    } catch (Exception ex)
                    {
                        // MessageBox.Show("Tạo Tài Khoản (" + txtTenTaiKhoan.Text + ") Thất Bại.");

                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }

                Con.Close();
                ConnecTaiKhoan(); // show dữ liệu ra datagridview
                btnLamMoi_Click(sender, e);
            }

            // LockControl(); // khóa button thêm bệnh nhân
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = "";
            txtSoTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cbbLoaiTaiKhoan.Text = "";
            txtDiaChiEmail.Text = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            rdbKhac.Checked = false;
            txtCCCD.Text = "";
            txtSoDienThoai.Text = "";
            txtNgaySinh.Text = "";
            cbbQuocTich.Text = "";
            cbbNgheNghiep.Text = "";
            ptbTaiAnh.Image = null;
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select an image file";
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.bmp;*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbTaiAnh.Image = new Bitmap(openFileDialog.FileName);
                txtImageData.Text = openFileDialog.FileName;
            }
        }

        private void DanhSachTaiKhoanGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // DataGridViewRow row = BenhNhanGV.Rows[e.RowIndex];
                DataGridViewRow row = DanhSachTaiKhoanGV.CurrentRow;

                txtTenTaiKhoan.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                txtSoTaiKhoan.Text = row.Cells["SoTaiKhoan"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                cbbLoaiTaiKhoan.Text = row.Cells["LoaiTaiKhoan"].Value.ToString();
                txtDiaChiEmail.Text = row.Cells["DiaChiEmail"].Value.ToString();

                if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else if (row.Cells["GioiTinh"].Value.ToString() == "Nữ")
                {
                    rdbNu.Checked = true;
                }
                else
                {
                    rdbKhac.Checked = true;
                }

                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value.ToString());
                cbbQuocTich.Text = row.Cells["QuocTich"].Value.ToString();
                cbbNgheNghiep.Text = row.Cells["NgheNghiep"].Value.ToString();

                // Lấy thông tin ảnh từ cơ sở dữ liệu
                byte[] imageBytes = (byte[])row.Cells["ImageData"].Value;

                // Chuyển đổi dữ liệu Binary về kiểu Image
                MemoryStream ms = new MemoryStream(imageBytes);
                Image image = Image.FromStream(ms);

                // Hiển thị ảnh lên PictureBox
                ptbTaiAnh.Image = image;

                // Chuyển đổi dữ liệu Binary sang chuỗi Base64 string
                // Hiển thị dữ liệu Base64 string lên TextBox
                txtImageData.Text = Convert.ToBase64String(imageBytes);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = "";
            txtSoTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cbbLoaiTaiKhoan.Text = "";
            txtDiaChiEmail.Text = "";

            if (rdbNam.Checked)
            {
                rdbNam.Checked = false;
            } else if (rdbNu.Checked)
            {
                rdbNu.Checked = false;
            } else
            {
                rdbNu.Checked = false;
            }

            txtCCCD.Text = "";
            txtMVDT.Text = ""; 
            txtSoDienThoai.Text = "";
            txtNgaySinh.Value = DateTime.Now;
            cbbQuocTich.Text = "";
            cbbNgheNghiep.Text = "";
            ptbTaiAnh.Image = null;
        }
    }
}
