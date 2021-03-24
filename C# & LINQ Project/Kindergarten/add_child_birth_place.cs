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

namespace kindergarten2
{
    public partial class add_child_birth_place : Form
    {
        Connection constr = new Connection();
        public add_child_birth_place()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addkids_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(place.Text))
            {
                MessageBox.Show("Please type something!");
            }
            else
            {
                SqlConnection con = new SqlConnection(constr.ConnectionString);
                SqlCommand nn = new SqlCommand();
                con.Open();
                nn.Connection = con;
                nn.CommandText = "insert into [tbl_address] (adrress) values ('" + place.Text + "')";
                nn.ExecuteNonQuery();
                MessageBox.Show("Added");
                con.Close();
            }
        }
    }
}
