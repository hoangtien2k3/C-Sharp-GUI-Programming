using HospitalManagementSysteam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhNhanNoiTru
{
    public partial class FormDieuTri : Form
    {
        SqlConnection Con =  Connection.getConnection();
        public FormDieuTri()
        {
            InitializeComponent();
        }
        void Connect()
        {
            if(Con.State == ConnectionState.Closed)
                Con.Open();
            else 
                Con.Close();
        }
        private void FormDieuTri_Load(object sender, EventArgs e)
        {
            loadGRVDieuTri();
            Load_cbbMaBN();
            txtSoNgayNhapVien.Enabled = false;
            txtChuanDoanHoSo.Enabled = false;
        }

        private void Load_cbbMaBN()
        {
            Connect();
            String query = "Select MaBN From ThongTinKhamBenh Where SoNgayNhapVien > 0";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            cmd.Dispose();
            Con.Close();

            DataRow r = tb.NewRow();
            r["MaBN"] = "---Nhâp_Mã_BN---";
            tb.Rows.InsertAt(r, 0);

            cbbMaBN.DataSource = tb;
            cbbMaBN.DisplayMember = "MaBN";
            cbbMaBN.ValueMember = "MaBN";

        }

        private void cbbMaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connect();
            SqlCommand cmd1 = new SqlCommand("select SoNgayNhapVien from ThongTinKhamBenh where MaBN = '" + cbbMaBN.Text + "'", Con);
            string songay = (string)cmd1.ExecuteScalar(); // Truy vấn dữ liệu và lấy giá trị trả về 
            txtSoNgayNhapVien.Text = songay; // Gán giá trị tên vào thuộc tính Text của textbox để hiển thị

            cmd1 = new SqlCommand("select ChuanDoanSoBo from ThongTinKhamBenh where MaBN = '" + cbbMaBN.Text + "'", Con);
            string ChuanDoanSoBo = (string)cmd1.ExecuteScalar(); // Truy vấn dữ liệu và lấy giá trị trả về 
            txtChuanDoanHoSo.Text = ChuanDoanSoBo; // Gán giá trị tên vào thuộc tính Text của textbox để hiển thị

            Connect();

            TongTienThuoc();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtChuanDoanHoSo_TextChanged(object sender, EventArgs e)
        {
            if (txtChuanDoanHoSo.Text == "Cảm lạnh")
            {
                cbbThuoc.Items.Clear();
                cbbThuoc.Items.Add("Metoprolol");
                cbbThuoc.Items.Add("Atenolol");
            }
            if (txtChuanDoanHoSo.Text == "Viêm họng")
            {
                cbbThuoc.Items.Clear();
                cbbThuoc.Items.Add("Nebivolol");
                cbbThuoc.Items.Add("Amlodipine");
                cbbThuoc.Items.Add("Nebivolol");
                cbbThuoc.Items.Add("Divalproex");
            }
            if (txtChuanDoanHoSo.Text == "Đau bụng")
            {
                cbbThuoc.Items.Clear();
                cbbThuoc.Items.Add("Olanzapine");
                cbbThuoc.Items.Add("Fluconazole");
                cbbThuoc.Items.Add("Zolpidem");
                cbbThuoc.Items.Add("Eszopiclone");
            }
            if (txtChuanDoanHoSo.Text == "Viêm xoang")
            {
                cbbThuoc.Items.Clear();
                cbbThuoc.Items.Add("Ticagrelor");
                cbbThuoc.Items.Add("Vitamin");
                cbbThuoc.Items.Add("Tiotropium");
            }
            if (txtChuanDoanHoSo.Text == "Viêm phổi")
            {
                cbbThuoc.Items.Clear();
                cbbThuoc.Items.Add("Meclizine");
                cbbThuoc.Items.Add("Tolterodine");
            }
            if (txtChuanDoanHoSo.Text == "Đau đầu")
            {
                cbbThuoc.Items.Clear();
                cbbThuoc.Items.Add("Trazodone");
                cbbThuoc.Items.Add("Duloxetine");
            }
            if (txtChuanDoanHoSo.Text == "Đau dạ dày")
            {
                cbbThuoc.Items.Clear();
                cbbThuoc.Items.Add("Losartan");
                cbbThuoc.Items.Add("Ramipril");
            }
            if (txtChuanDoanHoSo.Text == "Viêm khớp")
            {
                cbbThuoc.Items.Clear();
                cbbThuoc.Items.Add("Estrogen");
                cbbThuoc.Items.Add("Niacin");
            }
        }

        private void txtSoNgayNhapVien_ValueChanged(object sender, EventArgs e)
        {
            if(txtSoNgayNhapVien.Value > 0)
            {
                cbbNgay.Items.Clear();
                for(int i = 1; i <= txtSoNgayNhapVien.Value; i++)
                {
                    cbbNgay.Items.Add(i.ToString());
                }
            }
        }

        private void loadGRVDieuTri()
        {
            Con.Open();

            string query = "select * from DieuTri order by MaBN asc";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dataGRVDieuTri.DataSource = tb;
            cmd.Dispose();
            Con.Close();
        }


        private void _resert()
        {
            cbbNgay.Items.Clear();
            for (int i = 1; i <= txtSoNgayNhapVien.Value; i++)
            {
                cbbNgay.Items.Add(i.ToString());
            }
            cbbThuoc.Items.Add("Chon Thuoc");
            txtSoLuongThuoc.Text = string.Empty;
        }

        private void dataGRVDieuTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGRVDieuTri.CurrentRow;
                if (row.Cells["MaBN"].Value.ToString() == string.Empty)
                {
                    _resert();
                }

                cbbMaBN.Text = row.Cells["MaBN"].Value.ToString();
                txtSoNgayNhapVien.Text = row.Cells["SoNgayNhapVien"].Value.ToString();

                Con.Open();
                SqlCommand cmd = new SqlCommand("select ChuanDoanSoBo from ThongTinKhamBenh where MaBN = '" + cbbMaBN.Text + "'", Con);
                string ChuanDoanSoBo = (string)cmd.ExecuteScalar(); // Truy vấn dữ liệu và lấy giá trị trả về 
                txtChuanDoanHoSo.Text = ChuanDoanSoBo; // Gán giá trị tên vào thuộc tính Text của textbox để hiển thị
                Con.Close();

                cbbNgay.Text = row.Cells["Ngay"].Value.ToString();
                cbbThuoc.Text = row.Cells["Thuoc"].Value.ToString();
                txtSoLuongThuoc.Text = row.Cells["SoLuongThuoc"].Value.ToString();

                loadGRVDieuTri();
            }
        }


        private void btnXetThuoc_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = null;
            if (cbbMaBN.Text == "" || cbbNgay.Text == "" || cbbThuoc.Text == "" || txtSoLuongThuoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Con.Open();
                string queryGiaTien = "SELECT GiaTien FROM GiaThuoc WHERE Thuoc = '"+ cbbThuoc.Text.Trim() + "'";
                cmd = new SqlCommand(queryGiaTien, Con);

                // ExecuteScalar: tra ve gia tri cho cung ta 
                int giaTienThuoc = Convert.ToInt32(cmd.ExecuteScalar()) * Convert.ToInt32(txtSoLuongThuoc.Text);


                string query = "INSERT INTO DieuTri(MaBN, SoNgayNhapVien, Ngay, Thuoc, SoLuongThuoc, ThanhTien) " +
                    "VALUES('" + cbbMaBN.Text + "', '"+ txtSoNgayNhapVien.Text + "' , '"+ cbbNgay.Text + "', '"+ cbbThuoc.Text + "', '"+ txtSoLuongThuoc.Text + "', '"+ giaTienThuoc + "')";

                cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery(); // khong tra ve gia tri

                MessageBox.Show("Cấp Thuốc Thành Công");
                cmd.Dispose();
                Con.Close();

                loadGRVDieuTri();
                TongTienThuoc();
            }

        }


        private void TongTienThuoc()
        {
            using(SqlConnection Con = Connection.getConnection())
            {
                Con.Open();
                string query = "SELECT SUM(ThanhTien) FROM DieuTri WHERE MaBN = '" + cbbMaBN.Text + "' GROUP BY MaBN";
                SqlCommand cmd = new SqlCommand(query, Con);
                int tongGiaTien = Convert.ToInt32(cmd.ExecuteScalar());
                txtTongTienThuoc.Text = tongGiaTien.ToString();
                Con.Close();
            }
        }

    }
}
