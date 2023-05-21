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
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
            labelMatKhau.Text = "";
        }

        Modify modify = new Modify();
        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = txtEmailDangKy.Text;
            string cccd = txtCCCD.Text;

            if (email.Trim() == "" || cccd.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email và CCCD.");
            }
            else
            {
                try
                {
                    string query = "SELECT TenTaiKhoan, MatKhau FROM TaiKhoan WHERE DiaChiEmail = '" + email + "' AND CCCD = '" + cccd + "'";
                    if (modify.TaiKhoans(query).Count != 0)
                    {
                        labelMatKhau.ForeColor = Color.Blue;

                        labelMatKhau.Text = "Mật Khẩu: " + modify.TaiKhoans(query)[0].TenMatKhau;
                    }
                    else
                    {
                        labelMatKhau.ForeColor = Color.Red;
                        labelMatKhau.Text = "Email Hoặc CCCD Không đúng !!!";
                    }
                } catch
                {
                    MessageBox.Show("Không thể lấy lại được mật khẩu.");
                }
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            this.Hide();
            formDangNhap.Show();
        }

        private void FormQuenMatKhau_Load(object sender, EventArgs e)
        {
            txtEmailDangKy.Focus();

            txtEmailDangKy.TabIndex = 0;
            txtCCCD.TabIndex = 1;
        }

        private void FormQuenMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLayLaiMatKhau_Click(sender, e);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            this.Hide();
            formDangNhap.Show();
        }
    }
}
