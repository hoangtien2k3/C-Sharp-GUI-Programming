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
    public partial class Form_ShowDaKham : Form
    {
        public Form_ShowDaKham()
        {
            InitializeComponent();
        }
        SqlConnection Con = Connection.getConnection();
        void Connect()
        {
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        private void Form_ShowDaKham_Load(object sender, EventArgs e)
        {
           
            Load_GrvKhamBenh();
            Load_CbbBN();
            LockClick();
        }

        private void Load_GrvKhamBenh()
        {
            Connect();
            SqlCommand cmd = new SqlCommand("Select * From ThongTinKhamBenh", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            Grv_KhamBenh.DataSource = tb;
           // Grv_KhamBenh.Columns.Add();
            Grv_KhamBenh.Refresh();

        }
        private void Load_CbbBN()
        {
            Connect();
            SqlCommand cmd = new SqlCommand("Select MaBN from ThongTinKhamBenh", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            Con.Close();

            DataRow r = tb.NewRow();
            r["MaBN"] = "---Chọn_Mã_Bênh_Nhân---";

            tb.Rows.InsertAt(r, 0);
            cbbMaBN.DataSource = tb;
            cbbMaBN.DisplayMember = "MaBN";
            cbbMaBN.ValueMember= "MaBN";
        }
        private void Load_CbbBacsi(string chuyenkhoa)
        {
            Connect();
            SqlCommand cmd = new SqlCommand("Select MaBS From BacSi WHERE ChuyenKhoa = N'" + chuyenkhoa + "'", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            cmd.Dispose();
            Con.Close();

            cbbMaBS.DataSource = tb;
            cbbMaBS.DisplayMember = "MaBS";
            cbbMaBS.ValueMember = "MaBS";
        }     
        private void cbbChuyenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chuyenkhoa = cbbChuyenKhoa.Text.Trim();
            Load_CbbBacsi(chuyenkhoa);
        }


        private void cbbMaBS_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        void LockClick()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void Grv_KhamBenh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connect();
            if (cbbMaBN.Text == "---Chọn_Mã_Bênh_Nhân---")
            {
                MessageBox.Show("Chưa Nhập Mã Bênh Nhân");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Bệnh nhân ?", "Xác Nhận"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (dialog == DialogResult.Yes)
                {
                    String quety = "Delete from ThongTinKhamBenh where MaBN = '" + cbbMaBN.Text + "'";
                    SqlCommand cmd = new SqlCommand(quety, Con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    Con.Close();
                    Load_GrvKhamBenh();
                    Load_CbbBN();
                    MessageBox.Show("Xóa Thành công !");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Connect();
            if(cbbMaBN.Text == "---Chọn_Mã_Bênh_Nhân---")
            {
                MessageBox.Show("Chưa Nhập Mã Bệnh Nhân");
                Load_GrvKhamBenh();
            }
            else
            {
             string query = "Select * From ThongTinKhamBenh Where MaBN LIKE  '%' + @MaBN + '%' ";
            SqlCommand cmd = new SqlCommand(query, Con);

            String TkBN = String.IsNullOrEmpty(cbbMaBN.Text) ? cbbMaBN.SelectedItem.ToString() : cbbMaBN.Text;
            cmd.Parameters.AddWithValue("@MaBN", TkBN);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            Grv_KhamBenh.DataSource = tb;
            cmd.Dispose();
            Con.Close() ;
            
            Grv_KhamBenh.Refresh();
            }
      
        }

        private void Grv_KhamBenh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0 && e.RowIndex>= 0)
            {
                DataGridViewRow Row = Grv_KhamBenh.CurrentRow;
                cbbMaBN.Text = Row.Cells["MaBN"].Value.ToString();
                cbbMaBS.Text = Row.Cells["MaBS"].Value.ToString();

                if (Row.Cells["NgayKham"].Value != DBNull.Value )
                {
                    dtpNgayKham.Value = Convert.ToDateTime(Row.Cells["NgayKham"].Value.ToString());
                }
     
                cbbPhongKham.Text = Row.Cells["PhongKham"].Value.ToString();
                cbbCanNang.Text = Row.Cells["CanNang"].Value.ToString();
                cbbNhietDo.Text = Row.Cells["NhietDo"].Value.ToString();
                cbbNhomMau.Text = Row.Cells["NhomMau"].Value.ToString();
                cbbMach.Text = Row.Cells["Mach"].Value.ToString();
                cbbHuyetAp.Text = Row.Cells["HuyetAp"].Value.ToString();
                cbbNhipTho.Text = Row.Cells["NhipTho"].Value.ToString();
                txtLyDoKham.Text = Row.Cells["LyDoKham"].Value.ToString();
                txtTinhTrangHienTai.Text = Row.Cells["TinhTrangHienTai"].Value.ToString();
                cbbChuanDoanSoBo.Text = Row.Cells["ChuanDoanSoBo"].Value.ToString();
                txtSoNgayNhapVien.Text = Row.Cells["SoNgayNhapVien"].Value.ToString();
                txtHuongDieuTri.Text = Row.Cells["HuongDieuTri"].Value.ToString();
                cbbChuyenKhoa.Text = Row.Cells["ChuyenKhoa"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connect();
            String query = "Update ThongTinKhamBenh Set MaBN = @MaBN , MaBS = @MaBS, NgayKham = @NgayKham, " +
                "PhongKham = @PhongKham,ChuyenKhoa =@ChuyenKhoa, CanNang = @CanNang, NhomMau = @NhomMau, NhietDo = @NhietDo," +
                " Mach = @Mach, HuyetAp = @HuyetAp, NhipTho = @NhipTho, LyDoKham = @LyDoKham, TinhTrangHienTai = @TinhTrangHienTai, " +
                "ChuanDoanSoBo = @ChuanDoanSoBo, SoNgayNhapVien = @SoNgayNhapVien, HuongDieuTri = @HuongDieuTri " +
                "where MaBN = @MaBN";

            SqlCommand cmd = new SqlCommand(query,Con);
            if (cbbMaBN.Text == "---Chọn_Mã_Bênh_Nhân---")
            {
                MessageBox.Show("Chưa Nhập Mã Bênh Nhân");
            }
            else
            {
            cmd.Parameters.AddWithValue("@MaBN", cbbMaBN.Text);
            cmd.Parameters.AddWithValue("@MaBS", cbbMaBS.Text);
            cmd.Parameters.AddWithValue("@NgayKham", dtpNgayKham.Text);
            cmd.Parameters.AddWithValue("@PhongKham", cbbPhongKham.SelectedItem);
            cmd.Parameters.AddWithValue("@ChuyenKhoa", cbbChuyenKhoa.SelectedItem);
            cmd.Parameters.AddWithValue("@CanNang", cbbCanNang.SelectedItem);
            cmd.Parameters.AddWithValue("@NhomMau", cbbNhomMau.SelectedItem);
            cmd.Parameters.AddWithValue("@NhietDo", cbbNhietDo.SelectedItem);
            cmd.Parameters.AddWithValue("@Mach", cbbMach.SelectedItem);
            cmd.Parameters.AddWithValue("@HuyetAp", cbbHuyetAp.SelectedItem);
            cmd.Parameters.AddWithValue("@NhipTho", cbbNhipTho.SelectedItem);
            cmd.Parameters.AddWithValue("@LyDoKham", txtLyDoKham.Text);
            cmd.Parameters.AddWithValue("@TinhTrangHienTai", txtTinhTrangHienTai.Text);
            cmd.Parameters.AddWithValue("@ChuanDoanSoBo", cbbChuanDoanSoBo.Text);
            cmd.Parameters.AddWithValue("@SoNgayNhapVien", txtSoNgayNhapVien.Text.Trim());
            cmd.Parameters.AddWithValue("@HuongDieuTri", txtHuongDieuTri.Text.Trim());

            cmd.ExecuteNonQuery();

            MessageBox.Show("Sửa Thông Tin Thành Công");
            Load_GrvKhamBenh();
            }


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }


        public void ExportExcel(DataTable dataTable, String sheetname, String title)
        {
            // tao doi tuong excel 
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            // tao moi mot workbook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oExcel.Sheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;

            // Tao tieu de
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A2", "P2");
            head.MergeCells = true; // hop nhat cac o '
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tao tieu de cot 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Ngày Khám";
            cl1.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Mã Bác Sĩ";
            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Phòng Khám";
            cl3.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Mã Bệnh Nhân";
            cl4.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Chuyên Khoa";
            cl5.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Cân Nặng";
            cl6.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Nhóm Máu";
            cl7.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Nhiệt Độ";
            cl8.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Mạch";
            cl9.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Huyết Áp";
            cl10.ColumnWidth = 15.0;
            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");
            cl11.Value2 = "Nhịp Thở";
            cl11.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");
            cl12.Value2 = "Lý Do Khám";
            cl12.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl13 = oSheet.get_Range("M3", "M3");
            cl13.Value2 = "Tình Trạng";
            cl13.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl14 = oSheet.get_Range("N3", "N3");
            cl14.Value2 = "Chuẩn Đóan Sơ Bộ";
            cl14.ColumnWidth = 20.0;
            Microsoft.Office.Interop.Excel.Range cl15 = oSheet.get_Range("O3", "O3");
            cl15.Value2 = "Số Ngày Nhập Viện";
            cl15.ColumnWidth = 30.0;
            Microsoft.Office.Interop.Excel.Range cl16 = oSheet.get_Range("P3", "P3");
            cl16.Value2 = "Hướng Điều Trị";
            cl16.ColumnWidth = 30.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "P3");
            rowHead.Font.Bold = true;


            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6; // vàng: 6 , màu xám: 15
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Lay time in file
            String lastCell = $"{(char)(65 + dataTable.Columns.Count - 1)}{(dataTable.Rows.Count + 6)}"; // Lấy tên ô cuối cùng
            Microsoft.Office.Interop.Excel.Range lastCellRange = oSheet.get_Range(lastCell); // Lấy Range của ô cuối cùng
            String date = DateTime.Now.ToString("dd/MM/yyyy"); // Định dạng ngày tháng
            lastCellRange.Value2 = $"Ngày in: {date}"; // Ghi ngày tháng vào ô cuối cùng

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

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn cl1 = new DataColumn("dtpNgayKham");
            DataColumn cl2 = new DataColumn("cbbMaBN");
            DataColumn cl3 = new DataColumn("cbbPhongKham");
            DataColumn cl4 = new DataColumn("txtMaBN");
            DataColumn cl5 = new DataColumn("cbbCanNang");
            DataColumn cl6 = new DataColumn("cbbNhomMau");
            DataColumn cl7 = new DataColumn("cbbNhietDo");
            DataColumn cl8 = new DataColumn("cbbMach");
            DataColumn cl9 = new DataColumn("cbbHuyenAp");
            DataColumn cl10 = new DataColumn("cbbNhipTho");
            DataColumn cl11 = new DataColumn("txtLyDoKham");
            DataColumn cl12 = new DataColumn("txtTinhTrangHienTai");
            DataColumn cl13 = new DataColumn("cbbChuanDoanSoBo");
            DataColumn cl14 = new DataColumn("txtSoNgayNhapVien");
            DataColumn cl15 = new DataColumn("txtHuongDieuTri");
            DataColumn ct16 = new DataColumn("cbbChuyenKhoa");


            dataTable.Columns.Add(cl1);
            dataTable.Columns.Add(cl2);
            dataTable.Columns.Add(cl3);
            dataTable.Columns.Add(cl4);
            dataTable.Columns.Add(cl5);
            dataTable.Columns.Add(cl6);
            dataTable.Columns.Add(cl7);
            dataTable.Columns.Add(cl8);
            dataTable.Columns.Add(cl9);
            dataTable.Columns.Add(cl10);
            dataTable.Columns.Add(cl11);
            dataTable.Columns.Add(cl12);
            dataTable.Columns.Add(cl13);
            dataTable.Columns.Add(cl14);
            dataTable.Columns.Add(cl15);
            dataTable.Columns.Add(ct16);

            foreach (DataGridViewRow dtgvRow in Grv_KhamBenh.Rows)
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
                dtRow[10] = dtgvRow.Cells[10].Value;
                dtRow[11] = dtgvRow.Cells[11].Value;
                dtRow[12] = dtgvRow.Cells[12].Value;
                dtRow[13] = dtgvRow.Cells[13].Value;
                dtRow[14] = dtgvRow.Cells[14].Value;
                dtRow[15] = dtgvRow.Cells[15].Value;

                dataTable.Rows.Add(dtRow);
            }

            ExportExcel(dataTable, "DANH SÁCH BỆNH NHÂN ĐÃ KHÁM", "THỐNG KÊ DANH SÁCH CÁC BỆNH NHÂN ĐÃ KHÁM");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


    }
}
