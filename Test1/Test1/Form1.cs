using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " + " + txtB.Text + " = " + tong.ToString();
        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            hieu = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " - " + txtB.Text + " = " + hieu.ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            long tich;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);
            tich = long.Parse(txtA.Text) * long.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " * " + txtB.Text + " = " + tich.ToString();

        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            double thuong;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);

            thuong = double.Parse(txtA.Text) / double.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " / " + txtB.Text + " = " + thuong.ToString();

        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = "";
            txtB.Text = "";
            txtA.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
