namespace kindergarten2
{
    partial class add_address
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_address));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btn_address = new Guna.UI.WinForms.GunaAdvenceButton();
            this.address = new Guna.UI.WinForms.GunaLineTextBox();
            this.btn_close = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // btn_address
            // 
            this.btn_address.Animated = true;
            this.btn_address.AnimationHoverSpeed = 0.07F;
            this.btn_address.AnimationSpeed = 0.03F;
            this.btn_address.BackColor = System.Drawing.Color.Transparent;
            this.btn_address.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.btn_address.BorderColor = System.Drawing.Color.Black;
            this.btn_address.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_address.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_address.CheckedForeColor = System.Drawing.Color.White;
            this.btn_address.CheckedImage = null;
            this.btn_address.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_address.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_address.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_address.FocusedColor = System.Drawing.Color.Empty;
            this.btn_address.Font = new System.Drawing.Font("Open Sans", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_address.ForeColor = System.Drawing.Color.White;
            this.btn_address.Image = null;
            this.btn_address.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_address.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_address.Location = new System.Drawing.Point(155, 195);
            this.btn_address.Name = "btn_address";
            this.btn_address.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_address.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.btn_address.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(166)))), ((int)(((byte)(97)))));
            this.btn_address.OnHoverImage = null;
            this.btn_address.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_address.OnPressedColor = System.Drawing.Color.Black;
            this.btn_address.Radius = 3;
            this.btn_address.Size = new System.Drawing.Size(351, 57);
            this.btn_address.TabIndex = 68;
            this.btn_address.Text = "ADD NEW ADDRESS";
            this.btn_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_address.Click += new System.EventHandler(this.btn_address_Click);
            // 
            // address
            // 
            this.address.Animated = true;
            this.address.BackColor = System.Drawing.Color.White;
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(183)))), ((int)(((byte)(107)))));
            this.address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.address.LineColor = System.Drawing.Color.Gainsboro;
            this.address.Location = new System.Drawing.Point(155, 130);
            this.address.Name = "address";
            this.address.PasswordChar = '\0';
            this.address.Size = new System.Drawing.Size(351, 44);
            this.address.TabIndex = 67;
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
            this.btn_close.Location = new System.Drawing.Point(637, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_close.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_close.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_close.OnHoverImage = null;
            this.btn_close.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btn_close.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_close.Size = new System.Drawing.Size(31, 42);
            this.btn_close.TabIndex = 69;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // add_address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 375);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_address);
            this.Controls.Add(this.address);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_address";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_address";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_close;
        private Guna.UI.WinForms.GunaAdvenceButton btn_address;
        private Guna.UI.WinForms.GunaLineTextBox address;
    }
}