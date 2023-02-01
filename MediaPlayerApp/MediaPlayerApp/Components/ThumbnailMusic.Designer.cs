namespace MediaPlayerApp.Components
{
    partial class ThumbnailMusic
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
            this.lblSongName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblArtist = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAlbum = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGenre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPlay = new Guna.UI2.WinForms.Guna2Button();
            this.checkBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // lblSongName
            // 
            this.lblSongName.BackColor = System.Drawing.Color.Transparent;
            this.lblSongName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(63)))), ((int)(((byte)(10)))));
            this.lblSongName.IsSelectionEnabled = false;
            this.lblSongName.Location = new System.Drawing.Point(75, 14);
            this.lblSongName.MaximumSize = new System.Drawing.Size(146, 18);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(130, 18);
            this.lblSongName.TabIndex = 0;
            this.lblSongName.Text = "Leave the door open";
            this.lblSongName.MouseEnter += new System.EventHandler(this.ThumbnailMusic_MouseEnter);
            this.lblSongName.MouseLeave += new System.EventHandler(this.ThumbnailMusic_MouseLeave);
            // 
            // lblArtist
            // 
            this.lblArtist.BackColor = System.Drawing.Color.Transparent;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(63)))), ((int)(((byte)(10)))));
            this.lblArtist.IsSelectionEnabled = false;
            this.lblArtist.Location = new System.Drawing.Point(208, 14);
            this.lblArtist.MaximumSize = new System.Drawing.Size(103, 15);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(97, 15);
            this.lblArtist.TabIndex = 0;
            this.lblArtist.Text = "Unknown artist";
            this.lblArtist.MouseEnter += new System.EventHandler(this.ThumbnailMusic_MouseEnter);
            this.lblArtist.MouseLeave += new System.EventHandler(this.ThumbnailMusic_MouseLeave);
            // 
            // lblAlbum
            // 
            this.lblAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(63)))), ((int)(((byte)(10)))));
            this.lblAlbum.IsSelectionEnabled = false;
            this.lblAlbum.Location = new System.Drawing.Point(310, 14);
            this.lblAlbum.MaximumSize = new System.Drawing.Size(111, 18);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(104, 18);
            this.lblAlbum.TabIndex = 0;
            this.lblAlbum.Text = "Unknown album";
            this.lblAlbum.MouseEnter += new System.EventHandler(this.ThumbnailMusic_MouseEnter);
            this.lblAlbum.MouseLeave += new System.EventHandler(this.ThumbnailMusic_MouseLeave);
            // 
            // lblGenre
            // 
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(63)))), ((int)(((byte)(10)))));
            this.lblGenre.IsSelectionEnabled = false;
            this.lblGenre.Location = new System.Drawing.Point(419, 14);
            this.lblGenre.MaximumSize = new System.Drawing.Size(109, 18);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(100, 18);
            this.lblGenre.TabIndex = 0;
            this.lblGenre.Text = "Unknown genre";
            this.lblGenre.MouseEnter += new System.EventHandler(this.ThumbnailMusic_MouseEnter);
            this.lblGenre.MouseLeave += new System.EventHandler(this.ThumbnailMusic_MouseLeave);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(63)))), ((int)(((byte)(10)))));
            this.lblTime.IsSelectionEnabled = false;
            this.lblTime.Location = new System.Drawing.Point(528, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 19);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "04:08";
            this.lblTime.MouseEnter += new System.EventHandler(this.ThumbnailMusic_MouseEnter);
            this.lblTime.MouseLeave += new System.EventHandler(this.ThumbnailMusic_MouseLeave);
            // 
            // btnPlay
            // 
            this.btnPlay.BorderRadius = 5;
            this.btnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlay.FillColor = System.Drawing.Color.Transparent;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnPlay.Image = global::MediaPlayerApp.Properties.Resources.play_96px;
            this.btnPlay.Location = new System.Drawing.Point(48, 9);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(24, 24);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.MouseEnter += new System.EventHandler(this.ThumbnailMusic_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.ThumbnailMusic_MouseLeave);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox.CheckedState.BorderRadius = 0;
            this.checkBox.CheckedState.BorderThickness = 0;
            this.checkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox.Location = new System.Drawing.Point(15, 16);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 2;
            this.checkBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox.UncheckedState.BorderRadius = 0;
            this.checkBox.UncheckedState.BorderThickness = 0;
            this.checkBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ThumbnailMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblSongName);
            this.Name = "ThumbnailMusic";
            this.Size = new System.Drawing.Size(580, 46);
            this.ClientSizeChanged += new System.EventHandler(this.ThumbnailMusic_ClientSizeChanged);
            this.MouseEnter += new System.EventHandler(this.ThumbnailMusic_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ThumbnailMusic_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblSongName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblArtist;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAlbum;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGenre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private Guna.UI2.WinForms.Guna2Button btnPlay;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox;
    }
}
