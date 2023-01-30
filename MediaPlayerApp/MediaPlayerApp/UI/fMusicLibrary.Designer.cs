﻿
namespace MediaPlayerApp.UI
{
    partial class fMusicLibrary
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
            this.lblArtists = new System.Windows.Forms.Label();
            this.lblAlbums = new System.Windows.Forms.Label();
            this.lblSongs = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnShuffleAndPlay = new Guna.UI2.WinForms.Guna2Button();
            this.pbUnderline = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddFolder = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnderline)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtists
            // 
            this.lblArtists.AutoSize = true;
            this.lblArtists.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblArtists.Location = new System.Drawing.Point(410, 15);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(70, 28);
            this.lblArtists.TabIndex = 28;
            this.lblArtists.Text = "Artists";
            this.lblArtists.Click += new System.EventHandler(this.lblArtists_Click);
            // 
            // lblAlbums
            // 
            this.lblAlbums.AutoSize = true;
            this.lblAlbums.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAlbums.Location = new System.Drawing.Point(300, 15);
            this.lblAlbums.Name = "lblAlbums";
            this.lblAlbums.Size = new System.Drawing.Size(81, 28);
            this.lblAlbums.TabIndex = 27;
            this.lblAlbums.Text = "Albums";
            this.lblAlbums.Click += new System.EventHandler(this.lblAlbums_Click);
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSongs.Location = new System.Drawing.Point(197, 15);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(68, 28);
            this.lblSongs.TabIndex = 26;
            this.lblSongs.Text = "Songs";
            this.lblSongs.Click += new System.EventHandler(this.lblSongs_Click);
            // 
            // lblSort
            // 
            this.lblSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSort.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblSort.Location = new System.Drawing.Point(349, 58);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(191, 34);
            this.lblSort.TabIndex = 25;
            this.lblSort.Text = "Sort by: Date added  ▼";
            this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 410);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // lbGenre
            // 
            this.lbGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGenre.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbGenre.Location = new System.Drawing.Point(564, 59);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(176, 34);
            this.lbGenre.TabIndex = 23;
            this.lbGenre.Text = "Genre: All genres    ▼";
            this.lbGenre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 37);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Music";
            // 
            // btnShuffleAndPlay
            // 
            this.btnShuffleAndPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffleAndPlay.BorderRadius = 5;
            this.btnShuffleAndPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShuffleAndPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShuffleAndPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShuffleAndPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShuffleAndPlay.FillColor = System.Drawing.Color.OrangeRed;
            this.btnShuffleAndPlay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffleAndPlay.ForeColor = System.Drawing.Color.White;
            this.btnShuffleAndPlay.Image = global::MediaPlayerApp.Properties.Resources.white_shuffle;
            this.btnShuffleAndPlay.Location = new System.Drawing.Point(12, 55);
            this.btnShuffleAndPlay.Name = "btnShuffleAndPlay";
            this.btnShuffleAndPlay.Size = new System.Drawing.Size(154, 30);
            this.btnShuffleAndPlay.TabIndex = 30;
            this.btnShuffleAndPlay.Text = "Shuffle and play";
            // 
            // pbUnderline
            // 
            this.pbUnderline.BorderRadius = 3;
            this.pbUnderline.FillColor = System.Drawing.Color.OrangeRed;
            this.pbUnderline.ImageRotate = 0F;
            this.pbUnderline.Location = new System.Drawing.Point(214, 38);
            this.pbUnderline.Name = "pbUnderline";
            this.pbUnderline.Size = new System.Drawing.Size(20, 5);
            this.pbUnderline.TabIndex = 29;
            this.pbUnderline.TabStop = false;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFolder.BorderRadius = 5;
            this.btnAddFolder.BorderThickness = 1;
            this.btnAddFolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFolder.FillColor = System.Drawing.SystemColors.Control;
            this.btnAddFolder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolder.ForeColor = System.Drawing.Color.Black;
            this.btnAddFolder.Image = global::MediaPlayerApp.Properties.Resources.add_folder;
            this.btnAddFolder.Location = new System.Drawing.Point(595, 22);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.PressedColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddFolder.Size = new System.Drawing.Size(143, 30);
            this.btnAddFolder.TabIndex = 52;
            this.btnAddFolder.Text = " Add folder";
            // 
            // fMusicLibrary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.btnShuffleAndPlay);
            this.Controls.Add(this.pbUnderline);
            this.Controls.Add(this.lblArtists);
            this.Controls.Add(this.lblAlbums);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMusicLibrary";
            this.Text = "fMusicLibrary";
            ((System.ComponentModel.ISupportInitialize)(this.pbUnderline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnShuffleAndPlay;
        private Guna.UI2.WinForms.Guna2PictureBox pbUnderline;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Label lblAlbums;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnAddFolder;
    }
}