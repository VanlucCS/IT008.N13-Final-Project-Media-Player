
namespace MediaPlayerApp.UI
{
    partial class fRenamePlaylist
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
            this.tbPlaylistName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnNewPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // tbPlaylistName
            // 
            this.tbPlaylistName.BorderColor = System.Drawing.Color.Transparent;
            this.tbPlaylistName.BorderRadius = 5;
            this.tbPlaylistName.BorderThickness = 0;
            this.tbPlaylistName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPlaylistName.DefaultText = "New playlist";
            this.tbPlaylistName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPlaylistName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPlaylistName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPlaylistName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPlaylistName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPlaylistName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlaylistName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPlaylistName.Location = new System.Drawing.Point(52, 19);
            this.tbPlaylistName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPlaylistName.Name = "tbPlaylistName";
            this.tbPlaylistName.PasswordChar = '\0';
            this.tbPlaylistName.PlaceholderText = "";
            this.tbPlaylistName.SelectedText = "";
            this.tbPlaylistName.Size = new System.Drawing.Size(277, 32);
            this.tbPlaylistName.TabIndex = 45;
            this.tbPlaylistName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPlaylistName.TextChanged += new System.EventHandler(this.tbPlaylistName_TextChanged);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.CustomIconSize = 15F;
            this.btExit.FillColor = System.Drawing.SystemColors.Control;
            this.btExit.IconColor = System.Drawing.Color.Black;
            this.btExit.Location = new System.Drawing.Point(334, 5);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(32, 25);
            this.btExit.TabIndex = 47;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
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
            this.btnNewPlaylist.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnNewPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnNewPlaylist.Location = new System.Drawing.Point(127, 68);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Size = new System.Drawing.Size(127, 30);
            this.btnNewPlaylist.TabIndex = 46;
            this.btnNewPlaylist.Text = "Rename";
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // fRenamePlaylist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(374, 106);
            this.Controls.Add(this.tbPlaylistName);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btnNewPlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRenamePlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fRenamePlaylist";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbPlaylistName;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox btExit;
        private Guna.UI2.WinForms.Guna2Button btnNewPlaylist;
    }
}