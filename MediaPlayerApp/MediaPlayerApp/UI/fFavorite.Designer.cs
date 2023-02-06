
namespace MediaPlayerApp.UI
{
    partial class fFavorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFavorite));
            this.pnSong = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.moreButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnShuffleAndPlay = new Guna.UI2.WinForms.Guna2Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // pnSong
            // 
            this.pnSong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSong.AutoSize = true;
            this.pnSong.Location = new System.Drawing.Point(9, 92);
            this.pnSong.Name = "pnSong";
            this.pnSong.Size = new System.Drawing.Size(770, 410);
            this.pnSong.TabIndex = 53;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 30);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "Favorite song";
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
            this.moreButton.Location = new System.Drawing.Point(744, 12);
            this.moreButton.Name = "moreButton";
            this.moreButton.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.moreButton.Size = new System.Drawing.Size(35, 35);
            this.moreButton.TabIndex = 54;
            this.moreButton.Click += new System.EventHandler(this.moreButton_Click);
            // 
            // btnShuffleAndPlay
            // 
            this.btnShuffleAndPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffleAndPlay.BorderRadius = 5;
            this.btnShuffleAndPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShuffleAndPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShuffleAndPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShuffleAndPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShuffleAndPlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(62)))), ((int)(((byte)(9)))));
            this.btnShuffleAndPlay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffleAndPlay.ForeColor = System.Drawing.Color.White;
            this.btnShuffleAndPlay.Image = global::MediaPlayerApp.Properties.Resources.white_shuffle;
            this.btnShuffleAndPlay.Location = new System.Drawing.Point(12, 46);
            this.btnShuffleAndPlay.Name = "btnShuffleAndPlay";
            this.btnShuffleAndPlay.Size = new System.Drawing.Size(154, 30);
            this.btnShuffleAndPlay.TabIndex = 55;
            this.btnShuffleAndPlay.Text = "Shuffle and play";
            // 
            // lblSort
            // 
            this.lblSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSort.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblSort.Location = new System.Drawing.Point(336, 55);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(71, 27);
            this.lblSort.TabIndex = 57;
            this.lblSort.Text = "Sort by : ";
            this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGenre
            // 
            this.lbGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGenre.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbGenre.Location = new System.Drawing.Point(564, 54);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(56, 28);
            this.lbGenre.TabIndex = 56;
            this.lbGenre.Text = "Genre : ";
            this.lbGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.guna2ComboBox1.Location = new System.Drawing.Point(403, 56);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(117, 26);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2ComboBox1.TabIndex = 58;
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
            this.guna2ComboBox2.Location = new System.Drawing.Point(626, 56);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(107, 26);
            this.guna2ComboBox2.StartIndex = 0;
            this.guna2ComboBox2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2ComboBox2.TabIndex = 59;
            this.guna2ComboBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fFavorite
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.btnShuffleAndPlay);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.pnSong);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fFavorite";
            this.Text = "fFavorite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnSong;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ImageButton moreButton;
        private Guna.UI2.WinForms.Guna2Button btnShuffleAndPlay;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lbGenre;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
    }
}