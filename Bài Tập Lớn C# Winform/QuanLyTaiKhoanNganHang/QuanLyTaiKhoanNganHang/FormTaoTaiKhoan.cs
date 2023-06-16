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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyTaiKhoanNganHang
{
    public partial class FormTaoTaiKhoan : Form
    {

        SqlConnection Con = Connection.getInstance().getConnection();

        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }


        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            ConnecTaiKhoan();
        }


        private string GenerateAccountNumber(string customerName)
        {
            long accountNumber = GenerateRandomNumber(); // Tạo số tài khoản ngân hàng ngẫu nhiên
            string accountNumberString = accountNumber.ToString("D14"); // Tạo chuỗi số tài khoản ngân hàng
            string result = $"{accountNumberString}"; // Kết hợp tên người dùng và số tài khoản ngân hàng
            return result; // Trả về chuỗi kết quả
        }

        // Hàm tạo số ngẫu nhiên có 14 chữ số
        private long GenerateRandomNumber()
        {
            var random = new Random();
            long number = 0;
            for (int i = 0; i < 14; i++)
            {
                number *= 10;
                number += random.Next(0, 10);
            }
            return number;
        }

        private void txtTenNguoiDung_TextChanged(object sender, EventArgs e)
        {
            string customerName = txtTenTaiKhoan.Text;
            string accountNumber = GenerateAccountNumber(customerName);
            txtSoTaiKhoan.Text = accountNumber;
        }

        private void txtSoTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        public void ConnecTaiKhoan()
        {
            Con.Open();
            string query = "SELECT TenTaiKhoan, SoTaiKhoan, LoaiTaiKhoan, DiaChiEmail, GioiTinh, " +
                "CCCD, SoDienThoai, NgaySinh, QuocTich, NgheNghiep, ImageData FROM TaiKhoan";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DanhSachTaiKhoanGV.DataSource = dataTable;
            Con.Close();
        }


        // dùng để convert đường dẫn ảnh sang mảng byte[] để lưu trữ vào DB
        private byte[] convertImage(String txtImageData)
        {
            try
            {
                FileStream fileStream = new FileStream(txtImageData, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[fileStream.Length];
                fileStream.Read(data, 0, System.Convert.ToInt32(fileStream.Length));
                fileStream.Close();
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xảy ra khi đọc file: " + ex.Message); // Xử lý khi có lỗi xảy ra
                return null; // hoặc giá trị khác tùy theo logic của bạn
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {

            if (txtTenTaiKhoan.Text == "" || txtSoTaiKhoan.Text == "" || txtMatKhau.Text == "" || cbbLoaiTaiKhoan.Text == "" || txtDiaChiEmail.Text == "" || txtCCCD.Text == "" || txtSoDienThoai.Text == "" || txtNgaySinh.Text == "" || cbbQuocTich.Text == "" || cbbNgheNghiep.Text == "" || ptbTaiAnh.Image == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            else
            {
                Con.Open(); // Mở kết nối với cơ sở dữ liệu

                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                SqlCommand command = new SqlCommand(query, Con);

                command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0) // Kiểm tra xem mã bệnh nhân đã tồn tại hay chưa
                {
                    MessageBox.Show("Tài khoản đã tồn tại. Vui lòng tạo tài khoản khác.",
                        "Xác Nhận",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        query = "INSERT INTO TaiKhoan (TenTaiKhoan, SoTaiKhoan, MatKhau, LoaiTaiKhoan, DiaChiEmail, GioiTinh, CCCD, SoDienThoai, NgaySinh, QuocTich, NgheNghiep, ImageData)"
                        + "VALUES (@TenTaiKhoan, @SoTaiKhoan, @MatKhau, @LoaiTaiKhoan, @DiaChiEmail, @GioiTinh, @CCCD, @SoDienThoai, @NgaySinh, @QuocTich, @NgheNghiep, @ImageData)";

                        command = new SqlCommand(query, Con);

                        command.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                        command.Parameters.AddWithValue("@SoTaiKhoan", txtSoTaiKhoan.Text);
                        command.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);

                        string LoaiTaiKhoan = string.IsNullOrEmpty(cbbLoaiTaiKhoan.Text) ? cbbLoaiTaiKhoan.SelectedItem.ToString() : cbbLoaiTaiKhoan.Text;
                        command.Parameters.AddWithValue("@LoaiTaiKhoan", LoaiTaiKhoan);

                        command.Parameters.AddWithValue("@DiaChiEmail", txtDiaChiEmail.Text);

                        if (rdbNam.Checked)
                        {
                            command.Parameters.AddWithValue("@GioiTinh", "Nam");
                        }
                        else if (rdbNu.Checked)
                        {
                            command.Parameters.AddWithValue("@GioiTinh", "Nữ");
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@GioiTinh", "Khác");
                        }

                        command.Parameters.AddWithValue("@CCCD", txtCCCD.Text);

                        command.Parameters.AddWithValue("@SoDienThoai", (txtMVDT.Text != "") ? (txtMVDT.Text + txtSoDienThoai.Text) : txtSoDienThoai.Text);

                        DateTime ngaySinh = txtNgaySinh.Value;
                        string strNgaySinh = ngaySinh.ToString("yyyy-MM-dd"); // Chuyển đổi sang chuỗi theo định dạng yyyy-MM-dd
                        command.Parameters.AddWithValue("@NgaySinh", strNgaySinh);

                        string QuocTich = string.IsNullOrEmpty(cbbQuocTich.Text) ? cbbQuocTich.SelectedItem.ToString() : cbbQuocTich.Text;
                        command.Parameters.AddWithValue("@QuocTich", QuocTich);

                        string NgheNghiep = string.IsNullOrEmpty(cbbNgheNghiep.Text) ? cbbNgheNghiep.SelectedItem.ToString() : cbbNgheNghiep.Text;
                        command.Parameters.AddWithValue("@NgheNghiep", NgheNghiep);

                        command.Parameters.AddWithValue("@ImageData", convertImage(txtImageData.Text));

                        command.ExecuteNonQuery();

                        MessageBox.Show("Tạo Tài Khoản (" + txtTenTaiKhoan.Text + ") Thành Công.");
                    } catch 
                    {
                        MessageBox.Show("Tạo Tài Khoản Thất Bại. Bạn Chưa Cập Nhật Ảnh." , "Error: Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        command.Dispose();
                        Con.Close();
                        return;
                    } 
                }

                Con.Close();
                command.Dispose();
                ConnecTaiKhoan(); // show dữ liệu ra datagridview
                btnLamMoi_Click(sender, e);
            }

            // LockControl(); // khóa button thêm bệnh nhân
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = "";
            txtSoTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cbbLoaiTaiKhoan.Text = "";
            txtDiaChiEmail.Text = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            rdbKhac.Checked = false;
            txtCCCD.Text = "";
            txtSoDienThoai.Text = "";
            txtNgaySinh.Text = "";
            cbbQuocTich.Text = "";
            cbbNgheNghiep.Text = "";
            ptbTaiAnh.Image = null;
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select an image file";
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.bmp;*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbTaiAnh.Image = new Bitmap(openFileDialog.FileName);
                txtImageData.Text = openFileDialog.FileName;
            }
        }

        private void DanhSachTaiKhoanGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // DataGridViewRow row = BenhNhanGV.Rows[e.RowIndex];
                DataGridViewRow row = DanhSachTaiKhoanGV.CurrentRow;

                txtTenTaiKhoan.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                txtSoTaiKhoan.Text = row.Cells["SoTaiKhoan"].Value.ToString();
                txtMatKhau.Text = "************";
                cbbLoaiTaiKhoan.Text = row.Cells["LoaiTaiKhoan"].Value.ToString();
                txtDiaChiEmail.Text = row.Cells["DiaChiEmail"].Value.ToString();

                if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else if (row.Cells["GioiTinh"].Value.ToString() == "Nữ")
                {
                    rdbNu.Checked = true;
                }
                else
                {
                    rdbKhac.Checked = true;
                }

                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value.ToString());
                cbbQuocTich.Text = row.Cells["QuocTich"].Value.ToString();
                cbbNgheNghiep.Text = row.Cells["NgheNghiep"].Value.ToString();

                // Lấy thông tin ảnh từ cơ sở dữ liệu
                byte[] imageBytes = (byte[])row.Cells["ImageData"].Value;

                // Chuyển đổi dữ liệu Binary về kiểu Image
                MemoryStream ms = new MemoryStream(imageBytes);
                Image image = Image.FromStream(ms);

                // Hiển thị ảnh lên PictureBox
                ptbTaiAnh.Image = image;

                // Chuyển đổi dữ liệu Binary sang chuỗi Base64 string
                // Hiển thị dữ liệu Base64 string lên TextBox
                txtImageData.Text = Convert.ToBase64String(imageBytes);
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = "";
            txtSoTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cbbLoaiTaiKhoan.Text = "";
            txtDiaChiEmail.Text = "";

            if (rdbNam.Checked)
            {
                rdbNam.Checked = false;
            } else if (rdbNu.Checked)
            {
                rdbNu.Checked = false;
            } else
            {
                rdbNu.Checked = false;
            }

            txtCCCD.Text = "";
            txtMVDT.Text = ""; 
            txtSoDienThoai.Text = "";
            txtNgaySinh.Value = DateTime.Now;
            cbbQuocTich.Text = "";
            cbbNgheNghiep.Text = "";
            ptbTaiAnh.Image = null;
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A2", "J2");
            head.MergeCells = true;
            head.Value2 = title; 
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Tên Tài Khoản";
            cl1.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Số Tài Khoản";
            cl2.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Loại Tài Khoản";
            cl3.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Địa Chỉ Email";
            cl4.ColumnWidth = 35.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Giới Tính";
            cl5.ColumnWidth = 10.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Số CCCD";
            cl6.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Số Điện Thoại";
            cl7.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Ngày Sinh";
            cl8.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Quốc Tịch";
            cl9.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Nghề Nghiệp";
            cl10.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "J3");
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

            // Căn giữa cột STT
            /*Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;*/

            // Căn giữa cả bảng
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void btnInThongTin_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn("TenTaiKhoan"));
            dataTable.Columns.Add(new DataColumn("SoTaiKhoan"));
            dataTable.Columns.Add(new DataColumn("LoaiTaiKhoan"));
            dataTable.Columns.Add(new DataColumn("DiaChiEmail"));
            dataTable.Columns.Add(new DataColumn("GioiTinh"));
            dataTable.Columns.Add(new DataColumn("CCCD"));
            dataTable.Columns.Add(new DataColumn("SoDienThoai"));
            dataTable.Columns.Add(new DataColumn("NgaySinh"));
            dataTable.Columns.Add(new DataColumn("QuocTich"));
            dataTable.Columns.Add(new DataColumn("NgheNghiep"));

            foreach (DataGridViewRow dtgvRow in DanhSachTaiKhoanGV.Rows)
            {
                DataRow dtRow = dataTable.NewRow();

                dtRow[0] = dtgvRow.Cells[0].Value;
                dtRow[1] = dtgvRow.Cells[1].Value;
                dtRow[2] = dtgvRow.Cells[2].Value;
                dtRow[3] = dtgvRow.Cells[3].Value;
                dtRow[4] = dtgvRow.Cells[4].Value;
                dtRow[5] = dtgvRow.Cells[5].Value;
                dtRow[6] = dtgvRow.Cells[6].Value;
                dtRow[7] = dtgvRow.Cells[7].Value;
                dtRow[8] = dtgvRow.Cells[8].Value;
                dtRow[9] = dtgvRow.Cells[9].Value;

                dataTable.Rows.Add(dtRow);
            }

            ExportExcel(dataTable, "DANH SÁCH TÀI KHOẢN", "DANH SÁCH CÁC TÀI KHOẢN ĐÃ ĐƯỢC TẠO");
        }

        private bool isPasswordVisible = false; // Biến để theo dõi trạng thái hiển thị mật khẩu
        private void HienMatKhau_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtMatKhau.UseSystemPasswordChar = false; // Hiện mật khẩu
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true; // Ẩn mật khẩu
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true; // Luôn ẩn mật khẩu khi gõ vào ô nhập liệu
        }
    }
}
