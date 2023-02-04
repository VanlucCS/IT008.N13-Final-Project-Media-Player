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
            this.lbTimeCurrentPlay = new System.Windows.Forms.Label();
            this.tbProcess = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1s = new System.Windows.Forms.Timer(this.components);
            this.timer5s = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlHead.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlBottom.Controls.Add(this.lbTimeCurrentPlay);
            this.pnlBottom.Controls.Add(this.tbProcess);
            this.pnlBottom.Controls.Add(this.btPlay);
            this.pnlBottom.Controls.Add(this.pictureBox4);
            this.pnlBottom.Controls.Add(this.pictureBox3);
            this.pnlBottom.Controls.Add(this.pictureBox2);
            this.pnlBottom.Controls.Add(this.pictureBox1);
            this.pnlBottom.Location = new System.Drawing.Point(0, 350);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 100);
            this.pnlBottom.TabIndex = 2;
            this.pnlBottom.Visible = false;
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
            this.btPlay.Image = global::MediaPlayerApp.Properties.Resources.play_button;
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
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::MediaPlayerApp.Properties.Resources.shuffle;
            this.pictureBox4.Location = new System.Drawing.Point(251, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::MediaPlayerApp.Properties.Resources.repeat9;
            this.pictureBox3.Location = new System.Drawing.Point(509, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::MediaPlayerApp.Properties.Resources.left;
            this.pictureBox2.Location = new System.Drawing.Point(311, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MediaPlayerApp.Properties.Resources.right;
            this.pictureBox1.Location = new System.Drawing.Point(449, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
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
            this.Text = "fVideo";
            this.pnlHead.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTimeCurrentPlay;
        private System.Windows.Forms.Timer timer1s;
        private System.Windows.Forms.Timer timer5s;
        private Guna.UI2.WinForms.Guna2TrackBar tbProcess;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}