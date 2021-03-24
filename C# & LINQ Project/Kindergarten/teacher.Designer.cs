namespace kindergarten2
{
    partial class teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.not_teacher_subject = new Guna.UI.WinForms.GunaTextBox();
            this.combo_teacher_room_name = new Guna.UI.WinForms.GunaComboBox();
            this.DateTime_teacher_from = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.DateTime_teacher_to = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_close = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_teacher_search = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txt_subject_subjectName = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_rooms_delete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_rooms_save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(gunaPictureBox1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            gunaPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.InitialImage")));
            gunaPictureBox1.Location = new System.Drawing.Point(-137, 104);
            gunaPictureBox1.Name = "gunaPictureBox1";
            gunaPictureBox1.Size = new System.Drawing.Size(1693, 937);
            gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            gunaPictureBox1.TabIndex = 37;
            gunaPictureBox1.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // not_teacher_subject
            // 
            this.not_teacher_subject.BackColor = System.Drawing.Color.Transparent;
            this.not_teacher_subject.BaseColor = System.Drawing.Color.White;
            this.not_teacher_subject.BorderColor = System.Drawing.Color.Silver;
            this.not_teacher_subject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.not_teacher_subject.FocusedBaseColor = System.Drawing.Color.White;
            this.not_teacher_subject.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.not_teacher_subject.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.not_teacher_subject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.not_teacher_subject.Location = new System.Drawing.Point(55, 397);
            this.not_teacher_subject.MultiLine = true;
            this.not_teacher_subject.Name = "not_teacher_subject";
            this.not_teacher_subject.PasswordChar = '\0';
            this.not_teacher_subject.Radius = 5;
            this.not_teacher_subject.Size = new System.Drawing.Size(351, 201);
            this.not_teacher_subject.TabIndex = 2;
            // 
            // combo_teacher_room_name
            // 
            this.combo_teacher_room_name.BackColor = System.Drawing.Color.Transparent;
            this.combo_teacher_room_name.BaseColor = System.Drawing.Color.White;
            this.combo_teacher_room_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.combo_teacher_room_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_teacher_room_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_teacher_room_name.FocusedColor = System.Drawing.Color.Empty;
            this.combo_teacher_room_name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_teacher_room_name.ForeColor = System.Drawing.Color.Black;
            this.combo_teacher_room_name.FormattingEnabled = true;
            this.combo_teacher_room_name.IntegralHeight = false;
            this.combo_teacher_room_name.ItemHeight = 42;
            this.combo_teacher_room_name.Location = new System.Drawing.Point(55, 312);
            this.combo_teacher_room_name.Name = "combo_teacher_room_name";
            this.combo_teacher_room_name.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combo_teacher_room_name.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combo_teacher_room_name.Radius = 5;
            this.combo_teacher_room_name.Size = new System.Drawing.Size(351, 48);
            this.combo_teacher_room_name.TabIndex = 3;
            // 
            // DateTime_teacher_from
            // 
            this.DateTime_teacher_from.BackColor = System.Drawing.Color.Transparent;
            this.DateTime_teacher_from.BaseColor = System.Drawing.Color.White;
            this.DateTime_teacher_from.BorderColor = System.Drawing.Color.Silver;
            this.DateTime_teacher_from.CustomFormat = null;
            this.DateTime_teacher_from.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTime_teacher_from.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.DateTime_teacher_from.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTime_teacher_from.ForeColor = System.Drawing.Color.Black;
            this.DateTime_teacher_from.Location = new System.Drawing.Point(549, 133);
            this.DateTime_teacher_from.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTime_teacher_from.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTime_teacher_from.Name = "DateTime_teacher_from";
            this.DateTime_teacher_from.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateTime_teacher_from.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.DateTime_teacher_from.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.DateTime_teacher_from.OnPressedColor = System.Drawing.Color.Black;
            this.DateTime_teacher_from.Radius = 3;
            this.DateTime_teacher_from.Size = new System.Drawing.Size(263, 56);
            this.DateTime_teacher_from.TabIndex = 5;
            this.DateTime_teacher_from.Text = "Sunday, February 16, 2020";
            this.DateTime_teacher_from.Value = new System.DateTime(2020, 2, 16, 19, 19, 49, 564);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Open Sans", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(495, 150);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(43, 19);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "From";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Open Sans", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(827, 152);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(25, 19);
            this.gunaLabel2.TabIndex = 8;
            this.gunaLabel2.Text = "To";
            // 
            // DateTime_teacher_to
            // 
            this.DateTime_teacher_to.BackColor = System.Drawing.Color.Transparent;
            this.DateTime_teacher_to.BaseColor = System.Drawing.Color.White;
            this.DateTime_teacher_to.BorderColor = System.Drawing.Color.Silver;
            this.DateTime_teacher_to.CustomFormat = null;
            this.DateTime_teacher_to.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTime_teacher_to.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.DateTime_teacher_to.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTime_teacher_to.ForeColor = System.Drawing.Color.Black;
            this.DateTime_teacher_to.Location = new System.Drawing.Point(858, 133);
            this.DateTime_teacher_to.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTime_teacher_to.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTime_teacher_to.Name = "DateTime_teacher_to";
            this.DateTime_teacher_to.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateTime_teacher_to.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.DateTime_teacher_to.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.DateTime_teacher_to.OnPressedColor = System.Drawing.Color.Black;
            this.DateTime_teacher_to.Radius = 3;
            this.DateTime_teacher_to.Size = new System.Drawing.Size(263, 56);
            this.DateTime_teacher_to.TabIndex = 7;
            this.DateTime_teacher_to.Text = "Sunday, February 16, 2020";
            this.DateTime_teacher_to.Value = new System.DateTime(2020, 2, 16, 19, 19, 49, 564);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.Controls.Add(this.gunaAdvenceButton3);
            this.gunaElipsePanel1.Controls.Add(this.btn_close);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1435, 79);
            this.gunaElipsePanel1.TabIndex = 38;
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.CheckedImage")));
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.Image")));
            this.gunaAdvenceButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(13, 2);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(1290, 22);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(30, 42);
            this.gunaAdvenceButton3.TabIndex = 23;
            this.gunaAdvenceButton3.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // btn_close
            // 
            this.btn_close.AnimationHoverSpeed = 0.07F;
            this.btn_close.AnimationSpeed = 0.03F;
            this.btn_close.BaseColor = System.Drawing.Color.Transparent;
            this.btn_close.BorderColor = System.Drawing.Color.Black;
            this.btn_close.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_close.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_close.CheckedForeColor = System.Drawing.Color.White;
            this.btn_close.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_close.CheckedImage")));
            this.btn_close.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_close.FocusedColor = System.Drawing.Color.Empty;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_close.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_close.LineColor = System.Drawing.Color.Transparent;
            this.btn_close.Location = new System.Drawing.Point(1323, 22);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_close.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_close.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_close.OnHoverImage = null;
            this.btn_close.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btn_close.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_close.Size = new System.Drawing.Size(31, 42);
            this.btn_close.TabIndex = 22;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_teacher_search
            // 
            this.btn_teacher_search.AnimationHoverSpeed = 0.07F;
            this.btn_teacher_search.AnimationSpeed = 0.03F;
            this.btn_teacher_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_teacher_search.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.btn_teacher_search.BorderColor = System.Drawing.Color.Black;
            this.btn_teacher_search.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_teacher_search.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_teacher_search.CheckedForeColor = System.Drawing.Color.White;
            this.btn_teacher_search.CheckedImage = null;
            this.btn_teacher_search.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_teacher_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teacher_search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_teacher_search.FocusedColor = System.Drawing.Color.Empty;
            this.btn_teacher_search.Font = new System.Drawing.Font("Open Sans", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_search.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_search.Image = null;
            this.btn_teacher_search.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_teacher_search.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_teacher_search.Location = new System.Drawing.Point(1145, 133);
            this.btn_teacher_search.Name = "btn_teacher_search";
            this.btn_teacher_search.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(80)))));
            this.btn_teacher_search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_teacher_search.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_teacher_search.OnHoverImage = null;
            this.btn_teacher_search.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_teacher_search.OnPressedColor = System.Drawing.Color.Black;
            this.btn_teacher_search.Radius = 3;
            this.btn_teacher_search.Size = new System.Drawing.Size(181, 56);
            this.btn_teacher_search.TabIndex = 39;
            this.btn_teacher_search.Text = "SEARCH";
            this.btn_teacher_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(51, 285);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(85, 19);
            this.gunaLabel4.TabIndex = 58;
            this.gunaLabel4.Text = "Room Name";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(51, 363);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(39, 19);
            this.gunaLabel5.TabIndex = 62;
            this.gunaLabel5.Text = "Note";
            // 
            // txt_subject_subjectName
            // 
            this.txt_subject_subjectName.Animated = true;
            this.txt_subject_subjectName.BackColor = System.Drawing.Color.White;
            this.txt_subject_subjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_subject_subjectName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.txt_subject_subjectName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_subject_subjectName.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_subject_subjectName.Location = new System.Drawing.Point(55, 133);
            this.txt_subject_subjectName.Name = "txt_subject_subjectName";
            this.txt_subject_subjectName.PasswordChar = '\0';
            this.txt_subject_subjectName.Size = new System.Drawing.Size(351, 44);
            this.txt_subject_subjectName.TabIndex = 95;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(51, 103);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(53, 19);
            this.gunaLabel3.TabIndex = 96;
            this.gunaLabel3.Text = "Subject";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(503, 240);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 46;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(823, 474);
            this.dataGridView1.TabIndex = 97;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(55, 215);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(351, 52);
            this.gunaDateTimePicker1.TabIndex = 98;
            this.gunaDateTimePicker1.Text = "Wednesday, June 10, 2020";
            this.gunaDateTimePicker1.Value = new System.DateTime(2020, 6, 10, 18, 10, 25, 500);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(51, 186);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(38, 19);
            this.gunaLabel6.TabIndex = 99;
            this.gunaLabel6.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 745);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 26);
            this.label1.TabIndex = 103;
            this.label1.Text = "Make Sure Clear All Field Before Adding New Data";
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Animated = true;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Open Sans", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(499, 783);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 3;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(351, 57);
            this.gunaAdvenceButton1.TabIndex = 102;
            this.gunaAdvenceButton1.Text = "CLEAR";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click_1);
            // 
            // btn_rooms_delete
            // 
            this.btn_rooms_delete.Animated = true;
            this.btn_rooms_delete.AnimationHoverSpeed = 0.07F;
            this.btn_rooms_delete.AnimationSpeed = 0.03F;
            this.btn_rooms_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_rooms_delete.BaseColor = System.Drawing.Color.Coral;
            this.btn_rooms_delete.BorderColor = System.Drawing.Color.Black;
            this.btn_rooms_delete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_rooms_delete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_rooms_delete.CheckedForeColor = System.Drawing.Color.White;
            this.btn_rooms_delete.CheckedImage = null;
            this.btn_rooms_delete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_rooms_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rooms_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_rooms_delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_rooms_delete.Font = new System.Drawing.Font("Open Sans", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rooms_delete.ForeColor = System.Drawing.Color.White;
            this.btn_rooms_delete.Image = null;
            this.btn_rooms_delete.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_rooms_delete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_rooms_delete.Location = new System.Drawing.Point(55, 697);
            this.btn_rooms_delete.Name = "btn_rooms_delete";
            this.btn_rooms_delete.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_rooms_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_rooms_delete.OnHoverForeColor = System.Drawing.Color.Coral;
            this.btn_rooms_delete.OnHoverImage = null;
            this.btn_rooms_delete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_rooms_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_rooms_delete.Radius = 3;
            this.btn_rooms_delete.Size = new System.Drawing.Size(351, 57);
            this.btn_rooms_delete.TabIndex = 101;
            this.btn_rooms_delete.Text = "DELETE";
            this.btn_rooms_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_rooms_delete.Click += new System.EventHandler(this.btn_rooms_delete_Click_1);
            // 
            // btn_rooms_save
            // 
            this.btn_rooms_save.Animated = true;
            this.btn_rooms_save.AnimationHoverSpeed = 0.07F;
            this.btn_rooms_save.AnimationSpeed = 0.03F;
            this.btn_rooms_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_rooms_save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.btn_rooms_save.BorderColor = System.Drawing.Color.Black;
            this.btn_rooms_save.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_rooms_save.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_rooms_save.CheckedForeColor = System.Drawing.Color.White;
            this.btn_rooms_save.CheckedImage = null;
            this.btn_rooms_save.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_rooms_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rooms_save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_rooms_save.FocusedColor = System.Drawing.Color.Empty;
            this.btn_rooms_save.Font = new System.Drawing.Font("Open Sans", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rooms_save.ForeColor = System.Drawing.Color.White;
            this.btn_rooms_save.Image = null;
            this.btn_rooms_save.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_rooms_save.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_rooms_save.Location = new System.Drawing.Point(55, 628);
            this.btn_rooms_save.Name = "btn_rooms_save";
            this.btn_rooms_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(80)))));
            this.btn_rooms_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_rooms_save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_rooms_save.OnHoverImage = null;
            this.btn_rooms_save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_rooms_save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_rooms_save.Radius = 3;
            this.btn_rooms_save.Size = new System.Drawing.Size(351, 57);
            this.btn_rooms_save.TabIndex = 100;
            this.btn_rooms_save.Text = "SAVE OR UPDATE";
            this.btn_rooms_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_rooms_save.Click += new System.EventHandler(this.btn_rooms_save_Click);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(kindergarten2.teacher);
            // 
            // teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 874);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.btn_rooms_delete);
            this.Controls.Add(this.btn_rooms_save);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaDateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_subject_subjectName);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.btn_teacher_search);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.DateTime_teacher_to);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.DateTime_teacher_from);
            this.Controls.Add(this.combo_teacher_room_name);
            this.Controls.Add(this.not_teacher_subject);
            this.Controls.Add(gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teacher";
            this.Load += new System.EventHandler(this.teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(gunaPictureBox1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox not_teacher_subject;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaDateTimePicker DateTime_teacher_to;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDateTimePicker DateTime_teacher_from;
        private Guna.UI.WinForms.GunaComboBox combo_teacher_room_name;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton btn_close;
        private Guna.UI.WinForms.GunaAdvenceButton btn_teacher_search;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private Guna.UI.WinForms.GunaLineTextBox txt_subject_subjectName;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_rooms_delete;
        private Guna.UI.WinForms.GunaAdvenceButton btn_rooms_save;
    }
}