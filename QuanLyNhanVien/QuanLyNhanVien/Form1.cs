using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanVien
{
    public partial class Form1 : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = "";
        SqlDataAdapter adapter= new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata() 
        { 
            command = connection.CreateCommand();
            command.CommandText = "select * from ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
