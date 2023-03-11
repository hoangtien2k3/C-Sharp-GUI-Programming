using Microsoft.AnalysisServices;
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
    public partial class PatientForm : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FUO61S0\SQLEXPRESS02;Initial Catalog=HospitalManagementSysteam;Integrated Security=True");

        public PatientForm()
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
            string query = "SELECT * FROM PatTbl";
            SqlCommand command = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            PatGV.DataSource = datatable;
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatName.Text == "" || PatAddress.Text == "" || PatPhone.Text == "" || PatAge.Text == "" || PatGender.Text == "" || PatBloodGroup.Text == "" || PatMajorDisea.Text == "")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {
                Con.Open();

                string query = "INSERT INTO PatTbl (PatId, PatName, PatAddress, PatPhone, PatAge, PatGender, PatBloodGroup, PatMajorDisea) VALUES (@PatId, @PatName, @PatAddress, @PatPhone, @PatAge, @PatGender, @PatBloodGroup, @PatMajorDisea)";
                SqlCommand command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@PatId", PatId.Text);
                command.Parameters.AddWithValue("@PatName", PatName.Text);
                command.Parameters.AddWithValue("@PatAddress", PatAddress.Text);
                command.Parameters.AddWithValue("@PatPhone", PatPhone.Text);
                command.Parameters.AddWithValue("@PatAge", PatAge.Text);
                command.Parameters.AddWithValue("@PatGender", PatGender.SelectedItem.ToString());
                command.Parameters.AddWithValue("@PatBloodGroup", PatBloodGroup.SelectedItem.ToString());
                command.Parameters.AddWithValue("@PatMajorDisea", PatMajorDisea.Text);
                command.ExecuteNonQuery();
                
                MessageBox.Show("Patient Successfully Added");
                Con.Close();
                populate(); // show dữ liệu ra datagridview
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatGV.Rows[0].Cells[0].Value.ToString();
            PatName.Text = PatGV.Rows[0].Cells[1].Value.ToString();
            PatAddress.Text = PatGV.Rows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatGV.Rows[0].Cells[3].Value.ToString();
            PatAge.Text = PatGV.Rows[0].Cells[3].Value.ToString();
            PatGender.Text = PatGV.Rows[0].Cells[4].Value.ToString();
            PatBloodGroup.Text = PatGV.Rows[0].Cells[5].Value.ToString();
            PatMajorDisea.Text = PatGV.Rows[0].Cells[6].Value.ToString();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
            {
                MessageBox.Show("Enter the Patient Id");
            }
            else
            {
                Con.Open();

                DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Xóa Thông Tin",
                    "Conform",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM PatTbl WHERE PatId = " + PatId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                }

                Con.Close();
                populate();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Con.Open();

            string query = "UPDATE DoctorTbl set PatId = @PatId, PatName = @PatName, PatAddress = @PatAddress, PatPhone = @PatPhone, PatAge = @PatAge, PatGender = @PatGender, PatBloodGroup = @PatBloodGroup WHERE PatId = @PatId";
            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@PatId", PatId.Text);
            command.Parameters.AddWithValue("@PatName", PatName.Text);
            command.Parameters.AddWithValue("@PatAddress", PatAddress.Text);
            command.Parameters.AddWithValue("@PatPhone", PatPhone.Text);
            command.Parameters.AddWithValue("@PatAge", PatAge.Text);
            command.Parameters.AddWithValue("@PatGender", PatGender.SelectedItem.ToString());
            command.Parameters.AddWithValue("@PatBloodGroup", PatBloodGroup.SelectedItem.ToString());
            command.Parameters.AddWithValue("@PatMajorDisea", PatMajorDisea.Text);
            command.ExecuteNonQuery();

            MessageBox.Show("Patient Successfully Updated");
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
