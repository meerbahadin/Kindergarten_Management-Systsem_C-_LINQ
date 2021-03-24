using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kindergarten2
{
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
        }
        PreSchoolEntities1 db;
        int gbActivityId;

        private void teacher_Load(object sender, EventArgs e)
        {
            db = new PreSchoolEntities1();

            var rooms = db.tbl_room_name;

            foreach (var item in rooms)
            {
                combo_teacher_room_name.Items.Add(item.room_name);
            }


            view();

        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_teacher_save_Click(object sender, EventArgs e)
        {
            db = new PreSchoolEntities1();

            var roomId = db.tbl_room_name
                       .Where(items => items.room_name == combo_teacher_room_name.Text)
                       .Select(a => a.id)
                       .FirstOrDefault();

            var newActivity = new tbl_subject_activity()
            {
                subject = txt_subject_subjectName.Text,
                date = gunaDateTimePicker1.Value,
                note = not_teacher_subject.Text,
                datetime_save = DateTime.Now,
                id_user_save = userClass.getUserId(),
                id_room_name = roomId

            };

            db.tbl_subject_activity.Add(newActivity);
            db.SaveChangesAsync();
            MessageBox.Show("New Activity Added");
        }
        void view()
        {
            db = new PreSchoolEntities1();
            var activityData = db.tbl_subject_activity.Join(
             db.tbl_room_name,
             teacher => teacher.id_room_name,
             roomName => roomName.id,
             (subject, room) => new
             {
                 id = subject.id,
                 Subject = subject.subject,
                 RoomName = room.room_name,
                 Savedate = subject.date,
                 userId = subject.id_user_save,
                 teacherNote = subject.note

             }
         )
         .Join(
               db.tbl_user,
               subject => subject.userId,
               user => user.id,
                (table1, user) => new
                {
                    Id = table1.id,
                    Subject = table1.Subject,
                    Date = table1.Savedate,
                    RoomName = table1.RoomName,
                    Teacher = user.User_fullname,
                    Note = table1.teacherNote
                }

          )
         .ToList();
            dataGridView1.DataSource = activityData;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellData = dataGridView1.Rows;
            if (cellData != null)
            {
                try
                {
                    gbActivityId = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string subject = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string date = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    string roomname = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    string note = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();


                    txt_subject_subjectName.Text = subject;
                    gunaDateTimePicker1.Value = DateTime.Parse(date);
                    combo_teacher_room_name.Text = roomname;
                    not_teacher_subject.Text = note;


                }
                catch (Exception)
                {

                    MessageBox.Show("Please Select The Entire Row");
                }


            }
        }

        private void btn_rooms_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (gbActivityId > 0)
                {
                    db = new PreSchoolEntities1();
                    var activity = db.tbl_subject_activity.Where(item => item.id == gbActivityId).First();


                    var roomId = db.tbl_room_name
                        .Where(items => items.room_name == combo_teacher_room_name.Text)
                        .Select(a => a.id)
                        .FirstOrDefault();


                    activity.datetime_update = DateTime.Now;
                    activity.id_user_update = userClass.getUserId();
                    activity.date = gunaDateTimePicker1.Value;
                    activity.id_room_name = roomId;
                    activity.subject = txt_subject_subjectName.Text;
                    activity.note = not_teacher_subject.Text;



                    db.SaveChangesAsync();

                    view();
                    clear();


                }
                else if (gbActivityId == 0 && combo_teacher_room_name.SelectedIndex != -1 && !String.IsNullOrWhiteSpace(txt_subject_subjectName.Text) && !String.IsNullOrWhiteSpace(not_teacher_subject.Text))
                {
                    db = new PreSchoolEntities1();

                    var roomId = db.tbl_room_name
                        .Where(items => items.room_name == combo_teacher_room_name.Text)
                        .Select(a => a.id)
                        .FirstOrDefault();


                    var newActivity= new tbl_subject_activity()
                    {
                        datetime_save = DateTime.Now,
                        id_user_save = userClass.getUserId(),
                        id_room_name = roomId,
                        date = gunaDateTimePicker1.Value,
                        subject = txt_subject_subjectName.Text,
                        note = not_teacher_subject.Text,
                    };

                    db.tbl_subject_activity.Add(newActivity);
                    db.SaveChangesAsync();

                    view();
                    clear();
                }
                else
                {
                    MessageBox.Show("Please Select Some Data To Edit Or Add New Data");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error Adding New Subject Activity");
            }
        }

        void clear()
        {
            txt_subject_subjectName.Text = null;
            gunaDateTimePicker1.Value = DateTime.Now;
            combo_teacher_room_name.SelectedIndex = -1;
            not_teacher_subject.Text = null;
            gbActivityId = 0;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_rooms_delete_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_rooms_delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (gbActivityId > 0)
                {
                    using (var context = new PreSchoolEntities1())
                    {

                        var activity = context.tbl_subject_activity.Where(item => item.id == gbActivityId).First();
                        var confirmation = MessageBox.Show("Are You Sure About Deleting This Child In This Activity ?", "Please Confirm", MessageBoxButtons.YesNo);
                        if (confirmation == DialogResult.Yes)
                        {
                            context.tbl_subject_activity.Remove(activity);
                            context.SaveChanges();
                        }
                    }

                    view();
                    clear();
                }
                else
                {
                    MessageBox.Show("Please Select A Row To Delete");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error Deleting Room Data");
            }
        }

    }
}
