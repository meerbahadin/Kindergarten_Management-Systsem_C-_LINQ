using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Globalization;

namespace kindergarten2
{
    
    public partial class Login : Form
    {

        //public string path = @"C:\mode.txt";
        public Login()
        {
            InitializeComponent();
            
        }

        PreSchoolEntities1 db;

        private void gunaSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            
            changecolor();
     
        }


        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }
        void checkMode()
        {
            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //    File.WriteAllText(path, "Dark = False");

            //}
            
            //List<string> lines = File.ReadAllLines(path).ToList();

            //foreach (var item in lines)
            //{
            //    if (item.Contains("True"))
            //    {
            //        gunaWinSwitch1.Checked = true;
            //        changecolor();
            //    } else if (item.Contains("False")) {
            //        gunaWinSwitch1.Checked = false;
            //        changecolor();
            //    }
            //}
            

        }
        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox1.Checked)
            {
                gunaLineTextBox2.PasswordChar = '\0';

            } else
            {
                gunaLineTextBox2.PasswordChar = '●';
            }
        }


        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {  
            var user = new userClass();

            db = new PreSchoolEntities1();
            var authUser = db.tbl_user.Where(
                x => x.username == username.Text && x.password == gunaLineTextBox2.Text
            ).FirstOrDefault();

            if(authUser !=  null)
            {
                userClass.setUserId(int.Parse(authUser.id.ToString()));
                userClass.setUserName(authUser.username);
                userClass.setFullName(authUser.User_fullname);
                userClass.setUserStatus(authUser.status.ToString());
                userClass.setUserRole(authUser.User_Role);
                userClass.setUserPassword(authUser.password);
                main main = new main();
                main.c = gunaWinSwitch1.Checked;
                main.Show();
                this.Hide();
            }

            else
            {

                 MessageBox.Show(this,"Wrong Credentials");

            }
            
        }

        void changecolor ()
        {
            if (gunaWinSwitch1.Checked)
            {
                this.BackColor = Color.FromArgb(36,33,100);
                panel1.BackColor = Color.FromArgb(3,0,71);
                gunaLineTextBox2.ForeColor = Color.LightGray;
                gunaLabel2.ForeColor = Color.White;
                gunaLabel3.ForeColor = Color.White;
                gunaCheckBox1.BackColor = Color.FromArgb(3, 0, 71);
                gunaCheckBox1.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(244, 244, 244);
                panel1.BackColor = Color.White;
                gunaLineTextBox2.BackColor = Color.White;
                gunaLabel2.ForeColor = Color.Black;
                gunaLabel3.ForeColor = Color.Black;
                gunaCheckBox1.BackColor = Color.White;
                gunaCheckBox1.ForeColor = Color.Black;
                gunaLineTextBox2.ForeColor = Color.Black;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //checkMode();

            db = new PreSchoolEntities1();

            var users = db.tbl_user;

            foreach (var item in users)
            {
                username.Items.Add(item.username);
            }

        }

        private void gunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            changecolor();
      
        }

        static string CapitalizeFirst(string s)
        {
            TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
            string output = cultInfo.ToTitleCase(s);
            return output;
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
          
           //bool chk = gunaWinSwitch1.Checked;
           // if (chk)
           // {
           //     File.WriteAllText(path, "Dark = True");
           // }
           // else
           // {
           //     File.WriteAllText(path, "Dark = False");
           // }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
