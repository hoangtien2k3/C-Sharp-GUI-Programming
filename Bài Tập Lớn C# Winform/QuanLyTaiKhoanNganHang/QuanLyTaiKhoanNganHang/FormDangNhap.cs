using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            else if (taiKhoan == "admin" && matKhau == "admin")
            {
                FormBatDau formBatDau = new FormBatDau();
                this.Hide();
                formBatDau.Show();
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

        private void btnThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HienThiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = '\0'; // Hiện mật khẩu
            }
            else
            {
                txtMatKhau.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void txtMatKhau_TextChanged_1(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void txtQuenMatKhau_Click(object sender, EventArgs e)
        {
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            this.Hide();
            formQuenMatKhau.Show();
        }

        private void DangKy_Click(object sender, EventArgs e)
        {
            string ans = "Hãy đăng nhập với quyền 'admin'\n" +
                "\n\n\t+ Account:  admin" +
                "\n\n\t+ Password:  admin" +
                "\n\nSau đó vào chức năng đăng ký tài khoản.";
            MessageBox.Show(ans);
        }

        private void FormDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // gọi hàm đăng nhập tại đây
                btnDangNhap_Click(sender, e);
            }
        }

        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
