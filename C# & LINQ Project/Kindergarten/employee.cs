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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }
        PreSchoolEntities1 db;
        int gbEmpId;
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        void view()
        {
            db = new PreSchoolEntities1();
            var employees = db.tbl_employee.Join(
                 db.tbl_user,
                 empolooye => empolooye.id_user_save,
                 user => user.id,
                 (emp, usr) => new
                 {
                     id = emp.id,
                     EmployeeFullname = emp.employee_fullname,
                     EmployeeGender = emp.employee_gender,
                     JobTitle = emp.employee_job_title,
                     Salary = emp.salary,
                     Phone = emp.employee_phone,
                     SavedAt = emp.datetime_save,
                     SavedBy = usr.User_fullname,
                 }
     ).ToList();

            dataGridView1.DataSource = employees;
        }

        private void employee_Load(object sender, EventArgs e)
        {
            view();
        }

        private void btn_employee_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(gbEmpId > 0)
                {
                    db = new PreSchoolEntities1();
                    int userId = userClass.getUserId();

                    var emplooye = db.tbl_employee.Where(x => x.id == gbEmpId).FirstOrDefault();

                        emplooye.employee_fullname = txt_employee_employeeFullname.Text;
                        emplooye.employee_gender = combo_employee_employeeGender.Text;
                        emplooye.employee_job_title = job_title.Text;
                        emplooye.salary = Math.Round(Convert.ToDecimal(txt_employee_salary.Text));
                        emplooye.employee_phone = txt_employee_employeePhone.Text;
                        emplooye.datetime_save = DateTime.Now;
                        emplooye.id_user_update = userId;

                    db.SaveChanges();
                    view();
                    clear();
                    

                } else
                {
                    db = new PreSchoolEntities1();

                    int userId = userClass.getUserId();

                    var newEmployee = new tbl_employee()
                    {
                        employee_fullname = txt_employee_employeeFullname.Text,
                        employee_gender = combo_employee_employeeGender.Text,
                        employee_job_title = job_title.Text,
                        salary = Math.Round(Convert.ToDecimal(txt_employee_salary.Text)),
                        employee_phone = txt_employee_employeePhone.Text,
                        datetime_save = DateTime.Now,
                        id_user_save = userId

                    };

                    db.tbl_employee.Add(newEmployee);

                    db.SaveChanges();
                    view();
                    clear();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Eror");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellData = dataGridView1.Rows;
            if (cellData != null)
            {
                try
                {
                    gbEmpId = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string fullName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string gender = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    string jobTitle = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    string salary = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    string phone = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();


                    txt_employee_employeeFullname.Text = fullName;
                    combo_employee_employeeGender.Text = gender;
                    job_title.Text = jobTitle;
                    txt_employee_salary.Text = salary;
                    txt_employee_employeePhone.Text = phone;


                }
                catch (Exception)
                {

                    MessageBox.Show("Please Select The Entire Row");
                }
            }
        }

        void clear()
        {

            txt_employee_employeeFullname.Text = null;
            combo_employee_employeeGender.SelectedIndex = -1;
            job_title.Text = null;
            txt_employee_salary.Text = null;
            txt_employee_employeePhone.Text =null;

            gbEmpId = 0;
        }

        private void btn_employee_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gbEmpId > 0)
                {
                    using (var context = new PreSchoolEntities1())
                    {

                        var emplooye = context.tbl_employee.Where(item => item.id == gbEmpId).First();
                        var confirmation = MessageBox.Show("Are You Sure About Deleting This Emplooye ?", "Please Confirm", MessageBoxButtons.YesNo);
                        if (confirmation == DialogResult.Yes)
                        {
                            context.tbl_employee.Remove(emplooye);
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

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
