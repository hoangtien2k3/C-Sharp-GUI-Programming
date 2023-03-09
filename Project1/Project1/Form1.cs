using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int startpos = 0; // vị trí bắt đầu thời gian là 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            Myprogressbar.Value = startpos;
            if (Myprogressbar.Value == 50 ) 
            {
                Myprogressbar.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
