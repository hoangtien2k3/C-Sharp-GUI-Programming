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

namespace Project1
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FUO61S0\SQLEXPRESS02;Initial Catalog=Collegedb;Integrated Security=True");
        private void UserForm_Load(object sender, EventArgs e)
        {
            populate();
        }


        private void populate()
        {
            // Mở kết nối đến cơ sở dữ liệu SQL Server thông qua đối tượng 
            Con.Open();

            // Khai báo một biến kiểu chuỗi (string) để chứa câu truy vấn SQL.
            string query = "select * from UserTbl";

            // Khởi tạo đối tượng SqlDataAdapter với câu truy vấn SQL và kết nối đến cơ sở dữ liệu được truyền vào qua tham số.
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);

            // Đối tượng này sẽ tạo ra các câu lệnh SQL để cập nhật cơ sở dữ liệu tự động cho ta sau này.
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            // Khởi tạo đối tượng DataSet, đây là một cấu trúc dữ liệu tạm thời để lưu trữ dữ liệu từ cơ sở dữ liệu.
            var ds = new DataSet();

            // Sử dụng đối tượng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu và lưu trữ vào đối tượng DataSet đã khởi tạo ở bước trước.
            sda.Fill(ds);

            // Gán dữ liệu từ bảng đầu tiên trong DataSet vào DataSource của một đối tượng DataGridView được đặt tên là UserDGV
            UserDGV.DataSource = ds.Tables[0];

            // Đóng kết nối với cơ sở dữ liệu.
            Con.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            try
            {
                if (UIdTb.Text == "" || UnameTb.Text == "" || UpassTb.Text == "")
                {
                    MessageBox.Show("Quên Nhập Thông Tin !");
                } 
                else
                {
                    // Đây là lệnh để mở kết nối tới cơ sở dữ liệu.
                    Con.Open();

                    // Đây là lệnh để tạo một đối tượng SqlCommand để thực thi một câu lệnh SQL trên cơ sở dữ liệu. 
                    // Câu lệnh SQL này là một lệnh INSERT để thêm thông tin người dùng vào bảng UserTbl.
                    SqlCommand cmd = new SqlCommand("insert into UserTbl values("+UIdTb.Text+", '"+UnameTb.Text+"', '"+UpassTb.Text+"')", Con);

                    // Hàm ExecuteNonQuery() được sử dụng vì câu lệnh SQL này không trả về bất kỳ giá trị nào.
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Add Thành Công.");

                    // Đây là lệnh để đóng kết nối tới cơ sở dữ liệu.
                    Con.Close();

                    populate();

                }
            } catch {
                MessageBox.Show("Add Không Thành Công.");
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }


        int index;
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // các câu lệnh sau cho chức năng, mỗi khi ta ấn vào thông tin nào, thì thông tin đó sẽ được sổ ra màn hình để chúng ta sửa

            
            UIdTb.Text = UserDGV.Rows[0].Cells[0].Value.ToString();
            UnameTb.Text = UserDGV.Rows[0].Cells[1].Value.ToString();
            UpassTb.Text = UserDGV.Rows[0].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label16_Click(object sender, EventArgs e)
        {

            Con.Open();
            string query = "Xóa từ UserTbl khi UserId = " + UIdTb.Text + "; ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Người dùng Xóa thành công.");
            Con.Close();
            populate();
            /*
            try
            {
                if (UIdTb.Text == "")
                {
                    MessageBox.Show("Nhập User Id");
                } else
                {
                    Con.Open();
                    string query = "Xóa từ UserTbl khi UserId = " + UIdTb.Text + "; ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Người dùng Xóa thành công.");
                    Con.Close();
                    populate();
                }
            } 
            catch
            {
                MessageBox.Show("Xóa Thất Bại");
            }
            */
        }
    }
}
