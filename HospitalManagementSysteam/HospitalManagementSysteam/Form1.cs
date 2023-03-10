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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private bool IsValidUser(string username, string password)
        {
            // Kiểm tra xem username và password có hợp lệ hay không
            return (username == "admin" && password == "password"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (IsValidUser(username, password))
            {
                // Đăng nhập thành công
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                // Hiển thị thông báo lỗi
                if (username != "admin" && password != "password") {
                    DialogResult result = MessageBox.Show("Error Username and Password", "Login Againt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                } else if (username != "admin")
                {
                    DialogResult result = MessageBox.Show("Error Username.", "Login Againt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                } else
                {
                    DialogResult result = MessageBox.Show("Error Password.", "Login Againt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
