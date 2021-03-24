namespace kindergarten2
{
    partial class Attedance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attedance));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.left_with = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.comboo_child_name = new Guna.UI.WinForms.GunaComboBox();
            this.btn_rooms_delete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_rooms_save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_close = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_addkids_delete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DateTimePicker_to = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(417, 170);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
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
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(906, 520);
            this.dataGridView1.TabIndex = 109;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(38, 137);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(87, 19);
            this.gunaLabel6.TabIndex = 115;
            this.gunaLabel6.Text = "Income Time";
            // 
            // left_with
            // 
            this.left_with.Animated = true;
            this.left_with.BackColor = System.Drawing.Color.White;
            this.left_with.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.left_with.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.left_with.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.left_with.LineColor = System.Drawing.Color.Gainsboro;
            this.left_with.Location = new System.Drawing.Point(42, 360);
            this.left_with.Name = "left_with";
            this.left_with.PasswordChar = '\0';
            this.left_with.Size = new System.Drawing.Size(351, 44);
            this.left_with.TabIndex = 112;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(38, 330);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(65, 19);
            this.gunaLabel3.TabIndex = 113;
            this.gunaLabel3.Text = "Left With";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(38, 47);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(80, 19);
            this.gunaLabel4.TabIndex = 111;
            this.gunaLabel4.Text = "Child Name";
            // 
            // comboo_child_name
            // 
            this.comboo_child_name.BackColor = System.Drawing.Color.Transparent;
            this.comboo_child_name.BaseColor = System.Drawing.Color.White;
            this.comboo_child_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.comboo_child_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboo_child_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboo_child_name.FocusedColor = System.Drawing.Color.Empty;
            this.comboo_child_name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboo_child_name.ForeColor = System.Drawing.Color.Black;
            this.comboo_child_name.FormattingEnabled = true;
            this.comboo_child_name.IntegralHeight = false;
            this.comboo_child_name.ItemHeight = 42;
            this.comboo_child_name.Location = new System.Drawing.Point(42, 74);
            this.comboo_child_name.Name = "comboo_child_name";
            this.comboo_child_name.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboo_child_name.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboo_child_name.Radius = 5;
            this.comboo_child_name.Size = new System.Drawing.Size(351, 48);
            this.comboo_child_name.TabIndex = 110;
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
            this.btn_rooms_delete.Location = new System.Drawing.Point(42, 508);
            this.btn_rooms_delete.Name = "btn_rooms_delete";
            this.btn_rooms_delete.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_rooms_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_rooms_delete.OnHoverForeColor = System.Drawing.Color.Coral;
            this.btn_rooms_delete.OnHoverImage = null;
            this.btn_rooms_delete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_rooms_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_rooms_delete.Radius = 3;
            this.btn_rooms_delete.Size = new System.Drawing.Size(351, 57);
            this.btn_rooms_delete.TabIndex = 117;
            this.btn_rooms_delete.Text = "DELETE";
            this.btn_rooms_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_rooms_delete.Click += new System.EventHandler(this.btn_rooms_delete_Click);
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
            this.btn_rooms_save.Location = new System.Drawing.Point(42, 439);
            this.btn_rooms_save.Name = "btn_rooms_save";
            this.btn_rooms_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(80)))));
            this.btn_rooms_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_rooms_save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_rooms_save.OnHoverImage = null;
            this.btn_rooms_save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_rooms_save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_rooms_save.Radius = 3;
            this.btn_rooms_save.Size = new System.Drawing.Size(351, 57);
            this.btn_rooms_save.TabIndex = 116;
            this.btn_rooms_save.Text = "SAVE OR UPDATE";
            this.btn_rooms_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_rooms_save.Click += new System.EventHandler(this.btn_rooms_save_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(38, 230);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(65, 19);
            this.gunaLabel1.TabIndex = 119;
            this.gunaLabel1.Text = "Time Left";
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
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(1259, 12);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(30, 42);
            this.gunaAdvenceButton3.TabIndex = 121;
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
            this.btn_close.Location = new System.Drawing.Point(1292, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_close.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_close.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_close.OnHoverImage = null;
            this.btn_close.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btn_close.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_close.Size = new System.Drawing.Size(31, 42);
            this.btn_close.TabIndex = 120;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 26);
            this.label1.TabIndex = 123;
            this.label1.Text = "Make Sure Clear All Field Before Adding New Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(42, 630);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 3;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(352, 57);
            this.gunaAdvenceButton1.TabIndex = 122;
            this.gunaAdvenceButton1.Text = "CLEAR";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 170);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(352, 24);
            this.dateTimePicker1.TabIndex = 124;
            this.dateTimePicker1.Value = new System.DateTime(2020, 6, 12, 14, 14, 17, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(42, 262);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(351, 24);
            this.dateTimePicker2.TabIndex = 125;
            // 
            // btn_addkids_delete
            // 
            this.btn_addkids_delete.Animated = true;
            this.btn_addkids_delete.AnimationHoverSpeed = 0.07F;
            this.btn_addkids_delete.AnimationSpeed = 0.03F;
            this.btn_addkids_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_addkids_delete.BaseColor = System.Drawing.Color.Coral;
            this.btn_addkids_delete.BorderColor = System.Drawing.Color.Black;
            this.btn_addkids_delete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_addkids_delete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_addkids_delete.CheckedForeColor = System.Drawing.Color.White;
            this.btn_addkids_delete.CheckedImage = null;
            this.btn_addkids_delete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_addkids_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addkids_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_addkids_delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_addkids_delete.Font = new System.Drawing.Font("Open Sans", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addkids_delete.ForeColor = System.Drawing.Color.White;
            this.btn_addkids_delete.Image = null;
            this.btn_addkids_delete.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_addkids_delete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_addkids_delete.Location = new System.Drawing.Point(1103, 74);
            this.btn_addkids_delete.Name = "btn_addkids_delete";
            this.btn_addkids_delete.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_addkids_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_addkids_delete.OnHoverForeColor = System.Drawing.Color.Coral;
            this.btn_addkids_delete.OnHoverImage = null;
            this.btn_addkids_delete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_addkids_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_addkids_delete.Radius = 3;
            this.btn_addkids_delete.Size = new System.Drawing.Size(220, 48);
            this.btn_addkids_delete.TabIndex = 126;
            this.btn_addkids_delete.Text = "SAVE DATA AS PDF";
            this.btn_addkids_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_addkids_delete.Click += new System.EventHandler(this.btn_addkids_delete_Click);
            // 
            // DateTimePicker_to
            // 
            this.DateTimePicker_to.BaseColor = System.Drawing.Color.White;
            this.DateTimePicker_to.BorderColor = System.Drawing.Color.Silver;
            this.DateTimePicker_to.CustomFormat = null;
            this.DateTimePicker_to.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTimePicker_to.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.DateTimePicker_to.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker_to.ForeColor = System.Drawing.Color.Black;
            this.DateTimePicker_to.Location = new System.Drawing.Point(417, 78);
            this.DateTimePicker_to.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker_to.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker_to.Name = "DateTimePicker_to";
            this.DateTimePicker_to.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateTimePicker_to.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.DateTimePicker_to.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.DateTimePicker_to.OnPressedColor = System.Drawing.Color.Black;
            this.DateTimePicker_to.Size = new System.Drawing.Size(351, 44);
            this.DateTimePicker_to.TabIndex = 128;
            this.DateTimePicker_to.Text = "Sunday, January 5, 2020";
            this.DateTimePicker_to.Value = new System.DateTime(2020, 1, 5, 20, 50, 42, 74);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(413, 52);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(41, 19);
            this.gunaLabel2.TabIndex = 127;
            this.gunaLabel2.Text = "From";
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.Animated = true;
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = null;
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Open Sans", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = null;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(774, 78);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(80)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Radius = 3;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(155, 44);
            this.gunaAdvenceButton2.TabIndex = 129;
            this.gunaAdvenceButton2.Text = "FILLTER";
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // Attedance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 830);
            this.Controls.Add(this.gunaAdvenceButton2);
            this.Controls.Add(this.DateTimePicker_to);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btn_addkids_delete);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.gunaAdvenceButton3);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btn_rooms_delete);
            this.Controls.Add(this.btn_rooms_save);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.left_with);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.comboo_child_name);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attedance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attedance";
            this.Load += new System.EventHandler(this.Attedance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLineTextBox left_with;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox comboo_child_name;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_rooms_delete;
        private Guna.UI.WinForms.GunaAdvenceButton btn_rooms_save;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton btn_close;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Guna.UI.WinForms.GunaAdvenceButton btn_addkids_delete;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaDateTimePicker DateTimePicker_to;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}