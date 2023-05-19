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

namespace QuanLyTaiKhoanNganHang
{
    public partial class FormThongTinGiaoDich : Form
    {
        SqlConnection Con = Connection.getInstance().getConnection();

        public FormThongTinGiaoDich()
        {
            InitializeComponent();
        }


        public void ConnecThongTinGiaoDichGuiTien()
        {
            Con.Open();
            string query = "SELECT * FROM GiaoDichGuiTien";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            GiaoDichGuiTienGV.DataSource = dataTable;
            Con.Close();
        }


        public void ConnecThongTinGiaoDichChuyenTien()
        {
            Con.Open();
            string query = "SELECT * FROM GiaoDichChuyenTien";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            GiaoDichChuyenTienGV.DataSource = dataTable;
            Con.Close();
        }

        private void FormThongTinGiaoDich_Load(object sender, EventArgs e)
        {
            ConnecThongTinGiaoDichGuiTien();
            ConnecThongTinGiaoDichChuyenTien();
        }
    }
}
