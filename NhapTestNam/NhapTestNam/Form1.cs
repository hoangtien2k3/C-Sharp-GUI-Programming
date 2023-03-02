using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapTestNam
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(txtNam.Text);
            int month = int.Parse(txtThang.Text);
            int day = int.Parse(txtNgay.Text);

            int ngaytrongthang = 0;
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    ngaytrongthang = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    ngaytrongthang = 30;
                    break;
                case 2:
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        ngaytrongthang = 29;
                    } else
                    {
                        ngaytrongthang = 28;
                    }
                    break;
            }
            lblKetQua.Text = ngaytrongthang.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
