using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kindergarten2
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        PreSchoolEntities1 db;

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_rooms_save_Click(object sender, EventArgs e)
        {
            db = new PreSchoolEntities1();

           if(gunaLineTextBox1.Text == gunaLineTextBox2.Text && !String.IsNullOrWhiteSpace(gunaLineTextBox1.Text))
            {
                db = new PreSchoolEntities1();

                int userId = userClass.getUserId();

                var user = db.tbl_user.Where(x => x.id == userId).FirstOrDefault();

                user.password = gunaLineTextBox1.Text;

                userClass.setUserPassword(user.password);

                db.SaveChangesAsync();

                

                MessageBox.Show("Password Changed Successfully");

                gunaLineTextBox1.Text = null;
                gunaLineTextBox2.Text = null;


            }

           else if((gunaLineTextBox1.Text != gunaLineTextBox2.Text))
            {
                MessageBox.Show("Password Do Not Match");
            }
            else if(String.IsNullOrWhiteSpace(gunaLineTextBox1.Text)) 
            {
                MessageBox.Show("Please Enter Something At First");
            }


        }
    }
}
