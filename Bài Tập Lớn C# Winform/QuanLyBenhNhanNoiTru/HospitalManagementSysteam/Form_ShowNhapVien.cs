using HospitalManagementSysteam;
using System;
using System.CodeDom;
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
    public partial class Form_ShowNhapVien : Form
    {
        public Form_ShowNhapVien()
        {
            InitializeComponent();
        }
        SqlConnection Con = Connection.getConnection();
        void Connect()
        {
            if(Con.State == ConnectionState.Closed)
                Con.Open();
        }

        private void Form_ShowNhapVien_Load(object sender, EventArgs e)
        {
            Load_CbbMaBN();
            Load_GrvNhapVien();
        }
        private void Load_GrvNhapVien()
        {
            Connect();
            String query = "Select * from NoiDungKhamBenh";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable(); 
            da.Fill(tb);
            cmd.Dispose();
            Con.Close();

            Grv_NhapVien.DataSource = tb;
            Grv_NhapVien.Refresh();
        }
        private void Load_CbbMaBN()
        {
            Connect();
            String query = "Select MaBN From NoiDungKhamBenh";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            cmd.Dispose();
            Con.Close();

            DataRow r = tb.NewRow();
            r["MaBN"] = "---Chọn_Mã_Bệnh_Nhân---";

            tb.Rows.InsertAt(r, 0);
            cbbMaBN.DataSource = tb;
            cbbMaBN.DisplayMember = "MaBN";
            cbbMaBN.ValueMember = "MaBN";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connect();
            if(cbbMaBN.Text == "" || cbbChuanDoanSoBo.Text == "" || txtHuongDieuTri.Text == "" || txtTrieuChungThem.Text == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin");
            }
            else
            {
                String query = "Update NoiDungKhamBenh Set MaBN = @MaBN , ChuanDoanSoBo = @ChuanDoanSoBo ," +
                    " TrieuChungThem = @TrieuChungThem , HuongDieuTri = @HuongDieuTri where MaBN = @MaBN";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@MaBN", cbbMaBN.Text);
                cmd.Parameters.AddWithValue("@ChuanDoanSoBo", cbbChuanDoanSoBo.SelectedItem);
                cmd.Parameters.AddWithValue("@TrieuChungThem", txtTrieuChungThem.Text);
                cmd.Parameters.AddWithValue("@HuongDieuTri", txtHuongDieuTri.Text);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Con.Close();
                Load_GrvNhapVien();
                MessageBox.Show("Sửa Bệnh Nhân Thành Công");
            }




            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbbMaBN.Text == "---Chọn_Mã_Bệnh_Nhân---")
            {
                MessageBox.Show("Chưa Nhập Mã Bệnh Nhân");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Bệnh nhân ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialog == DialogResult.Yes) { 
                Connect();
                SqlCommand cmd = null;
                String query = "Delete  From NoiDungKhamBenh Where MaBN = '" + cbbMaBN.Text + "'";
                cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();
                String query1 = "Delete From ThongTinKhamBenh Where MaBN = '" + cbbMaBN.Text + "'";
                cmd = new SqlCommand(query1, Con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                Con.Close();
                Load_GrvNhapVien();
                Load_CbbMaBN();
            }
        }
        }

        private void Grv_NhapVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Grv_NhapVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = Grv_NhapVien.CurrentRow;
            cbbMaBN.Text = Row.Cells["MaBN"].Value.ToString();
            cbbChuanDoanSoBo.Text = Row.Cells["ChuanDoanSoBo"].Value.ToString();
            txtHuongDieuTri.Text = Row.Cells["HuongDieuTri"].Value.ToString();
            txtTrieuChungThem.Text = Row.Cells["TrieuChungThem"].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(cbbMaBN.Text == "---Chọn_Mã_Bệnh_Nhân---")
            {
                MessageBox.Show("Chưa Nhập Mã Bệnh Nhân");
                Load_GrvNhapVien();
            }
            else
            {
                String query = "Select * From NoiDungKhamBenh Where MaBN LIKE '%' +@MaBN+ '%'";
                SqlCommand cmd = new SqlCommand(query, Con);
                String TKBN = String.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedValue.ToString() : cbbMaBN.Text;
                cmd.Parameters.AddWithValue("@MaBN", TKBN);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);

                cmd.Dispose();
                Con.Close();

                Grv_NhapVien.DataSource = tb;

                Grv_NhapVien.Refresh();
            }
        }
    }
}
