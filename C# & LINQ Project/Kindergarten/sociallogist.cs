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
    public partial class sociallogist : Form
    {
        public sociallogist()
        {
            InitializeComponent();
        }
        PreSchoolEntities1 db;
        int gbSocialId;
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sociallogist_Load(object sender, EventArgs e)
        {
            db = new PreSchoolEntities1();

            var childs = db.tbl_child_info;
            var rooms = db.tbl_room_name;

            foreach (var item in childs)
            {
                combo_sociallogist_child_name.Items.Add(item.child_fullname);
            }

            foreach (var item in rooms)
            {
                combo_sociallogist_room_name.Items.Add(item.room_name);
            }

            view();
        }

        private void btn_rooms_save_Click(object sender, EventArgs e)
        {
            if (gbSocialId > 0)
            {
                db = new PreSchoolEntities1();
                var sociogistData = db.tbl_sociologist.Where(items => items.id == gbSocialId).FirstOrDefault();

                var childId = db.tbl_child_info.Where(items => items.child_fullname == combo_sociallogist_child_name.Text)
               .Select(a => a.id)
               .FirstOrDefault();

                var roomId = db.tbl_room_name
                    .Where(items => items.room_name == combo_sociallogist_room_name.Text)
                    .Select(a => a.id)
                    .FirstOrDefault();

                sociogistData.id_user_update = userClass.getUserId();
                sociogistData.datetime_update = DateTime.Now;
                sociogistData.note = not_sociallogist.Text;
                sociogistData.id_room_name = roomId;
                sociogistData.id_child = childId;

                db.SaveChangesAsync();
                view();
                clear();




            }  else
            {
                db = new PreSchoolEntities1();

                var childId = db.tbl_child_info.Where(items => items.child_fullname == combo_sociallogist_child_name.Text)
                    .Select(a => a.id)
                    .FirstOrDefault();

                var roomId = db.tbl_room_name
                    .Where(items => items.room_name == combo_sociallogist_room_name.Text)
                    .Select(a => a.id)
                    .FirstOrDefault();


                var newSocial = new tbl_sociologist()
                {
                    id_user_save = userClass.getUserId(),
                    id_child = childId,
                    note = not_sociallogist.Text,
                    datetime_save = DateTime.Now,
                    id_room_name = roomId
                };

                db.tbl_sociologist.Add(newSocial);
                db.SaveChangesAsync();
                view();
            }
           
        }

        void view()
        {
            db = new PreSchoolEntities1();
             var roomsData = db.tbl_sociologist.Join(
             db.tbl_child_info,
             room => room.id_child,
             child => child.id,
             (room, child) => new
             {
                 id = room.id,
                 childName = child.child_fullname,
                 roomId = room.id_room_name,
                 note = room.note,

             }
         )
         .Join(
               db.tbl_room_name,
               room => room.roomId,
               roomName => roomName.id,
                (table1, roomName) => new
                {
                    Id = table1.id,
                    ChildName = table1.childName,
                    RoomName = roomName.room_name,
                    TecherNote = table1.note
                }

          )
         .ToList();
           dataGridView1.DataSource = roomsData;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellData = dataGridView1.Rows;
            if (cellData != null)
            {
                try
                {
                    gbSocialId = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string childName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string roomName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    string note = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                    combo_sociallogist_child_name.Text =childName;
                    combo_sociallogist_room_name.Text = roomName;
                    not_sociallogist.Text = note;

                }
                catch (Exception)
                {

                    MessageBox.Show("Please Select The Entire Row");
                }


            }
        }
        void clear()
        {
            combo_sociallogist_child_name.SelectedIndex = -1;
            combo_sociallogist_room_name.SelectedIndex = -1;
            not_sociallogist.Text = null;
            gbSocialId = 0;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_rooms_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gbSocialId > 0)
                {
                    using (var context = new PreSchoolEntities1())
                    {

                        var sociolData = context.tbl_sociologist.Where(item => item.id == gbSocialId).First();
                        var confirmation = MessageBox.Show("Are You Sure About This ?", "Please Confirm", MessageBoxButtons.YesNo);
                        if (confirmation == DialogResult.Yes)
                        {
                            context.tbl_sociologist.Remove(sociolData);
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
