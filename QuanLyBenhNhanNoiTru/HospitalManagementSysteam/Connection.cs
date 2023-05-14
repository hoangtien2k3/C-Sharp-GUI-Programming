using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // add thư viện SqlClient.
using HospitalManagementSysteam;

namespace HospitalManagementSysteam
{
    class Connection
    {
        /*
        private static string stringConnection = @"Data Source=DESKTOP-QE5H4U6\SQLEXPRESS;Initial Catalog=QuanLyBenhNhanNoiTru;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
        */

        private static Connection instance;

        private static readonly string stringConnection = @"Data Source=DESKTOP-QE5H4U6\SQLEXPRESS;Initial Catalog=QuanLyBenhNhanNoiTru;Integrated Security=True";

        private Connection() { }

        public static Connection getInstance()
        {
            if (instance == null)
            {
                instance = new Connection();
            }
            return instance;
        }

        public SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
