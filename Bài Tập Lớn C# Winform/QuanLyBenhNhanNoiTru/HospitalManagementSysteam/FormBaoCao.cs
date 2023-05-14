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

namespace QuanLyBenhNhanNoiTru
{
    public partial class FormBaoCao : Form
    {

        SqlConnection Con = Connection.getConnection();

        public FormBaoCao()
        {
            InitializeComponent();
        }


        // load tất cả MaBN lên combobox
        private void LoadDataToComboBoxMaBN()
        {
            string query = "SELECT MaBN FROM BenhNhan";

            using (SqlConnection connection = Connection.getConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbbMaBN.Items.Add(reader.GetString(0));
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
        }


        // load tất cả TenBN lên comboboxTenBN
        private void LoadDataToComboBoxTenBN()
        {
            string query = "SELECT TenBN FROM BenhNhan";

            using (SqlConnection connection = Connection.getConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbbTenBN.Items.Add(reader.GetString(0));
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
        }


        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            ConnecVienPhi();
            LoadDataToComboBoxMaBN();
            LoadDataToComboBoxTenBN();

            label18.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"); // xuất ngày lập phiếu
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void ConnecVienPhi()
        {
            Con.Open();
            string query = "SELECT * FROM BaoCaoVienPhi";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            ChiPhiDichVuGV.DataSource = dataTable;
            Con.Close();
        }

        private void btnLuuDuLieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbMaBN.Text) || string.IsNullOrEmpty(cbbTenBN.Text) || string.IsNullOrEmpty(cbbTienPhatSinh.Text) || string.IsNullOrEmpty(cbbTienTamUng.Text))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
                return;
            }

            Con.Open();

            try
            {
                string query = "SELECT COUNT(*) FROM BaoCaoVienPhi WHERE MaBN = @MaBN";
                SqlCommand command = new SqlCommand(query, Con);

                string maBN = string.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedItem.ToString() : cbbMaBN.Text;
                command.Parameters.AddWithValue("@MaBN", maBN);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Mã bệnh nhân đã tồn tại. Hãy nhập lại mã khác.",
                        "Xác Nhận",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    query = "INSERT INTO BaoCaoVienPhi (MaBN, TenBN, TienTamUng, TienPhatSinh, TongChiPhi) VALUES (@MaBN, @TenBN, @TienTamUng, @TienPhatSinh, @TongChiPhi)";
                    command = new SqlCommand(query, Con);

                    string mabn = string.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedItem.ToString() : cbbMaBN.Text;
                    command.Parameters.AddWithValue("@MaBN", mabn);

                    string tenbn = string.IsNullOrEmpty(cbbTenBN.Text) ? cbbTenBN.SelectedItem.ToString() : cbbTenBN.Text;
                    command.Parameters.AddWithValue("@TenBN", tenbn);

                    float tienTamUng = float.Parse(cbbTienTamUng.Text);
                    command.Parameters.AddWithValue("@TienTamUng", tienTamUng);

                    float tienPhatSinh = float.Parse(cbbTienPhatSinh.Text);
                    command.Parameters.AddWithValue("@TienPhatSinh", tienPhatSinh);

                    // Khởi tạo dictionary chứa thông tin về giá tiền của dịch vụ
                    Dictionary<string, float> servicePrices = new Dictionary<string, float>
                    {
                        {"dv1", 780000},
                        {"dv2", 350000},
                        {"dv3", 700000},
                        {"dv4", 800000},
                        {"dv5", 2000000},
                        {"dv6", 1200000}
                    };

                    string selectedService = ""; // Lưu mã dịch vụ được chọn

                    if (dv1.Checked) selectedService = "dv1";
                    if (dv2.Checked) selectedService = "dv2";
                    if (dv3.Checked) selectedService = "dv3";
                    if (dv4.Checked) selectedService = "dv4";
                    if (dv5.Checked) selectedService = "dv5";
                    if (dv6.Checked) selectedService = "dv6";

                    if (!string.IsNullOrEmpty(selectedService))
                    {
                        float selectedServicePrice = servicePrices[selectedService];
                        float tongChiPhi = selectedServicePrice + tienTamUng + tienPhatSinh;
                        command.Parameters.AddWithValue("@TongChiPhi", tongChiPhi);
                    }

                    command.ExecuteNonQuery();

                    MessageBox.Show("Lưu Thành Công Chi Phí Viện Phí Nội Trú");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
                ConnecVienPhi(); // show dữ liệu ra datagridview
                btnLamMoi();
            }

        }


        private void btnLamMoi()
        {
            cbbMaBN.Text = "";
            cbbTenBN.Text = "";
            cbbTienTamUng.Text = "";
            cbbTienPhatSinh.Text = "";
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
            Microsoft.Office.Interop.Excel.Range head1 = oSheet.get_Range("D1", "E1");
            head1.MergeCells = true;
            head1.Value2 = "Cộng Hòa Xã Hội Chủ Nghĩa Việt Nam";
            head1.Font.Bold = true;
            head1.Font.Name = "Times New Roman";
            head1.Font.Size = "10";
            head1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head2 = oSheet.get_Range("D2", "E2");
            head2.MergeCells = true;
            head2.Value2 = "Độc lập - Tự do - Hạnh phúc.";
            head2.Font.Bold = true;
            head2.Font.Name = "Times New Roman";
            head2.Font.Size = "10";
            head2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A4", "E4");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "15";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A5", "A5");
            cl1.Value2 = "Mã Bệnh Nhân";
            cl1.ColumnWidth = 18.0;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B5", "B5");
            cl2.Value2 = "Tên Bệnh Nhân";
            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C5", "C5");
            cl3.Value2 = "Tiền Tạm Ứng";
            cl3.ColumnWidth = 18.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D5", "D5");
            cl4.Value2 = "Tiền Phát Sinh";
            cl4.ColumnWidth = 18.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E5", "E5");
            cl5.Value2 = "Tổng Chi Phí";
            cl5.ColumnWidth = 18.0;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A5", "E5");
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
            int rowStart = 6;
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

        private void btnVienPhi_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("cbbMaBN");
            DataColumn col2 = new DataColumn("cbbTenBN");
            DataColumn col3 = new DataColumn("cbbTienTamUng");
            DataColumn col4 = new DataColumn("cbbTienPhatSinh");
            DataColumn col5 = new DataColumn("cbbTongChiPhi");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);

            foreach (DataGridViewRow dtgvRow in ChiPhiDichVuGV.Rows)
            {
                DataRow dtRow = dataTable.NewRow();

                dtRow[0] = dtgvRow.Cells[0].Value;
                dtRow[1] = dtgvRow.Cells[1].Value;
                dtRow[2] = dtgvRow.Cells[2].Value;
                dtRow[3] = dtgvRow.Cells[3].Value;
                dtRow[4] = dtgvRow.Cells[4].Value;

                dataTable.Rows.Add(dtRow);
            }

            ExportExcel(dataTable, "DS VIỆN PHÍ", "THỐNG KÊ DANH SÁCH VIỆN PHÍ");

        }

        private void ChiPhiDichVuGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = ChiPhiDichVuGV.CurrentRow;

                cbbMaBN.Text = row.Cells["MaBN"].Value.ToString();
                cbbTenBN.Text = row.Cells["TenBN"].Value.ToString();
                cbbTienTamUng.Text = row.Cells["TienTamUng"].Value.ToString();
                cbbTienPhatSinh.Text = row.Cells["TienPhatSinh"].Value.ToString();
            }
        }

        

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbMaBN.Text) || string.IsNullOrEmpty(cbbTenBN.Text) || string.IsNullOrEmpty(cbbTienPhatSinh.Text) || string.IsNullOrEmpty(cbbTienTamUng.Text))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
                return;
            }

            Con.Open();

            try
            {
                string query = "SELECT COUNT(*) FROM BaoCaoVienPhi WHERE MaBN = @MaBN";
                SqlCommand command = new SqlCommand(query, Con);

                string maBN = string.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedItem.ToString() : cbbMaBN.Text;
                command.Parameters.AddWithValue("@MaBN", maBN);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Mã bệnh nhân đã tồn tại. Hãy nhập lại mã khác.",
                        "Xác Nhận",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    query = "INSERT INTO BaoCaoVienPhi (MaBN, TenBN, TienTamUng, TienPhatSinh, TongChiPhi) VALUES (@MaBN, @TenBN, @TienTamUng, @TienPhatSinh, @TongChiPhi)";
                    command = new SqlCommand(query, Con);

                    string mabn = string.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedItem.ToString() : cbbMaBN.Text;
                    command.Parameters.AddWithValue("@MaBN", mabn);

                    string tenbn = string.IsNullOrEmpty(cbbTenBN.Text) ? cbbTenBN.SelectedItem.ToString() : cbbTenBN.Text;
                    command.Parameters.AddWithValue("@TenBN", tenbn);

                    float tienTamUng = float.Parse(cbbTienTamUng.Text);
                    command.Parameters.AddWithValue("@TienTamUng", tienTamUng);

                    float tienPhatSinh = float.Parse(cbbTienPhatSinh.Text);
                    command.Parameters.AddWithValue("@TienPhatSinh", tienPhatSinh);

                    // Khởi tạo dictionary chứa thông tin về giá tiền của dịch vụ
                    Dictionary<string, float> servicePrices = new Dictionary<string, float>
                    {
                        {"dv1", 780000},
                        {"dv2", 350000},
                        {"dv3", 700000},
                        {"dv4", 800000},
                        {"dv5", 2000000},
                        {"dv6", 1200000}
                    };

                    string selectedService = ""; // Lưu mã dịch vụ được chọn

                    if (dv1.Checked) selectedService = "dv1";
                    if (dv2.Checked) selectedService = "dv2";
                    if (dv3.Checked) selectedService = "dv3";
                    if (dv4.Checked) selectedService = "dv4";
                    if (dv5.Checked) selectedService = "dv5";
                    if (dv6.Checked) selectedService = "dv6";

                    if (!string.IsNullOrEmpty(selectedService))
                    {
                        float selectedServicePrice = servicePrices[selectedService];
                        float tongChiPhi = selectedServicePrice + tienTamUng + tienPhatSinh;
                        command.Parameters.AddWithValue("@TongChiPhi", tongChiPhi);
                    }

                    command.ExecuteNonQuery();

                    MessageBox.Show("Lưu Thành Công Chi Phí Viện Phí Nội Trú");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
                ConnecVienPhi(); // show dữ liệu ra datagridview
                btnLamMoi();
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
