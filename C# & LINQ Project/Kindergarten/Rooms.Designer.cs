namespace kindergarten2
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.combo_rooms_child_name = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.combo_rooms_roomsName = new Guna.UI.WinForms.GunaComboBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_close = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_rooms_delete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_rooms_save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tblroomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(gunaPictureBox1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblroomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            gunaPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.InitialImage")));
            gunaPictureBox1.Location = new System.Drawing.Point(-87, 101);
            gunaPictureBox1.Name = "gunaPictureBox1";
            gunaPictureBox1.Size = new System.Drawing.Size(1693, 937);
            gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            gunaPictureBox1.TabIndex = 71;
            gunaPictureBox1.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(84, 208);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(85, 19);
            this.gunaLabel2.TabIndex = 68;
            this.gunaLabel2.Text = "Room Name";
            // 
            // combo_rooms_child_name
            // 
            this.combo_rooms_child_name.BackColor = System.Drawing.Color.Transparent;
            this.combo_rooms_child_name.BaseColor = System.Drawing.Color.White;
            this.combo_rooms_child_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.combo_rooms_child_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_rooms_child_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_rooms_child_name.FocusedColor = System.Drawing.Color.Empty;
            this.combo_rooms_child_name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_rooms_child_name.ForeColor = System.Drawing.Color.Black;
            this.combo_rooms_child_name.FormattingEnabled = true;
            this.combo_rooms_child_name.IntegralHeight = false;
            this.combo_rooms_child_name.ItemHeight = 42;
            this.combo_rooms_child_name.Location = new System.Drawing.Point(88, 143);
            this.combo_rooms_child_name.Name = "combo_rooms_child_name";
            this.combo_rooms_child_name.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combo_rooms_child_name.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combo_rooms_child_name.Radius = 5;
            this.combo_rooms_child_name.Size = new System.Drawing.Size(351, 48);
            this.combo_rooms_child_name.TabIndex = 67;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(84, 112);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(80, 19);
            this.gunaLabel3.TabIndex = 66;
            this.gunaLabel3.Text = "Child Name";
            // 
            // combo_rooms_roomsName
            // 
            this.combo_rooms_roomsName.BackColor = System.Drawing.Color.Transparent;
            this.combo_rooms_roomsName.BaseColor = System.Drawing.Color.White;
            this.combo_rooms_roomsName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.combo_rooms_roomsName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_rooms_roomsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_rooms_roomsName.FocusedColor = System.Drawing.Color.Empty;
            this.combo_rooms_roomsName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_rooms_roomsName.ForeColor = System.Drawing.Color.Black;
            this.combo_rooms_roomsName.FormattingEnabled = true;
            this.combo_rooms_roomsName.IntegralHeight = false;
            this.combo_rooms_roomsName.ItemHeight = 42;
            this.combo_rooms_roomsName.Location = new System.Drawing.Point(88, 243);
            this.combo_rooms_roomsName.Name = "combo_rooms_roomsName";
            this.combo_rooms_roomsName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combo_rooms_roomsName.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combo_rooms_roomsName.Radius = 5;
            this.combo_rooms_roomsName.Size = new System.Drawing.Size(351, 48);
            this.combo_rooms_roomsName.TabIndex = 65;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.Controls.Add(this.gunaAdvenceButton3);
            this.gunaElipsePanel1.Controls.Add(this.btn_close);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(-1, -1);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1391, 79);
            this.gunaElipsePanel1.TabIndex = 69;
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
            this.btn_rooms_delete.Location = new System.Drawing.Point(88, 387);
            this.btn_rooms_delete.Name = "btn_rooms_delete";
            this.btn_rooms_delete.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_rooms_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_rooms_delete.OnHoverForeColor = System.Drawing.Color.Coral;
            this.btn_rooms_delete.OnHoverImage = null;
            this.btn_rooms_delete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_rooms_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_rooms_delete.Radius = 3;
            this.btn_rooms_delete.Size = new System.Drawing.Size(351, 57);
            this.btn_rooms_delete.TabIndex = 78;
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
            this.btn_rooms_save.Location = new System.Drawing.Point(88, 318);
            this.btn_rooms_save.Name = "btn_rooms_save";
            this.btn_rooms_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(148)))), ((int)(((byte)(80)))));
            this.btn_rooms_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_rooms_save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_rooms_save.OnHoverImage = null;
            this.btn_rooms_save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_rooms_save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_rooms_save.Radius = 3;
            this.btn_rooms_save.Size = new System.Drawing.Size(351, 57);
            this.btn_rooms_save.TabIndex = 76;
            this.btn_rooms_save.Text = "SAVE OR UPDATE";
            this.btn_rooms_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_rooms_save.Click += new System.EventHandler(this.btn_rooms_save_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(511, 143);
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
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(823, 522);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(88, 608);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 3;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(351, 57);
            this.gunaAdvenceButton1.TabIndex = 95;
            this.gunaAdvenceButton1.Text = "CLEAR";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 26);
            this.label1.TabIndex = 96;
            this.label1.Text = "Make Sure Clear All Field Before Adding New Data";
            // 
            // tblroomsBindingSource
            // 
            this.tblroomsBindingSource.DataSource = typeof(kindergarten2.tbl_rooms);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 874);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_rooms_delete);
            this.Controls.Add(this.btn_rooms_save);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.combo_rooms_child_name);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.combo_rooms_roomsName);
            this.Controls.Add(gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(gunaPictureBox1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblroomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox combo_rooms_child_name;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox combo_rooms_roomsName;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton btn_close;
        private Guna.UI.WinForms.GunaAdvenceButton btn_rooms_delete;
        private Guna.UI.WinForms.GunaAdvenceButton btn_rooms_save;
        private System.Windows.Forms.BindingSource tblroomsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}