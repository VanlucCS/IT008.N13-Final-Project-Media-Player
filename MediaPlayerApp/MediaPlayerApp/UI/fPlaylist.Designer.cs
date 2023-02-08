
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
            this.btnNewPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.pnAllPlaylists = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbSortby = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
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
            // pnAllPlaylists
            // 
            this.pnAllPlaylists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnAllPlaylists.AutoScroll = true;
            this.pnAllPlaylists.Location = new System.Drawing.Point(10, 86);
            this.pnAllPlaylists.Name = "pnAllPlaylists";
            this.pnAllPlaylists.Size = new System.Drawing.Size(801, 425);
            this.pnAllPlaylists.TabIndex = 36;
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
            // cbSortby
            // 
            this.cbSortby.BackColor = System.Drawing.Color.Transparent;
            this.cbSortby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortby.FillColor = System.Drawing.SystemColors.Control;
            this.cbSortby.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortby.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortby.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSortby.ForeColor = System.Drawing.Color.Red;
            this.cbSortby.ItemHeight = 20;
            this.cbSortby.Items.AddRange(new object[] {
            "Date added",
            "A -> z"});
            this.cbSortby.Location = new System.Drawing.Point(660, 60);
            this.cbSortby.Name = "cbSortby";
            this.cbSortby.Size = new System.Drawing.Size(120, 26);
            this.cbSortby.StartIndex = 0;
            this.cbSortby.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbSortby.TabIndex = 66;
            this.cbSortby.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
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
            // fPlaylist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Controls.Add(this.cbSortby);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnNewPlaylist);
            this.Controls.Add(this.pnAllPlaylists);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fPlaylist";
            this.Text = "fPlaylist";
            this.Load += new System.EventHandler(this.fPlaylist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnNewPlaylist;
        private System.Windows.Forms.FlowLayoutPanel pnAllPlaylists;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortby;
        private System.Windows.Forms.Label lblSort;
    }
}