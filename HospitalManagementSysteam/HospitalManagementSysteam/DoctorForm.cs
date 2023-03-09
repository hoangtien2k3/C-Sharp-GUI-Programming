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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagementSysteam
{
    public partial class DoctorForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FUO61S0\SQLEXPRESS02;Initial Catalog=HospitalManagementSysteam;Integrated Security=True");
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }


        void populate()
        {
            Con.Open();
            string query = "SELECT * FROM DoctorTbl";
            SqlCommand command = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DoctorGV.DataSource = dataTable;
            Con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (DoctorId.Text== "" || DoctorName.Text == "" || DoctorPassword.Text == "" || DoctorExperience.Text == "") 
            {
                MessageBox.Show("No Empty Fill Accepted");
            } else
            {
                Con.Open();
                string query = "insert into DoctorTbl values("+DoctorId.Text+", '"+DoctorName.Text+"', "+DoctorExperience.Text+", '"+DoctorPassword.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery(); 
                MessageBox.Show("Doctor Successfully Added");
                Con.Close();
                populate(); // show dữ liệu ra datagridview
            }



        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            DoctorGV.CellContentClick += new DataGridViewCellEventHandler(DoctorGV_CellContentClick);
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DoctorId.Text == "")
            {
                MessageBox.Show("Enter the Doctor Id");
            }else
            {
                Con.Open();

                DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Thông Tin",
                    "Conform",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes) {
                    string query = "DELETE FROM DoctorTbl WHERE DoctorId=" + DoctorId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                }

                Con.Close();
                populate();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Lấy thông tin về ô được chọn
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            DoctorId.Text = DoctorGV.Rows[0].Cells[0].Value.ToString();
            DoctorName.Text = DoctorGV.Rows[0].Cells[1].Value.ToString();
            DoctorExperience.Text = DoctorGV.Rows[0].Cells[2].Value.ToString();
            DoctorPassword.Text = DoctorGV.Rows[0].Cells[3].Value.ToString();



        }
    }
}
