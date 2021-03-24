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
    public partial class nurse : Form
    {
        public nurse()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        PreSchoolEntities1 db;
        int gbNurseId;

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void nurse_Load(object sender, EventArgs e)
        {
            db = new PreSchoolEntities1();
            var childs = db.tbl_child_info;

            var roomName = db.tbl_room_name;

            foreach (var item in childs)
            {
                combo_nurse_child_name.Items.Add(item.child_fullname);
            }

            foreach (var item in roomName)
            {
                combo_nurse_room_name.Items.Add(item.room_name);
            }

            view();
        }

        void view()
        {
            var nurseData = db.tbl_nurse.Join(
            db.tbl_child_info,
            nurse => nurse.id_child,
            child => child.id,
            (nurse, child) => new
            {
                id = nurse.id,
                childName = child.child_fullname,
                roomId = nurse.id_room_name,
                note = nurse.note
            }
        ).Join(
              db.tbl_room_name,
              room => room.roomId,
              roomName => roomName.id,
               (table1, roomName) => new
               {
                   Id = table1.id,
                   ChildName = table1.childName,
                   RoomName = roomName.room_name,
                   Note = table1.note
               }

         ).ToList();
            dataGridView1.DataSource = nurseData;
        }

        private void btn_nurse_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (gbNurseId > 0)
                {
                    db = new PreSchoolEntities1();
                    var nurse = db.tbl_nurse.Where(item => item.id == gbNurseId).First();
                    int userId = userClass.getUserId();

                    var childId = db.tbl_child_info.Where(items => items.child_fullname == combo_nurse_child_name.Text)
                   .Select(a => a.id)
                   .FirstOrDefault();

                    var roomId = db.tbl_room_name
                        .Where(items => items.room_name == combo_nurse_room_name.Text)
                        .Select(a => a.id)
                        .FirstOrDefault();

                    nurse.id_child = childId;
                    nurse.id_user_update = userId;
                    nurse.id_room_name = roomId;
                    nurse.note = not_nurse.Text;
                    nurse.datetime_update = DateTime.Now;

                    db.SaveChanges();

                    view();
                    clear();


                }
                else if (gbNurseId == 0 && combo_nurse_room_name.SelectedIndex != -1 && combo_nurse_room_name.SelectedIndex != -1)
                {
                    db = new PreSchoolEntities1();
                    var childId = db.tbl_child_info.Where(items => items.child_fullname == combo_nurse_child_name.Text)
                   .Select(a => a.id)
                   .FirstOrDefault();

                    var roomId = db.tbl_room_name
                        .Where(items => items.room_name == combo_nurse_room_name.Text)
                        .Select(a => a.id)
                        .FirstOrDefault();

                    int userId = userClass.getUserId();
                    var newNurse = new tbl_nurse()
                    {
                        id_child = childId,
                        id_user_save = userId,
                        id_room_name = roomId,
                        note = not_nurse.Text,
                        datetime_save = DateTime.Now
                    };

                    db.tbl_nurse.Add(newNurse);
                    db.SaveChanges();

                    view();
                    clear();
                }
                else
                {
                    MessageBox.Show("Please Select Some Data To Edit Or Add New Data");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Adding New Data" + ex.Message);
            }

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            not_nurse.Text = null;
            combo_nurse_child_name.SelectedIndex = -1;
            combo_nurse_room_name.SelectedIndex = -1;
            gbNurseId = 0;
        }

        private void btn_rooms_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gbNurseId > 0)
                {
                    using (var context = new PreSchoolEntities1())
                    {

                        var nurseData = context.tbl_nurse.Where(item => item.id == gbNurseId).First();
                        var confirmation = MessageBox.Show("Are You Sure About Deleting This Data ?", "Please Confirm", MessageBoxButtons.YesNo);
                        if (confirmation == DialogResult.Yes)
                        {
                            context.tbl_nurse.Remove(nurseData);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellData = dataGridView1.Rows;
            if (cellData != null)
            {
                try
                {
                    gbNurseId = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string childName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string roomName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    string note = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();


                    combo_nurse_child_name.Text = childName;
                    combo_nurse_room_name.Text = roomName;
                    not_nurse.Text = note;

                }
                catch (Exception)
                {

                    MessageBox.Show("Please Select The Entire Row");
                }
            }
        }

    }
}
