using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            fTableMannager f = new fTableMannager();
            this.Hide();    // ẩn console ban dầu
            f.ShowDialog(); // nó sẽ hiểu thị và tắt file ban đầu
            this.Show();    // show console ban đầu lại.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát Chương Trình ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
