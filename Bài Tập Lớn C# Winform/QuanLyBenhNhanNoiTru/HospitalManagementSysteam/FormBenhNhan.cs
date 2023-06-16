using Microsoft.AnalysisServices;
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

namespace HospitalManagementSysteam
{
    public partial class FormBenhNhan : Form
    {
        SqlConnection Con = Connection.getConnection();

        public FormBenhNhan()
        {
            InitializeComponent();
        }

        private void FormBenhNhan_Load(object sender, EventArgs e)
        {
            LockControlInput(); // khoa nhap
            LockControl(); // khóa các button, khi mở form thì các button Them, Sua, Xoa sẽ bị khóa lại

            cbbMaBN.Focus();    // con trỏ chuột sẽ trỏ vào phần nhập MaBN đầu tiên.

            // cài đặt nút Tab trên bàn phím cho Form
            cbbMaBN.TabIndex = 0;
            cbbTen.TabIndex = 1;
            cbbDiaChi.TabIndex = 2;
            txtDienThoai.TabIndex = 4;

            txtNgaySinh.TabIndex = 9;

            ConnecBenhNhan(); // show dữ liệu ra datagridview
        }


        // khóa phần nhập dữ liệu đầu vào
        private void LockControlInput()
        {
            cbbMaBN.DropDownStyle = ComboBoxStyle.DropDown;
            cbbMaBN.Enabled = false;
            cbbTen.DropDownStyle = ComboBoxStyle.DropDown;
            cbbTen.Enabled = false;
            cbbDiaChi.DropDownStyle = ComboBoxStyle.DropDown;
            cbbDiaChi.Enabled = false;
            cbbGioiTinh.DropDownStyle = ComboBoxStyle.DropDown;
            cbbGioiTinh.Enabled = false;
           
            txtDienThoai.Enabled = false; // đọc thông tin 1 lần duy nhất
            txtBHYT.Enabled = false;
            txtCCCD.Enabled = false;
            txtNgaySinh.Enabled= false;

        }


        // mở khóa phần nhập dữ liệu đầu vào.
        private void UnLockControlInput()
        {
            cbbMaBN.DropDownStyle = ComboBoxStyle.DropDown;
            cbbMaBN.Enabled = true;
            cbbTen.DropDownStyle = ComboBoxStyle.DropDown;
            cbbTen.Enabled = true;
            cbbDiaChi.DropDownStyle = ComboBoxStyle.DropDown;
            cbbDiaChi.Enabled = true;
            cbbGioiTinh.DropDownStyle = ComboBoxStyle.DropDown;
            cbbGioiTinh.Enabled = true;

            txtDienThoai.Enabled = true; // đọc thông tin 1 lần duy nhất
            txtBHYT.Enabled = true;
            txtCCCD.Enabled = true;
            txtNgaySinh.Enabled = true;
        }


        // khóa
        private void LockControl()
        {
            btnSuaBenhNhan.Enabled = false;
            BtnXoaBenhNhan.Enabled = false;
        }


        // mở khóa
        private void UnLockControl()
        {
            btnSuaBenhNhan.Enabled = true;
            BtnXoaBenhNhan.Enabled = true;

            UnLockControlInput();
        }

        public void ConnecBenhNhan()
        {
            Con.Open();
            string query = "SELECT * FROM BenhNhan";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable= new DataTable();
            adapter.Fill(dataTable);
            BenhNhanGV.DataSource = dataTable;
            Con.Close();
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
                // Xử lý khi có lỗi xảy ra
                Console.WriteLine("Lỗi xảy ra khi đọc file: " + ex.Message);
                return null; // hoặc giá trị khác tùy theo logic của bạn
            }
        }

        // convert từ mảng byte[] sang string
        private string ConvertToString(byte[] data)
        {
            return Convert.ToBase64String(data);
        }


        // sửa thông tin của bệnh nhân.
        private void btnSuaBenhNhan_Click(object sender, EventArgs e)
        {
            Con.Open();

            string query = "UPDATE BenhNhan SET MaBN = @MaBN, TenBN = @TenBN, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, CCCD = @CCCD, DiaChi = @DiaChi, BHYT = @BHYT, DienThoai = @DienThoai WHERE MaBN = @MaBN";
            SqlCommand command = new SqlCommand(query, Con);

            command.Parameters.AddWithValue("@MaBN", cbbMaBN.Text);
            command.Parameters.AddWithValue("@TenBN", cbbTen.Text);

            // Chuyển đổi ngày tháng sang chuỗi định dạng yyyy-MM-dd
            string strNgaySinh = txtNgaySinh.Value.ToString("yyyy-MM-dd");
            SqlParameter parameterNgaySinh = new SqlParameter("@NgaySinh", SqlDbType.Date); 
            parameterNgaySinh.Value = strNgaySinh;
            command.Parameters.Add(parameterNgaySinh);

            string gioitinh = string.IsNullOrEmpty(cbbGioiTinh.Text) ? cbbGioiTinh.SelectedItem.ToString() : cbbGioiTinh.Text;
            command.Parameters.AddWithValue("@GioiTinh", gioitinh);

            command.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
            command.Parameters.AddWithValue("@DiaChi", cbbDiaChi.Text);
            command.Parameters.AddWithValue("@BHYT", txtBHYT.Text);
            command.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);

            command.ExecuteNonQuery(); // thực hiện câu truy vấn

            MessageBox.Show("Sửa Thông Tin Bệnh Nhân Thành Công.");
            Con.Close();
            ConnecBenhNhan();
        }


        // xóa thông tin của bệnh nhân.
        private void BtnXoaBenhNhan_Click(object sender, EventArgs e)
        {
            if (cbbMaBN.Text == "")
            {
                MessageBox.Show("Hãy chọn bệnh nhân cần xóa!!!");
            } else
            {
                Con.Open();

                DialogResult dialog = MessageBox.Show("Bạn Có Muốn Xóa Bệnh Nhân.",
                    "Xác Nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    string query = "DELETE FROM BenhNhan WHERE MaBN = @MaBN";
                    SqlCommand command = new SqlCommand(query, Con);

                    // Truyền tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@MaBN", cbbMaBN.Text);

                    // Thực thi câu lệnh SQL để xóa thông tin bệnh nhân
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa thông tin bệnh nhân thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bệnh nhân có mã " + cbbMaBN.Text);
                    }

                    Con.Close(); // Đóng kết nối
                    ConnecBenhNhan(); // Cập nhật lại datagridview hiển thị danh sách bệnh nhân
                    btnLamMoi_Click(sender, e); // xóa tất cả thông tin show ra ở phần nhập thông tin
                    return;
                }

                Con.Close();
            }
            
        }

        // click để hiện giá trị của bệnh nhân 
        private void BenhNhanGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbMaBN.Text = "";
            cbbTen.Text = "";
            txtDienThoai.Text = "";
            cbbDiaChi.Text = "";
            txtNgaySinh.Text = "";
            ptbTaiAnh.Image = null;
        }


        private void FormBenhNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                // ấn tổ hợp phím (Ctrl + S) để lưu thông tin bênh nhân 
            }
            if (e.Control && e.KeyCode == Keys.F)
            {
                // ấn tổ hợp phím (Ctrl + F) để sửa thông tin bênh nhân 
                btnSuaBenhNhan_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                // ấn tổ hợp phím (Ctrl + D) để xóa thông tin bênh nhân 
                BtnXoaBenhNhan_Click(sender, e);
            }
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A2", "H2");
            head.MergeCells = true;
            head.Value2 = title; // "THỐNG KÊ DANH SÁCH CÁC BỆNH NHÂN NỘI TRÚ"
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã Bệnh Nhân";
            cl1.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên Bệnh Nhân";
            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Ngày Sinh";
            cl3.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Giới Tính";
            cl4.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Số CCCD";
            cl5.ColumnWidth = 10.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Địa Chỉ";
            cl6.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Số BHYT";
            cl7.ColumnWidth = 10.0;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Số Điện Thoại";
            cl8.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "H3");
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

        public void btnInThongTin_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("cbbMaBN");
            DataColumn col2 = new DataColumn("cbbTen");
            DataColumn col3 = new DataColumn("txtNgaySinh");
            DataColumn col4 = new DataColumn("cbbGioiTinh");
            DataColumn col5 = new DataColumn("cbbDiaChi");
            DataColumn col6 = new DataColumn("txtCCCD");
            DataColumn col7 = new DataColumn("txtDienThoai");
            DataColumn col8 = new DataColumn("txtBHYT");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);

            foreach (DataGridViewRow dtgvRow in BenhNhanGV.Rows)
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

                dataTable.Rows.Add(dtRow);
            }

            ExportExcel(dataTable, "DANH SÁCH BỆNH NHÂN", "THỐNG KÊ DANH SÁCH CÁC BỆNH NHÂN NỘI TRÚ");
        }

        private void BenhNhanGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // DataGridViewRow row = BenhNhanGV.Rows[e.RowIndex];
                DataGridViewRow row = BenhNhanGV.CurrentRow;

                cbbMaBN.Text = row.Cells["MaBN"].Value.ToString();
                cbbTen.Text = row.Cells["TenBn"].Value.ToString();

                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                {
                    txtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value.ToString());
                }

                cbbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                cbbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();

                txtBHYT.Text = row.Cells["BHYT"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString();


                if (row.Cells["ImageData"].Value != DBNull.Value)
                {
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

                UnLockControl();
                cbbMaBN.Enabled = false;

            }
        }

    }
}
