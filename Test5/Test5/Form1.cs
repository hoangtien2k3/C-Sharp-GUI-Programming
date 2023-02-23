using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = txtNhapTen.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(lblOutput.Font.Name, 
                lblOutput.Font.Size, 
                lblOutput.Font.Style ^FontStyle.Underline);


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void chkInDam_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(
                lblOutput.Font.Name, // 
                lblOutput.Font.Size,
                lblOutput.Font.Style ^ FontStyle.Bold);

        }

        private void chkInNghiem_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(lblOutput.Font.Name, 
                lblOutput.Font.Size, 
                lblOutput.Font.Style ^FontStyle.Italic);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Muốn Thoát ?", 
                "Confirm", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // radRed.Checked = true;
            // chkInDam.Checked = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked == true)
            {
                lblOutput.ForeColor = radRed.ForeColor;
            }

        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if(radGreen.Checked)
            {
                lblOutput.ForeColor = radGreen.ForeColor;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if(radBlue.Checked == true)
            {
                lblOutput.ForeColor = radBlue.ForeColor;    
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if(radBlack.Checked) {
                lblOutput.ForeColor = radBlack.ForeColor;   
            }
        }
    }
}
