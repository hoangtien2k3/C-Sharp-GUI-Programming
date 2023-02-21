using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WinFormExmaple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, x;
                bool checkA, checkB;

                checkA = float.TryParse(txtA.Text, out a);
                if (!checkA)
                {
                    MessageBox.Show("Hệ số a không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtA.Clear();
                    txtA.Focus();
                    return;
                }

                checkB = float.TryParse(txtB.Text, out b);
                if (!checkB)
                {
                    MessageBox.Show("Hệ số B không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtB.Clear();
                    txtB.Focus();
                    return;
                }

                a = float.Parse(txtA.Text);
                b = float.Parse(txtB.Text);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        txtKQ.Text = "Phương trình vô số nghiệm.";
                    }
                    else
                    {
                        txtKQ.Text = "Phương trình vô nghiệm.";
                    }
                }
                else
                {
                    x = (float)-b / a;
                    txtKQ.Text = x.ToString();
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo"); 
            }
            
        }
    }
}
