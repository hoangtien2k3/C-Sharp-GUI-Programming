using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnThem_Click(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtNhap.Text);

                if (checkBoxChi.Checked == true)
                {
                    listBoxChi.Items.Add(x);
                }
                else if(checkBoxThu.Checked == true)
                {
                    listBoxThu.Items.Add(x);
                }
            } catch(Exception ex) { }
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string itemToRemove = txtNhap.Text;

            // Tìm và xóa tất cả các mục trong ListBox có nội dung giống với itemToRemove
            for (int i = listBoxThu.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBoxThu.Items[i].ToString();
                if (currentItem == itemToRemove)
                {
                    listBoxThu.Items.RemoveAt(i);
                }
            }

            for (int i = listBoxChi.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBoxChi.Items[i].ToString();
                if (currentItem == itemToRemove)
                {
                    listBoxChi.Items.RemoveAt(i);
                }
            }
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                int tong = 0;
                foreach (int i in listBoxThu.Items)
                {
                    tong += i;
                    MessageBox.Show("Tổng của danh sách là: " + tong);
                }
            } catch(Exception EX) { }
            
        }
    }
}
