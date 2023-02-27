using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test8_baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(textBoxMa.Text);
            sv.Ten = textBoxTen.Text;
            string s = sv.Ma + " - " + sv.Ten;
            listBoxDS.Items.Add(s);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            listBoxDS.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
