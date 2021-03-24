using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Globalization;

namespace kindergarten2
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        PreSchoolEntities1 db;
        int userId;


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

 

        private void btn_addkids_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(userId > 0)
                {
                    using (var context = new PreSchoolEntities1())
                    {
                      
                        var user = context.tbl_user.Where(item => item.id == userId).First();
                        var confirmation = MessageBox.Show("Are You Sure About Deleting " + user.User_fullname +  "?", "Please Confirm", MessageBoxButtons.YesNo);
                        if(confirmation == DialogResult.Yes)
                        {
                            context.tbl_user.Remove(user);
                            context.SaveChanges();
                        }
                    }

                    view();
                    clear();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please Select A Field You Want To Delete");
            }
        }

        private void user_Load(object sender, EventArgs e)
        {
            view();
        }

        void view()
        {
            db = new PreSchoolEntities1();
            db.tbl_user.Load();
            dataGridView1.DataSource = db.tbl_user.Local.ToBindingList();
        }
       

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            clear();

        }


        void clear()
        {
            txt_user_username.Text = null;
            txt_user_password.Text = null;
            txt_user_userFullname.Text =  null;
            combo_role.SelectedIndex = -1;
            gunaCheckBox1.Checked = false;
            userId = 0;

        }

   
    

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
           
            using (var context = new PreSchoolEntities1())
            {
                if(userId > 0 && !String.IsNullOrWhiteSpace(txt_user_userFullname.Text) &&
                    !String.IsNullOrWhiteSpace(txt_user_username.Text) &&
                      !String.IsNullOrWhiteSpace(txt_user_username.Text))
                {
                    var user = context.tbl_user.Where(item => item.id == userId).First();

                    user.User_fullname = CapitalizeFirst(txt_user_userFullname.Text);
                    user.User_Role = combo_role.Text;
                    user.password = txt_user_password.Text;
                    user.username = txt_user_username.Text;
                    user.status = gunaCheckBox1.Checked;

                    context.SaveChanges();

                } else if (userId == 0 && !String.IsNullOrWhiteSpace(txt_user_userFullname.Text) &&
                    !String.IsNullOrWhiteSpace(txt_user_username.Text) &&
                      !String.IsNullOrWhiteSpace(txt_user_username.Text))
                 {
                    var newUser = new tbl_user() {
                        User_fullname = CapitalizeFirst(txt_user_userFullname.Text),
                        User_Role = combo_role.Text,
                        password = txt_user_password.Text,
                        username = txt_user_username.Text,
                        status = gunaCheckBox1.Checked,

                    };

                    context.tbl_user.Add(newUser);
                    context.SaveChanges();
                }
                

                    
            else {
                    MessageBox.Show("Plese Enter Valid Fields");
                }
               
            }

            view();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellData = dataGridView1.SelectedCells[0].Value.ToString();
            if (!String.IsNullOrWhiteSpace(cellData))
            {
                try
                {
                    var id = int.Parse(cellData);
                    db = new PreSchoolEntities1();
                    var user = db.tbl_user
                          .Where(s => s.id == id)
                          .FirstOrDefault();
                    txt_user_userFullname.Text = user.User_fullname;
                    txt_user_password.Text = user.password;
                    txt_user_username.Text = user.username;
                    combo_role.Text = user.User_Role;
                    userId = int.Parse(user.id.ToString());


                    if (user.status == true)
                    {
                        gunaCheckBox1.Checked = true;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Please Select The Id");
                }


            }
        }

        static string CapitalizeFirst(string s)
        {
            TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
            string output = cultInfo.ToTitleCase(s);
            return output;
        }
    }
}
