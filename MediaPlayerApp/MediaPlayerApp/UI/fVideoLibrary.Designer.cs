namespace MediaPlayerApp.UI
{
    partial class fVideoLibrary
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblVideoFolders = new System.Windows.Forms.Label();
            this.lblAllVideos = new System.Windows.Forms.Label();
            this.btnPlayAll = new Guna.UI2.WinForms.Guna2Button();
            this.pbxUnderline = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddFolder = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUnderline)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Video";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 410);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // lblSort
            // 
            this.lblSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(525, 59);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(218, 34);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "Sort by: Date modified     ▼";
            this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSort.MouseEnter += new System.EventHandler(this.lblSort_MouseEnter);
            this.lblSort.MouseLeave += new System.EventHandler(this.lblSort_MouseLeave);
            // 
            // lblVideoFolders
            // 
            this.lblVideoFolders.AutoSize = true;
            this.lblVideoFolders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblVideoFolders.Location = new System.Drawing.Point(247, 18);
            this.lblVideoFolders.Name = "lblVideoFolders";
            this.lblVideoFolders.Size = new System.Drawing.Size(134, 28);
            this.lblVideoFolders.TabIndex = 53;
            this.lblVideoFolders.Text = "Video folders";
            this.lblVideoFolders.Click += new System.EventHandler(this.lblVideoFolders_Click);
            // 
            // lblAllVideos
            // 
            this.lblAllVideos.AutoSize = true;
            this.lblAllVideos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAllVideos.Location = new System.Drawing.Point(124, 18);
            this.lblAllVideos.Name = "lblAllVideos";
            this.lblAllVideos.Size = new System.Drawing.Size(100, 28);
            this.lblAllVideos.TabIndex = 52;
            this.lblAllVideos.Text = "All videos";
            this.lblAllVideos.Click += new System.EventHandler(this.lblAllVideos_Click);
            // 
            // btnPlayAll
            // 
            this.btnPlayAll.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayAll.BorderRadius = 5;
            this.btnPlayAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlayAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlayAll.FillColor = System.Drawing.Color.OrangeRed;
            this.btnPlayAll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAll.ForeColor = System.Drawing.Color.White;
            this.btnPlayAll.Image = global::MediaPlayerApp.Properties.Resources.white_play;
            this.btnPlayAll.Location = new System.Drawing.Point(12, 55);
            this.btnPlayAll.Name = "btnPlayAll";
            this.btnPlayAll.Size = new System.Drawing.Size(124, 30);
            this.btnPlayAll.TabIndex = 56;
            this.btnPlayAll.Text = "Play all";
            this.btnPlayAll.Click += new System.EventHandler(this.btnPlayAll_Click);
            // 
            // pbxUnderline
            // 
            this.pbxUnderline.BorderRadius = 3;
            this.pbxUnderline.FillColor = System.Drawing.Color.OrangeRed;
            this.pbxUnderline.ImageRotate = 0F;
            this.pbxUnderline.Location = new System.Drawing.Point(154, 41);
            this.pbxUnderline.Name = "pbxUnderline";
            this.pbxUnderline.Size = new System.Drawing.Size(20, 5);
            this.pbxUnderline.TabIndex = 55;
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
            this.btnAddFolder.TabIndex = 51;
            this.btnAddFolder.Text = " Add folder";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // fVideoLibrary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Controls.Add(this.btnPlayAll);
            this.Controls.Add(this.pbxUnderline);
            this.Controls.Add(this.lblVideoFolders);
            this.Controls.Add(this.lblAllVideos);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fVideoLibrary";
            this.Text = "fVideoLibrary";
            ((System.ComponentModel.ISupportInitialize)(this.pbxUnderline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblSort;
        private Guna.UI2.WinForms.Guna2Button btnAddFolder;
        private Guna.UI2.WinForms.Guna2PictureBox pbxUnderline;
        private System.Windows.Forms.Label lblVideoFolders;
        private System.Windows.Forms.Label lblAllVideos;
        private Guna.UI2.WinForms.Guna2Button btnPlayAll;
    }
}