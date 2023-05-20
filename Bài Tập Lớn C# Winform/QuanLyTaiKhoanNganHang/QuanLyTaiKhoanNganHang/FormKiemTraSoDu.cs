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
    public partial class FormKiemTraSoDu : Form
    {
        SqlConnection Con = Connection.getInstance().getConnection();

        public FormKiemTraSoDu()
        {
            InitializeComponent();
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

        private void txtSoTienHienTai_TextChanged(object sender, EventArgs e)
        {
            txtSoTienChuSo.Text = ConvertNumber.ConvertNumberToVietnamese(txtSoTienHienTai.Text);
        }

        private void FormKiemTraSoDu_Load(object sender, EventArgs e)
        {
            LoadDataToComboBoxThongTinTaiKhoan();
        }

        private void btnKiemTraSoDuTK_Click(object sender, EventArgs e)
        {
            if (cbbSoTaiKhoan.Text.Trim() == "" && cbbTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền thông tin tài khoản cần tìm kiếm.");
            }
            else
            {
                Con.Open();
                string query = "SELECT TenTaiKhoan, SoTaiKhoan, LoaiTaiKhoan, DiaChiEmail, CCCD, ImageData FROM TaiKhoan WHERE (TenTaiKhoan = @TenTaiKhoan OR @TenTaiKhoan = '') AND (SoTaiKhoan = @SoTaiKhoan OR @SoTaiKhoan = '')";
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@TenTaiKhoan", cbbTenTaiKhoan.Text.Trim());
                command.Parameters.AddWithValue("@SoTaiKhoan", cbbSoTaiKhoan.Text.Trim());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtTenTaiKhoan.Text = reader["TenTaiKhoan"].ToString();
                    txtSoTaiKhoan.Text = reader["SoTaiKhoan"].ToString();
                    txtLTK.Text = reader["LoaiTaiKhoan"].ToString();
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

        private void MayTinh_Click(object sender, EventArgs e)
        {
            FormMayTinh formMayTinh = new FormMayTinh();
            formMayTinh.Show();
        }
    }
}
