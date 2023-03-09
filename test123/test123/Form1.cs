using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test123
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

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhap.Text);
            int sum = 0;
            List<int> list = new List<int>();
            for(int i = 0; i < n; i++)
            {
                if (i % 3 ==0 && i % 2 != 0)
                {
                    sum += i;

                    list.Add(i);
                }
            }
            lblKetQua.Text = list.ToString();
            
        }
    }
}
