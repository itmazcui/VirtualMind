using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMData.Settings
{
    public class Connection
    {
        private SqlConnection Conn = new SqlConnection("workstation id=virtualmind.mssql.somee.com;packet size=4096;user id=mazcui_SQLLogin_1;pwd=yptgghdqdw;data source=virtualmind.mssql.somee.com;persist security info=False;initial catalog=virtualmind;");

        public SqlConnection OpenConnection()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            return Conn;
        }

        public SqlConnection CloseConnection()
        {
            if (Conn.State == ConnectionState.Open)
                Conn.Close();

            return Conn;
        }

    }
}
