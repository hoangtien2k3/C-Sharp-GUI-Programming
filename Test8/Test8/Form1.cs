using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listDanhSach.Items.Add("item6");
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            int dem = listDanhSach.Items.Count;
            MessageBox.Show("Sô Phần tử list Box: " + dem);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listDanhSach.Items[1].ToString());
        }

        private void buttonRemoveAt_Click(object sender, EventArgs e)
        {
            listDanhSach.Items.Remove(0);
        }
    }
}
