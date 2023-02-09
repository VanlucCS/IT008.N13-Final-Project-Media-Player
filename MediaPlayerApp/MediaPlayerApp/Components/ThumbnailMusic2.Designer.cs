
namespace MediaPlayerApp.Components
{
    partial class ThumbnailMusic2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThumbnailMusic2));
            this.nameSongLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureSong = new Guna.UI2.WinForms.Guna2Panel();
            this.playButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameSongLabel
            // 
            this.nameSongLabel.AutoSize = false;
            this.nameSongLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameSongLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSongLabel.Location = new System.Drawing.Point(0, 160);
            this.nameSongLabel.MaximumSize = new System.Drawing.Size(192, 100000);
            this.nameSongLabel.Name = "nameSongLabel";
            this.nameSongLabel.Size = new System.Drawing.Size(167, 43);
            this.nameSongLabel.TabIndex = 6;
            this.nameSongLabel.Text = "Chúng ta không thuộc về nhau";
            // 
            // pictureSong
            // 
            this.pictureSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureSong.BackgroundImage")));
            this.pictureSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureSong.BorderRadius = 15;
            this.pictureSong.Controls.Add(this.playButton);
            this.pictureSong.Location = new System.Drawing.Point(4, 1);
            this.pictureSong.Name = "pictureSong";
            this.pictureSong.Size = new System.Drawing.Size(160, 160);
            this.pictureSong.TabIndex = 5;
            this.pictureSong.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.HoverState.Image = global::MediaPlayerApp.Properties.Resources.playbutton;
            this.playButton.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.playButton.Image = global::MediaPlayerApp.Properties.Resources.transimage;
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
            // lblDate
            // 
            this.lblDate.AutoSize = false;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(0, 207);
            this.lblDate.MaximumSize = new System.Drawing.Size(192, 100000);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(167, 22);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "2/7/2023";
            // 
            // ThumbnailMusic2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pictureSong);
            this.Controls.Add(this.nameSongLabel);
            this.Name = "ThumbnailMusic2";
            this.Size = new System.Drawing.Size(167, 227);
            this.Load += new System.EventHandler(this.ThumbnailMusic2_Load);
            this.pictureSong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton playButton;
        private Guna.UI2.WinForms.Guna2Panel pictureSong;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameSongLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDate;
    }
}
