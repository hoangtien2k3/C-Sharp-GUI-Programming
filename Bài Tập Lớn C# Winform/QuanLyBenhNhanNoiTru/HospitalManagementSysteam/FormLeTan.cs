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
using Excel = Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using OfficeOpenXml;
using System.Reflection;
using Microsoft.AnalysisServices;

namespace QuanLyBenhNhanNoiTru
{
    public partial class FormLeTan : Form
    {
        SqlConnection Con = Connection.getConnection();

        public FormLeTan()
        {
            InitializeComponent();
        }

        //load danh sach benh nhan

        //load danh sach cho
        private void ConnectLeTan()
        {
            Con.Open();
            string query = "SELECT * FROM LeTan";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DanhSachBenhNhanChoGV.DataSource = dataTable;
            DanhSachBenhNhanChoGV.Refresh();

            Con.Close();
        }


        // dùng để convert đường dẫn ảnh sang mảng byte[] để lưu trữ vào DB
        private byte[] convert()
        {
            FileStream fileStream = new FileStream(txtImageData.Text, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fileStream.Length];
            fileStream.Read(data, 0, System.Convert.ToInt32(fileStream.Length));
            fileStream.Close();
            return data;
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            if (txtMaBN.Text == "" || txtTenBN.Text == "" || txtNgaySinh.Text == "" || cbbGioiTinh.Text == "" || txtCCCD.Text == "" || cbbDiaChi.Text == "" || txtBHYT.Text == "" || txtSDT.Text == "" )
            {
                MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                try
                {
                    using (var connection = Connection.getConnection())
                    {
                        connection.Open();

                        string query = "INSERT INTO LeTan (MaBN, TenBN, NgaySinh, GioiTinh, CCCD, DiaChi, BHYT, DienThoai, ImageData) " +
                            "VALUES (@MaBN, @TenBN, @NgaySinh, @GioiTinh, @CCCD, @DiaChi, @BHYT, @DienThoai, @ImageData)";

                        SqlCommand command = new SqlCommand(query, connection);

                        // thêm dữ liệu và đẩy vào combobox
                        command.Parameters.AddWithValue("@MaBN", txtMaBN.Text.Trim());
                        command.Parameters.AddWithValue("@TenBN", txtTenBN.Text.Trim());
                        DateTime ngaySinh = txtNgaySinh.Value;
                        command.Parameters.AddWithValue("@NgaySinh", ngaySinh.Date);
                        string gioitinh = string.IsNullOrEmpty(cbbGioiTinh.Text) ? cbbGioiTinh.SelectedItem.ToString() : cbbGioiTinh.Text.Trim();
                        command.Parameters.AddWithValue("@GioiTinh", gioitinh);

                        command.Parameters.AddWithValue("@CCCD", txtCCCD.Text.Trim());

                        string diachi = string.IsNullOrEmpty(cbbDiaChi.Text) ? cbbGioiTinh.SelectedItem.ToString() : cbbDiaChi.Text.Trim();
                        command.Parameters.AddWithValue("@DiaChi", diachi);

                        command.Parameters.AddWithValue("@BHYT", txtBHYT.Text.Trim());
                        command.Parameters.AddWithValue("@DienThoai", txtSDT.Text.Trim());

                        command.Parameters.AddWithValue("@ImageData", convert());

                        var rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã Thêm Bệnh Nhân Vào Danh Sách Chờ !!!");
                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: Hãy Thử Nhập Lại");
                }
                finally
                {
                    ConnectLeTan();
                    buttonLamMoi_Click(sender, e);
                }
            }
        }

        private void FormLeTan_Load(object sender, EventArgs e)
        {
            ConnectLeTan(); // load tất cả dữ liệu từ DB lên 
        }


        private void DanhSachBenhNhanGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DanhSachBenhNhanChoGV.CurrentRow;
            DanhSachBenhNhanChoGV.Text = row.Cells["MaBN"].Value.ToString();
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

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            ConnectLeTan(); // load tất cả dữ liệu từ DB lên 
            txtMaBN.Text = "";
            txtTenBN.Text = "";
            txtNgaySinh.Text = "";
            cbbGioiTinh.Text = "";
            txtCCCD.Text = "";
            cbbDiaChi.Text = "";
            txtBHYT.Text = "";
            txtSDT.Text = "";
            ptbTaiAnh.Image = null;
            txtImageData.Text = "Link Image";
        }

        private void DanhSachBenhNhanChoGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy thông tin bệnh nhân được chọn
                DataGridViewRow row = DanhSachBenhNhanChoGV.CurrentRow;

                // Lấy các giá trị cần thiết của bệnh nhân
                txtMaBN.Text = row.Cells["MaBN"].Value.ToString();
                txtTenBN.Text = row.Cells["TenBN"].Value.ToString();
                txtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value.ToString());
                cbbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                cbbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtBHYT.Text = row.Cells["BHYT"].Value.ToString();
                txtSDT.Text = row.Cells["DienThoai"].Value.ToString();

                if (DanhSachBenhNhanChoGV.CurrentRow.Cells["ImageData"].Value != null && DanhSachBenhNhanChoGV.CurrentRow.Cells["ImageData"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["ImageData"].Value; // Lấy thông tin ảnh từ cơ sở dữ liệu
                    MemoryStream ms = new MemoryStream(imageBytes); // Chuyển đổi dữ liệu Binary về kiểu Image
                    Image image = Image.FromStream(ms);
                    ptbTaiAnh.Image = image; 
                }
                else
                {
                    ptbTaiAnh.Image = default;
                }
            }
        }


        public void ImportDataExcel(string filePath)
        {
            Con.Open();
            
            if (txtImageData.Text == "")
            {
                MessageBox.Show("Bạn Chưa Cập Nhật Ảnh", "Xác Nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                    int startRow = excelWorksheet.Dimension.Start.Row + 1;
                    int endRow = excelWorksheet.Dimension.End.Row;

                    string query = "INSERT INTO LeTan (MaBN, TenBN, NgaySinh, GioiTinh, CCCD, DiaChi, BHYT, DienThoai, ImageData) " +
                        "VALUES (@MaBN, @TenBN, @NgaySinh, @GioiTinh, @CCCD, @DiaChi, @BHYT, @DienThoai, @ImageData)";

                    for (int i = startRow; i <= endRow; i++)
                    {
                        string value1 = excelWorksheet.Cells[i, 1].Value?.ToString();
                        string value2 = excelWorksheet.Cells[i, 2].Value?.ToString();
                        string value3 = excelWorksheet.Cells[i, 3].Value?.ToString();
                        string value4 = excelWorksheet.Cells[i, 4].Value?.ToString();
                        string value5 = excelWorksheet.Cells[i, 5].Value?.ToString();
                        string value6 = excelWorksheet.Cells[i, 6].Value?.ToString();
                        string value7 = excelWorksheet.Cells[i, 7].Value?.ToString();
                        string value8 = excelWorksheet.Cells[i, 8].Value?.ToString();
                        string value9 = excelWorksheet.Cells[i, 9].Value?.ToString();

                        using (SqlCommand command = new SqlCommand(query, Con))
                        {
                            command.Parameters.AddWithValue("@MaBN", value1);
                            command.Parameters.AddWithValue("@TenBN", value2);
                            command.Parameters.AddWithValue("@NgaySinh", value3);
                            command.Parameters.AddWithValue("@GioiTinh", value4);
                            command.Parameters.AddWithValue("@CCCD", value5);
                            command.Parameters.AddWithValue("@DiaChi", value6);
                            command.Parameters.AddWithValue("@BHYT", value7);
                            command.Parameters.AddWithValue("@DienThoai", value8);
                            command.Parameters.AddWithValue("@ImageData", convert());

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }

            Con.Close();
        }


        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(openFileDialog.FileName);
                excelApp.Visible = true;


                bool isWorkbookClosed = false;
                if (excelWorkbook.Saved)    // Khi tệp Excel đóng, thuộc tính Saved sẽ trả về giá trị True
                {
                    isWorkbookClosed = true;
                    MessageBox.Show("Excel đã mở, Nhập vào nhập dữ liệu. \nNhấn Ctr+S (Lưu) và nhấn Oke để hoàn tất.");
                }
                else
                {
                    isWorkbookClosed = false;
                    MessageBox.Show("Đã đóng file Excel.");
                }


                if (isWorkbookClosed == true)
                {
                    try
                    {
                        ImportDataExcel(openFileDialog.FileName);
                        MessageBox.Show("Nhập File Excel Thành Công.");
                        ConnectLeTan();
                    }
                    catch
                    {
                        MessageBox.Show("Nhập File Excel không thành công.");
                    }
                }

            }
        }
    }
}
