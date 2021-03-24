using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kindergarten2
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        PreSchoolEntities1 db;
        int gbRoomId;

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            db = new PreSchoolEntities1();
            var childs = db.tbl_child_info;
            var rooms = db.tbl_room_name;

            foreach (var item in childs)
            {
                combo_rooms_child_name.Items.Add(item.child_fullname);
            }
            foreach (var item in rooms)
            {
                combo_rooms_roomsName.Items.Add(item.room_name);
            }
            view();
          
        }

        void view()
        {
           db = new PreSchoolEntities1();
            var roomsData = db.tbl_rooms.Join(
             db.tbl_child_info,
             room => room.id_child,
             child => child.id,
             (room , child) => new
             {
                 id = room.id,
                 childName = child.child_fullname,
                 roomId = room.id_room_name,
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
                }

          ).ToList();
            dataGridView1.DataSource = roomsData;
        }

        private void btn_rooms_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (gbRoomId > 0)
                {
                    db = new PreSchoolEntities1();
                    var room = db.tbl_rooms.Where(item => item.id == gbRoomId).First();

                    var childId = db.tbl_child_info.Where(items => items.child_fullname == combo_rooms_child_name.Text)
                   .Select(a => a.id)
                   .FirstOrDefault();

                    var roomId = db.tbl_room_name
                        .Where(items => items.room_name == combo_rooms_roomsName.Text)
                        .Select(a => a.id)
                        .FirstOrDefault();

                    room.datetime_update = DateTime.Now;
                    room.id_user_update = userClass.getUserId();
                    room.id_child = childId;
                    room.id_room_name = roomId;

                    db.SaveChangesAsync();

                    view();
                    clear();


                } else if (gbRoomId == 0 && combo_rooms_child_name.SelectedIndex != -1 && combo_rooms_roomsName.SelectedIndex !=-1)
                {
                    db = new PreSchoolEntities1();
                    var childId = db.tbl_child_info.Where(items => items.child_fullname == combo_rooms_child_name.Text)
                        .Select(a => a.id)
                        .FirstOrDefault();

                    var roomId = db.tbl_room_name
                        .Where(items => items.room_name == combo_rooms_roomsName.Text)
                        .Select(a => a.id)
                        .FirstOrDefault();


                    var newRoom = new tbl_rooms()
                    {
                        id_user_save = userClass.getUserId(),
                        id_child = childId,
                        datetime_save = DateTime.Now,
                        id_room_name = roomId
                    };

                    db.tbl_rooms.Add(newRoom);
                    db.SaveChangesAsync();

                    view();
                    clear();
                } else
                {
                    MessageBox.Show("Please Select Some Data To Edit Or Add New Data");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error Adding New Rooms Data");
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellData = dataGridView1.Rows;
            if (cellData != null)
            {
                try
                {
                    gbRoomId = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string firstCellValue = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string secondCellValue = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                
                    combo_rooms_child_name.Text = firstCellValue;
                    combo_rooms_roomsName.Text = secondCellValue;

                }
                catch (Exception)
                {

                    MessageBox.Show("Please Select The Entire Row");
                }


            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            combo_rooms_child_name.SelectedIndex = -1;
            combo_rooms_roomsName.SelectedIndex = -1;
            gbRoomId = 0;
        }

        private void btn_rooms_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(gbRoomId > 0)
                {
                    using (var context = new PreSchoolEntities1())
                    {

                        var roomData = context.tbl_rooms.Where(item => item.id == gbRoomId).First();
                        var confirmation = MessageBox.Show("Are You Sure About Deleting This Child In This Room ", "Please Confirm", MessageBoxButtons.YesNo);
                        if (confirmation == DialogResult.Yes)
                        {
                            context.tbl_rooms.Remove(roomData);
                            context.SaveChanges();
                        }
                    }

                    view();
                    clear();
                } else
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
