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
    public partial class childHealth : Form
    {
        public childHealth()
        {
            InitializeComponent();
        }

        PreSchoolEntities1 db;

        private void gunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaWinSwitch1.Checked)
            {
                not_childHealth_surgery.Visible = true;
                gunaLabel12.Visible = true;

            } else
            {
                not_childHealth_surgery.Visible = false;
                gunaLabel12.Visible = false;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void gunaCircleButton4_Click(object sender, EventArgs e)
        {
            add_disease disease = new add_disease();
            disease.ShowDialog();
        }



        private void childHealth_Load(object sender, EventArgs e)
        {
            db = new PreSchoolEntities1();
            var childs = db.tbl_child_info;

            foreach (var item in childs)
            {
                combo_childHealth_child_name.Items.Add(item.child_fullname);
            }

            fillDisease();
        }

        private void combo_childHealth_child_disease_Click(object sender, EventArgs e)
        {
            fillDisease();
        }

        void fillDisease()
        {
            combo_childHealth_child_disease.Items.Clear();
            var disease = db.tbl_disease_type;
            foreach (var item in disease)
            {
                combo_childHealth_child_disease.Items.Add(item.name_disease);
            }
        }

        private void btn_addkids_view_Click(object sender, EventArgs e)
        {
            HealthData healthData = new HealthData();
            healthData.Show();
        }

        private void btn_addkids_save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(gunaLineTextBox1.Text) || gunaLineTextBox1.Text == "0")
            {
                db = new PreSchoolEntities1();
                var childId = db.tbl_child_info.Where(items => items.child_fullname == combo_childHealth_child_name.Text)
                                .Select(a => a.id).FirstOrDefault();

                var diseaseId = db.tbl_disease_type.Where(items => items.name_disease == combo_childHealth_child_disease.Text)
                          .Select(a => a.id).FirstOrDefault();

                var newHealth = new tbl_child_healthy()
                {
                    id_child = childId,
                    id_child_disease_type = diseaseId,
                    have_surgery = gunaWinSwitch1.Checked,
                    drug_allergy = txt_childHealth_drug_allergy.Text,
                    darmany_naxoshiya_drezhxayanaka = txt_childHealth_chronic_candition_cure.Text,
                    general_clinic_test_disease_type = disease_type_txt.Text,
                    general_clinic_test_disease_type_note = not_childHealth_surgery.Text,
                    face_type = txt_childHealth_face_type.Text,
                    food_eating_type = txt_childHealth_foot_eating_type.Text,
                    child_height = txt_childHealth_child_height.Text,
                    child_weight = txt_childHealth_child_weight.Text,
                    note_of_surgery = not_childHealth_surgery.Text,
                    id_user_save = userClass.getUserId(),
                    datetime_save = DateTime.Now


                };

                db.tbl_child_healthy.Add(newHealth);
                db.SaveChanges();

                MessageBox.Show("New Health Data Added");
            } else
            {
                db = new PreSchoolEntities1();

                int healthId = int.Parse(gunaLineTextBox1.Text);

                var childId = db.tbl_child_info.Where(items => items.child_fullname == combo_childHealth_child_name.Text)
                              .Select(a => a.id).FirstOrDefault();
                var diseaseId = db.tbl_disease_type.Where(items => items.name_disease == combo_childHealth_child_disease.Text)
                           .Select(a => a.id).FirstOrDefault();


                var healthData = db.tbl_child_healthy.Where(items => items.id == healthId).FirstOrDefault();

                healthData.id_child = childId;
                healthData.id_child_disease_type = diseaseId;
                healthData.have_surgery = gunaWinSwitch1.Checked;
                healthData.drug_allergy = txt_childHealth_drug_allergy.Text;
                healthData.darmany_naxoshiya_drezhxayanaka = txt_childHealth_chronic_candition_cure.Text;
                healthData.general_clinic_test_disease_type = disease_type_txt.Text;
                healthData.general_clinic_test_disease_type_note = not_childHealth_surgery.Text;
                healthData.face_type = txt_childHealth_face_type.Text;
                healthData.food_eating_type = txt_childHealth_foot_eating_type.Text;
                healthData.child_height = txt_childHealth_child_height.Text;
                healthData.child_weight = txt_childHealth_child_weight.Text;
                healthData.note_of_surgery = not_childHealth_surgery.Text;
                healthData.id_user_save = userClass.getUserId();
                healthData.datetime_save = DateTime.Now;

                db.SaveChanges();

                MessageBox.Show("Updated Successfully");


            }
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            try
            {
             
                if (!String.IsNullOrWhiteSpace(gunaLineTextBox1.Text) && gunaLineTextBox1.Text != "0")
                {
                    int healthId = int.Parse(gunaLineTextBox1.Text);
                    using (var context = new PreSchoolEntities1())
                    {

                        var healthData = context.tbl_child_healthy.Where(item => item.id == healthId).First();
                        var confirmation = MessageBox.Show("Are You Sure About Deleting This Child In This Room ", "Please Confirm", MessageBoxButtons.YesNo);
                        if (confirmation == DialogResult.Yes)
                        {
                            context.tbl_child_healthy.Remove(healthData);
                            context.SaveChanges();
                            clear();
                        }
                    }
                } else
                {
                    MessageBox.Show("No Id In The Search Field");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error Deleting Health Data");
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                gunaLineTextBox1.Text = Clipboard.GetText();
            }
        }

        private void btn_addkids_search_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(gunaLineTextBox1.Text) && gunaLineTextBox1.Text != "0")
            {

                try
                {
                    search(gunaLineTextBox1.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Done" + ex.Message);
                }
            
            } else
            {
                MessageBox.Show("Plase Copy An Id From The View");
            }


        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            combo_childHealth_child_name.SelectedIndex = -1;
            combo_childHealth_child_disease.SelectedIndex = -1;

            txt_childHealth_drug_allergy.Text = null;
            disease_type_txt.Text = null;
            not_childHealth_general_clinic_test.Text = null;
            not_childHealth_surgery.Text = null;
            txt_childHealth_face_type.Text = null;
            txt_childHealth_child_weight.Text = null;
            txt_childHealth_child_height.Text = null;
            txt_childHealth_foot_eating_type.Text = null;

            gunaWinSwitch1.Checked = false;

            gunaLineTextBox1.Text = null;
        } 
        void search(string txt)
        {
            db = new PreSchoolEntities1();
            int healthId = int.Parse(txt);
            var healthData = db.tbl_child_healthy
                  .Where(s => s.id == healthId)
                  .FirstOrDefault();

            decimal childId = healthData.id_child;



            var child = db.tbl_child_info.Where(
                x => x.id == childId
                ).Select(a => a.child_fullname)
                .FirstOrDefault();



            decimal diseaseId = Convert.ToInt32(healthData.id_child_disease_type);

            var disease = db.tbl_disease_type.Where(
                x => x.id == diseaseId
                ).Select(a => a.name_disease)
                .FirstOrDefault();



            combo_childHealth_child_name.Text = child;
            combo_childHealth_child_disease.Text = disease;

            txt_childHealth_drug_allergy.Text = healthData.drug_allergy;
            disease_type_txt.Text = healthData.general_clinic_test_disease_type;
            not_childHealth_general_clinic_test.Text = healthData.general_clinic_test_disease_type_note;
            not_childHealth_surgery.Text = healthData.note_of_surgery;
            txt_childHealth_chronic_candition_cure.Text = healthData.darmany_naxoshiya_drezhxayanaka;
            txt_childHealth_face_type.Text = healthData.face_type;
            txt_childHealth_child_weight.Text = healthData.child_weight;
            txt_childHealth_child_height.Text = healthData.child_height;
            txt_childHealth_foot_eating_type.Text = healthData.food_eating_type;

            if (healthData.have_surgery == true)
            {
                gunaWinSwitch1.Checked = true;
            }
        }
    }
}
