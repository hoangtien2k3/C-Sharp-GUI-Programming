using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhap.Text);

            int sum = 0;
            string s = "";

            for(int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    s += i + " ";
                    sum += i;
                }
            }
            lblKetQua.Text = "Số chia hết 3 và lẻ: " + s.ToString() + ", Sum = " + sum.ToString();

        }
    }
}
