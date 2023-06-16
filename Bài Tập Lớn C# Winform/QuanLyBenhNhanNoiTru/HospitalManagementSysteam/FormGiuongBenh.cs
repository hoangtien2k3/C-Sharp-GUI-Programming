using HospitalManagementSysteam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_excel = Microsoft.Office.Interop.Excel;

namespace QuanLyBenhNhanNoiTru
{
    public partial class FormGiuongBenh : Form
    {

        SqlConnection Con = Connection.getConnection();

        public FormGiuongBenh()
        {
            InitializeComponent();
        }

        private void FormGiuongBenh_Load(object sender, EventArgs e)
        {
            LoadcbbBN();
            txtChuyenKhoa.Enabled = false;
            txtMaBS.Enabled = false;
            LoadThongTinGiuongBenh();
        }


        private void LoadThongTinGiuongBenh()
        {
            Con.Open();
            string query = "SELECT * FROM GiuongBenh";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGRVBenhNhan.DataSource = dataTable;
            Con.Close();
        }


        void LoadcbbBN()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select MaBN from ThongTinKhamBenh where SoNgayNhapVien > 0 ", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                cbbMaBN.Items.Add(reader.GetString(0));

            }
            cmd.Dispose();
            reader.Close();
            Con.Close();
        }

        private void cbbMaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd1 = new SqlCommand("select ChuyenKhoa from ThongTinKhamBenh where MaBN = '" + cbbMaBN.Text + "'", Con);
            string khoa = (string)cmd1.ExecuteScalar(); // Truy vấn dữ liệu và lấy giá trị trả về 
            txtChuyenKhoa.Text = khoa; // Gán giá trị tên vào thuộc tính Text của textbox để hiển thị


            SqlCommand cmd2 = new SqlCommand("select MaBS from ThongTinKhamBenh where MaBN = '" + cbbMaBN.Text + "'", Con);
            string MaBS = (string)cmd2.ExecuteScalar(); // Truy vấn dữ liệu và lấy giá trị trả về 
            txtMaBS.Text = MaBS; // Gán giá trị tên vào thuộc tính Text của textbox để hiển thị

            cmd1.Dispose();
            cmd2.Dispose();
            Con.Close();
        }

        private void txtChuyenKhoa_TextChanged(object sender, EventArgs e)
        {
            if (txtChuyenKhoa.Text == "Khoa Nhi")
            {
                cbbSoPhong.Items.Clear();
                cbbSoPhong.Items.Add("201");
                cbbSoPhong.Items.Add("202");
                cbbSoPhong.Items.Add("203");
                cbbSoPhong.Items.Add("204");
            }
            if (txtChuyenKhoa.Text == "Khoa Nội")
            {
                cbbSoPhong.Items.Clear();
                cbbSoPhong.Items.Add("301");
                cbbSoPhong.Items.Add("302");
                cbbSoPhong.Items.Add("303");
                cbbSoPhong.Items.Add("304");
            }
            if (txtChuyenKhoa.Text == "Khoa Ngoại")
            {
                cbbSoPhong.Items.Clear();
                cbbSoPhong.Items.Add("401");
                cbbSoPhong.Items.Add("402");
                cbbSoPhong.Items.Add("403");
                cbbSoPhong.Items.Add("404");
            }
            if (txtChuyenKhoa.Text == "Khoa Tai Mũi Họng")
            {
                cbbSoPhong.Items.Clear();
                cbbSoPhong.Items.Add("501");
                cbbSoPhong.Items.Add("502");
                cbbSoPhong.Items.Add("503");
                cbbSoPhong.Items.Add("504");
            }
        }

        private void cbbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSoPhong.SelectedItem.ToString() == cbbSoPhong.Items[0].ToString())
            {
                txtLoaiPhong.Text = "Vip";
                cbbSoGiuong.Items.Clear();
                cbbSoGiuong.Items.Add("1");
            }
            else if (cbbSoPhong.SelectedItem.ToString() == null)
            {
                txtLoaiPhong.Text = null;
                cbbSoGiuong.Items.Clear();

            }
            else
            {
                txtLoaiPhong.Text = "Thuong";
                cbbSoGiuong.Items.Clear();
                cbbSoGiuong.Items.Add("1");
                cbbSoGiuong.Items.Add("2");
                cbbSoGiuong.Items.Add("3");
                cbbSoGiuong.Items.Add("4");
            }
        }


        private void cbbSoGiuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            Con.Open();
            cmd = new SqlCommand("Select Count(*) From GiuongBenh Where SoPhong = '" + cbbSoPhong.Text + "' and SoGiuong = '" + cbbSoGiuong.Text + "' ", Con);
            int Count = Convert.ToInt32(cmd.ExecuteScalar());
            if (Count > 0)
            {
                txtTrangThai.Text = "Không Còn Trống";
            }
            else
            {
                txtTrangThai.Text = "Còn Trống";
            }
            Con.Close();
        }


        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (cbbMaBN.Text == "" || cbbSoPhong.Text == "" || cbbSoGiuong.Text == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin !");

            }
            else
            {
                if (txtTrangThai.Text == "Không Còn Trống")
                {
                    MessageBox.Show("Giường hiện không còn trống !");
                }
                else
                {
                    Con.Open();
                    string query = "update GiuongBenh set ChuyenKhoa  = N'" + txtChuyenKhoa.Text + "', MaBS = '" + txtMaBS.Text + "', " +
                        "SoPhong = '" + cbbSoPhong.Text + "', LoaiPhong = '" + txtLoaiPhong.Text + "', SoGiuong = '" + cbbSoGiuong.Text + "' where MaBN = '" + cbbMaBN.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thông tin giường bệnh thành công");
                    cmd.Dispose();
                    Con.Close();
                    LoadThongTinGiuongBenh();
                }
            }
        }

        private void buttonXepGiuongBenh_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = null;

            if (cbbMaBN.Text == "" || cbbSoPhong.Text == "" || cbbSoGiuong.Text == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin !");

            }
            else if (txtTrangThai.Text == "Không Còn Trống")
            {
                MessageBox.Show("Giường này hiện không còn trống !");
            }
            else
            {
                cmd = new SqlCommand("Select Count(*) From GiuongBenh Where MaBN = '" + cbbMaBN.Text + "'", Con);
                int Count = Convert.ToInt32(cmd.ExecuteScalar());

                if (Count > 0)
                {
                    MessageBox.Show("Bệnh Nhân Đã Được Xếp Giường Bệnh", "Xác Nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "insert into GiuongBenh(MaBN, ChuyenKhoa, MaBS, SoPhong, LoaiPhong, SoGiuong) " +
                                                "values('" + cbbMaBN.Text + "', N'" + txtChuyenKhoa.Text + "', '" + txtMaBS.Text + "'" +
                                                ", '" + cbbSoPhong.Text + "', '" + txtLoaiPhong.Text + "' , '" + cbbSoGiuong.Text + "')";

                    cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            Con.Close();
            LoadThongTinGiuongBenh();
            buttonResert_Click(sender, e);
        }

        private void dataGRVBenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGRVBenhNhan.CurrentRow;

                cbbMaBN.Text = row.Cells["MaBN"].Value.ToString();
                txtChuyenKhoa.Text = row.Cells["ChuyenKhoa"].Value.ToString();
                cbbSoPhong.Text = row.Cells["SoPhong"].Value.ToString();
                txtLoaiPhong.Text = row.Cells["LoaiPhong"].Value.ToString();
                cbbSoGiuong.Text = row.Cells["SoGiuong"].Value.ToString();
                txtMaBS.Text = row.Cells["MaBS"].Value.ToString();
            }
        }

        private void buttonResert_Click(object sender, EventArgs e)
        {
            cbbMaBN.Items.Clear();
            LoadcbbBN();
            txtChuyenKhoa.Text = string.Empty;
            txtMaBS.Text = string.Empty;
            cbbSoPhong.Items.Clear();
            txtLoaiPhong.Text = string.Empty;
            cbbSoGiuong.Items.Clear();
            txtTrangThai.Text = string.Empty;

            LoadThongTinGiuongBenh();
        }

        public void ExportExcel(DataTable tb, string sheetname)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH GIƯỜNG BỆNH";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "16";
            head.HorizontalAlignment = e_excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ BỆNH NHÂN";
            cl1.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "CHUYÊN KHOA";
            cl2.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "MÃ BÁC SĨ";
            cl3.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "SO PHÒNG";
            cl4.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "LOẠI PHÒNG";
            cl5.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "SỐ GIƯỜNG";
            cl6.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");

            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 20;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                DataColumn col1 = new DataColumn("MaBN");
                DataColumn col2 = new DataColumn("ChuyenKhoa");
                DataColumn col3 = new DataColumn("MaBS");
                DataColumn col4 = new DataColumn("SoPhong");
                DataColumn col5 = new DataColumn("LoaiPhong");
                DataColumn col6 = new DataColumn("SoGiuong");


                DataTable dt = new DataTable();
                dt.Columns.Add(col1);
                dt.Columns.Add(col2);
                dt.Columns.Add(col3);
                dt.Columns.Add(col4);
                dt.Columns.Add(col5);
                dt.Columns.Add(col6);


                foreach (DataGridViewRow dataGRVrow in dataGRVBenhNhan.Rows)
                {
                    DataRow dtrow = dt.NewRow();
                    dtrow[0] = dataGRVrow.Cells[0].Value;
                    dtrow[1] = dataGRVrow.Cells[1].Value;
                    dtrow[2] = dataGRVrow.Cells[2].Value;
                    dtrow[3] = dataGRVrow.Cells[3].Value;
                    dtrow[4] = dataGRVrow.Cells[4].Value;
                    dtrow[5] = dataGRVrow.Cells[5].Value;


                    dt.Rows.Add(dtrow);
                }
                ExportExcel(dt, "Danh sách giường bệnh");
            }
        }

        private void btnTimKiemGiuongBenh_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = null;

            if (txtTimGiuong.Text == "")
            {
                MessageBox.Show("Hãy nhập vào mã bệnh nhân !");
            }
            else
            {
                cmd = new SqlCommand("Select Count(*) From GiuongBenh Where MaBN = '" + txtTimGiuong.Text + "'", Con);
                int Count = Convert.ToInt32(cmd.ExecuteScalar());

                if (Count > 0)
                {
                    // MessageBox.Show("Bệnh Nhân Đã Được Xếp Giường Bệnh", "Xác Nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmd = new SqlCommand("Select * From GiuongBenh Where MaBN = '" + txtTimGiuong.Text + "'", Con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    dataGRVBenhNhan.DataSource = tb;
                    cmd.Dispose();
                }
            }
            Con.Close();
        }
    }
}
