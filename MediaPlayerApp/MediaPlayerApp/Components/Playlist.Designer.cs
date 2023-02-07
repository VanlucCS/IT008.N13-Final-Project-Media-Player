namespace MediaPlayerApp.Components
{
    partial class Playlist
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.pnlBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.btMore = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbxImage4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbxImage2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbxImage3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbxImage1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 169);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Text1";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(5, 194);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(33, 13);
            this.lblItem.TabIndex = 6;
            this.lblItem.Text = "Text1";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.SystemColors.Info;
            this.pnlBackground.BorderRadius = 5;
            this.pnlBackground.Location = new System.Drawing.Point(4, 4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(160, 160);
            this.pnlBackground.TabIndex = 9;
            // 
            // btMore
            // 
            this.btMore.BackColor = System.Drawing.Color.Transparent;
            this.btMore.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMore.HoverState.Image = global::MediaPlayerApp.Properties.Resources.more1;
            this.btMore.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btMore.Image = global::MediaPlayerApp.Properties.Resources.transimage;
            this.btMore.ImageOffset = new System.Drawing.Point(0, 0);
            this.btMore.ImageRotate = 0F;
            this.btMore.ImageSize = new System.Drawing.Size(35, 35);
            this.btMore.Location = new System.Drawing.Point(118, 118);
            this.btMore.Name = "btMore";
            this.btMore.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btMore.Size = new System.Drawing.Size(35, 35);
            this.btMore.TabIndex = 8;
            this.btMore.Click += new System.EventHandler(this.btMore_Click);
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.Transparent;
            this.btPlay.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlay.HoverState.Image = global::MediaPlayerApp.Properties.Resources.playbutton;
            this.btPlay.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btPlay.Image = global::MediaPlayerApp.Properties.Resources.transimage;
            this.btPlay.ImageOffset = new System.Drawing.Point(0, 0);
            this.btPlay.ImageRotate = 0F;
            this.btPlay.ImageSize = new System.Drawing.Size(35, 35);
            this.btPlay.Location = new System.Drawing.Point(7, 118);
            this.btPlay.Name = "btPlay";
            this.btPlay.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btPlay.Size = new System.Drawing.Size(35, 35);
            this.btPlay.TabIndex = 7;
            // 
            // pbxImage4
            // 
            this.pbxImage4.FillColor = System.Drawing.Color.Transparent;
            this.pbxImage4.ImageRotate = 0F;
            this.pbxImage4.Location = new System.Drawing.Point(84, 84);
            this.pbxImage4.Name = "pbxImage4";
            this.pbxImage4.Size = new System.Drawing.Size(80, 80);
            this.pbxImage4.TabIndex = 4;
            this.pbxImage4.TabStop = false;
            // 
            // pbxImage2
            // 
            this.pbxImage2.FillColor = System.Drawing.Color.Transparent;
            this.pbxImage2.ImageRotate = 0F;
            this.pbxImage2.Location = new System.Drawing.Point(84, 4);
            this.pbxImage2.Name = "pbxImage2";
            this.pbxImage2.Size = new System.Drawing.Size(80, 80);
            this.pbxImage2.TabIndex = 3;
            this.pbxImage2.TabStop = false;
            // 
            // pbxImage3
            // 
            this.pbxImage3.FillColor = System.Drawing.Color.Transparent;
            this.pbxImage3.ImageRotate = 0F;
            this.pbxImage3.Location = new System.Drawing.Point(4, 84);
            this.pbxImage3.Name = "pbxImage3";
            this.pbxImage3.Size = new System.Drawing.Size(80, 80);
            this.pbxImage3.TabIndex = 2;
            this.pbxImage3.TabStop = false;
            // 
            // pbxImage1
            // 
            this.pbxImage1.FillColor = System.Drawing.Color.Transparent;
            this.pbxImage1.ImageRotate = 0F;
            this.pbxImage1.Location = new System.Drawing.Point(4, 4);
            this.pbxImage1.Name = "pbxImage1";
            this.pbxImage1.Size = new System.Drawing.Size(80, 80);
            this.pbxImage1.TabIndex = 1;
            this.pbxImage1.TabStop = false;
            // 
            // Playlist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btMore);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbxImage4);
            this.Controls.Add(this.pbxImage2);
            this.Controls.Add(this.pbxImage3);
            this.Controls.Add(this.pbxImage1);
            this.Controls.Add(this.pnlBackground);
            this.Name = "Playlist";
            this.Size = new System.Drawing.Size(168, 217);
            this.MouseEnter += new System.EventHandler(this.Playlist_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Playlist_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox pbxImage1;
        private Guna.UI2.WinForms.Guna2PictureBox pbxImage3;
        private Guna.UI2.WinForms.Guna2PictureBox pbxImage2;
        private Guna.UI2.WinForms.Guna2PictureBox pbxImage4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblItem;
        private Guna.UI2.WinForms.Guna2ImageButton btPlay;
        private Guna.UI2.WinForms.Guna2ImageButton btMore;
        private Guna.UI2.WinForms.Guna2Panel pnlBackground;
    }
}
