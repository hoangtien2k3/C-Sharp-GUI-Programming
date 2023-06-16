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
    public partial class Form_BenhAn : Form
    {
        public Form_BenhAn()
        {
            InitializeComponent();
        }
        SqlConnection Con = Connection.getConnection();
        void Connect()
        {
            if(Con.State == ConnectionState.Closed)
                Con.Open();
        }

        private void Form_BenhAn_Load(object sender, EventArgs e)
        {
            Load_Grv();
            Load_cbbMaBN();
        }

        public void Load_Grv()
        {
            Connect();
            String query = "Select * From BenhAn";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            cmd.Dispose();
            Con.Close();

            grvBenhAn.DataSource = tb;
            grvBenhAn.Refresh();
        }
        public void Load_cbbMaBN()
        {
            Connect();
            String query = "Select MaBN From ThongTinKhamBenh";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            cmd.Dispose();
            Con.Close();

            DataRow r = tb.NewRow();
            r["MaBN"] = "Nhập vào Mã Bệnh Nhân";
            tb.Rows.InsertAt(r, 0);

            cbbMaBN.DataSource = tb;
            cbbMaBN.DisplayMember = "MaBN";
            cbbMaBN.ValueMember = "MaBN";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Connect();
            SqlCommand cmd = null;
            String query1 = "Insert Into BenhAn (MaBA) values (@MaBA) ";
            /*String query2 = "Insert Into BenhAn (MaBS, NgayKham, PhongKham, ChuyenKhoa, CanNang, NhomMau, NhietDo, Mach, HuyetAp, NhipTho, LyDoKham, TinhTrangHienTai, ChuanDoanSoBo, SoNgayNhapVien, HuongDieuTri) " +
          "SELECT MaBS, NgayKham, PhongKham, ChuyenKhoa, CanNang, NhomMau, NhietDo, Mach, HuyetAp, NhipTho, LyDoKham, TinhTrangHienTai, ChuanDoanSoBo, SoNgayNhapVien, HuongDieuTri WHERE MaBN =  '" + cbbMaBN.Text + "' and Insert Into BenhAn (MaBN, TenBN, NgaySinh, GioiTinh, CCCD, DiaChi, BHYT, DienThoai) \" +\r\n                \"SELECT MaBN, TenBN, NgaySinh, GioiTinh, CCCD, DiaChi, BHYT, DienThoai FROM LeTan WHERE MaBN = '" + cbbMaBN.Text + "'";
            String query3 = "Insert Into BenhAn (MaBN, TenBN, NgaySinh, GioiTinh, CCCD, DiaChi, BHYT, DienThoai) " +
            "SELECT MaBN, TenBN, NgaySinh, GioiTinh, CCCD, DiaChi, BHYT, DienThoai FROM LeTan WHERE MaBN = '" + cbbMaBN.Text + "'";

*/
            String query = "SELECT MaBN FROM ThongTinKhamBenh UNION SELECT MaBN FROM BenhNhan";


            cmd = new SqlCommand("Select Count(*) From BenhAn Where MaBN = @Mabn", Con);
            String Mabn = String.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedValue.ToString() : cbbMaBN.Text;
            cmd.Parameters.AddWithValue("@Mabn", Mabn);
            int Count = Convert.ToInt32(cmd.ExecuteScalar());

            if (Count > 0)
            {
                MessageBox.Show("Mã bệnh nhân đã tồn tại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                cmd = new SqlCommand("Select Count(*) From BenhAn Where MaBA = @MaBA", Con);
                cmd.Parameters.AddWithValue("@MaBA", txtMaBA.Text);
                int Count1 = Convert.ToInt32(cmd.ExecuteScalar());

                if (Count1 > 0)
                {
                    MessageBox.Show("Mã bệnh án đã tồn tại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    cmd = new SqlCommand(query1,Con);
                    cmd.Parameters.AddWithValue("@MaBA", txtMaBA.Text.Trim());
                    cmd.ExecuteNonQuery();
                   // cmd = new SqlCommand(query2, Con);
                   // cmd.ExecuteNonQuery();
                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
