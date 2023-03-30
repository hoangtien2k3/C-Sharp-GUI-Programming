using Microsoft.AnalysisServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HospitalManagementSysteam
{
    public partial class FormBenhAn : Form
    {

        SqlConnection Con = Connection.getConnection();


        private void ConnectBenhAn()
        {
            Con.Open();
            string query = "SELECT * FROM BenhAn";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            BenhAnGV.DataSource = dataTable;
            Con.Close();
        }


        public FormBenhAn()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm h = new MainForm();
            h.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = BenhAnGV.Rows[e.RowIndex];

                cbbDoiTuong.Text = row.Cells[0].Value.ToString();
                txtMaBN.Text = row.Cells[1].Value.ToString();
                txtCCCD.Text = row.Cells[2].Value.ToString();
                cbbKhoa.Text = row.Cells[3].Value.ToString();
                txtBHYT.Text = row.Cells[4].Value.ToString();
                cbbDanToc.Text = row.Cells[5].Value.ToString();
                cbbQuocTich.Text = row.Cells[6].Value.ToString();
                cbbNgheNghiep.Text = row.Cells[7].Value.ToString();
                cbbTienSuBenh.Text = row.Cells[8].Value.ToString();
                cbbLoaiBenh.Text = row.Cells[9].Value.ToString();
                cbbChieuCao.Text = row.Cells[10].Value.ToString();
                cbbCanNang.Text = row.Cells[11].Value.ToString();
                dateTimePickerNgayKhamBenh.Value = Convert.ToDateTime(row.Cells[12].Value.ToString());

            }
        }

        private void txtNgheNhiep_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbDoiTuong.Text = "";
            txtMaBN.Text = "";
            txtCCCD.Text = "";
            txtBHYT.Text = "";
            cbbDanToc.Text = "";
            cbbChieuCao.Text = "";
            cbbCanNang.Text = "";
            cbbLoaiBenh.Text = "";
            cbbKhoa.Text = "";
            cbbNgheNghiep.Text = "";
            cbbQuocTich.Text = "";
            cbbTienSuBenh.Text = "";
        }

        private void btnThemBenhAn_Click(object sender, EventArgs e)
        {
            if (cbbDoiTuong.Text==""||txtMaBN.Text==""||txtCCCD.Text==""||cbbKhoa.Text==""||txtBHYT.Text==""||cbbDanToc.Text==""||cbbQuocTich.Text=="")
            {
                MessageBox.Show("Nhập đầy đủ thông tin !!!");
            } else
            {
                Con.Open();
                string query = "SELECT COUNT(*) FROM BenhAn WHERE MaBN = @MaBN";
                SqlCommand sqlCommand = new SqlCommand(query, Con);
                sqlCommand.Parameters.AddWithValue("@MaBN", txtMaBN.Text);
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                if (count > 0) // Kiểm tra xem mã bệnh án đã tồn tại hay chưa
                {
                    MessageBox.Show("Mã bệnh án đã tồn tại. Hãy nhập lại mã khác.",
                        "Xác Nhận",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                } else
                {
                    try
                    {
                        query = "INSERT INTO BenhAn (DoiTuong, MaBN, CCCD, Khoa, BHYT, DanToc, QuocTich, NgheNghiep, TienSuBenh, LoaiBenh, ChieuCao, CanNang, NgayKhamBenh) VALUES (@DoiTuong, @MaBN, @CCCD, @Khoa, @BHYT, @DanToc, @QuocTich, @NgheNghiep, @TienSuBenh, @LoaiBenh, @ChieuCao, @CanNang, @NgayKhamBenh)";
                        sqlCommand = new SqlCommand(query, Con);

                        if (cbbDoiTuong.Text != "")
                        {
                            sqlCommand.Parameters.AddWithValue("@DoiTuong", cbbDoiTuong.Text);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@DoiTuong", cbbDoiTuong.SelectedItem.ToString());
                        }

                        sqlCommand.Parameters.AddWithValue("@MaBN", txtMaBN.Text);
                        sqlCommand.Parameters.AddWithValue("@CCCD", txtCCCD.Text);

                        if (cbbKhoa.Text != "")
                        {
                            sqlCommand.Parameters.AddWithValue("@Khoa", cbbKhoa.Text);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@Khoa", cbbKhoa.SelectedItem.ToString());
                        }

                        sqlCommand.Parameters.AddWithValue("@BHYT", txtBHYT.Text);

                        if (cbbDanToc.Text != "")
                        {
                            sqlCommand.Parameters.AddWithValue("@DanToc", cbbDanToc.Text);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@DanToc", cbbDanToc.SelectedItem.ToString());
                        }

                        if (cbbQuocTich.Text != "")
                        {
                            sqlCommand.Parameters.AddWithValue("@QuocTich", cbbQuocTich.Text);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@QuocTich", cbbQuocTich.SelectedItem.ToString());
                        }

                        if (cbbNgheNghiep.Text != "")
                        {
                            sqlCommand.Parameters.AddWithValue("@NgheNghiep", cbbNgheNghiep.Text);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@NgheNghiep", cbbNgheNghiep.SelectedItem.ToString());
                        }

                        if (cbbTienSuBenh.Text != "")
                        {
                            sqlCommand.Parameters.AddWithValue("@TienSuBenh", cbbTienSuBenh.Text);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@TienSuBenh", cbbTienSuBenh.SelectedItem.ToString());
                        }

                        if (cbbLoaiBenh.Text != "")
                        {
                            sqlCommand.Parameters.AddWithValue("@LoaiBenh", cbbLoaiBenh.Text);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@LoaiBenh", cbbLoaiBenh.SelectedItem.ToString());
                        }

                        if (cbbChieuCao.Text != "")
                        {
                            sqlCommand.Parameters.AddWithValue("@ChieuCao", cbbChieuCao.Text);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@ChieuCao", cbbChieuCao.SelectedItem.ToString());
                        }

                        if (cbbCanNang.Text != "")
                        {
                            sqlCommand.Parameters.AddWithValue("@CanNang", cbbCanNang.Text);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@CanNang", cbbCanNang.SelectedItem.ToString());
                        }

                        sqlCommand.Parameters.AddWithValue("@NgayKhamBenh", dateTimePickerNgayKhamBenh.Value.ToString("yyyy-MM-dd"));

                        sqlCommand.ExecuteNonQuery(); // thực hiện câu SQL (nếu không có câu này thì nó không thực hiện được câu SQL đâu)
                        MessageBox.Show("Thêm Thông Tin Bênh Án Thành Công!!!" + "\n\t + Mã Bệnh Nhân: " + txtMaBN.Text);
                    }
                    catch {
                        MessageBox.Show("Thêm Thông Tin Bệnh Án Không Thành Công !!!", "Xác Nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                Con.Close();
                ConnectBenhAn(); // show du lieu ra GV
                btnLamMoi_Click(sender, e);
                lblMaBN_Click(sender, e);
            }
        }

        private void FormBenhAn_Load(object sender, EventArgs e)
        {
            ConnectBenhAn(); // show dữ liệu ra datagridview
        }

        private void btnSuaBenhAn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "UPDATE BenhAn SET DoiTuong=@DoiTuong, MaBN=@MaBN, CCCD=@CCCD, Khoa=@Khoa, BHYT=@BHYT, DanToc=@DanToc, QuocTich=@QuocTich, NgheNghiep=@NgheNghiep, TienSuBenh=@TienSuBenh, LoaiBenh=@LoaiBenh, ChieuCao=@ChieuCao, CanNang=@CanNang, NgayKhamBenh=@NgayKhamBenh WHERE MaBN = @MaBN";
                SqlCommand sqlCommand = new SqlCommand(query, Con);

                if (cbbDoiTuong.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@DoiTuong", cbbDoiTuong.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@DoiTuong", cbbDoiTuong.SelectedItem.ToString());
                }

                sqlCommand.Parameters.AddWithValue("@MaBN", txtMaBN.Text);
                sqlCommand.Parameters.AddWithValue("@CCCD", txtCCCD.Text);

                if (cbbKhoa.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@Khoa", cbbKhoa.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@Khoa", cbbKhoa.SelectedItem.ToString());
                }

                sqlCommand.Parameters.AddWithValue("@BHYT", txtBHYT.Text);

                if (cbbDanToc.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@DanToc", cbbDanToc.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@DanToc", cbbDanToc.SelectedItem.ToString());
                }

                if (cbbQuocTich.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@QuocTich", cbbQuocTich.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@QuocTich", cbbQuocTich.SelectedItem.ToString());
                }

                if (cbbNgheNghiep.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@NgheNghiep", cbbNgheNghiep.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@NgheNghiep", cbbNgheNghiep.SelectedItem.ToString());
                }

                if (cbbTienSuBenh.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@TienSuBenh", cbbTienSuBenh.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@TienSuBenh", cbbTienSuBenh.SelectedItem.ToString());
                }

                if (cbbLoaiBenh.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@LoaiBenh", cbbLoaiBenh.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@LoaiBenh", cbbLoaiBenh.SelectedItem.ToString());
                }

                if (cbbChieuCao.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@ChieuCao", cbbChieuCao.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@ChieuCao", cbbChieuCao.SelectedItem.ToString());
                }

                if (cbbCanNang.Text != "")
                {
                    sqlCommand.Parameters.AddWithValue("@CanNang", cbbCanNang.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@CanNang", cbbCanNang.SelectedItem.ToString());
                }

                DateTime ngaykhambenh = dateTimePickerNgayKhamBenh.Value;
                string strngaykhambenh = ngaykhambenh.ToString("yyyy-MM-dd"); // Chuyển đổi sang chuỗi theo định dạng yyyy-MM-dd
                sqlCommand.Parameters.AddWithValue("@NgayKhamBenh", strngaykhambenh);

                sqlCommand.ExecuteNonQuery(); // thực hiện câu SQL (nếu không có câu này thì nó không thực hiện được câu SQL đâu)
                
                MessageBox.Show("Sửa Thông Tin Bênh Án Thành Công !");
                Con.Close();
                ConnectBenhAn();
                lblMaBN_Click(sender, e);
            } catch(Exception ex)
            {
                MessageBox.Show("Sửa Thông Tin Bệnh Án không thanh công !!!");
            }
        }

        private void BtnXoaBenhAn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                DialogResult dialog = MessageBox.Show("Bạn Có Muốn Xóa Bệnh Nhân.",
                    "Xác Nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    string query = "DELETE FROM BenhAn WHERE MaBN = @MaBN";
                    SqlCommand command = new SqlCommand(query, Con);

                    // Truyền tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@MaBN", txtMaBN.Text);

                    // Thực thi câu lệnh SQL để xóa thông tin bệnh án
                    int result = command.ExecuteNonQuery();

                }

                Con.Close(); // Đóng kết nối

                // Cập nhật lại datagridview hiển thị danh sách bệnh nhân
                ConnectBenhAn();
                btnLamMoi_Click(sender, e); // xóa tất cả thông tin show ra ở phần nhập thông tin
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa Thông Tin Bệnh Án Không Thành Công !!!");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (txtTimKiemBenhAn.Text == txtMaBN.Text || txtTimKiemBenhAn.Text == txtBHYT.Text)
            {
                string strTimKiem = "\t--- Thông Tin Bệnh Án ---" + "\n\n- Đối tượng: "  + cbbDoiTuong.Text.Trim() +
                    "\n  + Mã BN: " + txtMaBN.Text +
                    "\n  + CCCD: " + txtCCCD.Text +
                    "\n  + Khoa: " + cbbKhoa.Text +
                    "\n  + BHYT: " + txtBHYT.Text +
                    "\n  + Dân Tộc: " + cbbDanToc.Text +
                    "\n  + Quốc Tịch: " + cbbQuocTich.Text +
                    "\n  + Nghề Nghiệp: " + cbbNgheNghiep.Text +
                    "\n  + Tiền Sử Bệnh: " + cbbTienSuBenh.Text +
                    "\n  + Loại Bệnh: " + cbbLoaiBenh.Text +
                    "\n  + Chiều Cao: " + cbbChieuCao.Text +
                    "\n  + Cân Nặng: " + cbbCanNang.Text +
                    "\n  + Ngày Khám Bệnh: " + dateTimePickerNgayKhamBenh.Text;

                MessageBox.Show(strTimKiem);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Bệnh Án !!!");
            }
        }

        private void lblMaBN_Click(object sender, EventArgs e)
        {
            lblMaBN.Text = txtMaBN.Text;
        }
    }
}
