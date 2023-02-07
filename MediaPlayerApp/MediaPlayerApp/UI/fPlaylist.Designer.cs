
namespace MediaPlayerApp.UI
{
    partial class fPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPlaylist));
            this.btnNewPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.moreButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPlaylist.BorderRadius = 5;
            this.btnNewPlaylist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewPlaylist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewPlaylist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewPlaylist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewPlaylist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(62)))), ((int)(((byte)(9)))));
            this.btnNewPlaylist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnNewPlaylist.Location = new System.Drawing.Point(12, 50);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Size = new System.Drawing.Size(127, 30);
            this.btnNewPlaylist.TabIndex = 42;
            this.btnNewPlaylist.Text = "+   New playlist";
            this.btnNewPlaylist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 410);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 37);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Playlists";
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
            this.guna2ComboBox1.Location = new System.Drawing.Point(660, 60);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(120, 26);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2ComboBox1.TabIndex = 66;
            // 
            // lblSort
            // 
            this.lblSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSort.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblSort.Location = new System.Drawing.Point(593, 59);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(71, 27);
            this.lblSort.TabIndex = 65;
            this.lblSort.Text = "Sort by : ";
            this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.moreButton.Location = new System.Drawing.Point(741, 12);
            this.moreButton.Name = "moreButton";
            this.moreButton.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.moreButton.Size = new System.Drawing.Size(35, 35);
            this.moreButton.TabIndex = 55;
            this.moreButton.Click += new System.EventHandler(this.moreButton_Click);
            // 
            // fPlaylist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.btnNewPlaylist);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fPlaylist";
            this.Text = "fPlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnNewPlaylist;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ImageButton moreButton;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label lblSort;
    }
}