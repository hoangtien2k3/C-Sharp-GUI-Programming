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
    public partial class FormXuatVien : Form
    {
        SqlConnection Con = Connection.getConnection();

        public FormXuatVien()
        {
            InitializeComponent();
        }

        public void Load_cbbMaBN()
        {
            Con.Open();
            String query = "Select MaBN From BenhNhan";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            cmd.Dispose();
            Con.Close();

            DataRow r = tb.NewRow();
            r["MaBN"] = "";
            tb.Rows.InsertAt(r, 0);

            cbbMaBN.DataSource = tb;
            cbbMaBN.DisplayMember = "MaBN";
            cbbMaBN.ValueMember = "MaBN";
        }

        private void FormXuatVien_Load(object sender, EventArgs e)
        {
            Load_cbbMaBN();
        }

        private void TongTienThuoc()
        {
            using (SqlConnection Con = Connection.getConnection())
            {
                Con.Open();
                string query = "SELECT SUM(ThanhTien) FROM DieuTri WHERE MaBN = '" + cbbMaBN.Text + "' GROUP BY MaBN";
                SqlCommand cmd = new SqlCommand(query, Con);
                int tongGiaTien = Convert.ToInt32(cmd.ExecuteScalar());
                txtSoTienThuoc.Text = tongGiaTien.ToString();
                Con.Close();
            }
        }

        private void TongTienPhong()
        {
            Con.Open();

            string query = "select LoaiPhong from GiuongBenh where MaBN = '" + cbbMaBN.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            string LoaiPhong = (string)cmd.ExecuteScalar();

            query = "select SoNgayNhapVien from ThongTinKhamBenh where MaBN = '" + cbbMaBN.Text + "'";
            cmd = new SqlCommand(query, Con);
            string SoNgayNhapVien = (string)cmd.ExecuteScalar();


            if (LoaiPhong == "Vip")
            {
                int TienPhong = 500000 * Convert.ToInt32(SoNgayNhapVien);
                txtTienPhong.Text = TienPhong.ToString();
            } else
            {
                int TienPhong = 100000 * Convert.ToInt32(SoNgayNhapVien);
                txtTienPhong.Text = TienPhong.ToString();
            }

            Con.Close();
        }


        private void TongChiPhi()
        {
            Con.Open();
            string query = "select BHYT from BenhNhan where MaBN = '"+ cbbMaBN.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            string BHYT = (string)cmd.ExecuteScalar();

            if (Convert.ToInt64(BHYT) > 0)
            {
                txtTongChiPhi.Text = ((Convert.ToInt32(txtSoTienThuoc.Text) + Convert.ToInt32(txtTienPhong.Text) + 200000) / 2).ToString();
            } else
            {
                txtTongChiPhi.Text = (Convert.ToInt32(txtSoTienThuoc.Text) + Convert.ToInt32(txtTienPhong.Text) + 200000).ToString();
            }

            cmd.Dispose();
            Con.Close();
        }

        private void LoadThongTin()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

            string query = "SELECT TenBN, DiaChi, ChuyenKhoa, GioiTinh FROM BenhNhan bn INNER JOIN ThongTinKhamBenh ttkb ON bn.MaBN = ttkb.MaBN WHERE bn.MaBN = @MaBN";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@MaBN", cbbMaBN.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtTenBN.Text = reader.GetString(reader.GetOrdinal("TenBN"));
                txtDiaChi.Text = reader.GetString(reader.GetOrdinal("DiaChi"));
                txtKhoa.Text = reader.GetString(reader.GetOrdinal("ChuyenKhoa"));
                txtGioiTinh.Text = reader.GetString(reader.GetOrdinal("GioiTinh"));
            }

            Con.Close();
        }


        // Định nghĩa một hàm để thực hiện truy vấn lấy ảnh từ database dựa vào `MaBN`
        private byte[] GetImageDataFromDatabase(string maBN)
        {
            byte[] imageData = null;

            try
            {
                using (SqlConnection connection = Connection.getConnection())
                {
                    connection.Open();
                    string query = "SELECT ImageData FROM BenhNhan WHERE MaBN = @MaBN";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaBN", maBN);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                imageData = (byte[])reader["ImageData"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return imageData;
        }


        // load ảnh Bệnh Nhân lên PictureBox
        private void Load_Anh_Len_PictureBox()
        {
            string maBN = cbbMaBN.Text;
            byte[] imageData = GetImageDataFromDatabase(maBN);
            if (imageData != null)
            {
                using (MemoryStream stream = new MemoryStream(imageData))
                {
                    ptbTaiAnh.Image = Image.FromStream(stream);
                }
            }
        }

        private void cbbMaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongTin(); // load thông tin tiền 
            TongTienThuoc(); // load tiền thuốc
            TongTienPhong(); // load tiền phòng bệnh
            TongChiPhi(); // load Chi Phí Điều Trị

            txtSoTienBangChu.Text = ConvertNumber.ConvertNumberToVietnamese(txtTongChiPhi.Text); // đọc số tiền viện phí (tiếng việt)
            Load_Anh_Len_PictureBox(); // load ảnh lên Picturebox
        }

        private void btnXuatVien_Click(object sender, EventArgs e)
        {
            if (cbbMaBN.Text == "")
            {
                MessageBox.Show("Hãy chọn bệnh nhân cần xuất viện !!!");
            }
            else
            {
                Con.Open();

                DialogResult dialog = MessageBox.Show("Bạn Có Chắc Chắn Muốn Xuất Viện.",
                    "Xác Nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    // xóa bệnh nhân
                    string query = "DELETE FROM BenhNhan WHERE MaBN = @MaBN";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.Parameters.AddWithValue("@MaBN", cbbMaBN.Text);
                    command.ExecuteNonQuery();

                    // xóa thông tin đã khám
                    query = "DELETE FROM ThongTinKhamBenh WHERE MaBN = @MaBN";
                    command = new SqlCommand(query, Con);
                    command.Parameters.AddWithValue("@MaBN", cbbMaBN.Text);
                    command.ExecuteNonQuery();

                    // xóa giường bệnh
                    query = "DELETE FROM GiuongBenh WHERE MaBN = @MaBN";
                    command = new SqlCommand(query, Con);
                    command.Parameters.AddWithValue("@MaBN", cbbMaBN.Text);
                    command.ExecuteNonQuery();


                    string xuatvien = "--- Xuất Viện Thành Công ---\n" +
                                        "\n\t+ Ngày Xuất Viện: " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss") +
                                        "\n\t+ Họ Tên: " + txtTenBN.Text +
                                        "\n\t+ Khoa: " + txtKhoa.Text +
                                        "\n\t+ Tổng Chi Phí: " + txtTongChiPhi.Text +
                                        "\n\t+ Số Tiền: " + txtSoTienBangChu.Text +
                                        "\n\t";

                    MessageBox.Show(xuatvien);

                    command.Dispose();
                    Clear_Thong_Tin();
                }

                Con.Close();
            }
        }


        private void Clear_Thong_Tin()
        {
            cbbMaBN.Text = "";
            txtTenBN.Text = "";
            txtDiaChi.Text = "";
            txtKhoa.Text = "";
            txtGioiTinh.Text = "";
            txtSoTienThuoc.Text = "";
            txtTienPhong.Text = "";
            txtTongChiPhi.Text = "";
            txtSoTienBangChu.Text = "";
            ptbTaiAnh.Image = null;
        }

    }
}
