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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyTaiKhoanNganHang
{
    public partial class FormRutTien : Form
    {
        SqlConnection Con = Connection.getInstance().getConnection();

        public FormRutTien()
        {
            InitializeComponent();
            // Khởi tạo timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 giây
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        // Phương thức để cập nhật giờ
        private void timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật và hiển thị giờ mới
            lblDataTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        // Đảm bảo dừng timer khi form bị đóng
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
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


        private void FormRutTien_Load(object sender, EventArgs e)
        {
            ConnecSoDuTaiKhoan();
            LoadDataToComboBoxThongTinTaiKhoan();
        }


        private void updateSoTienHienTai1()
        {
            string query = "UPDATE SoDuTaiKhoan SET SoTienHienTai = @SoTienHienTai  WHERE TenTaiKhoan = @TenTaiKhoan";
            using (SqlConnection sqlConnection = Connection.getInstance().getConnection())
            {
                sqlConnection.Open();
                SqlCommand updateCommand = new SqlCommand(query, sqlConnection);

                string SoTienMuonRut = string.IsNullOrEmpty(cbbSoTienCanRut.Text) ? cbbSoTienCanRut.SelectedItem.ToString() : cbbSoTienCanRut.Text;

                string ketqua = (int.Parse(txtSoTienHienTai.Text) - int.Parse(SoTienMuonRut)).ToString();
                updateCommand.Parameters.AddWithValue("@TenTaiKhoan", txtTenTaiKhoan.Text);
                updateCommand.Parameters.AddWithValue("@SoTienHienTai", ketqua);

                updateCommand.ExecuteNonQuery(); // thực hiện câu truy vấn

                txtSoTienHienTai.Text = ketqua;
                txtSoTienChuSo.Text = ConvertNumber.ConvertNumberToVietnamese(ketqua);
                sqlConnection.Close();
            }
        }

        private void btnRutTien_Click(object sender, EventArgs e)
        {

            if (cbbSoTaiKhoan.Text.Trim() == "" && cbbTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Muốn Rút Tiền ?",
                    "Xác Nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    if (int.Parse(txtSoTienHienTai.Text) < int.Parse(cbbSoTienCanRut.Text))
                    {
                        MessageBox.Show("Số tiền muốn rút đã vượt mức.",
                            "Xác Nhận",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        updateSoTienHienTai1();

                        string SoTienCanRut = string.IsNullOrEmpty(cbbSoTienCanRut.Text) ? cbbSoTienCanRut.SelectedItem.ToString() : cbbSoTienCanRut.Text;
                        txtSoTienDaRut.Text = SoTienCanRut;

                        MessageBox.Show("Đã Rút Số Tiền (" + cbbSoTienCanRut.Text + ") Thành Công.");
                    }
                }
                ConnecSoDuTaiKhoan();
            }

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (cbbSoTaiKhoan.Text.Trim() == "" && cbbTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền thông tin tài khoản cần kiểm tra.");
            }
            else
            {
                Con.Open();
                string query = "SELECT TenTaiKhoan FROM TaiKhoan WHERE (TenTaiKhoan = @TenTaiKhoan OR @TenTaiKhoan = '') AND (SoTaiKhoan = @SoTaiKhoan OR @SoTaiKhoan = '')";
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@TenTaiKhoan", cbbTenTaiKhoan.Text.Trim());
                command.Parameters.AddWithValue("@SoTaiKhoan", cbbSoTaiKhoan.Text.Trim());
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtTenTaiKhoan.Text = reader["TenTaiKhoan"].ToString();
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
                        txtSoTienHienTai.Text = "000.000";
                    }

                    txtSoTienChuSo.Text = ConvertNumber.ConvertNumberToVietnamese(txtSoTienHienTai.Text);

                    if (cbbSoTienCanRut.Text == "")
                    {
                        txtSoTienDaRut.Text = "000.000";
                    } 

                    reader.Close();
                    command.Dispose();
                    connection.Close();
                }

                reader.Close();
                Con.Close();
            }
        }

        private void SoDuTaiKhoanGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = SoDuTaiKhoanGV.CurrentRow;

                string tentaikhoan = row.Cells["TenTaiKhoan"].Value.ToString();
                string sotaikhoan = row.Cells["SoTaiKhoan"].Value.ToString();
                string cccd = row.Cells["CCCD"].Value.ToString();
                string sotienhientai = row.Cells["SoTienHienTai"].Value.ToString();

                string result = "THÔNG TIN CƠ BẢN VỀ TÀI KHOẢN\n" +
                    "\n\n\t+ Tên Tài Khoản: " + tentaikhoan +
                    "\n\n\t+ Số Tài Khoản: " + sotaikhoan +
                    "\n\n\t+ CCCD: " + cccd +
                    "\n\n\t+ Số Tiền Hiện Tại: " + sotienhientai +
                    "\n\n\t";

                MessageBox.Show(result);
            }
        }

        private void btnMayTinh_Click(object sender, EventArgs e)
        {
            FormMayTinh formMayTinh = new FormMayTinh();
            formMayTinh.Show();
        }
    }
}
