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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // tạo kết nối với DB
        private static string stringKetNoi = @"Data Source=DESKTOP-QE5H4U6\SQLEXPRESS;Initial Catalog=QLDiem;Integrated Security=True";
        SqlConnection Con = new SqlConnection(stringKetNoi);



        // tạo khóa
        private void LockControl()
        {
            // mở
            btnThemMoi.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;


            // khóa
            btnThem.Enabled = false;
            btnHuy.Enabled = false;

            /*
            // không nhập được dữ liệu
            txtID.ReadOnly = true; // đọc dữ liệu 1 lần duy nhất
            txtTenSV.ReadOnly = true;
            txtNgaySinh.ReadOnly = true;
            txtDiem.ReadOnly = true;
            */
        }


        // mở khóa
        private void UnLockControl()
        {
            // khóa
            btnThemMoi.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;


            // mở
            btnThem.Enabled = true;
            btnHuy.Enabled = true;


            // nhập được dữ liệu
            txtID.ReadOnly = false; 
            txtTenSV.ReadOnly = false;
            txtNgaySinh.ReadOnly = false;
            txtDiem.ReadOnly = false;

        }




        private void ConnectSinhVien()
        {
            Con.Open(); // bước 1:

            string query = "SELECT * FROM tbl_diem"; // LẤY RA TẤT CẢ THÔNG TIN CỦA BẢNG QLSV // bước 2
            SqlCommand sqlCommand = new SqlCommand(query, Con); // bước 3
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);  // bước 4
            DataTable dataTable = new DataTable(); // tạo ra đối tượng bảng // bước 5
            adapter.Fill(dataTable); // đầy : vào đẩy thông tin lên bảng // bước 6
            SinhVienGV.DataSource = dataTable; // hiển thị thông tin // // bước 7

            Con.Close(); // bước 8
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtID.Focus(); // Đặt con trỏ chuột vào phần nhập đầu tiên

            txtID.TabIndex = 0;
            txtTenSV.TabIndex = 1;
            txtNgaySinh.TabIndex = 2;
            txtDiem.TabIndex = 3;



            ConnectSinhVien();
            LoadDataComboBoxTimKiem();

            // khóa
            LockControl();

            // không nhập được dữ liệu
            txtID.ReadOnly = true; // đọc dữ liệu 1 lần duy nhất
            txtTenSV.ReadOnly = true;
            txtNgaySinh.ReadOnly = true;
            txtDiem.ReadOnly = true;
        }

        private void txtThem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "" || txtTenSV.Text == "" || txtNgaySinh.Text == "" || txtDiem.Text == "")
            {
                MessageBox.Show("Hãy Nhập vào đầy đủ thông tin");
            } else
            {
                Con.Open();  // mở đường dẫn đến cơ sở dữ liệu
                string query = "INSERT INTO tbl_diem(id, tensv, ngaysinh, diem) VALUES(@id, @tensv, @ngaysinh, @diem)";

                SqlCommand sqlCommand = new SqlCommand(query, Con);

                sqlCommand.Parameters.AddWithValue("@id", txtID.Text); // DÙNG ĐỂ INSERT(CHÈN) GIÁ TRỊ VÀO TRONG BẢNG, VỚI ĐỐI TƯỢNG CHÈN LÀ "Id"
                sqlCommand.Parameters.AddWithValue("@tensv", txtTenSV.Text);
                sqlCommand.Parameters.AddWithValue("@ngaysinh", txtNgaySinh.Text);
                sqlCommand.Parameters.AddWithValue("@diem", txtDiem.Text); // NHẬN GIÁ TRỊ MÀ CHUNG TA NHẬP VÀO


                sqlCommand.ExecuteNonQuery(); // thực hiện câu lệnh sql, để đẩy giá trị vào trong bảng SinhVien
                Con.Close();    // dóng đường dẫn đến cơ sở dữ liệu

                ConnectSinhVien(); // mục đích là: để cho người dùng có thể thấy được thông tin đó .
            }


            // khóa
            LockControl();
        }



        // 
        private void SinhVienGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // e nó sẽ bắt sự kiện của chuột
            {
                DataGridViewRow currentRow = SinhVienGV.CurrentRow; // hàng mà đang trỏ chuột đến.
                txtID.Text = currentRow.Cells["id"].Value.ToString();
                txtTenSV.Text = currentRow.Cells["tensv"].Value.ToString();
                txtNgaySinh.Text = currentRow.Cells["ngaysinh"].Value.ToString();
                txtDiem.Text = currentRow.Cells["diem"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // mở khóa
            // UnLockControl();

            if (txtID.Text == "" || txtTenSV.Text == "" || txtNgaySinh.Text == "" || txtDiem.Text == "")
            {
                MessageBox.Show("Hãy Nhập vào đầy đủ thông tin");
            }
            else
            {
                try
                {
                    Con.Open();  // mở đường dẫn đến cơ sở dữ liệu

                    // điều kiện Where để  chúng ta có thể bieey được, và sử đung sinh viên ma chúng ta mong muốn
                    string query = "UPDATE tbl_diem SET id = @id, tensv = @tensv, ngaysinh = @ngaysinh, diem = @diem WHERE id = @id"; 


                    SqlCommand sqlCommand = new SqlCommand(query, Con);

                    sqlCommand.Parameters.AddWithValue("@id", txtID.Text); // DÙNG ĐỂ INSERT(CHÈN) GIÁ TRỊ VÀO TRONG BẢNG, VỚI ĐỐI TƯỢNG CHÈN LÀ "Id"
                    sqlCommand.Parameters.AddWithValue("@tensv", txtTenSV.Text);
                    sqlCommand.Parameters.AddWithValue("@ngaysinh", txtNgaySinh.Text);
                    sqlCommand.Parameters.AddWithValue("@diem", txtDiem.Text); // NHẬN GIÁ TRỊ MÀ CHUNG TA NHẬP VÀO
                   

                    sqlCommand.ExecuteNonQuery(); // thực hiện câu lệnh sql, để đẩy giá trị vào trong bảng SinhVien


                    MessageBox.Show("Cập nhậ thông tin sinh viên thành công !!!");

                    Con.Close(); // dóng đường dẫn đến cơ sở dữ liệu

                    ConnectSinhVien(); // mục đích là: để cho người dùng có thể thấy được thông tin đó .
                }
                catch 
                {
                    MessageBox.Show("Trùng Id, xin hãy nhận Id khác !!!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Con.Open();  // mở đường dẫn đến cơ sở dữ liệu

            string query = "DELETE FROM tbl_diem WHERE id = @id"; // câu lệnh này dùng để xóa thong t in của sinh viên với id cho trước

            SqlCommand sqlCommand = new SqlCommand(query, Con);

            sqlCommand.Parameters.AddWithValue("@id", txtID.Text); // DÙNG ĐỂ INSERT(CHÈN) GIÁ TRỊ VÀO TRONG BẢNG, VỚI ĐỐI TƯỢNG CHÈN LÀ "Id"
            
            sqlCommand.ExecuteNonQuery(); // thực hiện câu lệnh sql, để đẩy giá trị vào trong bảng SinhVien

            MessageBox.Show("Xóa thông tin sinh viên thành công !!!");

            Con.Close(); // dóng đường dẫn đến cơ sở dữ liệu

            ConnectSinhVien(); // mục đích là: để cho người dùng có thể thấy được thông tin đó .
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Con.Open();

            string query = "SELECT * FROM tbl_diem WHERE id = @id"; 

            SqlCommand command = new SqlCommand(query, Con);

            string TimKiemID = string.IsNullOrEmpty(cbbTimKiem.Text) ? cbbTimKiem.SelectedItem.ToString() : cbbTimKiem.Text;

            command.Parameters.AddWithValue("@id", TimKiemID);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            TimKiemGV.DataSource = table;

            Con.Close();
        }




        // phương thức load thông tin lên combobox trong c#

        private void LoadDataComboBoxTimKiem()
        {
            string query = "SELECT id FROM tbl_diem";

            using(SqlConnection connect = new SqlConnection(stringKetNoi))
            {
                connect.Open();

                SqlCommand command = new SqlCommand(query, connect);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbbTimKiem.Items.Add(reader.GetString(0));
                }

                reader.Close();
                command.Dispose();

                connect.Close();
            }

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            txtID.Focus(); // Đặt con trỏ chuột vào phần nhập đầu tiên

            UnLockControl();

            txtID.Text = "";
            txtTenSV.Text = "";
            txtNgaySinh.Text = "";
            txtDiem.Text = "";

        }
    }
}
