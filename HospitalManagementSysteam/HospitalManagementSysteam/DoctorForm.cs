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
            MainForm h = new MainForm();
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

                string query = "INSERT INTO DoctorTbl(DoctorId, DoctorName, DoctorExperience, DoctorPassword) VALUES(@DoctorId, @DoctorName, @DoctorExperience, @DoctorPassword)";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@DoctorId", DoctorId.Text);
                cmd.Parameters.AddWithValue("@DoctorName", DoctorName.Text);
                cmd.Parameters.AddWithValue("@DoctorExperience", DoctorExperience.Text);
                cmd.Parameters.AddWithValue("@DoctorPassword", DoctorPassword.Text);

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
            DoctorId.Text = DoctorGV.Rows[0].Cells[0].Value.ToString();
            DoctorName.Text = DoctorGV.Rows[0].Cells[1].Value.ToString();
            DoctorExperience.Text = DoctorGV.Rows[0].Cells[2].Value.ToString();
            DoctorPassword.Text = DoctorGV.Rows[0].Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();

            string query = "UPDATE DoctorTbl set DoctorName = @Name, DoctorExperience = @Experience, DoctorPassword = @Password WHERE DoctorId = @Id";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@Name", DoctorName.Text);
            cmd.Parameters.AddWithValue("@Experience", DoctorExperience.Text);
            cmd.Parameters.AddWithValue("@Password", DoctorPassword.Text);
            cmd.Parameters.AddWithValue("@Id", DoctorId.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Doctor Successfully Updated");
            Con.Close();
            populate();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm h = new MainForm();
            h.Show();
        }
    }
}
