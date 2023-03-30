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

namespace HospitalManagementSysteam
{
    public partial class FormTimKiem : Form
    {
        SqlConnection Con = Connection.getConnection();
        public FormTimKiem()
        {
            InitializeComponent();
        }



        private void btnTimKiemBenhNhan_Click(object sender, EventArgs e)
        {
            Con.Open();
            // dấu '%' là wildcard character (đại diện cho bất kỳ ký tự nào).
            string query = "SELECT * FROM BenhNhan WHERE MaBN LIKE '%' + @txtTimKiemBenhNhan + '%' OR TenBN LIKE '%' + @txtTimKiemBenhNhan + '%'";
            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@txtTimKiemBenhNhan", txtTimKiemBenhNhan.Text); // Thêm giá trị của TextBox vào Parameter
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ThongTinBenhNhanGV.DataSource = table;
            Con.Close();
        }

        private void txtTimKiemBenhNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemBacSi_Click(object sender, EventArgs e)
        {
            Con.Open();
            // dấu '%' là wildcard character (đại diện cho bất kỳ ký tự nào).
            string query = "SELECT * FROM BacSi WHERE MaBS LIKE '%' + @txtTimKiemBacSi + '%' OR TenBS LIKE '%' + @txtTimKiemBacSi + '%'";
            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@txtTimKiemBacSi", txtTimKiemBacSi.Text); // Thêm giá trị của TextBox vào Parameter
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ThongTinBacSiGV.DataSource = table;
            Con.Close();
        }

        private void btnLamSachBN_Click(object sender, EventArgs e)
        {
            txtTimKiemBenhNhan.Text = "";
            ThongTinBenhNhanGV.DataSource = null; // hoặc ThongTinBenhNhanGV.DataSource = new DataTable();
        }

        private void btnLamSachBS_Click(object sender, EventArgs e)
        {
            txtTimKiemBacSi.Text = "";
            ThongTinBacSiGV.DataSource= null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiemBacSi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormTimKiem_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
