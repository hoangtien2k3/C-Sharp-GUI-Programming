using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // add thư viện SqlClient.

namespace HospitalManagementSysteam
{
    class Connection
    {
        // chuỗi kết nối
        // private static string stringConnection = @"Data Source=DESKTOP-FUO61S0\SQLEXPRESS02;Initial Catalog=HospitalManagementSysteam;Integrated Security=True";

        private static string stringConnection = @"Data Source=DESKTOP-FUO61S0\SQLEXPRESS02;Initial Catalog=QuanLyBenhNhanNoiTru;Integrated Security=True";

        // phương thức getConnection() để tạo đối tượng SqlConnection kết nối với Sql Server.
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
