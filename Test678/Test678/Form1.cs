using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test678
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string s = "";
            if (txtHoTenNhanVien.Text.Trim() == "")
            {
                txtHoTenNhanVien.Focus();
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên", 
                    "Thông báo", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (maskedTextBoxNgaySinh.Text.Trim() == "/ /")
            {
                maskedTextBoxNgaySinh.Focus();
                MessageBox.Show("Bạn chưa nhập ngày sinh",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (txtDiaChi.Text.Trim() == "")
            {
                txtDiaChi.Focus();
                MessageBox.Show("Bạn chưa nhập địa chỉ",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (cbbQueQuan.Text.Trim() == "")
            {
                cbbQueQuan.Focus();
                MessageBox.Show("Bạn chưa nhập quê quán",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (cbbQuocTich.Text.Trim() == "")
            {
                cbbQuocTich.Focus();
                MessageBox.Show("Bạn chưa nhập quốc tịch",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (cbbQuocTich.Text.Trim() == "")
            {
                cbbQuocTich.Focus();
                MessageBox.Show("Bạn chưa nhập quốc tịch",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (maskedTextBoxDienThoai.Text.Trim() == "(  )       ")
            {
                maskedTextBoxDienThoai.Focus();
                MessageBox.Show("Bạn chưa nhập điện thoại",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (txtEmail.Text.Trim() == "")
            {
                txtEmail.Focus();
                MessageBox.Show("Bạn chưa nhập Email",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (dateTimePickerNgayBatDau.Text.Trim() == "")
            {
                dateTimePickerNgayBatDau.Focus();
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


            s += "- Họ tên nhân viên: " + txtHoTenNhanVien.Text.Trim() + "\n" +
                "- Ngày Sinh: " + maskedTextBoxNgaySinh.Text.Trim() + "\n" +
                "- Địa Chỉ: " + txtDiaChi.Text.Trim() + "\n" +
                "- Quê Quán: " + cbbQueQuan.Text.Trim() + "\n" +
                "- Quốc Tịch: " + cbbQuocTich.Text.Trim() + "\n" +
                "- Điện Thoại: " + maskedTextBoxDienThoai.Text.Trim() + "\n" +
                "- Email: " + txtEmail.Text.Trim() + "\n" +
                "- Ngày Bắt Đầu: " + dateTimePickerNgayBatDau.Text.Trim() + "\n";


            MessageBox.Show(s);



        }
    }
}
