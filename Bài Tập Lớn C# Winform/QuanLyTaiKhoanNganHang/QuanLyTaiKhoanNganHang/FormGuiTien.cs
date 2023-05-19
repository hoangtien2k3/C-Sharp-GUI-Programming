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
    public partial class FormGuiTien : Form
    {
        SqlConnection Con = Connection.getInstance().getConnection();

        public FormGuiTien()
        {
            InitializeComponent();
        }

        private void FormGuiTien_Load(object sender, EventArgs e)
        {
            ConnecSoDuTaiKhoan();
            LoadDataToComboBoxSoTaiKhoan();
            LoadDataToComboBoxTenTaiKhoan();
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


        private void btnTimKiem_Click(object sender, EventArgs e)
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

                query = "SELECT SoTienHienTai FROM SoDuTaiKhoan WHERE (TenTaiKhoan = '"+ cbbTenTaiKhoan.Text + "' OR '"+ cbbTenTaiKhoan.Text + "' = '') AND (SoTaiKhoan = '"+ cbbSoTaiKhoan.Text + "' OR '"+ cbbSoTaiKhoan.Text +"' = '')";
                using (SqlConnection connection = Connection.getInstance().getConnection())
                {
                    command = new SqlCommand(query, connection);
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtSoTienHienTai.Text = reader["SoTienHienTai"].ToString();
                    }
                    else
                    {
                        txtSoTienHienTai.Text = "000000";
                    }
                    reader.Close();
                    command.Dispose();
                    connection.Close();
                }

                reader.Close();
                Con.Close();
                
            }
        }

        public void ConnecSoDuTaiKhoan()
        {
            Con.Open();
            string query = "SELECT * FROM SoDuTaiKhoan";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            SoDuTaiKhoanGV.DataSource = dataTable;
            Con.Close();
        }


        private void ThongTinGiaoDichGuiTien()
        {
            string soTaiKhoan = txtSoTaiKhoan.Text;
            decimal soTien = decimal.Parse(txtSoTienMuonGui.Text);

            string insertQuery = "INSERT INTO GiaoDichGuiTien (SoTaiKhoan, SoTien, NgayGiaoDich, GioGiaoDich) " +
                "VALUES (@SoTaiKhoan, @SoTien, @NgayGiaoDich, @GioGiaoDich)";

            using (SqlConnection connection = Connection.getInstance().getConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@SoTaiKhoan", soTaiKhoan);
                    command.Parameters.AddWithValue("@SoTien", soTien);
                    command.Parameters.AddWithValue("@NgayGiaoDich", DateTime.Now.ToString("dd/MM/yyyy"));
                    command.Parameters.AddWithValue("@GioGiaoDich", DateTime.Now.ToString("HH:mm:ss"));

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            // MessageBox.Show("Giao dịch gửi tiền thành công!");

            txtSoTienMuonGui.Text = string.Empty;
        }


        private void btnGuiTien_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "" || txtSoTaiKhoan.Text == "" || txtCCCD.Text == "" || txtSoTaiKhoan.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
            } else
            {
                Con.Open();

                DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Gửi Tiền Vào Tài Khoản Không ?",
                    "Xác Nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                
                if (dialogResult == DialogResult.Yes) {

                    

                    string query = "SELECT COUNT(*) FROM SoDuTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0) // Kiểm tra xem mã bệnh nhân đã tồn tại hay chưa
                    {
                        query = "UPDATE SoDuTaiKhoan SET SoTienHienTai = @SoTienHienTai  WHERE TenTaiKhoan = @TenTaiKhoan";
                        command = new SqlCommand(query, Con);

                        command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                        string SoTienMuonGui = string.IsNullOrEmpty(txtSoTienMuonGui.Text) ? txtSoTienMuonGui.SelectedItem.ToString() : txtSoTienMuonGui.Text;
                        string kp = (int.Parse(txtSoTienHienTai.Text) + int.Parse(SoTienMuonGui)).ToString();
                        command.Parameters.AddWithValue("@SoTienHienTai", kp);

                        command.ExecuteNonQuery(); // thực hiện câu truy vấn
                        MessageBox.Show("Đã Nạp Thêm Tiền Vào Tài Khoản (" + txtTenTaiKhoan.Text + ") Thành Công.");

                        txtSoTienHienTai.Text = kp;

                    }
                    else
                    {
                        query = "INSERT INTO SoDuTaiKhoan (TenTaiKhoan, SoTaiKhoan, CCCD, SoTienHienTai)"
                            + "VALUES (@TenTaiKhoan, @SoTaiKhoan, @CCCD, @SoTienHienTai)";

                        command = new SqlCommand(query, Con);

                        command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                        command.Parameters.AddWithValue("@SoTaiKhoan", txtSoTaiKhoan.Text);
                        command.Parameters.AddWithValue("@CCCD", txtCCCD.Text);

                        string SoTienMuonGui = string.IsNullOrEmpty(txtSoTienMuonGui.Text) ? txtSoTienMuonGui.SelectedItem.ToString() : txtSoTienMuonGui.Text;
                        command.Parameters.AddWithValue("@SoTienHienTai", SoTienMuonGui);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Nạp Tiền Vào Tài Khoản (" + txtTenTaiKhoan.Text + ") Thành Công.");
                        txtSoTienHienTai.Text = SoTienMuonGui;

                    }
                }


                Con.Close();
                ConnecSoDuTaiKhoan();
                ThongTinGiaoDichGuiTien();
            }

        }

        private void txtSoTienHienTai_TextChanged(object sender, EventArgs e)
        {
            txtSoTienChuSo1.Text = ConvertNumber.ConvertNumberToVietnamese(txtSoTienHienTai.Text);
        }

        private void txtSoTienMuonGui_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
