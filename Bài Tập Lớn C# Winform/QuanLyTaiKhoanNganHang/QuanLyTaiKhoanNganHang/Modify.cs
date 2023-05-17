using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoanNganHang
{
    class Modify
    {
        public Modify() { }

        SqlCommand sqlCommand;
        SqlDataReader dataReader;

        // dùng List lưu thông tin các tài khoản, mà lấy từ database ra
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection Con = Connection.getInstance().getConnection())
            {
                Con.Open();
                sqlCommand = new SqlCommand(query, Con);
                dataReader = sqlCommand.ExecuteReader(); // lấy thông tin từ DB và đẩy vào dataReader
                while (dataReader.Read()) // đọc từng TaiKhoang được đẩy vào dataReader
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1))); // đọc tất cả dữ liệu và đẩy vào trong List<TaiKhoan>
                }
                Con.Close();
            }
            return taiKhoans;
        }


        // hàm này dùng để check tài khoản.
        public void Command(string query)
        {
            using (SqlConnection Con = Connection.getInstance().getConnection())
            {
                Con.Open();
                sqlCommand = new SqlCommand(query, Con);
                sqlCommand.ExecuteNonQuery();
                Con.Close();
            }
        }
    }
}
