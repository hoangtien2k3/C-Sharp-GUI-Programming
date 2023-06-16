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
    public partial class Form_TimKiemBS : Form
    {
        SqlConnection Con = Connection.getConnection();

        void Connect()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
        }

        private void Load_Grv_TimBN()
        {
            Connect();
            String query = "Select * From BacSi";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            Con.Close();

            Grv_TimBS.DataSource = tb;
            Grv_TimBS.Refresh();
        }
        private void Load_CbbMaBS()
        {
            Connect();
            String query = "Select MaBS From BacSi";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            Con.Close();

            DataRow r = tb.NewRow();
            r["MaBS"] = "___Nhập thuộc tính hoặc chọn Mã Bác Sĩ___";
            tb.Rows.InsertAt(r, 0);
            cbbTK.DataSource = tb;
            cbbTK.DisplayMember = "MaBS";
            cbbTK.ValueMember = "MaBS";
        }

        public Form_TimKiemBS()
        {
            InitializeComponent();
        }

        private void Form_TimKiemBS_Load(object sender, EventArgs e)
        {
            Load_Grv_TimBN();
            Load_CbbMaBS();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            Connect();
            if (cbbTK.Text == "" || cbbTK.Text == "___Nhập thuộc tính hoặc chọn Mã Bác Sĩ___")
            {
                Load_Grv_TimBN();
            }
            else
            {
                String query = "Select * From BacSi Where MaBS LIKE '%' +@MaBS+ '%' OR TenBS LIKE '%' +@TenBS+ '%' OR ChuyenKhoa LIKE '%' +@ChuyenKhoa+ '%' OR KinhNghiem LIKE '%' +@KinhNghiem+ '%'";
                SqlCommand cmd = new SqlCommand(query, Con);

                string stringTimKiem = string.IsNullOrEmpty(cbbTK.Text) ? cbbTK.SelectedItem.ToString() : cbbTK.Text;
                cmd.Parameters.AddWithValue("@MaBS", stringTimKiem);
                cmd.Parameters.AddWithValue("@TenBS", stringTimKiem);
                cmd.Parameters.AddWithValue("@ChuyenKhoa", stringTimKiem);
                cmd.Parameters.AddWithValue("@KinhNghiem", stringTimKiem);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                cmd.Dispose();
                Con.Close();

                Grv_TimBS.DataSource = tb;
                Grv_TimBS.Refresh();
            }
        }
    }
}
