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
    public partial class FormBenhAn : Form
    {
        SqlConnection Con = Connection.getConnection();

        public FormBenhAn()
        {
            InitializeComponent();
        }

        private void FormBenhAn_Load(object sender, EventArgs e)
        {
            Load_cbbMaBN();
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
            r["MaBN"] = "- Mã Bệnh Nhân -";
            tb.Rows.InsertAt(r, 0);

            cbbMaBN.DataSource = tb;
            cbbMaBN.DisplayMember = "MaBN";
            cbbMaBN.ValueMember = "MaBN";
        }

        private void Load_Thong_Tin_Benh_An()
        {
            Con.Open();

            string query = "select TenBN, DiaChi, CCCD, GioiTinh, ChuanDoanSoBo, ChuyenKhoa, HuongDieuTri, SoNgayNhapVien " +
                "from BenhNhan bn inner join ThongTinKhamBenh ttkb on bn.MaBN = ttkb.MaBN where bn.MaBN = '" + cbbMaBN.Text + "'";

            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtHoTen.Text = reader["TenBN"].ToString();
                txtDiaChi.Text = reader["DiaChi"].ToString();
                txtCCCD.Text = reader["CCCD"].ToString();
                txtGioiTinh.Text = reader["GioiTinh"].ToString();
                txtChuanDoanBenh.Text = reader["ChuanDoanSoBo"].ToString();
                txtChuyenKhoa.Text = reader["ChuyenKhoa"].ToString();
                txtHuongDieuTri.Text = reader["HuongDieuTri"].ToString();
                txtSoNgayNhapVien.Text = reader["SoNgayNhapVien"].ToString();
            }

            Con.Close();
        }


        private void cbbMaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Thong_Tin_Benh_An();
        }

        private void btnLuuThongTinBenhAn_Click(object sender, EventArgs e)
        {
        }
    }
}
