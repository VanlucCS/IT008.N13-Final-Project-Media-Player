namespace MediaPlayerApp.Components
{
    partial class Thumbnail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thumbnail));
            this.nameSongLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.moreButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.playButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureSong = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameSongLabel
            // 
            this.nameSongLabel.AutoSize = false;
            this.nameSongLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameSongLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSongLabel.Location = new System.Drawing.Point(0, 162);
            this.nameSongLabel.MaximumSize = new System.Drawing.Size(192, 100000);
            this.nameSongLabel.Name = "nameSongLabel";
            this.nameSongLabel.Size = new System.Drawing.Size(163, 51);
            this.nameSongLabel.TabIndex = 2;
            this.nameSongLabel.Text = "Chúng ta không thuộc về nhau";
            // 
            // moreButton
            // 
            this.moreButton.BackColor = System.Drawing.Color.Transparent;
            this.moreButton.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.moreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moreButton.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.moreButton.Image = ((System.Drawing.Image)(resources.GetObject("moreButton.Image")));
            this.moreButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.moreButton.ImageRotate = 0F;
            this.moreButton.ImageSize = new System.Drawing.Size(35, 35);
            this.moreButton.Location = new System.Drawing.Point(118, 118);
            this.moreButton.Name = "moreButton";
            this.moreButton.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.moreButton.Size = new System.Drawing.Size(35, 35);
            this.moreButton.TabIndex = 0;
            this.moreButton.Click += new System.EventHandler(this.moreButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.playButton.ImageRotate = 0F;
            this.playButton.ImageSize = new System.Drawing.Size(35, 35);
            this.playButton.Location = new System.Drawing.Point(7, 118);
            this.playButton.Name = "playButton";
            this.playButton.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.playButton.Size = new System.Drawing.Size(35, 35);
            this.playButton.TabIndex = 0;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pictureSong
            // 
            this.pictureSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureSong.BackgroundImage")));
            this.pictureSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureSong.BorderRadius = 15;
            this.pictureSong.Controls.Add(this.playButton);
            this.pictureSong.Controls.Add(this.moreButton);
            this.pictureSong.Location = new System.Drawing.Point(3, 3);
            this.pictureSong.Name = "pictureSong";
            this.pictureSong.Size = new System.Drawing.Size(160, 160);
            this.pictureSong.TabIndex = 1;
            // 
            // Thumbnail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.nameSongLabel);
            this.Controls.Add(this.pictureSong);
            this.Name = "Thumbnail";
            this.Size = new System.Drawing.Size(167, 217);
            this.pictureSong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel nameSongLabel;
        private Guna.UI2.WinForms.Guna2ImageButton moreButton;
        private Guna.UI2.WinForms.Guna2ImageButton playButton;
        private Guna.UI2.WinForms.Guna2Panel pictureSong;
    }
}
