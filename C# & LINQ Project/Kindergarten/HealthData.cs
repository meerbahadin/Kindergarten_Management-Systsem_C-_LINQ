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
    public partial class HealthData : Form
    {
        public HealthData()
        {
            InitializeComponent();
        }
        PreSchoolEntities1 db;
        private void HealthData_Load(object sender, EventArgs e)
        {
            db = new PreSchoolEntities1();
            var healthData = db.tbl_child_healthy.Join(
                db.tbl_child_info,
                x => x.id_child,
                y => y.id,
                 (health, child) => new
                 {

                     id = health.id,
                     child_name = child.child_fullname,
                     drug_algeric = health.drug_allergy,
                     coronic_cure = health.darmany_naxoshiya_drezhxayanaka,
                     surgery = health.have_surgery,
                     disease_id_name = health.id_child_disease_type,
                     surgery_note = health.note_of_surgery,
                     clinic_type = health.general_clinic_test_disease_type,
                     clinic_type_note = health.general_clinic_test_disease_type_note,
                     face_type = health.face_type,
                     height = health.child_height,
                     weight = health.child_weight,
                     food_type = health.food_eating_type,
                     dateSave = health.datetime_save,
                     dateUpdate = health.datetime_update,



                 }).
                // Join(
                //db.tbl_disease_type,
                //x => x.disease_id_name,
                //y => y.id,
                //(tbl1, disease) => new
                //{
                //    //id = tbl1.id,
                //    //ChildName = tbl1.child_name,
                //    //DrugAlergic = tbl1.drug_algeric,
                //    //Surgery = tbl1.surgery,
                //    //SurgeryNote = tbl1.surgery_note,
                //    //CorinicCure = tbl1.coronic_cure,
                //    //ClinicType = tbl1.clinic_type,
                //    //ClinicNote = tbl1.clinic_type_note,
                //    //Heigth = tbl1.height,
                //    //Weight = tbl1.weight,
                //    //FoodType = tbl1.food_type,
                //    //Disease = disease.name_disease,
                //    //SavedAt = tbl1.dateSave,
                //    //LastUpdate = tbl1.dateUpdate,

                //}
                //).
                ToList();

            dataGridView1.DataSource = healthData;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void btn_addkids_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(gunaLineTextBox1.Text))
            {
                MessageBox.Show("Plase Enter Something To Search");
            }
            else {
                search(gunaLineTextBox1.Text);
            }
        }

        void search(string txt)
        {
            db = new PreSchoolEntities1();
            var healthData = db.tbl_child_healthy.Join(
                db.tbl_child_info,
                x => x.id_child,
                y => y.id,
                 (health, child) => new
                 {

                     id = health.id,
                     child_name = child.child_fullname,
                     drug_algeric = health.drug_allergy,
                     coronic_cure = health.darmany_naxoshiya_drezhxayanaka,
                     surgery = health.have_surgery,
                     disease_id_name = health.id_child_disease_type,
                     surgery_note = health.note_of_surgery,
                     clinic_type = health.general_clinic_test_disease_type,
                     clinic_type_note = health.general_clinic_test_disease_type_note,
                     face_type = health.face_type,
                     height = health.child_height,
                     weight = health.child_weight,
                     food_type = health.food_eating_type,
                     dateSave = health.datetime_save,
                     dateUpdate = health.datetime_update,



                 }).Join(
                db.tbl_disease_type,
                x => x.disease_id_name,
                y => y.id,
                (tbl1, disease) => new
                {
                    id = tbl1.id,
                    ChildName = tbl1.child_name,
                    DrugAlergic = tbl1.drug_algeric,
                    Surgery = tbl1.surgery,
                    SurgeryNote = tbl1.surgery_note,
                    CorinicCure = tbl1.coronic_cure,
                    ClinicType = tbl1.clinic_type,
                    ClinicNote = tbl1.clinic_type_note,
                    Heigth = tbl1.height,
                    Weight = tbl1.weight,
                    FoodType = tbl1.food_type,
                    Disease = disease.name_disease,
                    SavedAt = tbl1.dateSave,
                    LastUpdate = tbl1.dateUpdate,

                }
                )
                 .Where(
                  x => x.ChildName.Contains(txt)
                ).ToList();

            dataGridView1.DataSource = healthData;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dataGridView1.SelectedCells[0].Value.ToString();
            if (!String.IsNullOrWhiteSpace(data))
            {
                Clipboard.SetText(data.ToString());
            }
            gunaLabel1.Text = "You Copied " + data;
        }
        void view()
        {
            db = new PreSchoolEntities1();
            
        }
    }
}
