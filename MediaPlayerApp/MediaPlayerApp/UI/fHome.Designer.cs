
namespace MediaPlayerApp
{
    partial class fHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHome));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnControlMedia = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cbtshuffer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbtloop = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbSongName = new System.Windows.Forms.Label();
            this.pbSongpic = new System.Windows.Forms.PictureBox();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.btFavorite = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btVolume = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tbVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbShuffer = new System.Windows.Forms.PictureBox();
            this.pbPrev = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbRepeatSong = new System.Windows.Forms.PictureBox();
            this.lbTimeCurrentPlay = new System.Windows.Forms.Label();
            this.tbProcess = new Guna.UI2.WinForms.Guna2TrackBar();
            this.pnHeader = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btMaxsize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btMinisize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.btVideoLibrary = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btPlayqueue = new Guna.UI2.WinForms.Guna2Button();
            this.btPlayList = new Guna.UI2.WinForms.Guna2Button();
            this.btHisListen = new Guna.UI2.WinForms.Guna2Button();
            this.btFravorSong = new Guna.UI2.WinForms.Guna2Button();
            this.btMusicLibrary = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.togMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btHome = new Guna.UI2.WinForms.Guna2Button();
            this.pnChildren = new Guna.UI2.WinForms.Guna2Panel();
            this.moreButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnControlMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSongpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRepeatSong)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.4D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnControlMedia
            // 
            this.pnControlMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnControlMedia.Controls.Add(this.moreButton);
            this.pnControlMedia.Controls.Add(this.cbtshuffer);
            this.pnControlMedia.Controls.Add(this.cbtloop);
            this.pnControlMedia.Controls.Add(this.lbSongName);
            this.pnControlMedia.Controls.Add(this.pbSongpic);
            this.pnControlMedia.Controls.Add(this.Media);
            this.pnControlMedia.Controls.Add(this.btFavorite);
            this.pnControlMedia.Controls.Add(this.btVolume);
            this.pnControlMedia.Controls.Add(this.tbVolume);
            this.pnControlMedia.Controls.Add(this.btPlay);
            this.pnControlMedia.Controls.Add(this.pbShuffer);
            this.pnControlMedia.Controls.Add(this.pbPrev);
            this.pnControlMedia.Controls.Add(this.pbNext);
            this.pnControlMedia.Controls.Add(this.pbRepeatSong);
            this.pnControlMedia.Controls.Add(this.lbTimeCurrentPlay);
            this.pnControlMedia.Controls.Add(this.tbProcess);
            this.pnControlMedia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControlMedia.Location = new System.Drawing.Point(0, 549);
            this.pnControlMedia.Margin = new System.Windows.Forms.Padding(4);
            this.pnControlMedia.Name = "pnControlMedia";
            this.pnControlMedia.Size = new System.Drawing.Size(1000, 101);
            this.pnControlMedia.TabIndex = 0;
            // 
            // cbtshuffer
            // 
            this.cbtshuffer.BackColor = System.Drawing.Color.Transparent;
            this.cbtshuffer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbtshuffer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbtshuffer.ForeColor = System.Drawing.Color.White;
            this.cbtshuffer.Location = new System.Drawing.Point(394, 81);
            this.cbtshuffer.Name = "cbtshuffer";
            this.cbtshuffer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cbtshuffer.Size = new System.Drawing.Size(10, 10);
            this.cbtshuffer.TabIndex = 21;
            this.cbtshuffer.Visible = false;
            // 
            // cbtloop
            // 
            this.cbtloop.BackColor = System.Drawing.Color.Transparent;
            this.cbtloop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbtloop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbtloop.ForeColor = System.Drawing.Color.White;
            this.cbtloop.Location = new System.Drawing.Point(655, 79);
            this.cbtloop.Name = "cbtloop";
            this.cbtloop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cbtloop.Size = new System.Drawing.Size(10, 10);
            this.cbtloop.TabIndex = 20;
            this.cbtloop.Visible = false;
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.Location = new System.Drawing.Point(101, 31);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(64, 25);
            this.lbSongName.TabIndex = 19;
            this.lbSongName.Text = "label3";
            // 
            // pbSongpic
            // 
            this.pbSongpic.Location = new System.Drawing.Point(0, 0);
            this.pbSongpic.Name = "pbSongpic";
            this.pbSongpic.Size = new System.Drawing.Size(100, 100);
            this.pbSongpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSongpic.TabIndex = 18;
            this.pbSongpic.TabStop = false;
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(323, 29);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(56, 46);
            this.Media.TabIndex = 0;
            this.Media.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Media_PlayStateChange);
            this.Media.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.Media_MediaChange);
            // 
            // btFavorite
            // 
            this.btFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFavorite.BackColor = System.Drawing.Color.Transparent;
            this.btFavorite.CheckedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btFavorite.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btFavorite.Image = global::MediaPlayerApp.Properties.Resources.heart2;
            this.btFavorite.ImageOffset = new System.Drawing.Point(0, 0);
            this.btFavorite.ImageRotate = 0F;
            this.btFavorite.ImageSize = new System.Drawing.Size(35, 35);
            this.btFavorite.Location = new System.Drawing.Point(812, 55);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btFavorite.Size = new System.Drawing.Size(39, 35);
            this.btFavorite.TabIndex = 17;
            this.btFavorite.Click += new System.EventHandler(this.btFavorite_Click);
            // 
            // btVolume
            // 
            this.btVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btVolume.Checked = true;
            this.btVolume.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btVolume.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btVolume.Image = global::MediaPlayerApp.Properties.Resources.medium_volume;
            this.btVolume.ImageOffset = new System.Drawing.Point(0, 0);
            this.btVolume.ImageRotate = 0F;
            this.btVolume.ImageSize = new System.Drawing.Size(32, 32);
            this.btVolume.Location = new System.Drawing.Point(857, 55);
            this.btVolume.Name = "btVolume";
            this.btVolume.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btVolume.Size = new System.Drawing.Size(39, 35);
            this.btVolume.TabIndex = 16;
            this.btVolume.Click += new System.EventHandler(this.btVolume_Click_1);
            // 
            // tbVolume
            // 
            this.tbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVolume.LargeChange = 2;
            this.tbVolume.Location = new System.Drawing.Point(902, 60);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(87, 25);
            this.tbVolume.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.tbVolume.TabIndex = 0;
            this.tbVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbVolume_Scroll);
            // 
            // btPlay
            // 
            this.btPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btPlay.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btPlay.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btPlay.Image = global::MediaPlayerApp.Properties.Resources.play_button;
            this.btPlay.ImageOffset = new System.Drawing.Point(0, 0);
            this.btPlay.ImageRotate = 0F;
            this.btPlay.ImageSize = new System.Drawing.Size(50, 50);
            this.btPlay.Location = new System.Drawing.Point(504, 34);
            this.btPlay.Name = "btPlay";
            this.btPlay.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btPlay.Size = new System.Drawing.Size(64, 54);
            this.btPlay.TabIndex = 14;
            this.btPlay.CheckedChanged += new System.EventHandler(this.btPlay_CheckedChanged);
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // pbShuffer
            // 
            this.pbShuffer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbShuffer.Image = global::MediaPlayerApp.Properties.Resources.shuffle;
            this.pbShuffer.Location = new System.Drawing.Point(385, 43);
            this.pbShuffer.Name = "pbShuffer";
            this.pbShuffer.Size = new System.Drawing.Size(32, 32);
            this.pbShuffer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShuffer.TabIndex = 12;
            this.pbShuffer.TabStop = false;
            this.pbShuffer.Click += new System.EventHandler(this.pbShuffer_Click);
            // 
            // pbPrev
            // 
            this.pbPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPrev.Image = global::MediaPlayerApp.Properties.Resources.left;
            this.pbPrev.Location = new System.Drawing.Point(445, 43);
            this.pbPrev.Name = "pbPrev";
            this.pbPrev.Size = new System.Drawing.Size(32, 32);
            this.pbPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrev.TabIndex = 11;
            this.pbPrev.TabStop = false;
            this.pbPrev.Click += new System.EventHandler(this.pbPrev_Click);
            // 
            // pbNext
            // 
            this.pbNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbNext.Image = global::MediaPlayerApp.Properties.Resources.right;
            this.pbNext.Location = new System.Drawing.Point(583, 43);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(32, 32);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNext.TabIndex = 10;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // pbRepeatSong
            // 
            this.pbRepeatSong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbRepeatSong.Image = global::MediaPlayerApp.Properties.Resources.repeat9;
            this.pbRepeatSong.Location = new System.Drawing.Point(643, 43);
            this.pbRepeatSong.Name = "pbRepeatSong";
            this.pbRepeatSong.Size = new System.Drawing.Size(32, 32);
            this.pbRepeatSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRepeatSong.TabIndex = 9;
            this.pbRepeatSong.TabStop = false;
            this.pbRepeatSong.Click += new System.EventHandler(this.pbRepeatSong_Click);
            // 
            // lbTimeCurrentPlay
            // 
            this.lbTimeCurrentPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTimeCurrentPlay.AutoSize = true;
            this.lbTimeCurrentPlay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeCurrentPlay.Location = new System.Drawing.Point(98, 6);
            this.lbTimeCurrentPlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeCurrentPlay.Name = "lbTimeCurrentPlay";
            this.lbTimeCurrentPlay.Size = new System.Drawing.Size(65, 20);
            this.lbTimeCurrentPlay.TabIndex = 1;
            this.lbTimeCurrentPlay.Text = "00:00:00";
            // 
            // tbProcess
            // 
            this.tbProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProcess.Location = new System.Drawing.Point(166, 1);
            this.tbProcess.Margin = new System.Windows.Forms.Padding(4);
            this.tbProcess.Name = "tbProcess";
            this.tbProcess.Size = new System.Drawing.Size(781, 28);
            this.tbProcess.TabIndex = 0;
            this.tbProcess.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbProcess.Value = 0;
            this.tbProcess.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbProcess_Scroll);
            // 
            // pnHeader
            // 
            this.pnHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnHeader.Controls.Add(this.btMaxsize);
            this.pnHeader.Controls.Add(this.btMinisize);
            this.pnHeader.Controls.Add(this.btExit);
            this.pnHeader.Location = new System.Drawing.Point(212, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(788, 40);
            this.pnHeader.TabIndex = 1;
            // 
            // btMaxsize
            // 
            this.btMaxsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaxsize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btMaxsize.FillColor = System.Drawing.SystemColors.Control;
            this.btMaxsize.IconColor = System.Drawing.Color.Black;
            this.btMaxsize.Location = new System.Drawing.Point(630, 5);
            this.btMaxsize.Name = "btMaxsize";
            this.btMaxsize.Size = new System.Drawing.Size(45, 29);
            this.btMaxsize.TabIndex = 2;
            // 
            // btMinisize
            // 
            this.btMinisize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinisize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btMinisize.FillColor = System.Drawing.SystemColors.Control;
            this.btMinisize.IconColor = System.Drawing.Color.Black;
            this.btMinisize.Location = new System.Drawing.Point(681, 5);
            this.btMinisize.Name = "btMinisize";
            this.btMinisize.Size = new System.Drawing.Size(45, 29);
            this.btMinisize.TabIndex = 1;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.CustomIconSize = 15F;
            this.btExit.FillColor = System.Drawing.SystemColors.Control;
            this.btExit.IconColor = System.Drawing.Color.Black;
            this.btExit.Location = new System.Drawing.Point(732, 5);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(45, 29);
            this.btExit.TabIndex = 0;
            // 
            // pnLeft
            // 
            this.pnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnLeft.Controls.Add(this.btVideoLibrary);
            this.pnLeft.Controls.Add(this.guna2Separator1);
            this.pnLeft.Controls.Add(this.btPlayqueue);
            this.pnLeft.Controls.Add(this.btPlayList);
            this.pnLeft.Controls.Add(this.btHisListen);
            this.pnLeft.Controls.Add(this.btFravorSong);
            this.pnLeft.Controls.Add(this.btMusicLibrary);
            this.pnLeft.Controls.Add(this.label1);
            this.pnLeft.Controls.Add(this.label2);
            this.pnLeft.Controls.Add(this.togMode);
            this.pnLeft.Controls.Add(this.btHome);
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(212, 553);
            this.pnLeft.TabIndex = 2;
            // 
            // btVideoLibrary
            // 
            this.btVideoLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btVideoLibrary.Animated = true;
            this.btVideoLibrary.BorderRadius = 5;
            this.btVideoLibrary.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btVideoLibrary.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btVideoLibrary.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btVideoLibrary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btVideoLibrary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btVideoLibrary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btVideoLibrary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btVideoLibrary.FillColor = System.Drawing.SystemColors.Control;
            this.btVideoLibrary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btVideoLibrary.ForeColor = System.Drawing.Color.Black;
            this.btVideoLibrary.Image = global::MediaPlayerApp.Properties.Resources.video_96px1;
            this.btVideoLibrary.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btVideoLibrary.ImageSize = new System.Drawing.Size(25, 25);
            this.btVideoLibrary.Location = new System.Drawing.Point(6, 142);
            this.btVideoLibrary.Name = "btVideoLibrary";
            this.btVideoLibrary.Size = new System.Drawing.Size(197, 40);
            this.btVideoLibrary.TabIndex = 7;
            this.btVideoLibrary.Text = "Video library";
            this.btVideoLibrary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btVideoLibrary.Click += new System.EventHandler(this.btVideoLibrary_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(6, 363);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // btPlayqueue
            // 
            this.btPlayqueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btPlayqueue.Animated = true;
            this.btPlayqueue.BorderRadius = 5;
            this.btPlayqueue.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btPlayqueue.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btPlayqueue.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btPlayqueue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPlayqueue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPlayqueue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPlayqueue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPlayqueue.FillColor = System.Drawing.SystemColors.Control;
            this.btPlayqueue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btPlayqueue.ForeColor = System.Drawing.Color.Black;
            this.btPlayqueue.Image = global::MediaPlayerApp.Properties.Resources.lounge_music_playlist_96px;
            this.btPlayqueue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btPlayqueue.ImageSize = new System.Drawing.Size(25, 25);
            this.btPlayqueue.Location = new System.Drawing.Point(6, 274);
            this.btPlayqueue.Name = "btPlayqueue";
            this.btPlayqueue.Size = new System.Drawing.Size(197, 40);
            this.btPlayqueue.TabIndex = 11;
            this.btPlayqueue.Text = "Play Queue";
            this.btPlayqueue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btPlayqueue.Click += new System.EventHandler(this.btPlayqueue_Click);
            // 
            // btPlayList
            // 
            this.btPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btPlayList.Animated = true;
            this.btPlayList.BorderRadius = 5;
            this.btPlayList.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btPlayList.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btPlayList.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btPlayList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPlayList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPlayList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPlayList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPlayList.FillColor = System.Drawing.SystemColors.Control;
            this.btPlayList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btPlayList.ForeColor = System.Drawing.Color.Black;
            this.btPlayList.Image = global::MediaPlayerApp.Properties.Resources.lounge_music_playlist_96px;
            this.btPlayList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btPlayList.ImageSize = new System.Drawing.Size(25, 25);
            this.btPlayList.Location = new System.Drawing.Point(6, 318);
            this.btPlayList.Name = "btPlayList";
            this.btPlayList.Size = new System.Drawing.Size(197, 40);
            this.btPlayList.TabIndex = 10;
            this.btPlayList.Text = "Playlist";
            this.btPlayList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btPlayList.Click += new System.EventHandler(this.btPlayList_Click);
            // 
            // btHisListen
            // 
            this.btHisListen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btHisListen.Animated = true;
            this.btHisListen.BorderRadius = 5;
            this.btHisListen.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btHisListen.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btHisListen.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btHisListen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHisListen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHisListen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHisListen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHisListen.FillColor = System.Drawing.SystemColors.Control;
            this.btHisListen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btHisListen.ForeColor = System.Drawing.Color.Black;
            this.btHisListen.Image = global::MediaPlayerApp.Properties.Resources.time_machine_96px;
            this.btHisListen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHisListen.ImageSize = new System.Drawing.Size(25, 25);
            this.btHisListen.Location = new System.Drawing.Point(6, 230);
            this.btHisListen.Name = "btHisListen";
            this.btHisListen.Size = new System.Drawing.Size(197, 40);
            this.btHisListen.TabIndex = 9;
            this.btHisListen.Text = "History Listen";
            this.btHisListen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHisListen.Click += new System.EventHandler(this.btHisListen_Click);
            // 
            // btFravorSong
            // 
            this.btFravorSong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btFravorSong.Animated = true;
            this.btFravorSong.BorderRadius = 5;
            this.btFravorSong.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btFravorSong.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btFravorSong.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btFravorSong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btFravorSong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btFravorSong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btFravorSong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btFravorSong.FillColor = System.Drawing.SystemColors.Control;
            this.btFravorSong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btFravorSong.ForeColor = System.Drawing.Color.Black;
            this.btFravorSong.Image = global::MediaPlayerApp.Properties.Resources.heart_96px;
            this.btFravorSong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btFravorSong.ImageSize = new System.Drawing.Size(25, 25);
            this.btFravorSong.Location = new System.Drawing.Point(6, 186);
            this.btFravorSong.Name = "btFravorSong";
            this.btFravorSong.Size = new System.Drawing.Size(197, 40);
            this.btFravorSong.TabIndex = 8;
            this.btFravorSong.Text = "Favorite";
            this.btFravorSong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btFravorSong.Click += new System.EventHandler(this.btFravorSong_Click);
            // 
            // btMusicLibrary
            // 
            this.btMusicLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btMusicLibrary.Animated = true;
            this.btMusicLibrary.BorderRadius = 5;
            this.btMusicLibrary.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btMusicLibrary.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btMusicLibrary.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btMusicLibrary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMusicLibrary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMusicLibrary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMusicLibrary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMusicLibrary.FillColor = System.Drawing.SystemColors.Control;
            this.btMusicLibrary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btMusicLibrary.ForeColor = System.Drawing.Color.Black;
            this.btMusicLibrary.Image = global::MediaPlayerApp.Properties.Resources.music_512px;
            this.btMusicLibrary.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btMusicLibrary.ImageSize = new System.Drawing.Size(25, 25);
            this.btMusicLibrary.Location = new System.Drawing.Point(6, 98);
            this.btMusicLibrary.Name = "btMusicLibrary";
            this.btMusicLibrary.Size = new System.Drawing.Size(197, 40);
            this.btMusicLibrary.TabIndex = 6;
            this.btMusicLibrary.Text = "Music library";
            this.btMusicLibrary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btMusicLibrary.Click += new System.EventHandler(this.btMusicLibrary_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Media Player";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dark Mode";
            // 
            // togMode
            // 
            this.togMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.togMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.togMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.togMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.togMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.togMode.Location = new System.Drawing.Point(122, 525);
            this.togMode.Name = "togMode";
            this.togMode.Size = new System.Drawing.Size(35, 20);
            this.togMode.TabIndex = 3;
            this.togMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.togMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.togMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.togMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.togMode.CheckedChanged += new System.EventHandler(this.togMode_CheckedChanged);
            // 
            // btHome
            // 
            this.btHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btHome.Animated = true;
            this.btHome.BorderRadius = 5;
            this.btHome.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btHome.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btHome.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHome.FillColor = System.Drawing.SystemColors.Control;
            this.btHome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btHome.ForeColor = System.Drawing.Color.Black;
            this.btHome.Image = global::MediaPlayerApp.Properties.Resources.home_500px;
            this.btHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHome.ImageSize = new System.Drawing.Size(25, 25);
            this.btHome.Location = new System.Drawing.Point(6, 54);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(197, 40);
            this.btHome.TabIndex = 3;
            this.btHome.Text = "Home";
            this.btHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // pnChildren
            // 
            this.pnChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnChildren.Location = new System.Drawing.Point(212, 40);
            this.pnChildren.Name = "pnChildren";
            this.pnChildren.Size = new System.Drawing.Size(788, 510);
            this.pnChildren.TabIndex = 3;
            // 
            // moreButton
            // 
            this.moreButton.BackColor = System.Drawing.Color.Transparent;
            this.moreButton.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.moreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moreButton.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.moreButton.Image = global::MediaPlayerApp.Properties.Resources.more;
            this.moreButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.moreButton.ImageRotate = 0F;
            this.moreButton.ImageSize = new System.Drawing.Size(25, 25);
            this.moreButton.Location = new System.Drawing.Point(771, 53);
            this.moreButton.Name = "moreButton";
            this.moreButton.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.moreButton.Size = new System.Drawing.Size(35, 35);
            this.moreButton.TabIndex = 22;
            this.moreButton.Click += new System.EventHandler(this.moreButton_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnControlMedia);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnChildren);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.fHome_Load);
            this.pnControlMedia.ResumeLayout(false);
            this.pnControlMedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSongpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRepeatSong)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnControlMedia;
        private System.Windows.Forms.Label lbTimeCurrentPlay;
        private Guna.UI2.WinForms.Guna2TrackBar tbProcess;
        private Guna.UI2.WinForms.Guna2GradientPanel pnHeader;
        private Guna.UI2.WinForms.Guna2ControlBox btMaxsize;
        private Guna.UI2.WinForms.Guna2ControlBox btMinisize;
        private Guna.UI2.WinForms.Guna2ControlBox btExit;
        private Guna.UI2.WinForms.Guna2Panel pnLeft;
        private Guna.UI2.WinForms.Guna2Button btHome;
        private Guna.UI2.WinForms.Guna2ToggleSwitch togMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btMusicLibrary;
        private Guna.UI2.WinForms.Guna2Button btHisListen;
        private Guna.UI2.WinForms.Guna2Button btFravorSong;
        private Guna.UI2.WinForms.Guna2Button btVideoLibrary;
        private Guna.UI2.WinForms.Guna2Button btPlayqueue;
        private Guna.UI2.WinForms.Guna2Button btPlayList;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.PictureBox pbPrev;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbRepeatSong;
        private System.Windows.Forms.PictureBox pbShuffer;
        private Guna.UI2.WinForms.Guna2ImageButton btPlay;
        public Guna.UI2.WinForms.Guna2Panel pnChildren;
        private Guna.UI2.WinForms.Guna2TrackBar tbVolume;
        private Guna.UI2.WinForms.Guna2ImageButton btVolume;
        private Guna.UI2.WinForms.Guna2ImageButton btFavorite;
        public AxWMPLib.AxWindowsMediaPlayer Media;
        public System.Windows.Forms.PictureBox pbSongpic;
        public System.Windows.Forms.Label lbSongName;
        private Guna.UI2.WinForms.Guna2CircleButton cbtshuffer;
        private Guna.UI2.WinForms.Guna2CircleButton cbtloop;
        private Guna.UI2.WinForms.Guna2ImageButton moreButton;
    }
}

