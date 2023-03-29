using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test567
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string s = "- Mã Sinh Viên: " + txtMaSV.Text.Trim() + "\n"
                + "- Họ Tên: " + txtHoTen.Text.Trim() + "\n"
                + "- Niêm Khóa" + cbbNienKhoa.Text.Trim() + "\n"
                + "- Lớp: " + txtLop.Text.Trim() + "\n"
                + "- Môn Học: " + clbMonHoc.Text.Trim() + "\n";

            if (rdbI.Checked) {
                s += "- Học Kỳ: I" + "\n";
            } else if (rdbII.Checked)
            {
                s += "- Học Kỳ: II" + "\n";
            } else if (rdbIII.Checked)
            {
                s += "- Học Kỳ: III" + "\n";
            } else if (rdbIV.Checked)
            {
                s += "- Học Kỳ: IV" + "\n";
            }

            s += "- Môn Học \n";
            for(int i = 0; i < clbMonHoc.CheckedItems.Count; i++)
            {
                s += "  + " + (i + 1) + ". " + clbMonHoc.CheckedItems[i].ToString() + "\n";

            }
            MessageBox.Show(s);

        }
    }
}
