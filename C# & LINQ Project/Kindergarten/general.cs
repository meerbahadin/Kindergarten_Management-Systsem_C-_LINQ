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
    public partial class general : Form
    {
        public general()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_child_info_Click(object sender, EventArgs e)
        {
            addKids addKidsFrm = new addKids();
            addKidsFrm.Show();
        }

        private void btn_childHealth_Click(object sender, EventArgs e)
        {
            childHealth childHealthFrm = new childHealth();
            childHealthFrm.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            employee employeeFrm = new employee();
            employeeFrm.Show();
        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            Rooms RoomsFrm = new Rooms();
            RoomsFrm.Show();
        }



        private void btn_back_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            this.Hide();

        }

        private void general_Load(object sender, EventArgs e)
        {

            gunaLabel1.Text = "Welcome " + userClass.getFullName();
            if (userClass.getUserRole() != "Admin" && userClass.getUserRole() != "admin")
            {
                btn_employee.Enabled = false;
                label1.Text = "For Admins Only";
            }
        }

    }
}
