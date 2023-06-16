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

        private List<Button> buttons; // Danh sách các Button
        private Button selectedButton; // Button đang được chọn

        private void InitializeButtons()
        {
            // Khởi tạo danh sách các Button
            buttons = new List<Button>
            {
                btnBenhNhan,
                btnBacSi,
                btnBenhAn,
                btnHoSo,
                btnVienPhi,
                btnDangXuat
                // Thêm các Button khác vào danh sách
            };

            // Đặt sự kiện Click cho các Button
            foreach (Button button in buttons)
            {
                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Kiểm tra nếu Button đã được chọn trước đó
            if (clickedButton == selectedButton)
            {
                // Không làm gì nếu Button đã được chọn trước đó
                return;
            }

            // Đặt lại màu chữ của Button trước đó về màu ban đầu (nếu có)
            if (selectedButton != null)
            {
                selectedButton.ForeColor = SystemColors.ControlText;
            }

            // Thay đổi màu chữ của Button được nhấn thành màu mới
            clickedButton.ForeColor = Color.White;

            // Lưu Button được nhấn vào selectedButton
            selectedButton = clickedButton;
        }


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
            InitializeButtons();  // để thay đổi màu sác của chữ trong button khi button đó được ấn vào.

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

        private void pictureBoxBacSi_Click(object sender, EventArgs e)
        {
            FormBacSi form = new FormBacSi();
            form.MdiParent = this;
            form.Show();
        }


        private void pictureBoxBenhAn_Click(object sender, EventArgs e)
        {
            FormHoSo benhAn= new FormHoSo();
            benhAn.MdiParent = this; 
            benhAn.Show();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.MdiParent = this;
            form.Show();
        }

        private void btnLeTan_Click(object sender, EventArgs e)
        {
            FormLeTan form = new FormLeTan();
            form.MdiParent = this;
            form.Show();
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


        private void btnTkVienPhi_Click(object sender, EventArgs e)
        {
            FormXuatVien form = new FormXuatVien();
            form.MdiParent = this;
            form.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeTan form = new FormLeTan();
            form.MdiParent = this;
            form.Show();
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


        private void xếpGiườngBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiuongBenh form = new FormGiuongBenh();
            form.MdiParent = this;
            form.Show();
        }


        private void phímTắtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string phimtat = "CÁC PHÍM TẮT CÀI ĐẶT NHANH MẶC ĐỊNH CHO CHƯƠNG TRÌNH\n" +
               "\n Ctrl + S: Dùng để lưu " +
               "\n\n Ctrl + D: Dùng để xóa" +
               "\n\n Ctrl + F: Dùng để sửa" +
               "\n\n Ctrl + Space: Dùng để xóa khoảng trắng" +
               "\n\n Enter: Xác nhận thông tin";

            MessageBox.Show(phimtat);
        }

        private void hướngDẫnSửDụngHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string huongdan = "HƯỚNG DẪN SỬ DỤNG HỆ THỐNG QUẢN LÝ BỆNH NHÂN NỘI TRÚ\n" +
                "\n 1. Đăng nhập và quản lý tài khoản" +
                "\n\t+ Để truy cập vào hệ thống, người dùng cần sử dụng tên đăng nhập và mật khẩu." +
                "\n 2. Quản lý thông tin bệnh nhân:\n" +
                "\n\t- Bảng BenhNhan chứa thông tin chi tiết về bệnh nhân." +
                "\n 3. Quản lý thông tin bác sĩ:\n" +
                "\n\t- Bảng BacSi chứa thông tin về các bác sĩ trong bệnh viện." +
                "\n 4. Quản lý thông tin bệnh án:" +
                "\n\t+ Bảng \"BenhAn\" chứa thông tin về bệnh án của bệnh nhân." +
                "\n 5. Quản lý thông tin lễ tân:" +
                "\n\t- Bảng \"LeTan\" chứa thông tin về các nhân viên lễ tân." +
                "\n 6. Quản lý thông tin khám bệnh:" +
                "\n\t- Bảng \"ThongTinKhamBenh\" chứa thông tin về quá trình khám bệnh của bệnh nhân.";

            MessageBox.Show(huongdan);
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dichvukhambenh = "CÁC DỊCH VỤ KHÁM CHỮA BỆNH\n" +
                "\n\t1. Khám bệnh:" +
                "\n\t2. Chẩn đoán và xét nghiệm:" +
                "\n\t3. Điều trị và phẫu thuật:" +
                "\n\t4. Theo dõi và quản lý:" +
                "\n\t5. Báo cáo và ghi chú: " +
                "\n\t6. Quản lý giường bệnh: ";

            MessageBox.Show(dichvukhambenh);
        }

        private void khámChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ShowDaKham form = new Form_ShowDaKham();
            form.MdiParent = this;
            form.Show();
        }

        private void tìmTheoBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TimKiemBN form = new Form_TimKiemBN();
            form.MdiParent = this;
            form.Show();
        }

        private void tìmTheoBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TimKiemBS form = new Form_TimKiemBS();
            form.MdiParent = this;
            form.Show();
        }

        private void điềuTrịTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDieuTri form = new FormDieuTri();
            form.MdiParent = this;
            form.Show();
        }

    }
}
