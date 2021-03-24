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
    public partial class systemManagement : Form
    {
        public systemManagement()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            this.Hide();

        }

        private void btn_child_info_Click(object sender, EventArgs e)
        {
            ChangePass pass = new ChangePass();
            pass.ShowDialog();
        }

        private void btn_sys_users_Click(object sender, EventArgs e)
        {
            user userFrm = new user();
            userFrm.Show();
        }

        private void systemManagement_Load(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Welcome " + userClass.getFullName();
            if (userClass.getUserRole() != "Admin" && userClass.getUserRole() != "admin")
            {
                btn_sys_users.Enabled = false;
                user.Text = "Only Admins Can Modify Users Data";
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
