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
            this.moreButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.playButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureSong = new Guna.UI2.WinForms.Guna2Panel();
            this.cbxChon = new Guna.UI2.WinForms.Guna2CheckBox();
            this.nameSongLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureSong.SuspendLayout();
            this.SuspendLayout();
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
            this.pictureSong.Controls.Add(this.cbxChon);
            this.pictureSong.Controls.Add(this.playButton);
            this.pictureSong.Controls.Add(this.moreButton);
            this.pictureSong.Location = new System.Drawing.Point(3, 3);
            this.pictureSong.Name = "pictureSong";
            this.pictureSong.Size = new System.Drawing.Size(160, 160);
            this.pictureSong.TabIndex = 1;
            // 
            // cbxChon
            // 
            this.cbxChon.BackColor = System.Drawing.SystemColors.Control;
            this.cbxChon.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxChon.CheckedState.BorderRadius = 5;
            this.cbxChon.CheckedState.BorderThickness = 1;
            this.cbxChon.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.cbxChon.CheckMarkColor = System.Drawing.Color.Black;
            this.cbxChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxChon.Location = new System.Drawing.Point(4, 4);
            this.cbxChon.Margin = new System.Windows.Forms.Padding(4);
            this.cbxChon.Name = "cbxChon";
            this.cbxChon.Size = new System.Drawing.Size(20, 20);
            this.cbxChon.TabIndex = 4;
            this.cbxChon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxChon.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxChon.UncheckedState.BorderRadius = 5;
            this.cbxChon.UncheckedState.BorderThickness = 1;
            this.cbxChon.UncheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.cbxChon.UseVisualStyleBackColor = false;
            this.cbxChon.CheckedChanged += new System.EventHandler(this.cbxChon_CheckedChanged);
            // 
            // nameSongLabel
            // 
            this.nameSongLabel.AutoSize = false;
            this.nameSongLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameSongLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSongLabel.Location = new System.Drawing.Point(0, 161);
            this.nameSongLabel.MaximumSize = new System.Drawing.Size(192, 100000);
            this.nameSongLabel.Name = "nameSongLabel";
            this.nameSongLabel.Size = new System.Drawing.Size(167, 43);
            this.nameSongLabel.TabIndex = 3;
            this.nameSongLabel.Text = "Chúng ta không thuộc về nhau";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = false;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 206);
            this.lblDate.MaximumSize = new System.Drawing.Size(192, 100000);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(167, 22);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "2/7/2023";
            // 
            // Thumbnail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.nameSongLabel);
            this.Controls.Add(this.pictureSong);
            this.Name = "Thumbnail";
            this.Size = new System.Drawing.Size(167, 227);
            this.pictureSong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton moreButton;
        private Guna.UI2.WinForms.Guna2ImageButton playButton;
        private Guna.UI2.WinForms.Guna2Panel pictureSong;
        private Guna.UI2.WinForms.Guna2CheckBox cbxChon;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameSongLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDate;
    }
}
