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
    public partial class FormHoSo : Form
    {
        SqlConnection Con = Connection.getConnection();
        public FormHoSo()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm h = new MainForm();
            h.Show();
            this.Hide();
        }

        private void ConnecBenhNhan()
        {
            Con.Open();
            string query = "SELECT * FROM BenhNhan";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            BenhNhanGV.DataSource = dataTable;
            Con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BenhNhanGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void ConnectBacSi()
        {
            Con.Open();
            string query = "SELECT * FROM BacSi";
            SqlCommand command = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            BacSiGV.DataSource = dataTable;
            Con.Close();
        }

        private void BacSiGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        FormBenhNhan formBenhNhan = new FormBenhNhan();
        FormBacSi formBacSi = new FormBacSi();
        private void FormHoSo_Load(object sender, EventArgs e)
        {
            ConnecBenhNhan();
            ConnectBacSi();
        }
    }
}
