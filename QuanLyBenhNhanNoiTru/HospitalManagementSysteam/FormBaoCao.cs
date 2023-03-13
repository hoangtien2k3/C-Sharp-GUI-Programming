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
using HospitalManagementSysteam;
using Microsoft.Reporting.WinForms;

namespace QuanLyBenhNhanNoiTru
{
    public partial class FormBaoCao : Form
    {
        SqlConnection Con = Connection.getConnection();

        public FormBaoCao()
        {
            InitializeComponent();
        }


        DataTable ConnectBacSi()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM BacSi";
                SqlCommand command = new SqlCommand(query, Con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                // BacSiGV.DataSource = dataTable;
                Con.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBenhNhanNoiTru.ReportVienPhi.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = ConnectBacSi();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
