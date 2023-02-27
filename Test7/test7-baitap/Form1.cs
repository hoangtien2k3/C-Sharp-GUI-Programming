using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test7_baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            bool check = true;


            errorProvider1.Clear();
            if (textPhone.Text == " ")
            {
                errorProvider1.SetError(textPhone, "Bạn Chưa Nhập Phone...");
                check = false;
            }

            // tuoi
            int tuoi;
            if (int.TryParse(textTuoi.Text, out tuoi) == false)
            {
                errorProvider1.SetError(textTuoi, "Sai Định Dạng...");
                check = false;
            } else
            {
                if (tuoi < 17)
                {
                    errorProvider1.SetError(textTuoi, "Tuổi Lớn Hơn 17.");
                    check = false;
                }
            }

            // kiem tra ngay dang ky

            if (dateTimeDK.Value.DayOfWeek == DayOfWeek.Monday)
            {
                errorProvider1.SetError(dateTimeDK, "Thứ 2 rạp không chiếu Firm.");
                check= false;
            }

            if (check)
            {
                MessageBox.Show("Bạn Đã Đăng Ký Thành Công.");
            }

        }
    }
}
