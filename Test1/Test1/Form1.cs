using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", 
                "Thông Báo", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            try
            {
                int tong;
                Console.WriteLine(txtA.Text);
                Console.WriteLine(txtB.Text);
                Console.WriteLine(txtC.Text);
                tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
                lblKetQua.Text = txtA.Text + "+" + "(" + txtB.Text + ")" + "+" + "(" + txtC.Text + ")" + " = " + tong.ToString();
            } catch(Exception ex)
            {
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                lblKetQua.Text = "";
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }

        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            try
            {
                int hieu;
                Console.WriteLine(txtA.Text);
                Console.WriteLine(txtB.Text);
                Console.WriteLine(txtC.Text);
                hieu = int.Parse(txtA.Text) - int.Parse(txtB.Text) - int.Parse(txtC.Text);
                lblKetQua.Text = txtA.Text + "-" + "(" + txtB.Text + ")" + "-" + "(" + txtC.Text + ")" + " = " + hieu.ToString();
            } catch(Exception ex)
            {
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
             
                lblKetQua.Text = "";
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
            
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            try
            {
                long tich;
                Console.WriteLine(txtA.Text);
                Console.WriteLine(txtB.Text);
                Console.WriteLine(txtC.Text);
                tich = long.Parse(txtA.Text) * long.Parse(txtB.Text) * long.Parse(txtC.Text);
                lblKetQua.Text = txtA.Text + " * " + txtB.Text + " * " + txtC.Text + " = " + tich.ToString();
            } catch(Exception ex)
            {
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                    
                lblKetQua.Text = "";
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
            

        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            try
            {
                double thuong;
                Console.WriteLine(txtA.Text);
                Console.WriteLine(txtB.Text);
                Console.WriteLine(txtC.Text);

                thuong = double.Parse(txtA.Text) / double.Parse(txtB.Text) / double.Parse(txtC.Text);
                lblKetQua.Text = txtA.Text + " / " + txtB.Text + " / " + txtC.Text + " = " + thuong.ToString();

            }
            catch (Exception ex)
            {
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                lblKetQua.Text = "";
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
            
        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = "";
            txtB.Text = "";
            txtA.Text = "";
            txtC.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
           

            if (a == 0)
            {
                if (b == 0)
                {
                    lblKetQua.Text = "Phương trình vô số nghiệm";

                } else
                {
                    lblKetQua.Text = "Phương trình vô nghiệm";
                }
            } else
            {
                double c = (double)-b / a;
                lblKetQua.Text = "x = " + c.ToString();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double x1, x2;
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            double delta = double.Parse(txtB.Text) * double.Parse(txtB.Text) - 4 * double.Parse(txtA.Text) * double.Parse(txtC.Text);
            if (delta < 0)
            {
                x1 = x2 = 0.0;
                lblKetQua.Text = "PT vô nghiệm !";
            }
            else if (delta == 0)
            {
                x1 = x2 = - b/ (2 * a);
                lblKetQua.Text = "x1 = x2 = " + x1.ToString();
            }
            else
            {
                delta = Math.Sqrt(delta);
                x1 = (-b + delta) / (2 * a);
                x2 = (-b - delta) / (2 * a);
                lblKetQua.Text = "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
            }
        }
    }
}
