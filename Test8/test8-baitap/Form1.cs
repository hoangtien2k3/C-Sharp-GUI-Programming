using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test8_baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBoxNhapSo.Text);
            listBoxSo.Items.Add(x);

        }

        private void buttonTongDS_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach(int i in listBoxSo.Items)
            {
                tong += i;
                MessageBox.Show("Tổng của danh sách là: " + tong);
            }
        }

        private void buttonXoaDauCuoi_Click(object sender, EventArgs e)
        {
            listBoxSo.Items.RemoveAt(0);
            listBoxSo.Items.RemoveAt(listBoxSo.Items.Count - 1);
        }

        private void buttonXoaPTChon_Click(object sender, EventArgs e)
        {
            while (listBoxSo.SelectedIndex != -1)
            {
                listBoxSo.Items.RemoveAt(listBoxSo.SelectedIndex);
            }
        }

        private void buttonTangLen2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBoxSo.Items.Count; i++)
            {
                int k = (int)listBoxSo.Items[i] + 2;
                listBoxSo.Items[i] = k;
            }
        }

        private void buttonThayBangBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxSo.Items.Count; i++)
            {
                int k = (int)listBoxSo.Items[i] * (int)listBoxSo.Items[i];
                listBoxSo.Items[i] = k;
            }
        }

        private void buttonSoChan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxSo.Items.Count; i++)
            {
                int k = (int)listBoxSo.Items[i];
                if (k % 2 == 0)
                {
                    listBoxSo.SelectedIndex = i;
                }
                listBoxSo.Items[i] = k;
            }
        }

        private void buttonSoLe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxSo.Items.Count; i++)
            {
                int k = (int)listBoxSo.Items[i];
                if (k % 2 != 0)
                {
                    listBoxSo.SelectedIndex = i;
                }
                listBoxSo.Items[i] = k;
            }
        }

        private void buttonKeThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có đồng ý thoát hay không ?", 
                "Confirm", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
