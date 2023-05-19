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
        private List<Button> buttons; // Danh sách các Button
        private Button selectedButton; // Button đang được chọn

        private void InitializeButtons()
        {
            // Khởi tạo danh sách các Button
            buttons = new List<Button>
            {
                btnHome,
                btnTaoTaiKhoan,
                btnGuiTien,
                btnChuyenKhoan,
                btnRutTien,
                btnKiemTraSoDu,
                btnGiaoDich

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
            clickedButton.ForeColor = Color.Blue;

            // Lưu Button được nhấn vào selectedButton
            selectedButton = clickedButton;
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


        // Phương thức để cập nhật giờ
        private void timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật và hiển thị giờ mới
            lblDataTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
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
            timer.Stop();
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

            this.Hide();
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

        private void btnDangXuat_Click(object sender, EventArgs e)
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void đăngNhậpTàiKhoảnKhácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn Có Chắc Chắn Muốn Đăng Nhập Tài Khoản Khác.",
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

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXoaTaiKhoan formXoaTaiKhoan = new FormXoaTaiKhoan();
            formXoaTaiKhoan.MdiParent = this;
            formXoaTaiKhoan.FormClosed += new FormClosedEventHandler(MainForm_FormClosed); // Đăng ký sự kiện FormClosed
            formXoaTaiKhoan.Show();
        }

        private void xemChiTiếtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinGiaoDich formThongTinGiaoDich = new FormThongTinGiaoDich();
            formThongTinGiaoDich.MdiParent = this;
            formThongTinGiaoDich.FormClosed += new FormClosedEventHandler(MainForm_FormClosed); // Đăng ký sự kiện FormClosed
            formThongTinGiaoDich.Show();
        }
    }
}
