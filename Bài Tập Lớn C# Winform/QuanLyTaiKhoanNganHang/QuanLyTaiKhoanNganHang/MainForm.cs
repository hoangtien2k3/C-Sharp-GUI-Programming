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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            FormTaoTaiKhoan form = new FormTaoTaiKhoan();
            form.MdiParent = this;
            form.FormClosed += new FormClosedEventHandler(MainForm_FormClosed); // Đăng ký sự kiện FormClosed
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Thiết lập Form hiện tại thành MdiContainer
            this.IsMdiContainer = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Xóa Form con khỏi danh sách MdiChildren của Form cha
            ((Form)sender).MdiParent = null;
        }

        private void btnGuiTien_Click(object sender, EventArgs e)
        {
            FormGuiTien form = new FormGuiTien();
            form.MdiParent = this;
            form.FormClosed += new FormClosedEventHandler(MainForm_FormClosed); // Đăng ký sự kiện FormClosed
            form.Show();
        }
    }
}
