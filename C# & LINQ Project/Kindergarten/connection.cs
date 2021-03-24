using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace kindergarten2
{
    public class Connection
    {

        public string ConnectionString = @"Data Source=DESKTOP-KR6Q89B;Initial Catalog=PreSchool;Integrated Security=True";
        SqlConnection con;

        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }


        public void CloseConnection()
        {
            con.Close();
        }
       
    }
}