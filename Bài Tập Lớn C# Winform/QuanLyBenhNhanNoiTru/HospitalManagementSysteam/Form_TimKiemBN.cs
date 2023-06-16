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
    public partial class Form_TimKiemBN : Form
    {
        SqlConnection Con = Connection.getConnection();

        void Connect()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
        }

        public Form_TimKiemBN()
        {
            InitializeComponent();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            Connect();
            if (cbbTK.Text == "" || cbbTK.Text == "___Nhập thuộc tính hoặc chọn Mã Bệnh Nhân___")
            {
                Load_Grv_TimBN();
            }
            else
            {
                String query = "Select * From BenhNhan Where MaBN LIKE '%' +@MaBN+ '%' OR TenBN LIKE '%' +@TenBN+ '%' OR DiaChi LIKE '%' +@DiaChi+ '%' OR NgaySinh LIKE '%' +@NgaySinh+ '%' OR GioiTinh LIKE '%' +@GioiTinh+ '%' OR CCCD LIKE '%' +@CCCD+ '%' OR BHYT LIKE '%' +@BHYT+ '%'";
                SqlCommand cmd = new SqlCommand(query, Con);

                String MaBN = String.IsNullOrEmpty(cbbTK.Text) ? cbbTK.SelectedValue.ToString() : cbbTK.Text;
                cmd.Parameters.AddWithValue("@MaBN", MaBN);
                cmd.Parameters.AddWithValue("@TenBN", MaBN);
                cmd.Parameters.AddWithValue("@DiaChi", MaBN);
                cmd.Parameters.AddWithValue("@GioiTinh", MaBN);
                cmd.Parameters.AddWithValue("@loaiBenh", MaBN);
                cmd.Parameters.AddWithValue("@NgaySinh", MaBN);
                cmd.Parameters.AddWithValue("@CCCD", MaBN);
                cmd.Parameters.AddWithValue("@BHYT", MaBN);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                cmd.Dispose();
                Con.Close();

                Grv_TimBN.DataSource = tb;
                Grv_TimBN.Refresh();
            }
        }

        private void Form_TimKiemBN_Load(object sender, EventArgs e)
        {
            Load_Grv_TimBN();
            Load_CbbMaBN();
        }

        private void Load_Grv_TimBN()
        {
            Connect();
            String query = "Select * From BenhNhan";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            Con.Close();

            Grv_TimBN.DataSource = tb;
            Grv_TimBN.Refresh();
        }

        private void Load_CbbMaBN()
        {
            Connect();
            String query = "Select MaBN From BenhNhan";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            Con.Close();

            DataRow r = tb.NewRow();
            r["MaBN"] = "___Nhập thuộc tính hoặc chọn Mã Bệnh Nhân___";
            tb.Rows.InsertAt(r, 0);
            cbbTK.DataSource = tb;
            cbbTK.DisplayMember = "MaBN";
            cbbTK.ValueMember = "MaBN";
        }
    }
}
