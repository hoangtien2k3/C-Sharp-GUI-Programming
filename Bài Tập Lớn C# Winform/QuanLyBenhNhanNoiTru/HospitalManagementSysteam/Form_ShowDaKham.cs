using HospitalManagementSysteam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhNhanNoiTru
{
    public partial class Form_ShowDaKham : Form
    {
        public Form_ShowDaKham()
        {
            InitializeComponent();
        }
        SqlConnection Con = Connection.getConnection();
        void Connect()
        {
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        private void Form_ShowDaKham_Load(object sender, EventArgs e)
        {
            load_CbbBS();
            Load_GrvKhamBenh();
            Load_CbbBN();
        }

        private void Load_GrvKhamBenh()
        {
            Connect();
            SqlCommand cmd = new SqlCommand("Select * From ThongTinKhamBenh", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            Grv_KhamBenh.DataSource = tb;
           // Grv_KhamBenh.Columns.Add();
            Grv_KhamBenh.Refresh();

        }
        private void Load_CbbBN()
        {
            Connect();
            SqlCommand cmd = new SqlCommand("Select MaBN from ThongTinKhamBenh", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            Con.Close();

            DataRow r = tb.NewRow();
            r["MaBN"] = "---Chọn_Mã_Bênh_Nhân---";

            tb.Rows.InsertAt(r, 0);
            cbbMaBN.DataSource = tb;
            cbbMaBN.DisplayMember = "MaBN";
            cbbMaBN.ValueMember= "MaBN";
        }
        private void load_CbbBS()
        {
            Connect();
            SqlCommand cmd = new SqlCommand("Select MaBS from BacSi", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            Con.Close();

            cbbMaBS.DataSource = tb;
            cbbMaBS.DisplayMember = "MaBS";
            cbbMaBS.ValueMember = "MaBS";
        }


        private void Grv_KhamBenh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connect();
            if (cbbMaBN.Text == "---Chọn_Mã_Bênh_Nhân---")
            {
                MessageBox.Show("Chưa Nhập Mã Bênh Nhân");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Bệnh nhân ?", "Xác Nhận"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (dialog == DialogResult.Yes)
                {
                    String quety = "Delete from ThongTinKhamBenh where MaBN = '" + cbbMaBN.Text + "'";
                    SqlCommand cmd = new SqlCommand(quety, Con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    Con.Close();
                    Load_GrvKhamBenh();
                    Load_CbbBN();
                    MessageBox.Show("Xóa Thành công !");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Connect();
            if(cbbMaBN.Text == "---Chọn_Mã_Bênh_Nhân---")
            {
                MessageBox.Show("Chưa Nhập Mã Bệnh Nhân");
                Load_GrvKhamBenh();
            }
            else
            {
             string query = "Select * From ThongTinKhamBenh Where MaBN LIKE  '%' + @MaBN + '%' ";
            SqlCommand cmd = new SqlCommand(query, Con);

            String TkBN = String.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedItem.ToString() : cbbMaBN.Text;
            cmd.Parameters.AddWithValue("@MaBN", TkBN);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            Grv_KhamBenh.DataSource = tb;
            cmd.Dispose();
            Con.Close() ;
            
            Grv_KhamBenh.Refresh();
            }
      
        }

        private void Grv_KhamBenh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0 && e.RowIndex>= 0)
            {
                DataGridViewRow Row = Grv_KhamBenh.CurrentRow;
                cbbMaBN.Text = Row.Cells["MaBN"].Value.ToString();
                cbbMaBS.Text = Row.Cells["MaBS"].Value.ToString();
                dtpNgayKham.Value = Convert.ToDateTime(Row.Cells["NgayKham"].Value.ToString());
                cbbPhongKham.Text = Row.Cells["PhongKham"].Value.ToString();
                cbbCanNang.Text = Row.Cells["CanNang"].Value.ToString();
                cbbNhietDo.Text = Row.Cells["NhietDo"].Value.ToString();
                cbbNhomMau.Text = Row.Cells["NhomMau"].Value.ToString();
                cbbMach.Text = Row.Cells["Mach"].Value.ToString();
                cbbHuyetAp.Text = Row.Cells["HuyetAp"].Value.ToString();
                cbbNhipTho.Text = Row.Cells["NhipTho"].Value.ToString();
                txtLyDoKham.Text = Row.Cells["LyDoKham"].Value.ToString();
                txtTinhTrangHienTai.Text = Row.Cells["TinhTrangHienTai"].Value.ToString();
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            Connect();
            String query = "Update ThongTinKhamBenh Set MaBN = @MaBN , MaBS = @MaBS, NgayKham = @NgayKham, " +
                "PhongKham = @PhongKham, CanNang = @CanNang, NhomMau = @NhomMau, NhietDo = @NhietDo," +
                " Mach = @Mach, HuyetAp = @HuyetAp, NhipTho = @NhipTho, LyDoKham = @LyDoKham, TinhTrangHienTai = @TinhTrangHienTai where MaBN = @MaBN";
            SqlCommand cmd = new SqlCommand(query,Con);
            cmd.Parameters.AddWithValue("@MaBN", cbbMaBN.Text);
            cmd.Parameters.AddWithValue("@MaBS", cbbMaBS.Text);
            cmd.Parameters.AddWithValue("@NgayKham", dtpNgayKham.Text);
            cmd.Parameters.AddWithValue("@PhongKham", cbbPhongKham.SelectedItem);
            cmd.Parameters.AddWithValue("@CanNang", cbbCanNang.SelectedItem);
            cmd.Parameters.AddWithValue("@NhomMau", cbbNhomMau.SelectedItem);
            cmd.Parameters.AddWithValue("@NhietDo", cbbNhietDo.SelectedItem);
            cmd.Parameters.AddWithValue("@Mach", cbbMach.SelectedItem);
            cmd.Parameters.AddWithValue("@HuyetAp", cbbHuyetAp.SelectedItem);
            cmd.Parameters.AddWithValue("@NhipTho", cbbNhipTho.SelectedItem);
            cmd.Parameters.AddWithValue("@LyDoKham", txtLyDoKham.Text);
            cmd.Parameters.AddWithValue("@TinhTrangHienTai", txtTinhTrangHienTai.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Sửa Thông Tin Thành Công");
            Load_GrvKhamBenh();


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
