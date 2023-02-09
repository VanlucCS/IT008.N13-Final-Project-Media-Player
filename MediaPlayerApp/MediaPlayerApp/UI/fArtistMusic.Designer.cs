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
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblSongs = new System.Windows.Forms.Label();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.btnAddTo = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewPlaylist = new Guna.UI2.WinForms.Guna2Button();
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
            this.pnSong.TabIndex = 72;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalTime.Location = new System.Drawing.Point(404, 66);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(38, 17);
            this.lblTotalTime.TabIndex = 68;
            this.lblTotalTime.Text = "Text1";
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongs.ForeColor = System.Drawing.Color.Black;
            this.lblSongs.Location = new System.Drawing.Point(254, 66);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(38, 17);
            this.lblSongs.TabIndex = 69;
            this.lblSongs.Text = "Text1";
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.Location = new System.Drawing.Point(250, 21);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(91, 40);
            this.lblArtistName.TabIndex = 67;
            this.lblArtistName.Text = "Text1";
            // 
            // btnAddTo
            // 
            this.btnAddTo.BorderColor = System.Drawing.Color.Silver;
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
            this.btnAddTo.Location = new System.Drawing.Point(407, 122);
            this.btnAddTo.Name = "btnAddTo";
            this.btnAddTo.Size = new System.Drawing.Size(93, 29);
            this.btnAddTo.TabIndex = 71;
            this.btnAddTo.Text = "Add to";
            this.btnAddTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddTo.TextOffset = new System.Drawing.Point(-2, 0);
            this.btnAddTo.Click += new System.EventHandler(this.btnAddTo_Click);
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
            this.btnNewPlaylist.TabIndex = 70;
            this.btnNewPlaylist.Text = "Play All";
            this.btnNewPlaylist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // avatar
            // 
            this.avatar.Image = global::MediaPlayerApp.Properties.Resources.UnknownArtist;
            this.avatar.Location = new System.Drawing.Point(66, 10);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(157, 157);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 73;
            this.avatar.TabStop = false;
            // 
            // fArtistMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Controls.Add(this.pnSong);
            this.Controls.Add(this.btnAddTo);
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
        private Guna.UI2.WinForms.Guna2Button btnAddTo;
        private Guna.UI2.WinForms.Guna2Button btnNewPlaylist;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.PictureBox avatar;
    }
}