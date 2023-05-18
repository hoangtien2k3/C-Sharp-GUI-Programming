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

            FormHome formHome = new FormHome();
            formHome.MdiParent = this;
            formHome.FormClosed += new FormClosedEventHandler(MainForm_FormClosed); // Đăng ký sự kiện FormClosed
            formHome.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Xóa Form con khỏi danh sách MdiChildren của Form cha
            ((Form)sender).MdiParent = null;
        }

        private void btnGuiTien_Click(object sender, EventArgs e)
        {
            FormGuiTien formGuiTien = new FormGuiTien();
            formGuiTien.MdiParent = this;
            formGuiTien.FormClosed += new FormClosedEventHandler(MainForm_FormClosed); // Đăng ký sự kiện FormClosed
            formGuiTien.Show();
        }

        private void btnChuyenKhoan_Click(object sender, EventArgs e)
        {
            FormChuyenTien formChuyenTien =  new FormChuyenTien();
            formChuyenTien.MdiParent = this;
            formChuyenTien.FormClosed += new FormClosedEventHandler(MainForm_FormClosed); // Đăng ký sự kiện FormClosed
            formChuyenTien.Show();
        }

        private void btnRutTien_Click(object sender, EventArgs e)
        {
            FormRutTien formRutTien = new FormRutTien();
            formRutTien.MdiParent = this;
            formRutTien.FormClosed += new FormClosedEventHandler(MainForm_FormClosed); // Đăng ký sự kiện FormClosed
            formRutTien.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.MdiParent = this;
            formHome.FormClosed += new FormClosedEventHandler(MainForm_FormClosed); // Đăng ký sự kiện FormClosed
            formHome.Show();
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            FormGiaoDich formGiaoDich = new FormGiaoDich();
            formGiaoDich.MdiParent = this;
            formGiaoDich.FormClosed += new FormClosedEventHandler(MainForm_FormClosed); // Đăng ký sự kiện FormClosed
            formGiaoDich.Show();
        }
    }
}
