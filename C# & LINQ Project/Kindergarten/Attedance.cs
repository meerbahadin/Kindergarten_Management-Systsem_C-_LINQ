using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing;

namespace kindergarten2
{
    public partial class Attedance : Form
    {
        public Attedance()
        {
            InitializeComponent();
        }

        PreSchoolEntities1 db;
        int gbAttensId;
        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Attedance_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm tt";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm tt";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.ShowUpDown = true;


            db = new PreSchoolEntities1();

            var childs = db.tbl_child_info;

            foreach (var item in childs)
            {
                comboo_child_name.Items.Add(item.child_fullname);
            }

            view();


        }

        void view()
        {
            var attendance = db.tbl_attendance.Join(
            db.tbl_child_info,
            atten => atten.id_child,
            child => child.id,
            (atten, child) => new
            {
                id = atten.id,
                ChildName = child.child_fullname,
                time_income = atten.time_income,
                left_time = atten.time_left,
                left_with = atten.left_with,
                Saved_At = atten.date_save,


            }
        ).ToList();

            dataGridView1.DataSource = attendance;
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Child Name";
            dataGridView1.Columns[2].HeaderText = "Time Income";
            dataGridView1.Columns[3].HeaderText = "Time Left";
            dataGridView1.Columns[4].HeaderText = "Left With";
            dataGridView1.Columns[5].HeaderText = "Saved At";
        }

        private void btn_rooms_save_Click(object sender, EventArgs e)
        {
            if (gbAttensId > 0)
            {
                db = new PreSchoolEntities1();
                var attenData = db.tbl_attendance.Where(x => x.id == gbAttensId).FirstOrDefault();

                var childId = db.tbl_child_info.Where(items => items.child_fullname == comboo_child_name.Text)
                   .Select(a => a.id)
                   .FirstOrDefault();

                DateTime dt = dateTimePicker1.Value;
                TimeSpan incomeTime = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

                DateTime dt2 = dateTimePicker2.Value;
                TimeSpan leftTime = new TimeSpan(dt2.Hour, dt2.Minute, dt2.Second);

                attenData.id_child = childId;
                attenData.time_income = incomeTime;
                attenData.time_left = leftTime;
                attenData.left_with = left_with.Text;
                attenData.date_save = DateTime.Now;

                db.SaveChanges();
                view();
                clear();

            }
            else
            {
                db = new PreSchoolEntities1();
                DateTime dt = dateTimePicker1.Value;
                TimeSpan incomeTime = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

                DateTime dt2 = dateTimePicker2.Value;
                TimeSpan leftTime = new TimeSpan(dt2.Hour, dt2.Minute, dt2.Second);

                var childId = db.tbl_child_info.Where(items => items.child_fullname == comboo_child_name.Text)
                   .Select(a => a.id)
                   .FirstOrDefault();

                var newAttendance = new tbl_attendance()
                {
                    id_child = childId,
                    id_user_save = userClass.getUserId(),
                    time_income = incomeTime,
                    time_left = leftTime,
                    left_with = left_with.Text,
                    date_save = DateTime.Now

                };

                db.tbl_attendance.Add(newAttendance);

                db.SaveChanges();

                view();
                clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellData = dataGridView1.Rows;
            if (cellData != null)
            {
                try
                {
                    gbAttensId = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string childName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string incomeTime = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    string leftTime = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    string leftWith = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


                    comboo_child_name.Text = childName;
                    left_with.Text = leftWith;
                    dateTimePicker1.Value = DateTime.Parse(incomeTime);
                    dateTimePicker2.Value = DateTime.Parse(leftTime);

                }
                catch (Exception)
                {

                    MessageBox.Show("Please Select The Entire Row");
                }

            }
        }

        private void btn_rooms_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gbAttensId > 0)
                {
                    using (var context = new PreSchoolEntities1())
                    {

                        var roomData = context.tbl_attendance.Where(item => item.id == gbAttensId).First();
                        var confirmation = MessageBox.Show("Are You Sure About Deleting This Data  ?", "Please Confirm", MessageBoxButtons.YesNo);
                        if (confirmation == DialogResult.Yes)
                        {
                            context.tbl_attendance.Remove(roomData);
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
        void clear()
        {
            comboo_child_name.SelectedIndex = -1;
            left_with.Text = null;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            gbAttensId = 0;

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_addkids_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                DateTime todaysDate = DateTime.Now;
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Attendance Report " + Path.Combine(String.Format("{0}.pdf", todaysDate.ToString("dd-MM-yyyy")));
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 5;
                            pdfTable.DefaultCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            pdfTable.DefaultCell.BorderColor = BaseColor.DARK_GRAY;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {

                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            var attendance = db.tbl_attendance.Join(
           db.tbl_child_info,
           atten => atten.id_child,
           child => child.id,
           (atten, child) => new
           {
               id = atten.id,
               ChildName = child.child_fullname,
               time_income = atten.time_income,
               left_time = atten.time_left,
               left_with = atten.left_with,
               Saved_At = atten.date_save,


           }
       ).Where(
                x => x.Saved_At >= DateTimePicker_to.Value
           ).ToList();

            dataGridView1.DataSource = attendance;
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Child Name";
            dataGridView1.Columns[2].HeaderText = "Time Income";
            dataGridView1.Columns[3].HeaderText = "Time Left";
            dataGridView1.Columns[4].HeaderText = "Left With";
            dataGridView1.Columns[5].HeaderText = "Saved At";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
