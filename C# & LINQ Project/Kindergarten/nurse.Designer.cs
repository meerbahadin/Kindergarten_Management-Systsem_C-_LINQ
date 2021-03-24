namespace kindergarten2
{
    partial class nurse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nurse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btn_nurse_save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_close = new Guna.UI.WinForms.GunaAdvenceButton();
            this.combo_nurse_room_name = new Guna.UI.WinForms.GunaComboBox();
            this.not_nurse = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.combo_nurse_child_name = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_rooms_delete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label2 = new System.Windows.Forms.Label();
            gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(gunaPictureBox1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            gunaPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.InitialImage")));
            gunaPictureBox1.Location = new System.Drawing.Point(-165, 101);
            gunaPictureBox1.Name = "gunaPictureBox1";
            gunaPictureBox1.Size = new System.Drawing.Size(1693, 937);
            gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            gunaPictureBox1.TabIndex = 49;
            gunaPictureBox1.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // btn_nurse_save
            // 
            this.btn_nurse_save.AnimationHoverSpeed = 0.07F;
            this.btn_nurse_save.AnimationSpeed = 0.03F;
            this.btn_nurse_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_nurse_save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.btn_nurse_save.BorderColor = System.Drawing.Color.Black;
            this.btn_nurse_save.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_nurse_save.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_nurse_save.CheckedForeColor = System.Drawing.Color.White;
            this.btn_nurse_save.CheckedImage = null;
            this.btn_nurse_save.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_nurse_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nurse_save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_nurse_save.FocusedColor = System.Drawing.Color.Empty;
            this.btn_nurse_save.Font = new System.Drawing.Font("Open Sans", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nurse_save.ForeColor = System.Drawing.Color.White;
            this.btn_nurse_save.Image = null;
            this.btn_nurse_save.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_nurse_save.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_nurse_save.Location = new System.Drawing.Point(55, 545);
            this.btn_nurse_save.Name = "btn_nurse_save";
            this.btn_nurse_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(80)))));
            this.btn_nurse_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_nurse_save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_nurse_save.OnHoverImage = null;
            this.btn_nurse_save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_nurse_save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_nurse_save.Radius = 3;
            this.btn_nurse_save.Size = new System.Drawing.Size(353, 57);
            this.btn_nurse_save.TabIndex = 51;
            this.btn_nurse_save.Text = "SAVE OR UPDATE";
            this.btn_nurse_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_nurse_save.Click += new System.EventHandler(this.btn_nurse_save_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.Controls.Add(this.gunaAdvenceButton3);
            this.gunaElipsePanel1.Controls.Add(this.btn_close);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1391, 79);
            this.gunaElipsePanel1.TabIndex = 48;
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
            // combo_nurse_room_name
            // 
            this.combo_nurse_room_name.BackColor = System.Drawing.Color.Transparent;
            this.combo_nurse_room_name.BaseColor = System.Drawing.Color.White;
            this.combo_nurse_room_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.combo_nurse_room_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_nurse_room_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_nurse_room_name.FocusedColor = System.Drawing.Color.Empty;
            this.combo_nurse_room_name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_nurse_room_name.ForeColor = System.Drawing.Color.Black;
            this.combo_nurse_room_name.FormattingEnabled = true;
            this.combo_nurse_room_name.IntegralHeight = false;
            this.combo_nurse_room_name.ItemHeight = 42;
            this.combo_nurse_room_name.Location = new System.Drawing.Point(56, 232);
            this.combo_nurse_room_name.Name = "combo_nurse_room_name";
            this.combo_nurse_room_name.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combo_nurse_room_name.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combo_nurse_room_name.Radius = 5;
            this.combo_nurse_room_name.Size = new System.Drawing.Size(352, 48);
            this.combo_nurse_room_name.TabIndex = 46;
            // 
            // not_nurse
            // 
            this.not_nurse.BackColor = System.Drawing.Color.Transparent;
            this.not_nurse.BaseColor = System.Drawing.Color.White;
            this.not_nurse.BorderColor = System.Drawing.Color.Silver;
            this.not_nurse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.not_nurse.FocusedBaseColor = System.Drawing.Color.White;
            this.not_nurse.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.not_nurse.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.not_nurse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.not_nurse.Location = new System.Drawing.Point(56, 325);
            this.not_nurse.MultiLine = true;
            this.not_nurse.Name = "not_nurse";
            this.not_nurse.PasswordChar = '\0';
            this.not_nurse.Radius = 5;
            this.not_nurse.Size = new System.Drawing.Size(352, 201);
            this.not_nurse.TabIndex = 45;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(52, 105);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(80, 19);
            this.gunaLabel1.TabIndex = 53;
            this.gunaLabel1.Text = "Child Name";
            // 
            // combo_nurse_child_name
            // 
            this.combo_nurse_child_name.BackColor = System.Drawing.Color.Transparent;
            this.combo_nurse_child_name.BaseColor = System.Drawing.Color.White;
            this.combo_nurse_child_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.combo_nurse_child_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_nurse_child_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_nurse_child_name.FocusedColor = System.Drawing.Color.Empty;
            this.combo_nurse_child_name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_nurse_child_name.ForeColor = System.Drawing.Color.Black;
            this.combo_nurse_child_name.FormattingEnabled = true;
            this.combo_nurse_child_name.IntegralHeight = false;
            this.combo_nurse_child_name.ItemHeight = 42;
            this.combo_nurse_child_name.Location = new System.Drawing.Point(56, 134);
            this.combo_nurse_child_name.Name = "combo_nurse_child_name";
            this.combo_nurse_child_name.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combo_nurse_child_name.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combo_nurse_child_name.Radius = 5;
            this.combo_nurse_child_name.Size = new System.Drawing.Size(352, 48);
            this.combo_nurse_child_name.TabIndex = 54;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(52, 202);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(85, 19);
            this.gunaLabel2.TabIndex = 55;
            this.gunaLabel2.Text = "Room Name";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(52, 297);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(39, 19);
            this.gunaLabel3.TabIndex = 61;
            this.gunaLabel3.Text = "Note";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(451, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersWidth = 46;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(903, 546);
            this.dataGridView1.TabIndex = 110;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 702);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 26);
            this.label1.TabIndex = 126;
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(56, 741);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 3;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(352, 57);
            this.gunaAdvenceButton1.TabIndex = 125;
            this.gunaAdvenceButton1.Text = "CLEAR";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
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
            this.btn_rooms_delete.Location = new System.Drawing.Point(54, 623);
            this.btn_rooms_delete.Name = "btn_rooms_delete";
            this.btn_rooms_delete.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_rooms_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_rooms_delete.OnHoverForeColor = System.Drawing.Color.Coral;
            this.btn_rooms_delete.OnHoverImage = null;
            this.btn_rooms_delete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_rooms_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_rooms_delete.Radius = 3;
            this.btn_rooms_delete.Size = new System.Drawing.Size(354, 57);
            this.btn_rooms_delete.TabIndex = 124;
            this.btn_rooms_delete.Text = "DELETE";
            this.btn_rooms_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_rooms_delete.Click += new System.EventHandler(this.btn_rooms_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 26);
            this.label2.TabIndex = 127;
            this.label2.Text = "Select The Row You Wan\'t To Edit";
            // 
            // nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 874);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.btn_rooms_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.combo_nurse_child_name);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btn_nurse_save);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.combo_nurse_room_name);
            this.Controls.Add(this.not_nurse);
            this.Controls.Add(gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nurse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nurse";
            this.Load += new System.EventHandler(this.nurse_Load);
            ((System.ComponentModel.ISupportInitialize)(gunaPictureBox1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_nurse_save;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton btn_close;
        private Guna.UI.WinForms.GunaComboBox combo_nurse_room_name;
        private Guna.UI.WinForms.GunaTextBox not_nurse;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox combo_nurse_child_name;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_rooms_delete;
        private System.Windows.Forms.Label label2;
    }
}