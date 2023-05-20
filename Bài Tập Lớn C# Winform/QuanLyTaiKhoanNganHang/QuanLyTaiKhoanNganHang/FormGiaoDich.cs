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

namespace QuanLyTaiKhoanNganHang
{
    public partial class FormGiaoDich : Form
    {
        SqlConnection Con = Connection.getInstance().getConnection();

        public FormGiaoDich()
        {
            InitializeComponent();
            // Khởi tạo timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 giây
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        // Phương thức để cập nhật giờ
        private void timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật và hiển thị giờ mới
            lblDataTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        // Đảm bảo dừng timer khi form bị đóng
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }

        // load dữ liệu lên combobox SoTaiKhoan
        private void LoadDataToComboBoxSoTaiKhoan()
        {
            string query = "SELECT SoTaiKhoan FROM TaiKhoan";

            using (SqlConnection connection = Connection.getInstance().getConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbbSoTaiKhoan.Items.Add(reader.GetString(0));
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
        }


        // load dữ liệu lên combobox TenTaiKhoan
        private void LoadDataToComboBoxTenTaiKhoan()
        {
            string query = "SELECT TenTaiKhoan FROM TaiKhoan";

            using (SqlConnection connection = Connection.getInstance().getConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbbTenTaiKhoan.Items.Add(reader.GetString(0));
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (cbbSoTaiKhoan.Text.Trim() == "" && cbbTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền thông tin tài khoản cần tìm kiếm.");
            }
            else
            {
                Con.Open();
                string query = "SELECT TenTaiKhoan, SoTaiKhoan, DiaChiEmail, CCCD, ImageData FROM TaiKhoan WHERE (TenTaiKhoan = @TenTaiKhoan OR @TenTaiKhoan = '') AND (SoTaiKhoan = @SoTaiKhoan OR @SoTaiKhoan = '')";
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@TenTaiKhoan", cbbTenTaiKhoan.Text.Trim());
                command.Parameters.AddWithValue("@SoTaiKhoan", cbbSoTaiKhoan.Text.Trim());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtTenTaiKhoan.Text = reader["TenTaiKhoan"].ToString();
                    txtSoTaiKhoan.Text = reader["SoTaiKhoan"].ToString();
                    txtDiaChiEmail.Text = reader["DiaChiEmail"].ToString();
                    txtCCCD.Text = reader["CCCD"].ToString();

                    // Lấy thông tin ảnh từ cơ sở dữ liệu
                    byte[] imageBytes = (byte[])reader["ImageData"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);
                        ptbTaiAnh.Image = image; // Hiển thị ảnh lên PictureBox
                    }
                }

                reader.Close();
                Con.Close();

            }
        }

        private void FormGiaoDich_Load(object sender, EventArgs e)
        {
            LoadDataToComboBoxSoTaiKhoan();
            LoadDataToComboBoxTenTaiKhoan();
        }

        public void ConnecGiaoDich()
        {
            Con.Open();
            string query = "SELECT SoTaiKhoan, NgayGiaoDich, GhiChu FROM GiaoDich";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            GiaoDichGV.DataSource = dataTable;
            Con.Close();
        }

        private void btnLuuThongTinGiaoDich_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "" || txtSoTaiKhoan.Text == "" || txtCCCD.Text == "" || txtSoTaiKhoan.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
            }
            else
            {
                Con.Open();

                DialogResult dialogResult = MessageBox.Show("Bạn Xác Nhận Đầy Đủ Thông Tin Giao Dịch ?",
                    "Xác Nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {

                    string query = "SELECT COUNT(*) FROM GiaoDich WHERE TenTaiKhoan = @TenTaiKhoan";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0) // Kiểm tra xem mã bệnh nhân đã tồn tại hay chưa
                    {
                        query = "UPDATE GiaoDich SET NgayGiaoDich = @NgayGiaoDich, GhiChu = @GhiChu  WHERE TenTaiKhoan = @TenTaiKhoan";
                        command = new SqlCommand(query, Con);

                        command = new SqlCommand(query, Con);

                        command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);

                        DateTime ngaySinh = txtNgayGiaoDich.SelectionRange.Start;
                        string strNgaySinh = ngaySinh.ToString("yyyy-MM-dd");   // Chuyển đổi thành chuỗi theo định dạng yyyy-MM-dd
                        command.Parameters.AddWithValue("@NgayGiaoDich", strNgaySinh);

                        command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Lưu Thông Tin Giao Dịch Thành Công.");
                    }
                    else
                    {
                        query = "INSERT INTO GiaoDich (TenTaiKhoan, SoTaiKhoan, NgayGiaoDich, GhiChu)"
                            + "VALUES (@TenTaiKhoan, @SoTaiKhoan, @NgayGiaoDich, @GhiChu)";

                        command = new SqlCommand(query, Con);

                        command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                        command.Parameters.AddWithValue("@SoTaiKhoan", txtSoTaiKhoan.Text);

                        DateTime ngaySinh = txtNgayGiaoDich.SelectionRange.Start;
                        string strNgaySinh = ngaySinh.ToString("yyyy-MM-dd");   // Chuyển đổi thành chuỗi theo định dạng yyyy-MM-dd
                        command.Parameters.AddWithValue("@NgayGiaoDich", strNgaySinh);
                      
                        command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Lưu Thông Tin Giao Dịch Thành Công.");
                    }
                }

                Con.Close();
                ConnecGiaoDich();
            }
        }

        private void btnKiemTraTK_Click(object sender, EventArgs e)
        {
            if (cbbSoTaiKhoan.Text.Trim() == "" && cbbTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền thông tin tài khoản cần tìm kiếm.");
            }
            else
            {
                Con.Open();
                string query = "SELECT TenTaiKhoan, SoTaiKhoan, DiaChiEmail, CCCD, ImageData FROM TaiKhoan WHERE (TenTaiKhoan = @TenTaiKhoan OR @TenTaiKhoan = '') AND (SoTaiKhoan = @SoTaiKhoan OR @SoTaiKhoan = '')";
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@TenTaiKhoan", cbbTenTaiKhoan.Text.Trim());
                command.Parameters.AddWithValue("@SoTaiKhoan", cbbSoTaiKhoan.Text.Trim());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtTenTaiKhoan.Text = reader["TenTaiKhoan"].ToString();
                    txtSoTaiKhoan.Text = reader["SoTaiKhoan"].ToString();
                    txtDiaChiEmail.Text = reader["DiaChiEmail"].ToString();
                    txtCCCD.Text = reader["CCCD"].ToString();

                    // Lấy thông tin ảnh từ cơ sở dữ liệu
                    byte[] imageBytes = (byte[])reader["ImageData"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);
                        ptbTaiAnh.Image = image; // Hiển thị ảnh lên PictureBox
                    }
                }

                reader.Close();
                command.Dispose();
                Con.Close();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
