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

namespace kindergarten2
{
    public partial class add_address : Form
    {
        Connection constr = new Connection();
        public add_address()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_address_Click(object sender, EventArgs e)
        {

            if (address.Text == "")
            {
                MessageBox.Show("Please type something!");
            }
            else
            {
                SqlConnection con = new SqlConnection(constr.ConnectionString);
                SqlCommand nn = new SqlCommand();
                con.Open();
                nn.Connection = con;
                nn.CommandText = "insert into [tbl_address] (adrress) values ('" + address.Text + "')";
                nn.ExecuteNonQuery();
                MessageBox.Show("Added");
                con.Close();
            }
        }
    }
}
