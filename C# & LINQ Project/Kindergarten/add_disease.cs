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
    public partial class add_disease : Form
    {
        
        public add_disease()
        {
            InitializeComponent();
        }

        PreSchoolEntities1 db;

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addkids_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(diseasse.Text))
            {
                MessageBox.Show("Please type something!");
            }
            else
            {
                try
                {
                    db = new PreSchoolEntities1();
                    int userId = userClass.getUserId();
                    var newDisease = new tbl_disease_type()
                    {
                        name_disease = diseasse.Text,
                        id_user_save = userId,
                    };

                    db.tbl_disease_type.Add(newDisease);

                    db.SaveChanges();

                    MessageBox.Show("New Disease Added");
                }
                catch (Exception)
                {

                    MessageBox.Show("Error Adding New Data");
                }
            }
        }
    }
}
