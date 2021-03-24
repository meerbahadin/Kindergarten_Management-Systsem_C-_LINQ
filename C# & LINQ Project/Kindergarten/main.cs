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
    public partial class main : Form
    {
        public bool panel = true;
        public bool c;
        public bool isc = false;
        public main()
        {
            InitializeComponent();
        }

        private void btn_generals_Click(object sender, EventArgs e)
        {
            this.Hide();
            general generalFrm = new general();
            generalFrm.Show();
          
        }

        private void btn_teachers_Click(object sender, EventArgs e)
        {
            teacher teacherFrm = new teacher();
            teacherFrm.Show();
           
        }

        private void btn_sociallogist_Click(object sender, EventArgs e)
        {

            sociallogist sociallogistFrm = new sociallogist();
            sociallogistFrm.Show();
        }

        private void btn_nurse_Click(object sender, EventArgs e)
        {
            nurse nurseFrm = new nurse();
            nurseFrm.Show();
        }

        private void btn_system_management_Click(object sender, EventArgs e)
        {
            this.Hide();
            systemManagement sm = new systemManagement();
            sm.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void main_Load(object sender, EventArgs e)
        {
            var user = new userClass();
            gunaLabel1.Text = "Welcome " + userClass.getFullName();
            if (c)
            {
                chanagecolor();
                isc = true;
            }
            if (isc)
            {
                gunaWinSwitch1.Checked = true;
            }
        }
        void chanagecolor()
        {

            this.BackColor = Color.FromArgb(25, 24, 45);

        }

        private void gunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {

            if (gunaWinSwitch1.Checked == true)
            {
                chanagecolor();
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 255, 255);


            }
        }



        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            userClass.clear();
            login.Show();
            this.Hide();
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            Attedance attns = new Attedance();
            attns.Show();
        }
    }
}
