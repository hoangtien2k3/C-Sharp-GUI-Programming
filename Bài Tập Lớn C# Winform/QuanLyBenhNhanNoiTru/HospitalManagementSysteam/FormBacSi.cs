using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HospitalManagementSysteam
{
    public partial class FormBacSi : Form
    {
        SqlConnection Con = Connection.getConnection();
        
        public FormBacSi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm h = new MainForm();
            h.Show();
            this.Hide();
        }

        void Connect_database()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
        }


        void Load_GrvBacSi()
        {
            try
            {
                //Ket noi den database
                Connect_database();
                //Tao doi tuong cmd de thu thi cau lenh suy van
                SqlCommand cmd = new SqlCommand("Select * From BacSi", Con);
                //Tao datada de lay du lieu
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //Tao table de truyen du lieu tu database vao
                DataTable tb = new DataTable();
                da.Fill(tb);

                GrvBacSi.DataSource = tb;
                GrvBacSi.Refresh();
                cmd.Dispose();
                Con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }




        private void DoctorForm_Load(object sender, EventArgs e)
        {
            Load_GrvBacSi();
        }

      

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string query = "UPDATE BacSi SET MaBS = @MaBS, TenBS = @TenBS, KinhNghiem = @KinhNghiem, TuoiTac = @TuoiTac, ChuyenKhoa = @ChuyenKhoa WHERE MaBS = @MaBS";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@MaBS", txtMaBS.Text);
                cmd.Parameters.AddWithValue("@TenBS", txtTenBS.Text);
                cmd.Parameters.AddWithValue("@KinhNghiem", txtKinhNghiem.Text);
                cmd.Parameters.AddWithValue("@TuoiTac", txtTuoiTac.Text);
                cmd.Parameters.AddWithValue("@ChuyenKhoa", cbChuyenKhoa.SelectedItem.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sửa Thông Tin Thành Công.");
                Con.Close();
                Load_GrvBacSi(); 
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm h = new MainForm();
            h.Show();
        }

        private void DoctorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLamSach_Click(object sender, EventArgs e)
        {
            txtMaBS.Text = "";
            txtTenBS.Text = "";
            txtTuoiTac.Text = "";
            txtKinhNghiem.Text = "";
            cbChuyenKhoa.Text = "";
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void FormBacSi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                // ấn tổ hợp phím (Ctrl + S) để lưu thông tin bênh nhân 
                btnThemThongTin_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.F)
            {
                // ấn tổ hợp phím (Ctrl + D) để sửa thông tin bênh nhân 
                btnSuaThongTin_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                // ấn tổ hợp phím (Ctrl + F) để xóa thông tin bênh nhân 
                btnXoaThongTin_Click(sender, e);
            }
        }

        // thêm thông tin bác sĩ vào database và load lên datagridview
        private void btnThemThongTin_Click(object sender, EventArgs e)
        {
            Connect_database();
            SqlCommand cmd = null;
            if (txtMaBS.Text == "" || txtTenBS.Text == "" || txtTuoiTac.Text == "" || txtKinhNghiem.Text == "" || cbChuyenKhoa.Text == "")
            {
                MessageBox.Show("Hãy Điền đầy đủ thông tin.");
            }
            else
            {
                cmd = new SqlCommand("Select Count (*) From BacSi Where MaBS = @Mabs", Con);
                String Mabs = txtMaBS.Text;
                cmd.Parameters.AddWithValue("@Mabs",Mabs);
                int Count = Convert.ToInt32(cmd.ExecuteScalar());
                if(Count > 0)
                {
                    MessageBox.Show("Mã Bác Sĩ Đã Tồn Tại");
                }
                else
                {
                String query = "INSERT INTO BacSi(MaBS, TenBS, KinhNghiem, TuoiTac, ChuyenKhoa) VALUES(@MaBS, @TenBS, @KinhNghiem, @TuoiTac, @ChuyenKhoa)";
                cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@MaBS", txtMaBS.Text);
                cmd.Parameters.AddWithValue("@TenBS", txtTenBS.Text);
                cmd.Parameters.AddWithValue("@KinhNghiem", txtKinhNghiem.Text);
                cmd.Parameters.AddWithValue("@TuoiTac", txtTuoiTac.Text);
                String ChuyenKhoa = String.IsNullOrEmpty(txtKinhNghiem.Text) ? cbChuyenKhoa.SelectedItem.ToString() : cbChuyenKhoa.Text;
                cmd.Parameters.AddWithValue("@ChuyenKhoa", ChuyenKhoa);

                cmd.ExecuteNonQuery(); // thực thi lệnh truy vấn.
                MessageBox.Show("Thêm Bác Sĩ Thanh Công.");
                Con.Close();
                Load_GrvBacSi();
                btnLamSach_Click(sender, e);

                }
                
                
               
        }
        
        
    }

        // sửa thông tin bác sĩ vào database và load lên datagridview
        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if(txtMaBS.Text == "" || txtTenBS.Text == "" || txtKinhNghiem.Text == "" || txtTuoiTac.Text == "" || cbChuyenKhoa.Text == "")
            {
                MessageBox.Show("Chưa Nhập Đủ Thông Tin");
            }
            else
            {
                Con.Open();

                string query = "UPDATE BacSi SET MaBS = @MaBS, TenBS = @TenBS, KinhNghiem = @KinhNghiem, TuoiTac = @TuoiTac, ChuyenKhoa = @ChuyenKhoa WHERE MaBS = @MaBS";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@MaBS", txtMaBS.Text);
                cmd.Parameters.AddWithValue("@TenBS", txtTenBS.Text);
                cmd.Parameters.AddWithValue("@KinhNghiem", txtKinhNghiem.Text);
                cmd.Parameters.AddWithValue("@TuoiTac", txtTuoiTac.Text);
                cmd.Parameters.AddWithValue("@ChuyenKhoa", cbChuyenKhoa.SelectedItem.ToString());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sửa Thông Tin Thành Công.");
                Con.Close();
                Load_GrvBacSi();

            }


        }

        // xóa thông tin bác sĩ vào database và load lên datagridview
        private void btnXoaThongTin_Click(object sender, EventArgs e)
        {
            if(txtMaBS.Text == "")
            {
                MessageBox.Show("Chưa Nhập Mã Bác Sĩ");
            }
            else 
                Con.Open();
                DialogResult dialog = MessageBox.Show("Bạn Có Muốn Xóa Bác Sĩ.",
                "Xác Nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                string query = "DELETE FROM BacSi WHERE MaBS = '" + txtMaBS.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);


                // Thực thi câu lệnh SQL để xóa thông tin bệnh nhân
                cmd.ExecuteNonQuery();

                Con.Close();

                // Cập nhật lại datagridview hiển thị danh sách bác sĩ
                Load_GrvBacSi();
                MessageBox.Show("Xóa Thông Tin Thành Công");
                btnLamSach_Click(sender, e);
            {

            }
 
            }
        }

        private void txtMaBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrvBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = GrvBacSi.CurrentRow;
            txtMaBS.Text = Row.Cells["MaBS"].Value.ToString();
            txtTenBS.Text = Row.Cells["TenBS"].Value.ToString();
            txtKinhNghiem.Text = Row.Cells["KinhNghiem"].Value.ToString();
            cbChuyenKhoa.Text = Row.Cells["ChuyenKhoa"].Value.ToString();
            txtTuoiTac.Text = Row.Cells["TuoiTac"].Value.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
