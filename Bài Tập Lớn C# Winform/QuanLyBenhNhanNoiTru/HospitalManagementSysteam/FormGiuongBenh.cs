using HospitalManagementSysteam;
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

namespace QuanLyBenhNhanNoiTru
{
    public partial class FormGiuongBenh : Form
    {
        SqlConnection Con = Connection.getConnection();

        public FormGiuongBenh()
        {
            InitializeComponent();
        }

        private void FormGiuongBenh_Load(object sender, EventArgs e)
        {
            LoadDataGRVGiuongBenh();
            LoadDataGRVBenhNhan();
            LoadCBBTimGiuong();
            LoadCBBMaBNGiuong();
            ReadOnlyThongTinBN();
        }

        void LoadDataGRVGiuongBenh()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from GiuongBenh", Con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGRVGiuongBenh.DataSource = tb;
            Con.Close();
        }

        void LoadDataGRVBenhNhan()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from BenhNhan", Con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGRVBenhNhan.DataSource = tb;
            Con.Close();
        }

        void LoadCBBTimGiuong()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select MaBN from BenhNhan", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbTimGiuong.Items.Add(reader.GetString(0));

            }
            cmd.Dispose();
            reader.Close();
            Con.Close();
        }

        void LoadCBBMaBNGiuong()
        {
            cbbMaBNGiuong.Items.Clear();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select MaBN from BenhNhan", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbMaBNGiuong.Items.Add(reader.GetString(0));

            }
            cmd.Dispose();
            reader.Close();
            Con.Close();
        }

        void ReadOnlyThongTinBN()
        {
            txtMaBN.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtGioiTinh.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            datetimeNgaySinh.Enabled = false;
        }

        private void dataGRVGiuongBenh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Đẩy dữ liệu lên panel danh sách giường bệnh
                DataGridViewRow row = dataGRVGiuongBenh.CurrentRow;
                for (int i = 0; i < cbbMaBNGiuong.Items.Count; i++)
                {
                    if (row.Cells["MaBN"].Value.ToString() == cbbMaBNGiuong.Items[i].ToString())
                    {
                        // Lấy giá dữ liệu tại vị trí thứ i trong cbb
                        cbbMaBNGiuong.SelectedItem = cbbMaBNGiuong.Items[i];
                        break;
                    }
                }
                for (int i = 0; i < cbbSoTang.Items.Count; i++)
                {
                    if (row.Cells["SoTang"].Value.ToString() == cbbSoTang.Items[i].ToString())
                    {
                        // Lấy giá dữ liệu tại vị trí thứ i trong cbb
                        cbbSoTang.SelectedItem = cbbSoTang.Items[i];
                        break;
                    }
                }
                for (int i = 0; i < cbbSoPhong.Items.Count; i++)
                {
                    if (row.Cells["SoPhong"].Value.ToString() == cbbSoPhong.Items[i].ToString())
                    {
                        // Lấy giá dữ liệu tại vị trí thứ i trong cbb
                        cbbSoPhong.SelectedItem = cbbSoPhong.Items[i];
                        break;
                    }
                }
                for (int i = 0; i < cbbSoGiuong.Items.Count; i++)
                {
                    if (row.Cells["SoGiuong"].Value.ToString() == cbbSoGiuong.Items[i].ToString())
                    {
                        // Lấy giá dữ liệu tại vị trí thứ i trong cbb
                        cbbSoGiuong.SelectedItem = cbbSoGiuong.Items[i];
                        break;
                    }
                }

                /*                // Đưa giá trị vào combobox
                                string selectedValue = row.Cells["MaBN"].Value.ToString();
                                cbbMaBNGiuong.Items.Clear();
                                cbbMaBNGiuong.Items.Add(selectedValue);
                                cbbMaBNGiuong.SelectedIndex = 0;

                                selectedValue = row.Cells["SoTang"].Value.ToString();
                                cbbSoTang.Items.Clear();
                                cbbSoTang.Items.Add(selectedValue);
                                cbbSoTang.SelectedIndex = 0;

                                selectedValue = row.Cells["SoPhong"].Value.ToString();
                                cbbSoPhong.Items.Clear();
                                cbbSoPhong.Items.Add(selectedValue);
                                cbbSoPhong.SelectedIndex = 0;

                                selectedValue = row.Cells["SoGiuong"].Value.ToString();
                                cbbSoGiuong.Items.Clear();
                                cbbSoGiuong.Items.Add(selectedValue);
                                cbbSoGiuong.SelectedIndex = 0;*/

                // Đẩy dữ liệu bệnh nhân của giường được chọn lên panel thông tin giường 

                // Mở kết nối
                Con.Open();

                // Tạo đối tượng SqlCommand với truy vấn SQL để lấy thông tin của nhân viên có EmployeeID là 1
                SqlCommand cmd = new SqlCommand("SELECT MaBN, TenBN, DiaChi, GioiTinh, NgaySinh, ImageData FROM BenhNhan WHERE MaBN = '" + row.Cells["MaBN"].Value.ToString() + "'", Con);

                // Thực thi truy vấn và lấy dữ liệu
                SqlDataReader reader = cmd.ExecuteReader();

                // Đưa thông tin vào các textbox
                while (reader.Read())
                {
                    txtMaBN.Text = reader["MaBN"].ToString();
                    txtHoTen.Text = reader["TenBN"].ToString();
                    txtDiaChi.Text = reader["DiaChi"].ToString();
                    txtGioiTinh.Text = reader["GioiTinh"].ToString();
                    datetimeNgaySinh.Text = reader["NgaySinh"].ToString();
                    byte[] imageBytes = (byte[])reader["ImageData"];

                    // Chuyển đổi dữ liệu Binary về kiểu Image
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image image = Image.FromStream(ms);

                    // Hiển thị ảnh lên PictureBox
                    ptbTaiAnh.Image = image;
                }

                // Đóng SqlDataReader và kết nối
                reader.Close();
                Con.Close();
            }
        }

        private void dataGRVBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGRVBenhNhan.CurrentRow;

                txtMaBN.Text = row.Cells["MaBN"].Value.ToString();
                txtHoTen.Text = row.Cells["TenBN"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();

                if (row.Cells["NgaySinh"].Value != null && row.Cells["NgaySinh"].Value != DBNull.Value)
                {
                    datetimeNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value.ToString());
                }
                else
                {
                    datetimeNgaySinh.Value = DateTime.Now;
                }


                if (dataGRVBenhNhan.CurrentRow.Cells["ImageData"].Value != null && dataGRVBenhNhan.CurrentRow.Cells["ImageData"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["ImageData"].Value; // Lấy thông tin ảnh từ cơ sở dữ liệu
                    MemoryStream ms = new MemoryStream(imageBytes); // Chuyển đổi dữ liệu Binary về kiểu Image
                    Image image = Image.FromStream(ms);
                    ptbTaiAnh.Image = image; // Hiển thị ảnh lên PictureBox
                }
                else
                {
                    ptbTaiAnh.Image = default;
                }
            }
        }

        private void cbbSoTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSoTang.SelectedItem.ToString() == "(1) Khoa Cấp Cứu")
            {
                cbbSoPhong.Items.Clear();
                cbbSoPhong.Items.Add("101");
                cbbSoPhong.Items.Add("102");
            }
            if (cbbSoTang.SelectedItem.ToString() == "(2) Khoa Nhi")
            {
                cbbSoPhong.Items.Clear();
                cbbSoPhong.Items.Add("201");
                cbbSoPhong.Items.Add("202");
            }
            if (cbbSoTang.SelectedItem.ToString() == "(3) Khoa Hồi Sức")
            {
                cbbSoPhong.Items.Clear();
                cbbSoPhong.Items.Add("301");
                cbbSoPhong.Items.Add("302");
            }
            if (cbbSoTang.SelectedItem.ToString() == "(4) Khoa Phẩu Thuật")
            {
                cbbSoPhong.Items.Clear();
                cbbSoPhong.Items.Add("401");
                cbbSoPhong.Items.Add("402");
            }
            if (cbbSoTang.SelectedItem.ToString() == "(5) Khoa Ngoại")
            {
                cbbSoPhong.Items.Clear();
                cbbSoPhong.Items.Add("501");
                cbbSoPhong.Items.Add("502");
            }
            if (cbbSoTang.SelectedItem.ToString() == "(6) Khoa Nội")
            {
                cbbSoPhong.Items.Clear();
                cbbSoPhong.Items.Add("601");
                cbbSoPhong.Items.Add("602");
            }
        }

        private void cbbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSoPhong.SelectedItem.ToString() != "")
            {
                cbbSoGiuong.Items.Clear();
                cbbSoGiuong.Items.Add("1");
                cbbSoGiuong.Items.Add("2");
                cbbSoGiuong.Items.Add("3");
                cbbSoGiuong.Items.Add("4");
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (cbbMaBNGiuong.Text == "" || cbbSoTang.Text == "" || cbbSoPhong.Text == "" || cbbSoGiuong.Text == "")
            {
                MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                Con.Open();
                string query = "select count(*) from GiuongBenh where MaBN = '" + cbbMaBNGiuong.SelectedItem.ToString() + "' ";
                /*                    "and SoTang = '"+cbbSoTang.SelectedItem.ToString()+"'" + 
                                    "and SoPhong = '"+cbbSoPhong.SelectedItem.ToString()+"' " +
                                    "and SoGiuong = '"+cbbSoGiuong.SelectedItem.ToString()+"'";*/
                SqlCommand cmd = new SqlCommand(query, Con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Mã bệnh nhân đã tồn tại. Hãy nhập lại mã khác.",
                        "Xác Nhận",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    query = "insert into GiuongBenh (MaBN, SoTang, SoPhong, SoGiuong) " +
                        "values('" + cbbMaBNGiuong.SelectedItem.ToString() + "', " +
                        "N'" + cbbSoTang.SelectedItem.ToString() + "', " +
                        "'" + cbbSoPhong.SelectedItem.ToString() + "', " +
                        "'" + cbbSoGiuong.SelectedItem.ToString() + "')";
                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    Con.Close();
                    MessageBox.Show("Thêm thông tin thành công.", "", MessageBoxButtons.OK);
                    LoadDataGRVGiuongBenh();

                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            LoadCBBMaBNGiuong();
            cbbSoTang.Items.Clear();
            cbbSoTang.Items.Add("(1) Khoa Cấp Cứu");
            cbbSoTang.Items.Add("(2) Khoa Nhi");
            cbbSoTang.Items.Add("(3) Khoa Hồi Sức");
            cbbSoTang.Items.Add("(4) Khoa Phẩu Thuật");
            cbbSoTang.Items.Add("(5) Khoa Ngoại");
            cbbSoTang.Items.Add("(6) Khoa Nội");
            cbbSoPhong.Items.Clear();
            cbbSoGiuong.Items.Clear();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from GiuongBenh where MaBN = '" + cbbMaBNGiuong.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            Con.Close();
            LoadDataGRVGiuongBenh();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (cbbMaBNGiuong.Text == "" || cbbSoTang.Text == "" || cbbSoPhong.Text == "" || cbbSoGiuong.Text == "")
            {
                MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                Con.Open();
                string query = "select MaBN, SoTang, SoPhong, SoGiuong from GiuongBenh";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Đọc các thuộc tính từng dòng trong bảng
                        while (reader.Read())
                        {
                            if (cbbSoTang.Text == reader["SoTang"].ToString()
                                && cbbSoPhong.Text == reader["SoPhong"].ToString()
                                && cbbSoGiuong.Text == reader["SoGiuong"].ToString())
                            {
                                if (cbbMaBNGiuong.Text == reader["MaBN"].ToString())
                                    MessageBox.Show("Bệnh nhân đã nằm giường này.");
                                else
                                    MessageBox.Show("Đã có bệnh nhân khác nằm giường này.");
                            }
                            else
                            {
                                query = "update GiuongBenh set MaBN = '" + cbbMaBNGiuong.Text + "', " +
                                    "SoTang = N'" + cbbSoTang.Text + "', " +
                                    "SoPhong = '" + cbbSoPhong.Text + "', " +
                                    "SoGiuong = '" + cbbSoGiuong.Text + "' " +
                                    "where MaBN = '" + dataGRVGiuongBenh.CurrentRow.Cells["MaBN"].Value.ToString() + "'";
                                SqlCommand command = new SqlCommand(query, Con);
                                reader.Close();
                                command.ExecuteNonQuery();
                                command.Dispose();
                                cmd.Dispose();
                                MessageBox.Show("Sửa thông tin thành công.");
                                break;
                            }
                        }
                    }
                }
                Con.Close();
                LoadDataGRVGiuongBenh();
            }
        }

    }
}
