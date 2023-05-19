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
using System.Xml.Serialization;

namespace QuanLyTaiKhoanNganHang
{
    public partial class FormXoaTaiKhoan : Form
    {
        SqlConnection Con = Connection.getInstance().getConnection();

        public FormXoaTaiKhoan()
        {
            InitializeComponent();
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

                reader.Close();
                Con.Close();

            }
        }

        public void ConnecXoaTaiKhoan()
        {
            Con.Open();
            string query = "SELECT TenTaiKhoan, SoTaiKhoan, DiaChiEmail, GioiTinh, CCCD, NgaySinh FROM TaiKhoan";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            XoaTaiKhoanGV.DataSource = dataTable;
            Con.Close();
        }

        private void FormXoaTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDataToComboBoxSoTaiKhoan();
            LoadDataToComboBoxTenTaiKhoan();
            ConnecXoaTaiKhoan();
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "" || txtSoTaiKhoan.Text == "" || txtDiaChiEmail.Text == "" || txtCCCD.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin tài khoản cần xóa.");
            }
            else
            {
                Con.Open();

                DialogResult dialog = MessageBox.Show("Bạn Có Chắc Chắn Xóa Tài Khoản.",
                    "Xác Nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    string query = "DELETE FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text); // Truyền tham số vào câu lệnh SQL
                    int result = command.ExecuteNonQuery(); // Thực thi câu lệnh SQL để xóa thông tin bệnh nhân

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa thông tin tài khoản thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản (" + txtSoTaiKhoan.Text + ").");
                    }

                    query = "DELETE FROM SoDuTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                    command = new SqlCommand(query, Con);
                    command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                    command.ExecuteNonQuery();

                    Con.Close();
                    LamMoiThongTin();
                    ConnecXoaTaiKhoan();
                    cbbSoTaiKhoan.Text = "";
                    cbbTenTaiKhoan.Text = "";
                    return;
                }

                Con.Close();
            }
        }


        private void LamMoiThongTin()
        {
            txtTenTaiKhoan.Text = "";
            txtSoTaiKhoan.Text = "";
            txtCCCD.Text = "";
            txtDiaChiEmail.Text = "";
            ptbTaiAnh.Image = null;
        }

    }
}
