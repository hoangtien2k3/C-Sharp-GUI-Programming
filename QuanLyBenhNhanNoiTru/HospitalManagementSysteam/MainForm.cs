using QuanLyBenhNhanNoiTru;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSysteam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap form = new FormDangNhap();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormTimKiem form = new FormTimKiem();
            form.MdiParent= this;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormThongTin form= new FormThongTin();
            form.MdiParent = this;
            form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();

        }

        private void pictureBoxHoSo_Click(object sender, EventArgs e)
        {
            FormThongTin form = new FormThongTin();
            form.MdiParent = this;
            form.Show();
        }

        private void pictureBoxBenhNhan_Click(object sender, EventArgs e)
        {
            FormBenhNhan form = new FormBenhNhan(); 
            form.MdiParent = this;  
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBacSi_Click(object sender, EventArgs e)
        {
            FormBacSi form = new FormBacSi();
            form.MdiParent = this;
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBenhAn_Click(object sender, EventArgs e)
        {
            FormHoSo benhAn= new FormHoSo();
            benhAn.MdiParent = this; 
            benhAn.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormBaoCao formBaoCao = new FormBaoCao();
            formBaoCao.ShowDialog();    
        }
    }
}
