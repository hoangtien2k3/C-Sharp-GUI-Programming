using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSysteam
{
    public partial class FormMain : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FUO61S0\SQLEXPRESS02;Initial Catalog=HospitalManagementSysteam;Integrated Security=True");

        void populate()
        {
            Con.Open();

            string query = "Select * From MabenhanTbl";
            SqlCommand command = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            FormMainGV.DataSource = data;

            Con.Close();
        }


        public FormMain()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
