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

        private void ConnecBenhNhan()
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

        private void btnThemBenhNhan_Click(object sender, EventArgs e)
        {
            if (txtMaBN.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtNgaySinh.Text == "" || txtTuoi.Text == "" || txtDienThoai.Text == "" || txtNhomMau.Text == "" || txtLoaiBenh.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
            }
            else
            {
                Con.Open();

                string query = "SELECT COUNT(*) FROM BenhNhan WHERE MaBN = @MaBN";
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@MaBN", txtMaBN.Text);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0) // Kiểm tra xem mã bệnh nhân đã tồn tại hay chưa
                {
                    MessageBox.Show("Mã bệnh nhân đã tồn tại. Hãy nhập lại mã khác.", 
                        "Xác Nhận",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    query = "INSERT INTO BenhNhan (MaBN, TenBn, DiaChi, NgaySinh, Tuoi, DienThoai, GioiTinh, NhomMau, LoaiBenh) VALUES (@MaBN, @TenBn, @DiaChi, @NgaySinh, @Tuoi, @DienThoai, @GioiTinh, @NhomMau, @LoaiBenh)";
                    command = new SqlCommand(query, Con);

                    command.Parameters.AddWithValue("@MaBN", txtMaBN.Text);
                    command.Parameters.AddWithValue("@TenBn", txtTen.Text);
                    command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);

                    DateTime ngaySinh = txtNgaySinh.Value;
                    string strNgaySinh = ngaySinh.ToString("yyyy-MM-dd"); // Chuyển đổi sang chuỗi theo định dạng yyyy-MM-dd
                    command.Parameters.AddWithValue("@NgaySinh", strNgaySinh);
                    command.Parameters.AddWithValue("@Tuoi", txtTuoi.Text);
                    command.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
                    command.Parameters.AddWithValue("@GioiTinh", (chkNam.Checked) ? "Nam" : "Nữ");

                    if (txtNhomMau.Text != "")
                    {
                        command.Parameters.AddWithValue("@NhomMau", txtNhomMau.Text);
                    } else
                    {
                        command.Parameters.AddWithValue("@NhomMau", txtNhomMau.SelectedItem.ToString());
                    }
                    command.Parameters.AddWithValue("@LoaiBenh", txtLoaiBenh.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Thêm Bệnh Nhân Thành Công");
                }

                Con.Close();
                ConnecBenhNhan(); // show dữ liệu ra datagridview
                btnLamMoi_Click(sender, e);
            }
        }

        private void FormBenhNhan_Load(object sender, EventArgs e)
        {
            ConnecBenhNhan(); // show dữ liệu ra datagridview
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuaBenhNhan_Click(object sender, EventArgs e)
        {
            Con.Open();

            string query = "UPDATE BenhNhan SET MaBN = @MaBN, TenBN = @TenBN, DiaChi = @DiaChi, NgaySinh = @NgaySinh, Tuoi = @Tuoi, DienThoai = @DienThoai, GioiTinh = @GioiTinh, NhomMau = @NhomMau, LoaiBenh = @LoaiBenh WHERE MaBN = @MaBN";
            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@MaBN", txtMaBN.Text);
            command.Parameters.AddWithValue("@TenBN", txtTen.Text);
            command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);

            DateTime ngaySinh = txtNgaySinh.Value;
            string strNgaySinh = ngaySinh.ToString("dd-MM-yyyy"); // Chuyển đổi sang chuỗi theo định dạng dd-MM-yyyy
            command.Parameters.AddWithValue("@NgaySinh", strNgaySinh);
            command.Parameters.AddWithValue("@Tuoi", txtTuoi.Text);
            command.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);
            command.Parameters.AddWithValue("@GioiTinh", (chkNam.Checked) ? "Nam" : "Nữ");
            command.Parameters.AddWithValue("@NhomMau", txtNhomMau.SelectedItem.ToString());
            command.Parameters.AddWithValue("@LoaiBenh", txtLoaiBenh.Text);
            command.ExecuteNonQuery(); // thực hiện câu truy vấn

            MessageBox.Show("Sửa Thông Tin Bệnh Nhân Thành Công.");
            Con.Close();
            ConnecBenhNhan();
        }

        
        private void BtnXoaBenhNhan_Click(object sender, EventArgs e)
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
                command.Parameters.AddWithValue("@MaBN", txtMaBN.Text);

                // Thực thi câu lệnh SQL để xóa thông tin bệnh nhân
                int result = command.ExecuteNonQuery();

                /*
                if (result > 0)
                {
                    MessageBox.Show("Xóa thông tin bệnh nhân thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bệnh nhân có mã " + txtMaBN.Text);
                }
                */

            }
            // Đóng kết nối
            Con.Close();

            // Cập nhật lại datagridview hiển thị danh sách bệnh nhân
            ConnecBenhNhan();
            btnLamMoi_Click(sender, e); // xóa tất cả thông tin show ra ở phần nhập thông tin
        }

        private void BenhNhanGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {   
                DataGridViewRow row = BenhNhanGV.Rows[e.RowIndex];

                txtMaBN.Text = row.Cells["MaBN"].Value.ToString();
                txtTen.Text = row.Cells["TenBn"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value.ToString());
                txtTuoi.Text = row.Cells["Tuoi"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString();

                if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    chkNam.Checked = true;
                }
                else if (row.Cells["GioiTinh"].Value.ToString() == "Nữ")
                {
                    chkNu.Checked = true;
                }
                else
                {
                    chkNam.Checked = false;
                    chkNu.Checked = false;
                }

                txtNhomMau.SelectedItem = row.Cells["NhomMau"].Value.ToString();
                txtLoaiBenh.Text = row.Cells["LoaiBenh"].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaBN.Text = "";
            txtTen.Text = "";
            txtLoaiBenh.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtNhomMau.Text = "";
            txtTuoi.Text = "";
            txtNgaySinh.Text = "";
            chkNam.Checked = false;
            chkNu.Checked = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtMaBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
