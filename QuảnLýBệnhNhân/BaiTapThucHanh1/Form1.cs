using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThucHanh1
{
    public partial class frmName : Form
    {
        string flag;
        DataTable dtBN;
        int index;


        // tạo ra phương thức createDataTable kiểu DataTable(cung cấp sẵn trong C#)
        // để đẩy dữ liệu vào DataGridView
        public DataTable createDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("Diem");
            dt.Columns.Add("Lop");
            return dt;
        }

        public frmName()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            UnlockControl();
        }

        private void frmName_Load(object sender, EventArgs e)
        {
            LockControl();
            dtBN = createDataTable(); // khi dữ liệu được load lên thì tọa bảng.
        }

        public void LockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false; // vì ta chưa nhập dữ liệu gì cả, nên ta set Lưu là False
            btnHuy.Enabled = false; // vì ta chưa nhập dữ liệu gì cả, nên ta set Huy là False

            txtMaBN.ReadOnly= true;
            txtTenBN.ReadOnly= true;
            txtLoaiBenh.ReadOnly= true;

            btnThem.Focus();
        }
        
        public void UnlockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaBN.ReadOnly= false;
            txtTenBN.ReadOnly= false;
            txtLoaiBenh.ReadOnly= false;

            txtMaBN.Focus();   
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "add";
            txtMaBN.Text = "";
            txtTenBN.Text = "";
            txtLoaiBenh.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "edit";
        }

        // phương thức kiểm tra xem dữ liệu đã được add chưa
        public bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtMaBN.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã Sinh Viên", 
                    "Thông báo", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtMaBN.Focus() ;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenBN.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên Sinh Viên",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtTenBN.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLoaiBenh.Text))
            {
                MessageBox.Show("Bạn chưa nhập Điểm Sinh Viên",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtLoaiBenh.Focus();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // ta sẽ đẩy dữ liệu vào dataGridWiew
            if (flag == "add")
            {
                if (CheckData())
                {
                    dtBN.Rows.Add(txtTenBN.Text, txtMaBN.Text, txtLoaiBenh.Text);
                    // DataSource để liên kết dữ liệu của một control điều khiển.
                    // hay có nghĩa là , có sẽ add dữ liệu vừa nhập vào DataSource ấy
                    dataGridViewBenhNhan.DataSource = dtBN;

                    // phương thức RefreshEdit: là làm mới lại dữ liệu đang chỉnh sửa. hay đang thêm vào.
                    dataGridViewBenhNhan.RefreshEdit();
                }
            } else if (flag == "edit")
            {
                if (CheckData())
                {
                    dtBN.Rows[index][0] = txtMaBN.Text;
                    dtBN.Rows[index][1] = txtTenBN.Text;
                    dtBN.Rows[index][2] = txtLoaiBenh.Text;

                    dataGridViewBenhNhan.DataSource = dtBN;
                    dataGridViewBenhNhan.RefreshEdit();
                }
            }
            LockControl();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muối xóa thông tin này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtBN.Rows.RemoveAt(index);
                dataGridViewBenhNhan.DataSource = dtBN;
                dataGridViewBenhNhan.RefreshEdit();
            } 

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            // lấy ra index của hàng hiện tại
            // dùng toán tử 3 ngôi, tránh trường hợp khi mà xóa dữ liệu mà dữ liệu trong bảng là rỗng.
            index = dataGridViewBenhNhan.CurrentCell == null ? -1 : dataGridViewBenhNhan.CurrentCell.RowIndex;
            DataTable dt = (DataTable) dataGridViewBenhNhan.DataSource;
            if (index != -1)
            {
                txtMaBN.Text = dataGridViewBenhNhan.Rows[index].Cells[0].Value.ToString();
                txtTenBN.Text = dataGridViewBenhNhan.Rows[index].Cells[1].Value.ToString();
                txtLoaiBenh.Text = dataGridViewBenhNhan.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void dataGridSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtLoaiBenh_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
