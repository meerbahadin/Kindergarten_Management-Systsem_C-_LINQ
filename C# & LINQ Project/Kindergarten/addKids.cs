using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Data.Entity;

namespace kindergarten2
{
    public partial class addKids : Form
    {
        public addKids()
        {
            InitializeComponent();
        }

        PreSchoolEntities1 db;

        private void addKidscs_Load(object sender, EventArgs e)
        {
            db = new PreSchoolEntities1();
            var addresses = db.tbl_address;

            foreach (var item in addresses)
            {
                combo_addkids_child_address.Items.Add(item.adrress);
                combo_addkids_child_place_of_birth.Items.Add(item.adrress);
            }
        }

       

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            add_child_birth_place place = new add_child_birth_place();
            place.ShowDialog();
        }




        private void gunaCircleButton4_Click(object sender, EventArgs e)
        {
            add_address address = new add_address();
            address.ShowDialog();
        }

        static string CapitalizeFirst(string s)
        {
            TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
            string output = cultInfo.ToTitleCase(s);
            return output;
        }

        private void btn_addkids_save_Click(object sender, EventArgs e)
        {
            try
            {


                if (!String.IsNullOrWhiteSpace(gunaLineTextBox1.Text))
                {
                    var userId = int.Parse(gunaLineTextBox1.Text);
                    var existingUser = db.tbl_child_info.
                         Where(s => s.id == userId).
                         First();


                    existingUser.child_fullname = CapitalizeFirst(txt_addkids_child_fullname.Text);
                    existingUser.income_date = DateTime.Parse(DateTimePicker_In_come_date.Text);
                    existingUser.id_user_update = userClass.getUserId();
                    existingUser.datetime_update = DateTime.Today; ;
                    existingUser.id_child_address = combo_addkids_child_address.Text;
                    existingUser.child_birthday = DateTime.Parse(DateTimePicker_child_birth_date.Text);
                    existingUser.father_fullname = CapitalizeFirst(txt_addkids_father_fullname.Text);
                    existingUser.mother_fullname = CapitalizeFirst(txt_addkids_mother_fullname.Text);
                    existingUser.father_phone = txt_addkids_father_phone_number.Text;
                    existingUser.mother_phone = txt_addkids_mother_phone_number.Text;
                    existingUser.id_child_place_of_birth = combo_addkids_child_place_of_birth.Text;
                    existingUser.id_child_address = combo_addkids_child_address.Text;
                    existingUser.child_nationality = combo_addkids_child_nationality.Text;
                    existingUser.child_blood_type = combo_addkids_child__blood_type.Text;
                    existingUser.serial_of_child = combo_addkids_serial_of_child.Text;
                    existingUser.child_language = combo_addkids_child_language.Text;
                    existingUser.child_gender = combo_addkids_child_gendar.Text;
                    existingUser.number_of_bro_and_sis = int.Parse(txt_addkids_number_of_bro_sis.Text);
                    existingUser.parent_email = txt_addkids_parent_email.Text;
                    existingUser.name_of_baby_steer = txt_addkids_name_of_baby_steer.Text;
                    existingUser.baby_steer_phone = txt_addkids_baby_steer_phone.Text;

                    db.SaveChangesAsync();
                    MessageBox.Show("Updated Successfully");


                }

                else
                {
                    gunaLineTextBox1.Text = "0";


                    var currentAddressId = db.tbl_address
                       .Where(a => a.adrress == combo_addkids_child_address.Text)
                       .Select(a => a.id)
                       .SingleOrDefault();

                        var birtrhAddressId = db.tbl_address
                       .Where(a => a.adrress == combo_addkids_child_place_of_birth.Text)
                       .Select(a => a.id)
                       .SingleOrDefault();


                var child = new tbl_child_info()

                {
                    child_fullname = CapitalizeFirst(txt_addkids_child_fullname.Text),
                    income_date = DateTime.Parse(DateTimePicker_In_come_date.Text),
                    id_user_save = userClass.getUserId(),
                    datetime_save = DateTime.Today,
                    form_number = int.Parse(txt_addkids_form_number.Text),
         
                    child_birthday = DateTime.Parse(DateTimePicker_child_birth_date.Text),
                    father_fullname = CapitalizeFirst(txt_addkids_father_fullname.Text),
                    mother_fullname = CapitalizeFirst(txt_addkids_mother_fullname.Text),
                    father_phone = txt_addkids_father_phone_number.Text,
                    mother_phone = txt_addkids_mother_phone_number.Text,
                    id_child_place_of_birth = combo_addkids_child_place_of_birth.Text,
                    id_child_address = combo_addkids_child_place_of_birth.Text,
                    child_nationality = combo_addkids_child_nationality.Text,
                    child_blood_type = combo_addkids_child__blood_type.Text,
                    serial_of_child = combo_addkids_serial_of_child.Text,
                    child_language = combo_addkids_child_language.Text,
                    child_gender = combo_addkids_child_gendar.Text,
                    number_of_bro_and_sis = int.Parse(txt_addkids_number_of_bro_sis.Text),
                    parent_email = txt_addkids_parent_email.Text,
                    name_of_baby_steer = txt_addkids_name_of_baby_steer.Text,
                    baby_steer_phone = txt_addkids_baby_steer_phone.Text,

                };

                db.tbl_child_info.Add(child);
                db.SaveChangesAsync();

            MessageBox.Show("New child Added Successfully");
        }


    }
            catch (Exception)
            {

                MessageBox.Show("Some Field Are Required");
            }



        }

        private void btn_addkids_view_Click(object sender, EventArgs e)
        {
            ChildData childData = new ChildData();
            childData.ShowDialog();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            add_child_birth_place place = new add_child_birth_place();
            place.ShowDialog();
        }

        private void btn_addkids_search_Click(object sender, EventArgs e)
        {
            try
            {
                search(int.Parse(gunaLineTextBox1.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("No Record Found");
            }
        }
        public void search(int number)
        {
            //Creatig objct from the database
            db = new PreSchoolEntities1();
            var childData = db.tbl_child_info
                  .Where(s => s.id == number)
                  .FirstOrDefault();

            //The Fields

            txt_addkids_child_fullname.Text = childData.child_fullname;
            txt_addkids_form_number.Text = childData.form_number.ToString();
            combo_addkids_child_gendar.Text = childData.child_gender;
            txt_addkids_father_fullname.Text = childData.father_fullname;
            txt_addkids_mother_fullname.Text = childData.mother_fullname;
            txt_addkids_father_phone_number.Text = childData.father_phone;
            txt_addkids_mother_phone_number.Text = childData.mother_phone;
            combo_addkids_child_language.Text = childData.child_language;
            combo_addkids_child_nationality.Text = childData.child_nationality;
            txt_addkids_parent_email.Text = childData.parent_email;
            txt_addkids_name_of_baby_steer.Text = childData.name_of_baby_steer;
            txt_addkids_baby_steer_phone.Text = childData.baby_steer_phone;
            combo_addkids_serial_of_child.Text = childData.serial_of_child;
            combo_addkids_child__blood_type.Text = childData.child_blood_type;
            txt_addkids_number_of_bro_sis.Text = childData.number_of_bro_and_sis.ToString();

            //Date And Time

            DateTimePicker_In_come_date.Value = childData.income_date;
            DateTimePicker_child_birth_date.Value = childData.child_birthday;


            //Address And Place Of Birth
          
            combo_addkids_child_address.Text = childData.id_child_address;
            combo_addkids_child_place_of_birth.Text = childData.id_child_place_of_birth;

        }

   

        private void combo_addkids_child_address_Enter(object sender, EventArgs e)
        {
            combo_addkids_child_address.Items.Clear();
            db = new PreSchoolEntities1();
            var addresses = db.tbl_address;

            foreach (var item in addresses)
            {
                combo_addkids_child_address.Items.Add(item.adrress);
            }
        }
 
        private void combo_addkids_child_place_of_birth_Enter(object sender, EventArgs e)
        {
            combo_addkids_child_place_of_birth.Items.Clear();
            db = new PreSchoolEntities1();
            var addresses = db.tbl_address;

            foreach (var item in addresses)
            {
                combo_addkids_child_place_of_birth.Items.Add(item.adrress);
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Clear(Controls);
        }

       

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if(Clipboard.ContainsText())
            {
                gunaLineTextBox1.Text = Clipboard.GetText();
            }
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            try
            {

                if (!String.IsNullOrWhiteSpace(gunaLineTextBox1.Text) && gunaLineTextBox1.Text != "0")
                {
                    int childId = int.Parse(gunaLineTextBox1.Text);
                    using (var context = new PreSchoolEntities1())
                    {

                        var childData = context.tbl_child_info.Where(item => item.id == childId).First();
                        var confirmation = MessageBox.Show("Are You Sure About Deleting This Child Data ", "Please Confirm", MessageBoxButtons.YesNo);
                        if (confirmation == DialogResult.Yes)
                        {
                            context.tbl_child_info.Remove(childData);
                            context.SaveChanges();
                            Clear(Controls);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Id In The Search Field");
                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Before You Deeleting This Child Data You Should Remove It From The Room And Other References");
                Clear(Controls);
            }
        }
        void Clear(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                Clear(ctrl.Controls);
            }

            combo_addkids_child_address.SelectedIndex = -1;
            combo_addkids_child_place_of_birth.SelectedIndex = -1;
            combo_addkids_child__blood_type.SelectedIndex = -1;
            combo_addkids_serial_of_child.SelectedIndex = -1;
            combo_addkids_child_gendar.SelectedIndex = -1;
            combo_addkids_child_language.SelectedIndex = -1;
            combo_addkids_child_nationality.SelectedIndex = -1;

            DateTimePicker_child_birth_date.Value = DateTime.Now;
            DateTimePicker_In_come_date.Value = DateTime.Now;
        }
    }
}
