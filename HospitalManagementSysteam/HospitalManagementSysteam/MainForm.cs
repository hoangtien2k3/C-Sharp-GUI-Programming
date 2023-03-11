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
            FormThongTin form = new FormThongTin();
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
            PatientForm form = new PatientForm(); // form con
            form.MdiParent = this;  
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBacSi_Click(object sender, EventArgs e)
        {
            DoctorForm form = new DoctorForm();
            form.MdiParent = this;
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBenhAn_Click(object sender, EventArgs e)
        {
            BenhAn benhAn= new BenhAn();
            benhAn.MdiParent = this; 
            benhAn.Show();
        }
    }
}
