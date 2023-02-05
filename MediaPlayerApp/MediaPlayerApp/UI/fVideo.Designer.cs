namespace MediaPlayerApp.UI
{
    partial class fVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVideo));
            this.pnlHead = new Guna.UI2.WinForms.Guna2Panel();
            this.btMaxsize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btMinisize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.pbxNext = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.lbTimeCurrentPlay = new System.Windows.Forms.Label();
            this.tbProcess = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbxShuffle = new System.Windows.Forms.PictureBox();
            this.pbxReplay = new System.Windows.Forms.PictureBox();
            this.pbxBackward = new System.Windows.Forms.PictureBox();
            this.pbxForward = new System.Windows.Forms.PictureBox();
            this.timer1s = new System.Windows.Forms.Timer(this.components);
            this.timer5s = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlHead.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlHead.Controls.Add(this.btMaxsize);
            this.pnlHead.Controls.Add(this.btMinisize);
            this.pnlHead.Controls.Add(this.btExit);
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(800, 35);
            this.pnlHead.TabIndex = 1;
            this.pnlHead.Visible = false;
            // 
            // btMaxsize
            // 
            this.btMaxsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaxsize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btMaxsize.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btMaxsize.IconColor = System.Drawing.Color.Black;
            this.btMaxsize.Location = new System.Drawing.Point(688, 3);
            this.btMaxsize.Name = "btMaxsize";
            this.btMaxsize.Size = new System.Drawing.Size(45, 29);
            this.btMaxsize.TabIndex = 5;
            // 
            // btMinisize
            // 
            this.btMinisize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinisize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btMinisize.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btMinisize.IconColor = System.Drawing.Color.Black;
            this.btMinisize.Location = new System.Drawing.Point(639, 3);
            this.btMinisize.Name = "btMinisize";
            this.btMinisize.Size = new System.Drawing.Size(45, 29);
            this.btMinisize.TabIndex = 4;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.CustomIconSize = 15F;
            this.btExit.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btExit.IconColor = System.Drawing.Color.Black;
            this.btExit.Location = new System.Drawing.Point(739, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(45, 29);
            this.btExit.TabIndex = 3;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlBottom.Controls.Add(this.pbxNext);
            this.pnlBottom.Controls.Add(this.pbxBack);
            this.pnlBottom.Controls.Add(this.lbTimeCurrentPlay);
            this.pnlBottom.Controls.Add(this.tbProcess);
            this.pnlBottom.Controls.Add(this.btPlay);
            this.pnlBottom.Controls.Add(this.pbxShuffle);
            this.pnlBottom.Controls.Add(this.pbxReplay);
            this.pnlBottom.Controls.Add(this.pbxBackward);
            this.pnlBottom.Controls.Add(this.pbxForward);
            this.pnlBottom.Location = new System.Drawing.Point(0, 350);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 100);
            this.pnlBottom.TabIndex = 2;
            this.pnlBottom.Visible = false;
            // 
            // pbxNext
            // 
            this.pbxNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxNext.Image = global::MediaPlayerApp.Properties.Resources.video_next;
            this.pbxNext.Location = new System.Drawing.Point(514, 43);
            this.pbxNext.Name = "pbxNext";
            this.pbxNext.Size = new System.Drawing.Size(32, 32);
            this.pbxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNext.TabIndex = 23;
            this.pbxNext.TabStop = false;
            this.pbxNext.Click += new System.EventHandler(this.pbxNext_Click);
            // 
            // pbxBack
            // 
            this.pbxBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxBack.Image = global::MediaPlayerApp.Properties.Resources.grey_back;
            this.pbxBack.Location = new System.Drawing.Point(250, 43);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(32, 32);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBack.TabIndex = 22;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // lbTimeCurrentPlay
            // 
            this.lbTimeCurrentPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTimeCurrentPlay.AutoSize = true;
            this.lbTimeCurrentPlay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeCurrentPlay.Location = new System.Drawing.Point(9, 10);
            this.lbTimeCurrentPlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeCurrentPlay.Name = "lbTimeCurrentPlay";
            this.lbTimeCurrentPlay.Size = new System.Drawing.Size(88, 25);
            this.lbTimeCurrentPlay.TabIndex = 21;
            this.lbTimeCurrentPlay.Text = "00:00:00";
            // 
            // tbProcess
            // 
            this.tbProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProcess.FillColor = System.Drawing.Color.White;
            this.tbProcess.Location = new System.Drawing.Point(76, 0);
            this.tbProcess.Margin = new System.Windows.Forms.Padding(4);
            this.tbProcess.Name = "tbProcess";
            this.tbProcess.Size = new System.Drawing.Size(708, 28);
            this.tbProcess.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.tbProcess.TabIndex = 20;
            this.tbProcess.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbProcess.Value = 0;
            this.tbProcess.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbProcess_Scroll);
            // 
            // btPlay
            // 
            this.btPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btPlay.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btPlay.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btPlay.Image = global::MediaPlayerApp.Properties.Resources.video_pause;
            this.btPlay.ImageOffset = new System.Drawing.Point(0, 0);
            this.btPlay.ImageRotate = 0F;
            this.btPlay.ImageSize = new System.Drawing.Size(50, 50);
            this.btPlay.Location = new System.Drawing.Point(370, 34);
            this.btPlay.Name = "btPlay";
            this.btPlay.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btPlay.Size = new System.Drawing.Size(64, 54);
            this.btPlay.TabIndex = 19;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // pbxShuffle
            // 
            this.pbxShuffle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxShuffle.Image = global::MediaPlayerApp.Properties.Resources.not_shuffle;
            this.pbxShuffle.Location = new System.Drawing.Point(189, 43);
            this.pbxShuffle.Name = "pbxShuffle";
            this.pbxShuffle.Size = new System.Drawing.Size(32, 32);
            this.pbxShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxShuffle.TabIndex = 18;
            this.pbxShuffle.TabStop = false;
            this.pbxShuffle.Click += new System.EventHandler(this.pbxShuffle_Click);
            // 
            // pbxReplay
            // 
            this.pbxReplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxReplay.Image = global::MediaPlayerApp.Properties.Resources.video_not_repeat;
            this.pbxReplay.Location = new System.Drawing.Point(574, 43);
            this.pbxReplay.Name = "pbxReplay";
            this.pbxReplay.Size = new System.Drawing.Size(32, 32);
            this.pbxReplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxReplay.TabIndex = 15;
            this.pbxReplay.TabStop = false;
            this.pbxReplay.Click += new System.EventHandler(this.pbxReplay_Click);
            // 
            // pbxBackward
            // 
            this.pbxBackward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxBackward.Image = global::MediaPlayerApp.Properties.Resources.video_backward;
            this.pbxBackward.Location = new System.Drawing.Point(311, 43);
            this.pbxBackward.Name = "pbxBackward";
            this.pbxBackward.Size = new System.Drawing.Size(32, 32);
            this.pbxBackward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBackward.TabIndex = 17;
            this.pbxBackward.TabStop = false;
            this.pbxBackward.Click += new System.EventHandler(this.pbxBackward_Click);
            // 
            // pbxForward
            // 
            this.pbxForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxForward.Image = global::MediaPlayerApp.Properties.Resources.video_forward;
            this.pbxForward.Location = new System.Drawing.Point(449, 43);
            this.pbxForward.Name = "pbxForward";
            this.pbxForward.Size = new System.Drawing.Size(32, 32);
            this.pbxForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxForward.TabIndex = 16;
            this.pbxForward.TabStop = false;
            this.pbxForward.Click += new System.EventHandler(this.pbxForward_Click);
            // 
            // timer1s
            // 
            this.timer1s.Enabled = true;
            this.timer1s.Interval = 1000;
            this.timer1s.Tick += new System.EventHandler(this.timer1s_Tick);
            // 
            // timer5s
            // 
            this.timer5s.Interval = 5000;
            this.timer5s.Tick += new System.EventHandler(this.timer5s_Tick);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(800, 450);
            this.player.TabIndex = 3;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            this.player.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.player_MouseMoveEvent);
            // 
            // fVideo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fVideo";
            this.pnlHead.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlHead;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private Guna.UI2.WinForms.Guna2ControlBox btMaxsize;
        private Guna.UI2.WinForms.Guna2ControlBox btMinisize;
        private Guna.UI2.WinForms.Guna2ControlBox btExit;
        private Guna.UI2.WinForms.Guna2ImageButton btPlay;
        private System.Windows.Forms.PictureBox pbxShuffle;
        private System.Windows.Forms.PictureBox pbxReplay;
        private System.Windows.Forms.PictureBox pbxBackward;
        private System.Windows.Forms.PictureBox pbxForward;
        private System.Windows.Forms.Label lbTimeCurrentPlay;
        private System.Windows.Forms.Timer timer1s;
        private System.Windows.Forms.Timer timer5s;
        private Guna.UI2.WinForms.Guna2TrackBar tbProcess;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.PictureBox pbxNext;
        private System.Windows.Forms.PictureBox pbxBack;
    }
}