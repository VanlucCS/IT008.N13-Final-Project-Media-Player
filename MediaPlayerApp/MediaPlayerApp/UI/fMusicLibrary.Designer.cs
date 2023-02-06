
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
            this.components = new System.ComponentModel.Container();
            this.lblArtists = new System.Windows.Forms.Label();
            this.lblAlbums = new System.Windows.Forms.Label();
            this.lblSongs = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnShuffleAndPlay = new Guna.UI2.WinForms.Guna2Button();
            this.pbxUnderline = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddFolder = new Guna.UI2.WinForms.Guna2Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUnderline)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtists
            // 
            this.lblArtists.AutoSize = true;
            this.lblArtists.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblArtists.Location = new System.Drawing.Point(333, 15);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(57, 21);
            this.lblArtists.TabIndex = 28;
            this.lblArtists.Text = "Artists";
            this.lblArtists.Click += new System.EventHandler(this.lblArtists_Click);
            // 
            // lblAlbums
            // 
            this.lblAlbums.AutoSize = true;
            this.lblAlbums.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAlbums.Location = new System.Drawing.Point(223, 15);
            this.lblAlbums.Name = "lblAlbums";
            this.lblAlbums.Size = new System.Drawing.Size(65, 21);
            this.lblAlbums.TabIndex = 27;
            this.lblAlbums.Text = "Albums";
            this.lblAlbums.Click += new System.EventHandler(this.lblAlbums_Click);
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSongs.Location = new System.Drawing.Point(120, 15);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(55, 21);
            this.lblSongs.TabIndex = 26;
            this.lblSongs.Text = "Songs";
            this.lblSongs.Click += new System.EventHandler(this.lblSongs_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(797, 410);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 30);
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
            this.btnShuffleAndPlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.btnShuffleAndPlay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffleAndPlay.ForeColor = System.Drawing.Color.White;
            this.btnShuffleAndPlay.Image = global::MediaPlayerApp.Properties.Resources.white_shuffle;
            this.btnShuffleAndPlay.Location = new System.Drawing.Point(12, 55);
            this.btnShuffleAndPlay.Name = "btnShuffleAndPlay";
            this.btnShuffleAndPlay.Size = new System.Drawing.Size(127, 30);
            this.btnShuffleAndPlay.TabIndex = 30;
            this.btnShuffleAndPlay.Text = "Shuffle and play";
            // 
            // pbxUnderline
            // 
            this.pbxUnderline.BorderRadius = 3;
            this.pbxUnderline.FillColor = System.Drawing.Color.OrangeRed;
            this.pbxUnderline.ImageRotate = 0F;
            this.pbxUnderline.Location = new System.Drawing.Point(137, 38);
            this.pbxUnderline.Name = "pbxUnderline";
            this.pbxUnderline.Size = new System.Drawing.Size(20, 5);
            this.pbxUnderline.TabIndex = 29;
            this.pbxUnderline.TabStop = false;
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
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblSort
            // 
            this.lblSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSort.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblSort.Location = new System.Drawing.Point(378, 62);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(71, 27);
            this.lblSort.TabIndex = 60;
            this.lblSort.Text = "Sort by : ";
            this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGenre
            // 
            this.lbGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGenre.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbGenre.Location = new System.Drawing.Point(580, 63);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(56, 28);
            this.lbGenre.TabIndex = 63;
            this.lbGenre.Text = "Genre : ";
            this.lbGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbGenre.Click += new System.EventHandler(this.lbGenre_Click);
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FillColor = System.Drawing.SystemColors.Control;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.Red;
            this.guna2ComboBox2.ItemHeight = 20;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "All genres"});
            this.guna2ComboBox2.Location = new System.Drawing.Point(642, 63);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(107, 26);
            this.guna2ComboBox2.StartIndex = 0;
            this.guna2ComboBox2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2ComboBox2.TabIndex = 65;
            this.guna2ComboBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Red;
            this.guna2ComboBox1.ItemHeight = 20;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Date added"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(442, 63);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(120, 26);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2ComboBox1.TabIndex = 64;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fMusicLibrary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.btnShuffleAndPlay);
            this.Controls.Add(this.pbxUnderline);
            this.Controls.Add(this.lblArtists);
            this.Controls.Add(this.lblAlbums);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMusicLibrary";
            this.Text = "fMusicLibrary";
            this.Load += new System.EventHandler(this.fMusicLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUnderline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnShuffleAndPlay;
        private Guna.UI2.WinForms.Guna2PictureBox pbxUnderline;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Label lblAlbums;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnAddFolder;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lbGenre;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Timer timer1;
    }
}