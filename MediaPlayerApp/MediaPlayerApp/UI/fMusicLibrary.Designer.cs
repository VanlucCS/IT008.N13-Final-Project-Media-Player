
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblArtists = new System.Windows.Forms.Label();
            this.lblAlbums = new System.Windows.Forms.Label();
            this.lblSongs = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbGenre = new System.Windows.Forms.Label();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbUnderline = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnderline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(65, 67);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(160, 31);
            this.guna2Button1.TabIndex = 30;
            this.guna2Button1.Text = "Shuffle and play";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblArtists
            // 
            this.lblArtists.AutoSize = true;
            this.lblArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtists.Location = new System.Drawing.Point(410, 15);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(78, 29);
            this.lblArtists.TabIndex = 28;
            this.lblArtists.Text = "Artists";
            this.lblArtists.Click += new System.EventHandler(this.lblArtists_Click);
            // 
            // lblAlbums
            // 
            this.lblAlbums.AutoSize = true;
            this.lblAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbums.Location = new System.Drawing.Point(300, 15);
            this.lblAlbums.Name = "lblAlbums";
            this.lblAlbums.Size = new System.Drawing.Size(93, 29);
            this.lblAlbums.TabIndex = 27;
            this.lblAlbums.Text = "Albums";
            this.lblAlbums.Click += new System.EventHandler(this.lblAlbums_Click);
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongs.Location = new System.Drawing.Point(197, 15);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(82, 29);
            this.lblSongs.TabIndex = 26;
            this.lblSongs.Text = "Songs";
            this.lblSongs.Click += new System.EventHandler(this.lblSongs_Click);
            // 
            // lblSort
            // 
            this.lblSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(349, 64);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(191, 34);
            this.lblSort.TabIndex = 25;
            this.lblSort.Text = "Sort by: Date added  ▼";
            this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(65, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(725, 394);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // lbGenre
            // 
            this.lbGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(562, 64);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(176, 34);
            this.lbGenre.TabIndex = 23;
            this.lbGenre.Text = "Genre: All genres    ▼";
            this.lbGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFolder.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolder.Location = new System.Drawing.Point(609, 15);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(130, 40);
            this.btnAddFolder.TabIndex = 21;
            this.btnAddFolder.Text = "Add folder";
            this.btnAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFolder.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(58, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 38);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Music";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::MediaPlayerApp.Properties.Resources.white_shuffle;
            this.pictureBox2.Location = new System.Drawing.Point(84, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pbUnderline
            // 
            this.pbUnderline.BorderRadius = 3;
            this.pbUnderline.FillColor = System.Drawing.Color.OrangeRed;
            this.pbUnderline.ImageRotate = 0F;
            this.pbUnderline.Location = new System.Drawing.Point(219, 40);
            this.pbUnderline.Name = "pbUnderline";
            this.pbUnderline.Size = new System.Drawing.Size(20, 5);
            this.pbUnderline.TabIndex = 29;
            this.pbUnderline.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MediaPlayerApp.Properties.Resources.add_folder1;
            this.pictureBox1.Location = new System.Drawing.Point(620, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // fMusicLibrary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pbUnderline);
            this.Controls.Add(this.lblArtists);
            this.Controls.Add(this.lblAlbums);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMusicLibrary";
            this.Text = "fMusicLibrary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnderline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox pbUnderline;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Label lblAlbums;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}