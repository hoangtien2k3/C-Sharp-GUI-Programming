using HospitalManagementSysteam;
using Microsoft.AnalysisServices;
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
            Load_CbbBacsi();
            Load_GrvLeTan();

        }
        private void Lock_formLeTan()
        {

            txtHoTen.ReadOnly = true;
            txtHoTen.Enabled = false;
            cbbMaBN.DropDownStyle = ComboBoxStyle.Simple;
            cbbMaBN.Enabled = false;
            cbbMaBA.DropDownStyle = ComboBoxStyle.Simple;
            cbbMaBA.Enabled = false;
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
        private void Load_CbbBacsi()
        {
            Connect_Sql() ;
            SqlCommand cmd = new SqlCommand("Select MaBS From BacSi",Con);
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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Grv_LeTan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
/*            int i;
            i = Grv_LeTan.CurrentRow.Index;

            cbbMaBN.Text = Grv_LeTan.Rows[i].Cells[0].Value.ToString();
            cbbMaBA.Text = Grv_LeTan.Rows[i].Cells[1].Value.ToString();
            txtHoTen.Text = Grv_LeTan.Rows[i].Cells[2].Value.ToString();
            cbbGioiTinh.Text = Grv_LeTan.Rows[i].Cells[3].Value.ToString();
            cbbDiaChi.Text = Grv_LeTan.Rows[i].Cells[4].Value.ToString();
            if(Grv_LeTan.Rows[i].Cells[5].Value != DBNull.Value && Grv_LeTan.Rows[i].Cells[5].Value != null)
            {
            txtNgaySinh.Text = Grv_LeTan.Rows[i].Cells[5].Value.ToString();
            }
            else
            {
            txtNgaySinh.Text = DateTime.Now.ToString();
            }
            

            if (Grv_LeTan.Rows[i].Cells[6].Value != DBNull.Value && Grv_LeTan.Rows[i].Cells[6].Value != null)
            {
                byte[] imageBytes = (byte[])Grv_LeTan.Rows[i].Cells[6].Value;
                MemoryStream ms = new MemoryStream(imageBytes);
                Image im = Image.FromStream(ms);

                ptbTaiAnh.Image = im;
            }
            else
            {
                ptbTaiAnh.Image = default;
            }*/

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Lấy thông tin bệnh nhân được chọn
                DataGridViewRow row = Grv_LeTan.CurrentRow;

                // Lấy các giá trị cần thiết của bệnh nhân
                cbbMaBN.Text = row.Cells["MaBN"].Value.ToString();
                cbbMaBA.Text = row.Cells["MaBA"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                cbbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                cbbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                if(row.Cells["NgaySinh"].Value != null && row.Cells["NgaySinh"].Value != DBNull.Value)
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

        private void btnLuu_Click(object sender, EventArgs e)   
        {
            SqlCommand cmd = null;
            if (dtpNgayKham.Text == "" || cbbPhongKham.Text == "" || cbbMaBS.Text == "" ||  cbbCanNang.Text == "" ||
                cbbNhietDo.Text == "" || cbbNhomMau.Text == "" || cbbMach.Text == "" || cbbHuyetAp.Text == "" ||
                cbbNhipTho.Text == "" || txtLyDoKham.Text == "" || txtTinhTrangHienTai.Text == "" || cbbMaBN.Text == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin ","Xác Nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Connect_Sql();
                // Check trung ma nhan vien
                String query = "SELECT COUNT(*) FROM ThongTinKhamBenh Where MaBN = @MaBN";
                cmd = new SqlCommand(query, Con);

                String MaBN = String.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedValue.ToString() : cbbMaBN.Text;
                cmd.Parameters.AddWithValue("MaBN", MaBN);

                int count = Convert.ToInt32(cmd.ExecuteScalar()); // Count so lan xuat hien cua MaBN

                if (count > 0) // check so lan xuat hien cua MaBN
                {
                    MessageBox.Show("Mã Bệnh Nhân Đã Tông Tại", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Thêm Bệnh Nhân vào from ThongTinKhamBenh
                    query = "Insert Into ThongTinKhamBenh(MaBN , MaBS, NgayKham, PhongKham, CanNang, NhomMau, NhietDo, Mach, HuyetAp, NhipTho, LyDoKham, TinhTrangHienTai) Values (@MaBN , @MaBS, @NgayKham, @PhongKham, @CanNang, @NhomMau, @NhietDo, @Mach, @HuyetAp, @NhipTho, @LyDoKham, @TinhTrangHienTai)";
                    cmd = new SqlCommand(query, Con);

                    String Mabn = String.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedItem.ToString() : cbbMaBN.Text;
                    cmd.Parameters.AddWithValue("@MaBN", Mabn);

                    String MaBS = String.IsNullOrEmpty(cbbMaBS.Text) ? cbbMaBS.SelectedItem.ToString() : cbbMaBS.Text;
                    cmd.Parameters.AddWithValue("@MaBS", MaBS);

                    cmd.Parameters.AddWithValue("@NgayKham", dtpNgayKham.Value.ToString("yyyy-MM-dd"));

                    String PhongKham = String.IsNullOrEmpty(cbbPhongKham.Text) ? cbbPhongKham.SelectedItem.ToString() : cbbPhongKham.Text;
                    cmd.Parameters.AddWithValue("@PhongKham", PhongKham);

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
                    cmd.ExecuteNonQuery();


                    // Xóa BN trong form lễ tân vì BN đã khám rồi
                    String query_xoa = "Delete From LeTan Where MaBN = '" + cbbMaBN.Text + "'";
                    cmd = new SqlCommand(query_xoa, Con);
                    cmd.ExecuteNonQuery();

                    Load_GrvLeTan();
                    cmd.Dispose();
                    Con.Close();
                }
            }

 
            

        }

        private void btnNhapVien_Click(object sender, EventArgs e)
        {           
            Connect_Sql();
            SqlCommand cmd = null;
            if (cbbMaBN.Text == "" || cbbChuanDoanSoBo.Text == "" || txtTrieuChungThem.Text == "" || txtHuongDieuTri.Text == "" ||
                dtpNgayKham.Text == "" || cbbPhongKham.Text == "" || cbbMaBS.Text == "" || cbbCanNang.Text == "" ||
                cbbNhietDo.Text == "" || cbbNhomMau.Text == "" || cbbMach.Text == "" || cbbHuyetAp.Text == "" ||
                cbbNhipTho.Text == "" || txtLyDoKham.Text == "" || txtTinhTrangHienTai.Text == "" || cbbMaBN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
            cmd = new SqlCommand("Select Count(*) From NoiDungKhamBenh Where MaBN = @Mabn",Con);
                String Mabn = String.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedValue.ToString() : cbbMaBN.Text;
                cmd.Parameters.AddWithValue("Mabn", Mabn);
                int Count = Convert.ToInt32(cmd.ExecuteScalar());

            if(Count > 0)
                {
                    MessageBox.Show("Mã bệnh nhân đã tồn tại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Thêm vào form Show_daKham
                    String query1 = "Insert Into ThongTinKhamBenh(MaBN , MaBS, NgayKham, PhongKham, CanNang, NhomMau, NhietDo, Mach, HuyetAp, NhipTho, LyDoKham, TinhTrangHienTai) Values (@MaBN , @MaBS, @NgayKham, @PhongKham, @CanNang, @NhomMau, @NhietDo, @Mach, @HuyetAp, @NhipTho, @LyDoKham, @TinhTrangHienTai)";
                    cmd = new SqlCommand(query1, Con);

                    String Mabn1 = String.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedItem.ToString() : cbbMaBN.Text;
                    cmd.Parameters.AddWithValue("@MaBN", Mabn1);

                    String MaBS = String.IsNullOrEmpty(cbbMaBS.Text) ? cbbMaBS.SelectedItem.ToString() : cbbMaBS.Text;
                    cmd.Parameters.AddWithValue("@MaBS", MaBS);

                    cmd.Parameters.AddWithValue("@NgayKham", dtpNgayKham.Value.ToString("yyyy-MM-dd"));

                    String PhongKham = String.IsNullOrEmpty(cbbPhongKham.Text) ? cbbPhongKham.SelectedItem.ToString() : cbbPhongKham.Text;
                    cmd.Parameters.AddWithValue("@PhongKham", PhongKham);

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
                    cmd.ExecuteNonQuery();

                    // Thêm vào form Show_NhapVien  
                    String quety = "insert into NoiDungKhamBenh(MaBN, ChuanDoanSoBo, TrieuChungThem, HuongDieuTri) values (@MaBN, @ChuanDoanSoBo, @TrieuChungThem, @HuongDieuTri)";
                    cmd = new SqlCommand (quety, Con);

                    String MaBN = String.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedValue.ToString () : cbbMaBN.Text;
                    cmd.Parameters.AddWithValue("@MaBN", MaBN);
                    String ChuanDoanSoBo = String.IsNullOrEmpty(cbbChuanDoanSoBo.Text) ? cbbChuanDoanSoBo.SelectedItem.ToString() : cbbChuanDoanSoBo.Text;
                    cmd.Parameters.AddWithValue("@ChuanDoanSoBo", ChuanDoanSoBo);

                    cmd.Parameters.AddWithValue("@TrieuChungThem", txtTrieuChungThem.Text);

                    cmd.Parameters.AddWithValue("@HuongDieuTri", txtHuongDieuTri.Text);
                    cmd.ExecuteNonQuery();

                    //xóa Bệnh nhân Chờ Khi ấn nhập viện
                    String query_xoa = "Delete From LeTan Where MaBN = '" + cbbMaBN.Text + "'";
                    cmd = new SqlCommand(query_xoa, Con);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Nhập Viện Thành Công");
                    Load_GrvLeTan();
                    cmd.Dispose();
                    Con.Close();
                }

            
            }
        }

        private void btnXoaTTBN_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btXem_Click(object sender, EventArgs e)
        {
            Form_ShowDaKham form = new Form_ShowDaKham();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ShowNhapVien Form = new Form_ShowNhapVien();
            Form.Show();
        }

        private void Grv_LeTan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
/*
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Lấy thông tin bệnh nhân được chọn
                DataGridViewRow row = Grv_LeTan.CurrentRow;

                // Lấy các giá trị cần thiết của bệnh nhân
                cbbMaBN.Text = row.Cells["MaBN"].Value.ToString();
                cbbMaBA.Text = row.Cells["MaBA"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                cbbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                cbbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value.ToString());


                byte[] imageBytes = (byte[])row.Cells["ImageData"].Value; // Lấy thông tin ảnh từ cơ sở dữ liệu
                MemoryStream ms = new MemoryStream(imageBytes); // Chuyển đổi dữ liệu Binary về kiểu Image
                Image image = Image.FromStream(ms);
                ptbTaiAnh.Image = image; // Hiển thị ảnh lên PictureBox
            }*/
        }
    }
}
