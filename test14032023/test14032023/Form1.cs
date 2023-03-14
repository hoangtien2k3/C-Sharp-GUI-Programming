using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test14032023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoCong_CheckedChanged(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text.Trim());
            int b = int.Parse(txtSo2.Text.Trim());


            if (rdoCong.Checked == true)
            {
                int c = a + b;
                txtKetQua.Text = c.ToString();
            } else if (rdoTru.Checked == true)
            {
                int c = a - b;
                txtKetQua.Text = c.ToString();
            } 
            
            if (rdoNhan.Checked == true)
            {
                int c = a * b;
                txtKetQua.Text = c.ToString();
            } else if (rdoChia.Checked == true)
            {
                int c = a / b;
                txtKetQua.Text = c.ToString();
            }

        }
    }
}
