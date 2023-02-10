namespace MediaPlayerApp.Components
{
    partial class SelectedSong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblSongName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnMore = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddTo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblSongNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 5;
            this.guna2CheckBox1.CheckedState.BorderThickness = 1;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.guna2CheckBox1.CheckMarkColor = System.Drawing.Color.Black;
            this.guna2CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CheckBox1.Location = new System.Drawing.Point(19, 10);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(15, 16);
            this.guna2CheckBox1.TabIndex = 4;
            this.guna2CheckBox1.TabStop = false;
            this.guna2CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 5;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 1;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.guna2CheckBox1.UseVisualStyleBackColor = false;
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // lblSongName
            // 
            this.lblSongName.BackColor = System.Drawing.Color.Transparent;
            this.lblSongName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.Black;
            this.lblSongName.IsSelectionEnabled = false;
            this.lblSongName.Location = new System.Drawing.Point(56, 10);
            this.lblSongName.MaximumSize = new System.Drawing.Size(146, 18);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(3, 2);
            this.lblSongName.TabIndex = 5;
            this.lblSongName.Text = null;
            this.lblSongName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(149, 7);
            this.guna2HtmlLabel1.MaximumSize = new System.Drawing.Size(146, 18);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(34, 18);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Clear";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            this.guna2HtmlLabel1.MouseEnter += new System.EventHandler(this.guna2HtmlLabel1_MouseEnter);
            this.guna2HtmlLabel1.MouseLeave += new System.EventHandler(this.guna2HtmlLabel1_MouseLeave);
            // 
            // btnMore
            // 
            this.btnMore.BorderRadius = 5;
            this.btnMore.BorderThickness = 1;
            this.btnMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMore.FillColor = System.Drawing.Color.White;
            this.btnMore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMore.ForeColor = System.Drawing.Color.Black;
            this.btnMore.Image = global::MediaPlayerApp.Properties.Resources.more;
            this.btnMore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMore.Location = new System.Drawing.Point(496, 5);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(39, 26);
            this.btnMore.TabIndex = 10;
            this.btnMore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMore.TextOffset = new System.Drawing.Point(-2, 0);
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnAddTo
            // 
            this.btnAddTo.BorderRadius = 5;
            this.btnAddTo.BorderThickness = 1;
            this.btnAddTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTo.FillColor = System.Drawing.Color.White;
            this.btnAddTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTo.ForeColor = System.Drawing.Color.Black;
            this.btnAddTo.Image = global::MediaPlayerApp.Properties.Resources.plus;
            this.btnAddTo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddTo.Location = new System.Drawing.Point(386, 5);
            this.btnAddTo.Name = "btnAddTo";
            this.btnAddTo.Size = new System.Drawing.Size(96, 26);
            this.btnAddTo.TabIndex = 9;
            this.btnAddTo.Text = "Add to";
            this.btnAddTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddTo.TextOffset = new System.Drawing.Point(-2, 0);
            this.btnAddTo.Click += new System.EventHandler(this.btnAddTo_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = global::MediaPlayerApp.Properties.Resources.playnext;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(-5, 0);
            this.guna2Button2.Location = new System.Drawing.Point(284, 5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(96, 26);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "Play next";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::MediaPlayerApp.Properties.Resources.white_play;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-5, 0);
            this.guna2Button1.Location = new System.Drawing.Point(209, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(69, 26);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Play";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblSongNumber
            // 
            this.lblSongNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblSongNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongNumber.ForeColor = System.Drawing.Color.Black;
            this.lblSongNumber.IsSelectionEnabled = false;
            this.lblSongNumber.Location = new System.Drawing.Point(40, 7);
            this.lblSongNumber.MaximumSize = new System.Drawing.Size(146, 18);
            this.lblSongNumber.Name = "lblSongNumber";
            this.lblSongNumber.Size = new System.Drawing.Size(10, 18);
            this.lblSongNumber.TabIndex = 11;
            this.lblSongNumber.Text = "1";
            this.lblSongNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectedSong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblSongNumber);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnAddTo);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.guna2CheckBox1);
            this.Name = "SelectedSong";
            this.Size = new System.Drawing.Size(550, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSongName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnAddTo;
        private Guna.UI2.WinForms.Guna2Button btnMore;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSongNumber;
        public Guna.UI2.WinForms.Guna2HtmlLabel LblSongNumber
        {
            get { return lblSongNumber; }
            set { lblSongNumber = value; }
        }
        public Guna.UI2.WinForms.Guna2Button BtnMore
        {
            get { return btnMore; }
            set { btnMore = value; }
        }
        public Guna.UI2.WinForms.Guna2CheckBox Guna2CheckBox1
        {
            get { return guna2CheckBox1; }
            set { guna2CheckBox1 = value; }
        }
    }
}
