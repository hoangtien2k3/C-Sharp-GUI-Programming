using HospitalManagementSysteam;
using Microsoft.AnalysisServices;
using Microsoft.AnalysisServices.Tabular;
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

namespace QuanLyBenhNhanNoiTru
{
    public partial class Form_khambenh : Form
    {
        SqlConnection Con = Connection.getConnection();
        void Connect_Sql()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
        }
        public Form_khambenh()
        {
            InitializeComponent();
        }

        private void Form_khambenh_Load(object sender, EventArgs e)
        {
            Lock_formLeTan();  
            Load_GrvLeTan();

        }
        private void Lock_formLeTan()
        {

            txtTenBN.ReadOnly = true;
            txtTenBN.Enabled = false;
            cbbMaBN.DropDownStyle = ComboBoxStyle.Simple;
            cbbMaBN.Enabled = false;
            cbbGioiTinh.DropDownStyle = ComboBoxStyle.Simple;
            cbbGioiTinh.Enabled = false;
            cbbDiaChi.DropDownStyle = ComboBoxStyle.Simple;
            cbbDiaChi.Enabled = false;
            txtNgaySinh.Enabled = false;
        }
        private void Load_GrvLeTan()
        {
            Connect_Sql();
            SqlCommand cmd = new SqlCommand("Select * from LeTan" , Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb =new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            Con.Close();
            Grv_LeTan.DataSource = tb;
            Grv_LeTan.Refresh();
        } 

        private void Load_CbbBacsi(string chuyenkhoa)
        {
            Connect_Sql() ;
            SqlCommand cmd = new SqlCommand("Select MaBS From BacSi WHERE ChuyenKhoa = N'"+ chuyenkhoa + "'", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb =new DataTable();
            da.Fill(tb);

            cmd.Dispose();
            Con.Close() ;

            DataRow r = tb.NewRow();
            r["MaBS"] = "___MaBS___";

            tb.Rows.InsertAt(r, 0);
            cbbMaBS.DataSource = tb;
            cbbMaBS.DisplayMember= "MaBS";
            cbbMaBS.ValueMember = "MaBS";
        }

        private void cbbChuyenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chuyenkhoa = cbbChuyenKhoa.Text.Trim();
            Load_CbbBacsi(chuyenkhoa);
        }

        private void Grv_LeTan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Lấy thông tin bệnh nhân được chọn
                DataGridViewRow row = Grv_LeTan.CurrentRow;

                // Lấy các giá trị cần thiết của bệnh nhân
                cbbMaBN.Text = row.Cells["MaBN"].Value.ToString();
                txtTenBN.Text = row.Cells["TenBN"].Value.ToString();
                cbbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                cbbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();

                if(row.Cells["NgaySinh"].Value != DBNull.Value)
                { 
                    txtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value.ToString());
                }
                else
                {
                    txtNgaySinh.Value = DateTime.Now;
                }
               

                if (Grv_LeTan.CurrentRow.Cells["ImageData"].Value != null && Grv_LeTan.CurrentRow.Cells["ImageData"].Value != DBNull.Value)
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

        private void btnNhapVien_Click(object sender, EventArgs e)
        {           
            Connect_Sql();
            SqlCommand cmd = null;
            if (cbbMaBN.Text == "" || cbbChuanDoanSoBo.Text == "" || txtHuongDieuTri.Text == "" ||
                dtpNgayKham.Text == "" || cbbPhongKham.Text == "" || cbbMaBS.Text == "" || cbbCanNang.Text == "" ||
                cbbNhietDo.Text == "" || cbbNhomMau.Text == "" || cbbMach.Text == "" || cbbHuyetAp.Text == "" ||
                cbbNhipTho.Text == "" || txtLyDoKham.Text == "" || txtTinhTrangHienTai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                cmd = new SqlCommand("Select Count(*) From ThongTinKhamBenh Where MaBN = @Mabn", Con);
                String Mabn = String.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedValue.ToString() : cbbMaBN.Text;
                cmd.Parameters.AddWithValue("@Mabn", Mabn);
                int Count = Convert.ToInt32(cmd.ExecuteScalar());

                if(Count > 0)
                {
                    MessageBox.Show("Mã bệnh nhân đã tồn tại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Thêm vào form Show_daKham
                    String query = "Insert Into ThongTinKhamBenh(MaBN , MaBS, NgayKham, PhongKham, ChuyenKhoa, CanNang, NhomMau, NhietDo, Mach, HuyetAp, NhipTho, LyDoKham, TinhTrangHienTai, ChuanDoanSoBo, SoNgayNhapVien, HuongDieuTri) " +
                        "Values (@MaBN , @MaBS, @NgayKham, @PhongKham, @ChuyenKhoa, @CanNang, @NhomMau, @NhietDo, @Mach, @HuyetAp, @NhipTho, @LyDoKham, @TinhTrangHienTai, @ChuanDoanSoBo, @SoNgayNhapVien, @HuongDieuTri)";
                    cmd = new SqlCommand(query, Con);

                    String Mabn1 = String.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedItem.ToString() : cbbMaBN.Text;
                    cmd.Parameters.AddWithValue("@MaBN", Mabn1);

                    String MaBS = String.IsNullOrEmpty(cbbMaBS.Text) ? cbbMaBS.SelectedItem.ToString() : cbbMaBS.Text;
                    cmd.Parameters.AddWithValue("@MaBS", MaBS);

                    cmd.Parameters.AddWithValue("@NgayKham", dtpNgayKham.Value.ToString("yyyy-MM-dd"));

                    String PhongKham = String.IsNullOrEmpty(cbbPhongKham.Text) ? cbbPhongKham.SelectedItem.ToString() : cbbPhongKham.Text;
                    cmd.Parameters.AddWithValue("@PhongKham", PhongKham);

                    cmd.Parameters.AddWithValue("@ChuyenKhoa", cbbChuyenKhoa.Text.Trim());

                    String CanNang = String.IsNullOrEmpty(cbbCanNang.Text) ? cbbCanNang.SelectedItem.ToString() : cbbCanNang.Text;
                    cmd.Parameters.AddWithValue("@CanNang", CanNang);

                    String NhomMau = String.IsNullOrEmpty(cbbNhomMau.Text) ? cbbNhomMau.SelectedItem.ToString() : cbbNhomMau.Text;
                    cmd.Parameters.AddWithValue("@NhomMau", NhomMau);

                    string NhietDo = string.IsNullOrEmpty(cbbNhietDo.Text) ? cbbNhietDo.SelectedItem.ToString() : cbbNhietDo.Text;
                    cmd.Parameters.AddWithValue("@NhietDo", NhietDo);

                    string Mach = string.IsNullOrEmpty(cbbMach.Text) ? cbbMach.SelectedItem.ToString() : cbbMach.Text;
                    cmd.Parameters.AddWithValue("@Mach", Mach);

                    string HuyetAp = string.IsNullOrEmpty(cbbHuyetAp.Text) ? cbbHuyetAp.SelectedItem.ToString() : cbbHuyetAp.Text;
                    cmd.Parameters.AddWithValue("@HuyetAp", HuyetAp);

                    string NhipTho = string.IsNullOrEmpty(cbbNhipTho.Text) ? cbbNhipTho.SelectedItem.ToString() : cbbNhipTho.Text;
                    cmd.Parameters.AddWithValue("@NhipTho", NhipTho);

                    cmd.Parameters.AddWithValue("@LyDoKham", txtLyDoKham.Text);
                    cmd.Parameters.AddWithValue("@TinhTrangHienTai", txtTinhTrangHienTai.Text);

                    string chuanDoanSoBo = string.IsNullOrEmpty(cbbChuanDoanSoBo.Text) ? cbbChuanDoanSoBo.SelectedItem.ToString() : cbbChuanDoanSoBo.Text;
                    cmd.Parameters.AddWithValue("@ChuanDoanSoBo", chuanDoanSoBo);

                    cmd.Parameters.AddWithValue("@SoNgayNhapVien", txtSoNgayNhapVien.Text.Trim());

                    cmd.Parameters.AddWithValue("@HuongDieuTri", txtHuongDieuTri.Text.Trim());

                    cmd.ExecuteNonQuery();


                    if (txtSoNgayNhapVien.Value > 0)
                    {
                        // thêm thông tin bệnh nhân vào form BenhNhan
                        String query2 = "INSERT INTO BenhNhan (MaBN, TenBN, NgaySinh, GioiTinh, CCCD, DiaChi, BHYT, DienThoai, ImageData)" +
                        " SELECT MaBN, TenBN, NgaySinh, GioiTinh, CCCD, DiaChi, BHYT, DienThoai, ImageData FROM LeTan" +
                        " WHERE MaBN = '" + cbbMaBN.Text + "'";

                        cmd = new SqlCommand(query2, Con);
                        cmd.ExecuteNonQuery();
                    } else
                    {
                        // xóa thong tin benh nhan da kham (ngoai tru)
                        String query_xoa_benhNhanDaKham = "Delete From ThongTinKhamBenh Where MaBN = '" + cbbMaBN.Text + "'";
                        cmd = new SqlCommand(query_xoa_benhNhanDaKham, Con);
                        cmd.ExecuteNonQuery();
                    }


                    // Xóa Thông tin Bênh Nhân Lễ Tân
                    String query_xoa_benhNhanCho = "Delete From LeTan Where MaBN = '" + cbbMaBN.Text + "'";
                    cmd = new SqlCommand(query_xoa_benhNhanCho, Con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Nhập Viện Thành Công");
                    Load_GrvLeTan();
                    cmd.Dispose();
                    Con.Close();
                }
            }
        }

        private void Grv_LeTan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        
    }
}
