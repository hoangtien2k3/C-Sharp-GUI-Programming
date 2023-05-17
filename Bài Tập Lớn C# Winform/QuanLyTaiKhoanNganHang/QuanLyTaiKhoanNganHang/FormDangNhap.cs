using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoanNganHang
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
            txtTaiKhoan.TabIndex = 0;
            txtMatKhau.TabIndex = 1;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            // nếu người dùng nhập khoản trắng
            if (taiKhoan.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản.");
                return;
            }
            else if (matKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                return;
            }
            else
            {
                string query = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan = '" + taiKhoan + "' AND MatKhau = '" + matKhau + "'";
                if (new Modify().TaiKhoans(query).Count != 0)
                {
                    FormBatDau formBatDau = new FormBatDau();
                    this.Hide();
                    formBatDau.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản đăng nhập không đúng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
