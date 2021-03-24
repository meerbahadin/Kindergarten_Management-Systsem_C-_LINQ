using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;


namespace kindergarten2
{
    public partial class ChildData : Form
    {
        public ChildData()
        {
            InitializeComponent();
        }
        PreSchoolEntities1 db;

        private void ChildData_Load(object sender, EventArgs e)
        {
 
            db = new PreSchoolEntities1();
            db.tbl_child_info.Load();
            dataGridView1.DataSource = db.tbl_child_info.Local.ToBindingList();


        }


        private void btn_addkids_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                var confirmation = MessageBox.Show("Are You Sure To Save These Changes ?","Submit Channges", MessageBoxButtons.YesNo);
                if(confirmation == DialogResult.Yes)
                {
                    using (var context = new PreSchoolEntities1())
                    {

                        context.SaveChanges();
                        
                    }
                } else
                {
                    db = new PreSchoolEntities1();
                    db.tbl_child_info.Load();
                    dataGridView1.DataSource = db.tbl_child_info.Local.ToBindingList();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

  


        private void btn_addkids_search_Click(object sender, EventArgs e)
        {
            search(gunaLineTextBox1.Text);

        }
 
       public void search(string text)
        {
            db = new PreSchoolEntities1();
            db.tbl_child_info.Where(n => n.child_fullname.Contains(text)).Load();
            var childs = dataGridView1.DataSource = db.tbl_child_info.Local.ToBindingList();
            dataGridView1.DataSource = childs;
        }

        private void gunaLineTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                search(gunaLineTextBox1.Text);
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            db = new PreSchoolEntities1();
            db.tbl_child_info.Load();
            dataGridView1.DataSource = db.tbl_child_info.Local.ToBindingList();
            
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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


    }
}
