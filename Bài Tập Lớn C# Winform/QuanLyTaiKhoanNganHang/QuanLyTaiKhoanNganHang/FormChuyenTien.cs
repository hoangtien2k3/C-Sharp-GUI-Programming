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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoanNganHang
{
    public partial class FormChuyenTien : Form
    {
        SqlConnection Con = Connection.getInstance().getConnection();

        public FormChuyenTien()
        {
            InitializeComponent();
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
            SoDuTaiKhoanGV.Refresh();
            Con.Close();
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

                query = "SELECT SoTienHienTai FROM SoDuTaiKhoan WHERE (TenTaiKhoan = '" + cbbTenTaiKhoan.Text + "' OR '" + cbbTenTaiKhoan.Text + "' = '') AND (SoTaiKhoan = '" + cbbSoTaiKhoan.Text + "' OR '" + cbbSoTaiKhoan.Text + "' = '')";
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
                        txtSoTienHienTai.Text = "000.000";
                    }
                    reader.Close();
                    command.Dispose();
                    connection.Close();
                }

                reader.Close();
                Con.Close();

            }
        }

        // load dữ liệu lên combobox SoTaiKhoan
        private void LoadDataToComboBoxThongTinTaiKhoan()
        {
            string query = "SELECT SoTaiKhoan, TenTaiKhoan FROM TaiKhoan";
            using (SqlConnection connection = Connection.getInstance().getConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbbSoTaiKhoan.Items.Add(reader.GetString(0));
                    cbbTenTaiKhoan.Items.Add(reader.GetString(1));
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
        }

        private void FormChuyenTien_Load(object sender, EventArgs e)
        {
            ConnecSoDuTaiKhoan();
            LoadDataToComboBoxThongTinTaiKhoan();
        }


        // load dữ liệu lên combobox SoTaiKhoan
        private string getSoTienHienTai(string DenTaiKhoan)
        {
            string result = "";

            string query = "SELECT SoTienHienTai FROM SoDuTaiKhoan WHERE SoTaiKhoan = '" + DenTaiKhoan + "'";

            using (SqlConnection connection = Connection.getInstance().getConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = reader["SoTienHienTai"].ToString();
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }

            return result;
        }

        private void updateSoTienHienTai1()
        {
            string query = "UPDATE SoDuTaiKhoan SET SoTienHienTai = @SoTienHienTai  WHERE TenTaiKhoan = @TenTaiKhoan";
            using (SqlConnection sqlConnection = Connection.getInstance().getConnection())
            {
                sqlConnection.Open();
                SqlCommand updateCommand = new SqlCommand(query, sqlConnection);

                string SoTienMuonChuyen = string.IsNullOrEmpty(txtSoTienMuonChuyen.Text) ? txtSoTienMuonChuyen.SelectedItem.ToString() : txtSoTienMuonChuyen.Text;

                string ketqua = (int.Parse(txtSoTienHienTai.Text) - int.Parse(SoTienMuonChuyen)).ToString();
                updateCommand.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                updateCommand.Parameters.AddWithValue("@SoTienHienTai", ketqua);

                updateCommand.ExecuteNonQuery(); // thực hiện câu truy vấn

                txtSoTienHienTai.Text = ketqua;
                sqlConnection.Close();
            }
        }

        private void updateSoTienHienTai2()
        {
            string query = "UPDATE SoDuTaiKhoan SET SoTienHienTai = @SoTienHienTai  WHERE SoTaiKhoan = @SoTaiKhoan";
            using (SqlConnection sqlConnection = Connection.getInstance().getConnection())
            {
                sqlConnection.Open();
                SqlCommand updateCommand = new SqlCommand(query, sqlConnection);

                string DenTaiKhoan = string.IsNullOrEmpty(cbbDenTaiKhoan.Text) ? cbbDenTaiKhoan.SelectedItem.ToString() : cbbDenTaiKhoan.Text;

                string ketqua = (int.Parse(getSoTienHienTai(DenTaiKhoan)) + int.Parse(txtSoTienMuonChuyen.Text)).ToString();

                updateCommand.Parameters.AddWithValue("@SoTaiKhoan", DenTaiKhoan);
                updateCommand.Parameters.AddWithValue("@SoTienHienTai", ketqua);

                updateCommand.ExecuteNonQuery(); // thực hiện câu truy vấn
                sqlConnection.Close();
            }
        }


        private void ThongTinGiaoDichChuyenTien()
        {
            string soTaiKhoan = txtSoTaiKhoan.Text;
            decimal soTien = decimal.Parse(txtSoTienMuonChuyen.Text);

            string insertQuery = "INSERT INTO GiaoDichChuyenTien (SoTaiKhoan, SoTien, NgayGiaoDich, GioGiaoDich) " +
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

            txtSoTienMuonChuyen.Text = string.Empty;
        }


        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "" || txtSoTaiKhoan.Text == "" || txtCCCD.Text == "" || txtSoTaiKhoan.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Chuyển Tiền Đến Tài Khoản Này ?",
                    "Xác Nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    if (int.Parse(txtSoTienHienTai.Text) < int.Parse(txtSoTienMuonChuyen.Text))
                    {
                        MessageBox.Show("Số tiền muốn chuyển quá lớn.",
                            "Xác Nhận",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        updateSoTienHienTai1();
                        updateSoTienHienTai2();
                        ThongTinGiaoDichChuyenTien();
                        MessageBox.Show("Đã Chuyển Tiền Vào Tài Khoản (" + txtTenTaiKhoan.Text + ") Thành Công.");
                        txtSoTienMuonChuyen.Text = "";
                    }
                }
                ConnecSoDuTaiKhoan();
            }
        }

        private void txtSoTienHienTai_TextChanged(object sender, EventArgs e)
        {
            txtSoTienChuSo.Text = ConvertNumber.ConvertNumberToVietnamese(txtSoTienHienTai.Text);
        }

        private void btnMayTinh_Click(object sender, EventArgs e)
        {
            FormMayTinh formMayTinh = new FormMayTinh();
            formMayTinh.Show();
        }
    }
}
