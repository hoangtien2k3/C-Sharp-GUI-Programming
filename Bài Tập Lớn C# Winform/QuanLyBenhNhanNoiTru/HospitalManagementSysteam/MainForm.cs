using QuanLyBenhNhanNoiTru;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSysteam
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;

        // Phương thức để cập nhật giờ
        private void timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật và hiển thị giờ mới
            lblDataTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        // Đảm bảo dừng timer khi form bị đóng
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }

        public MainForm()
        {
            InitializeComponent();

            // Khởi tạo timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 giây
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap form = new FormDangNhap();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormTimKiem form = new FormTimKiem();
            form.MdiParent= this;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBenhAn form= new FormBenhAn();
            form.MdiParent = this;
            form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.MdiParent = this;
            form.Show();
        }

        private void pictureBoxHoSo_Click(object sender, EventArgs e)
        {
            FormBenhAn form = new FormBenhAn();
            form.MdiParent = this;
            form.Show();
        }

        private void pictureBoxBenhNhan_Click(object sender, EventArgs e)
        {
            FormBenhNhan form = new FormBenhNhan(); 
            form.MdiParent = this;  
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBacSi_Click(object sender, EventArgs e)
        {
            FormBacSi form = new FormBacSi();
            form.MdiParent = this;
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBenhAn_Click(object sender, EventArgs e)
        {
            FormHoSo benhAn= new FormHoSo();
            benhAn.MdiParent = this; 
            benhAn.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnLeTan_Click(object sender, EventArgs e)
        {
            FormLeTan form = new FormLeTan();
            form.MdiParent = this;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            Form_khambenh form = new Form_khambenh();
            form.MdiParent = this;
            form.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn Có Chắc Chắn Muốn Đăng Xuất.",
                "Xác Nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap form = new FormDangNhap();
                form.Show();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn Có Chắc Chắn Muốn Đăng Xuất.",
                "Xác Nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap form = new FormDangNhap();
                form.Show();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FormTimKiem form = new FormTimKiem();
            form.MdiParent = this;
            form.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormBenhAn form = new FormBenhAn();
            form.MdiParent = this;
            form.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FormBacSi form = new FormBacSi();
            form.MdiParent = this;
            form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormBenhNhan form = new FormBenhNhan();
            form.MdiParent = this;
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormHoSo form = new FormHoSo();
            form.MdiParent = this;
            form.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.MdiParent = this;
            form.Show();
        }

        private void btnCaiDatPhimTat_Click(object sender, EventArgs e)
        {
            string phimtat = "CÁC PHÍM TẮT CÀI ĐẶT NHANH MẶC ĐỊNH CHO CHƯƠNG TRÌNH\n" + 
                "\n Ctrl + S: Dùng để lưu " + 
                "\n\n Ctrl + D: Dùng để xóa" + 
                "\n\n Ctrl + F: Dùng để sửa" + 
                "\n\n Ctrl + Space: Dùng để xóa khoảng trắng" + 
                "\n\n Enter: Xác nhận thông tin";

            MessageBox.Show(phimtat);
        }

        private void ptbHome_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.MdiParent = this;
            form.Activate();
            form.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FormBenhNhan formBenhNhan = new FormBenhNhan();
            formBenhNhan.btnInThongTin_Click(sender, e);
        }

        private void btnBenhNhan_Click_1(object sender, EventArgs e)
        {
            FormBenhNhan form = new FormBenhNhan();
            form.MdiParent = this;
            form.Show();
        }

        private void ptbBenhNhan_Click(object sender, EventArgs e)
        {
            FormBenhNhan form = new FormBenhNhan();
            form.MdiParent = this;
            form.Show();
        }

        private void btnVienPhi_Click(object sender, EventArgs e)
        {
            FormBaoCao formBaoCao = new FormBaoCao();
            formBaoCao.MdiParent = this;
            formBaoCao.Show();
        }

        private void btnTkVienPhi_Click(object sender, EventArgs e)
        {
            FormBaoCao formBaoCao = new FormBaoCao();
            formBaoCao.MdiParent = this;
            formBaoCao.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeTan form = new FormLeTan();
            form.MdiParent = this;
            form.Show();
        }

        private void tìmKiếmTheoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.MdiParent = this;
            form.Show();
        }

        private void khámTổngQuátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_khambenh form = new Form_khambenh();
            form.MdiParent = this;
            form.Show();
        }

        private void tìmKiếmBNBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimKiem form = new FormTimKiem();
            form.MdiParent = this;
            form.Show();
        }

        private void xuấtExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBenhNhan formBenhNhan = new FormBenhNhan();
            formBenhNhan.btnInThongTin_Click(sender, e);
        }

        private void càiĐặtPhímTắtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string phimtat = "CÁC PHÍM TẮT CÀI ĐẶT NHANH MẶC ĐỊNH CHO CHƯƠNG TRÌNH\n" +
               "\n Ctrl + S: Dùng để lưu " +
               "\n\n Ctrl + D: Dùng để xóa" +
               "\n\n Ctrl + F: Dùng để sửa" +
               "\n\n Ctrl + Space: Dùng để xóa khoảng trắng" +
               "\n\n Enter: Xác nhận thông tin";

            MessageBox.Show(phimtat);
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xếpGiườngBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiuongBenh form = new FormGiuongBenh();
            form.MdiParent = this;
            form.Show();
        }

        private void lblDataTimeNow_Click(object sender, EventArgs e)
        {

        }

 
    }
}
