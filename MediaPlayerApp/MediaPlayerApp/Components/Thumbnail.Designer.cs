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
            this.pictureSong = new Guna.UI2.WinForms.Guna2Panel();
            this.playButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.moreButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameSongLabel
            // 
            this.nameSongLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameSongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSongLabel.Location = new System.Drawing.Point(6, 232);
            this.nameSongLabel.MaximumSize = new System.Drawing.Size(192, 100000);
            this.nameSongLabel.Name = "nameSongLabel";
            this.nameSongLabel.Size = new System.Drawing.Size(192, 42);
            this.nameSongLabel.TabIndex = 2;
            this.nameSongLabel.Text = "Chúng ta không thuộc về nhau";
            this.nameSongLabel.Click += new System.EventHandler(this.nameSongLabel_Click);
            // 
            // pictureSong
            // 
            this.pictureSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureSong.BackgroundImage")));
            this.pictureSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSong.Controls.Add(this.playButton);
            this.pictureSong.Controls.Add(this.moreButton);
            this.pictureSong.Location = new System.Drawing.Point(3, 3);
            this.pictureSong.Name = "pictureSong";
            this.pictureSong.Size = new System.Drawing.Size(198, 223);
            this.pictureSong.TabIndex = 1;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.DimGray;
            this.playButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.playButton.ImageRotate = 0F;
            this.playButton.ImageSize = new System.Drawing.Size(45, 45);
            this.playButton.Location = new System.Drawing.Point(3, 175);
            this.playButton.Name = "playButton";
            this.playButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.playButton.Size = new System.Drawing.Size(45, 45);
            this.playButton.TabIndex = 0;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // moreButton
            // 
            this.moreButton.BackColor = System.Drawing.Color.DimGray;
            this.moreButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.moreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moreButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.moreButton.Image = ((System.Drawing.Image)(resources.GetObject("moreButton.Image")));
            this.moreButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.moreButton.ImageRotate = 0F;
            this.moreButton.ImageSize = new System.Drawing.Size(45, 45);
            this.moreButton.Location = new System.Drawing.Point(150, 173);
            this.moreButton.Name = "moreButton";
            this.moreButton.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.moreButton.Size = new System.Drawing.Size(45, 45);
            this.moreButton.TabIndex = 0;
            this.moreButton.Click += new System.EventHandler(this.moreButton_Click);
            // 
            // thumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameSongLabel);
            this.Controls.Add(this.pictureSong);
            this.Name = "thumbnail";
            this.Size = new System.Drawing.Size(204, 285);
            this.pictureSong.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton playButton;
        private Guna.UI2.WinForms.Guna2ImageButton moreButton;
        private Guna.UI2.WinForms.Guna2Panel pictureSong;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameSongLabel;
    }
}
