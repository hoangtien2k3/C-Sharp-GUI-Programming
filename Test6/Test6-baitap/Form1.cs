using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Test6_baitap
{
    public partial class Form1 : Form
    {
        private SoundPlayer choiNhac;
        public Form1()
        {
            InitializeComponent();
            choiNhac = new SoundPlayer(@"D:\Code Java\C-Sharp-GUI-Programming\Test6\pic-nang-ta\nhactap.wav");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát ?", 
                "Xác Nhận",
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            buttonClick.Text = textBoxInput.Text;
            // kiểm tra xem bức ảnh được hiện hay không.
            if (pictureBoxHaTa.Visible == false)
            {
                buttonClick.Text = textBoxInput.Text + " ! Click để Hạ tạ đi.";
            } else
            {
                buttonClick.Text = textBoxInput.Text + " ! Click để Nâng tạ đi.";
            }
        }

        int count = 1;
        private void buttonClick_Click(object sender, EventArgs e)
        {
            if (pictureBoxHaTa.Visible == false)
            {
                pictureBoxHaTa.Visible = true;
                pictureBoxNangTa.Visible = false;
                buttonClick.Text = buttonClick.Text.Replace("Hạ", "Nâng");
                labelCount.Text = count.ToString();
                count++;
                if (count == 11)
                {
                    DialogResult result = MessageBox.Show("Bạn Đã Tập Mệt Rồi, Có Nâng Tiếp Không", 
                        "Confirm", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        Close();
                    }
                }
            } else
            {
                pictureBoxHaTa.Visible = false;
                pictureBoxNangTa.Visible = true;
                buttonClick.Text = buttonClick.Text.Replace("Nâng", "Hạ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxHaTa.Visible = false;
            pictureBoxNangTa.Visible = true;

        }

        private void checkBoxMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMusic.Checked == true)
            {
                choiNhac.Play();
            } else
            {
                choiNhac.Stop();
            }
        }
    }
}
