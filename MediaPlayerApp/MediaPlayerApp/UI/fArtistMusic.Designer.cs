namespace MediaPlayerApp.UI
{
    partial class fArtistMusic
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
            this.pnSong = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.lblSongs = new System.Windows.Forms.Label();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSong
            // 
            this.pnSong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSong.AutoScroll = true;
            this.pnSong.Location = new System.Drawing.Point(-6, 186);
            this.pnSong.Name = "pnSong";
            this.pnSong.Size = new System.Drawing.Size(801, 314);
            this.pnSong.TabIndex = 65;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.Silver;
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Image = global::MediaPlayerApp.Properties.Resources.plus;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(407, 122);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(93, 29);
            this.guna2Button3.TabIndex = 62;
            this.guna2Button3.Text = "Add to";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button3.TextOffset = new System.Drawing.Point(-2, 0);
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPlaylist.BorderRadius = 5;
            this.btnNewPlaylist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewPlaylist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewPlaylist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewPlaylist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewPlaylist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(62)))), ((int)(((byte)(9)))));
            this.btnNewPlaylist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnNewPlaylist.Image = global::MediaPlayerApp.Properties.Resources.play_96px;
            this.btnNewPlaylist.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewPlaylist.ImageSize = new System.Drawing.Size(32, 32);
            this.btnNewPlaylist.Location = new System.Drawing.Point(257, 115);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Size = new System.Drawing.Size(100, 40);
            this.btnNewPlaylist.TabIndex = 61;
            this.btnNewPlaylist.Text = "Play All";
            this.btnNewPlaylist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongs.ForeColor = System.Drawing.Color.Black;
            this.lblSongs.Location = new System.Drawing.Point(254, 66);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(38, 17);
            this.lblSongs.TabIndex = 60;
            this.lblSongs.Text = "Text1";
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.Location = new System.Drawing.Point(250, 21);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(91, 40);
            this.lblArtistName.TabIndex = 59;
            this.lblArtistName.Text = "Text1";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalTime.Location = new System.Drawing.Point(404, 66);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(38, 17);
            this.lblTotalTime.TabIndex = 60;
            this.lblTotalTime.Text = "Text1";
            // 
            // avatar
            // 
            this.avatar.Image = global::MediaPlayerApp.Properties.Resources.UnknownArtist;
            this.avatar.Location = new System.Drawing.Point(66, 10);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(157, 157);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 66;
            this.avatar.TabStop = false;
            // 
            // fArtistMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.ControlBox = false;
            this.Controls.Add(this.pnSong);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.btnNewPlaylist);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.lblArtistName);
            this.Controls.Add(this.avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fArtistMusic";
            this.Text = "fArtistMusic";
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnSong;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnNewPlaylist;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.PictureBox avatar;
    }
}