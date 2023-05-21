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

namespace QuanLyTaiKhoanNganHang
{
    public partial class FormGuiTien : Form
    {
        SqlConnection Con = Connection.getInstance().getConnection();

        public FormGuiTien()
        {
            InitializeComponent();
        }

        private void FormGuiTien_Load(object sender, EventArgs e)
        {
            ConnecSoDuTaiKhoan();
            LoadDataToComboBoxThongTinTaiKhoan();
        }


        // load dữ liệu lên combobox SoTaiKhoan
        private void LoadDataToComboBoxThongTinTaiKhoan()
        {
            string query = "SELECT SoTaiKhoan, TenTaiKhoan FROM TaiKhoan";
            using (SqlConnection connection = Connection.getInstance().getConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbbSoTaiKhoan.Items.Add(reader.GetString(0));
                    cbbTenTaiKhoan.Items.Add(reader.GetString(1));
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbSoTaiKhoan.Text.Trim() == "" && cbbTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền thông tin tài khoản cần tìm kiếm.");
            }
            else
            {
                Con.Open();
                string query = "SELECT TenTaiKhoan, SoTaiKhoan, DiaChiEmail, CCCD, ImageData FROM TaiKhoan WHERE (TenTaiKhoan = @TenTaiKhoan OR @TenTaiKhoan = '') AND (SoTaiKhoan = @SoTaiKhoan OR @SoTaiKhoan = '')";
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@TenTaiKhoan", cbbTenTaiKhoan.Text.Trim());
                command.Parameters.AddWithValue("@SoTaiKhoan", cbbSoTaiKhoan.Text.Trim());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtTenTaiKhoan.Text = reader["TenTaiKhoan"].ToString();
                    txtSoTaiKhoan.Text = reader["SoTaiKhoan"].ToString();
                    txtDiaChiEmail.Text = reader["DiaChiEmail"].ToString();
                    txtCCCD.Text = reader["CCCD"].ToString();

                    // Lấy thông tin ảnh từ cơ sở dữ liệu
                    byte[] imageBytes = (byte[])reader["ImageData"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);
                        ptbTaiAnh.Image = image; // Hiển thị ảnh lên PictureBox
                    }
                }

                query = "SELECT SoTienHienTai FROM SoDuTaiKhoan WHERE (TenTaiKhoan = '"+ cbbTenTaiKhoan.Text + "' OR '"+ cbbTenTaiKhoan.Text + "' = '') AND (SoTaiKhoan = '"+ cbbSoTaiKhoan.Text + "' OR '"+ cbbSoTaiKhoan.Text +"' = '')";
                using (SqlConnection connection = Connection.getInstance().getConnection())
                {
                    command = new SqlCommand(query, connection);
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtSoTienHienTai.Text = reader["SoTienHienTai"].ToString();
                    }
                    else
                    {
                        txtSoTienHienTai.Text = "000000";
                    }
                    reader.Close();
                    command.Dispose();
                    connection.Close();
                }

                reader.Close();
                Con.Close();
                
            }
        }

        public void ConnecSoDuTaiKhoan()
        {
            Con.Open();
            string query = "SELECT * FROM SoDuTaiKhoan";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            SoDuTaiKhoanGV.DataSource = dataTable;
            Con.Close();
        }


        private void ThongTinGiaoDichGuiTien()
        {
            string soTaiKhoan = txtSoTaiKhoan.Text;
            decimal soTien = decimal.Parse(txtSoTienMuonGui.Text);

            string insertQuery = "INSERT INTO GiaoDichGuiTien (SoTaiKhoan, SoTien, NgayGiaoDich, GioGiaoDich) " +
                "VALUES (@SoTaiKhoan, @SoTien, @NgayGiaoDich, @GioGiaoDich)";

            using (SqlConnection connection = Connection.getInstance().getConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@SoTaiKhoan", soTaiKhoan);
                    command.Parameters.AddWithValue("@SoTien", soTien);
                    command.Parameters.AddWithValue("@NgayGiaoDich", DateTime.Now.ToString("dd/MM/yyyy"));
                    command.Parameters.AddWithValue("@GioGiaoDich", DateTime.Now.ToString("HH:mm:ss"));

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            txtSoTienMuonGui.Text = string.Empty;
        }


        private void btnGuiTien_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "" || txtSoTaiKhoan.Text == "" || txtCCCD.Text == "" || txtSoTaiKhoan.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
            } else
            {
                Con.Open();

                DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Gửi Tiền Vào Tài Khoản Không ?",
                    "Xác Nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                
                if (dialogResult == DialogResult.Yes) {

                    string query = "SELECT COUNT(*) FROM SoDuTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0) // Kiểm tra xem mã bệnh nhân đã tồn tại hay chưa
                    {
                        query = "UPDATE SoDuTaiKhoan SET SoTienHienTai = @SoTienHienTai  WHERE TenTaiKhoan = @TenTaiKhoan";
                        command = new SqlCommand(query, Con);

                        command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                        string SoTienMuonGui = string.IsNullOrEmpty(txtSoTienMuonGui.Text) ? txtSoTienMuonGui.SelectedItem.ToString() : txtSoTienMuonGui.Text;
                        string kp = (int.Parse(txtSoTienHienTai.Text) + int.Parse(SoTienMuonGui)).ToString();
                        command.Parameters.AddWithValue("@SoTienHienTai", kp);

                        command.ExecuteNonQuery(); // thực hiện câu truy vấn

                        string guitien = "Nạp Tiền Vào Tài Khoản (" + txtTenTaiKhoan.Text + ") Thành Công.\n" +
                            "\n\n\t- Hóa Đơn: " +
                            "\n\n\t+ Tài Khoản: " + txtSoTaiKhoan.Text +
                            "\n\n\t+ Số Tiền: " + SoTienMuonGui +
                            "\n\n\t+ Email: " + txtDiaChiEmail.Text +
                            "\n\n\t+ Ngày Gửi: " + DateTime.Now.ToString("dd/MM/yyyy") +
                            "\n\n\t+ Giờ Gửi: " + DateTime.Now.ToString("HH:mm:ss") +
                            "\n\n";
                        MessageBox.Show(guitien);

                        txtSoTienHienTai.Text = kp;
                    }
                    else
                    {
                        query = "INSERT INTO SoDuTaiKhoan (TenTaiKhoan, SoTaiKhoan, CCCD, SoTienHienTai)"
                            + "VALUES (@TenTaiKhoan, @SoTaiKhoan, @CCCD, @SoTienHienTai)";

                        command = new SqlCommand(query, Con);

                        command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                        command.Parameters.AddWithValue("@SoTaiKhoan", txtSoTaiKhoan.Text);
                        command.Parameters.AddWithValue("@CCCD", txtCCCD.Text);

                        string SoTienMuonGui = string.IsNullOrEmpty(txtSoTienMuonGui.Text) ? txtSoTienMuonGui.SelectedItem.ToString() : txtSoTienMuonGui.Text;
                        command.Parameters.AddWithValue("@SoTienHienTai", SoTienMuonGui);

                        command.ExecuteNonQuery();


                        string guitien = "Nạp Tiền Vào Tài Khoản (" + txtTenTaiKhoan.Text + ") Thành Công.\n" +
                            "\n\n\t- Hóa Đơn: " +
                            "\n\n\t+ Tài Khoản: " + txtSoTaiKhoan.Text +
                            "\n\n\t+ Số Tiền: " + SoTienMuonGui +
                            "\n\n\t+ Email: " + txtDiaChiEmail.Text +
                            "\n\n\t+ Ngày Gửi: " + DateTime.Now.ToString("dd/MM/yyyy") +
                            "\n\n\t+ Giờ Gửi: " + DateTime.Now.ToString("HH:mm:ss") +
                            "\n\n";
                        MessageBox.Show(guitien);

                        txtSoTienHienTai.Text = SoTienMuonGui;
                    }
                }


                Con.Close();
                ConnecSoDuTaiKhoan();
                ThongTinGiaoDichGuiTien();
            }

        }

        private void txtSoTienHienTai_TextChanged(object sender, EventArgs e)
        {
            txtSoTienChuSo1.Text = ConvertNumber.ConvertNumberToVietnamese(txtSoTienHienTai.Text);
        }

        private void txtSoTienMuonGui_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMayTinh_Click(object sender, EventArgs e)
        {
            FormMayTinh formMayTinh = new FormMayTinh();
            formMayTinh.Show();
        }

        private void btnMayTinh_Click_1(object sender, EventArgs e)
        {
            FormMayTinh formMayTinh = new FormMayTinh();
            formMayTinh.Show();
        }



        public void ExportExcel(DataTable dataTable, string sheetName, string title)
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
            oSheet.Name = sheetName;

            // tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A2", "D2");
            head.MergeCells = true;
            head.Value2 = title; 
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "14";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Tên Tài Khoản";
            cl1.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Số Tài Khoản";
            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Căn Cước Công Dân";
            cl3.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Số Tiền Hiện Tại";
            cl4.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "D3");
            rowHead.Font.Bold = true;

            // NGày tháng xuất file excel
            string lastCell = $"{(char)(65 + dataTable.Columns.Count - 1)}{(dataTable.Rows.Count + 6)}"; // Lấy tên ô cuối cùng
            Microsoft.Office.Interop.Excel.Range lastCellRange = oSheet.get_Range(lastCell); // Lấy Range của ô cuối cùng
            string date = DateTime.Now.ToString("dd/MM/yyyy"); // Định dạng ngày tháng
            lastCellRange.Value2 = $"Ngày in: {date}"; // Ghi ngày tháng vào ô cuối cùng

            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6; // vàng: 6 , màu xám: 15
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable, vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 2;
            int columnEnd = dataTable.Columns.Count;

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

            // Căn giữa cả bảng
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void btnInThongTin_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("TenTaiKhoan");
            DataColumn col2 = new DataColumn("SoTaiKhoan");
            DataColumn col3 = new DataColumn("CCCD");
            DataColumn col4 = new DataColumn("SoTienHienTai");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);

            foreach (DataGridViewRow dtgvRow in SoDuTaiKhoanGV.Rows)
            {
                DataRow dtRow = dataTable.NewRow();

                dtRow[0] = dtgvRow.Cells[0].Value;
                dtRow[1] = dtgvRow.Cells[1].Value;
                dtRow[2] = dtgvRow.Cells[2].Value;
                dtRow[3] = dtgvRow.Cells[3].Value;

                dataTable.Rows.Add(dtRow);
            }

            ExportExcel(dataTable, "Danh Sách Tài Khoản", "THỐNG KÊ DANH SÁCH CÁC TÀI KHOẢN");
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (cbbSoTaiKhoan.Text.Trim() == "" && cbbTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền thông tin tài khoản cần tìm kiếm.");
            }
            else
            {
                Con.Open();
                string query = "SELECT TenTaiKhoan, SoTaiKhoan, DiaChiEmail, CCCD, ImageData FROM TaiKhoan WHERE (TenTaiKhoan = @TenTaiKhoan OR @TenTaiKhoan = '') AND (SoTaiKhoan = @SoTaiKhoan OR @SoTaiKhoan = '')";
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@TenTaiKhoan", cbbTenTaiKhoan.Text.Trim());
                command.Parameters.AddWithValue("@SoTaiKhoan", cbbSoTaiKhoan.Text.Trim());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtTenTaiKhoan.Text = reader["TenTaiKhoan"].ToString();
                    txtSoTaiKhoan.Text = reader["SoTaiKhoan"].ToString();
                    txtDiaChiEmail.Text = reader["DiaChiEmail"].ToString();
                    txtCCCD.Text = reader["CCCD"].ToString();

                    // Lấy thông tin ảnh từ cơ sở dữ liệu
                    byte[] imageBytes = (byte[])reader["ImageData"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);
                        ptbTaiAnh.Image = image; // Hiển thị ảnh lên PictureBox
                    }
                }

                query = "SELECT SoTienHienTai FROM SoDuTaiKhoan WHERE (TenTaiKhoan = '" + cbbTenTaiKhoan.Text + "' OR '" + cbbTenTaiKhoan.Text + "' = '') AND (SoTaiKhoan = '" + cbbSoTaiKhoan.Text + "' OR '" + cbbSoTaiKhoan.Text + "' = '')";
                using (SqlConnection connection = Connection.getInstance().getConnection())
                {
                    command = new SqlCommand(query, connection);
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtSoTienHienTai.Text = reader["SoTienHienTai"].ToString();
                    }
                    else
                    {
                        txtSoTienHienTai.Text = "000000";
                    }
                    reader.Close();
                    command.Dispose();
                    connection.Close();
                }

                reader.Close();
                Con.Close();

            }
        }
    }
}
