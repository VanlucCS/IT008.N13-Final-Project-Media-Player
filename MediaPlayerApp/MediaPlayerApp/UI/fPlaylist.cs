using MediaPlayerApp.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerApp.UI
{
    public partial class fPlaylist : Form
    {
        public fHome parent;
        public fPlaylist(fHome parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            //Components.Playlist it = new Components.Playlist("");
            //flowLayoutPanel1.Controls.Add(it);
        }
        private void fPlaylist_Load(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"./Data/Playlists");
            FileInfo[] Files = d.GetFiles();
            int previewCount = 0;
            this.parent.fpnPreviewPlaylist.Controls.Clear();
            foreach (FileInfo file in Files)
            {
                Components.Playlist i = new Components.Playlist(file.FullName,this.parent);
                pnAllPlaylists.Controls.Add(i);
                if(previewCount < 5 )
                {
                    Guna.UI2.WinForms.Guna2Button pl = new Guna.UI2.WinForms.Guna2Button();
                    pl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                    pl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                    pl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                    pl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                    pl.FillColor = System.Drawing.SystemColors.Control;
                    pl.Font = new System.Drawing.Font("Segoe UI", 9F);
                    pl.ForeColor = System.Drawing.Color.DimGray;
                    pl.Location = new System.Drawing.Point(3, 3);
                    pl.Name = "guna2Button1";
                    pl.Size = new System.Drawing.Size(194, 29);
                    pl.TabIndex = 0;
                    pl.Text = i.PlayListName;
                    pl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                    pl.TextOffset = new System.Drawing.Point(30, 0);
                    pl.Tag = i;
                    pl.Image = MediaPlayerApp.Properties.Resources.music_player;
                    pl.ImageAlign = HorizontalAlignment.Left;
                    pl.ImageOffset = new System.Drawing.Point(15, 0);
                    pl.Click += playlistClick;
                    this.parent.fpnPreviewPlaylist.Controls.Add(pl);
                    previewCount++;
                }
            }

        }
        private void playlistClick(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button pl = (Guna.UI2.WinForms.Guna2Button)sender;
            Components.Playlist k = (Components.Playlist)pl.Tag;
            k.ShowPlayList();
        }
        private void moreButton_Click(object sender, EventArgs e)
        {

        }

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            fAddNewPlaylistcs f = new fAddNewPlaylistcs();
            f.Location = new Point(btnNewPlaylist.Location.X +280, btnNewPlaylist.Location.Y + 120);
            f.ShowDialog();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnAllPlaylists.Controls.Clear();
            DirectoryInfo d = new DirectoryInfo(@"./Data/Playlists");
            FileInfo[] Files = d.GetFiles();
            foreach (FileInfo file in Files)
            {
                Components.Playlist i = new Components.Playlist(file.FullName, this.parent);
                pnAllPlaylists.Controls.Add(i);
            }
            #region Sort genre
            if (cbSortby.Text != "Date added")
            {
                Playlist[] controlArray = new Playlist[pnAllPlaylists.Controls.Count];
                this.pnAllPlaylists.Controls.CopyTo(controlArray, 0);
                Array.Sort(controlArray, (c1, c2) => (int)(new FileInfo(c1.PlayListPath).CreationTime.Ticks) - (int)(new FileInfo(c2.PlayListPath).CreationTime.Ticks));

                pnAllPlaylists.Controls.Clear();
                pnAllPlaylists.Controls.AddRange(controlArray);
            }
            if (cbSortby.Text != "A -> z")
            {
                Playlist[] controlArray = new Playlist[pnAllPlaylists.Controls.Count];
                this.pnAllPlaylists.Controls.CopyTo(controlArray, 0);
                Array.Sort(controlArray, (c1, c2) => String.Compare(c1.PlayListName, c2.PlayListName));

                pnAllPlaylists.Controls.Clear();
                pnAllPlaylists.Controls.AddRange(controlArray);
            }
            #endregion
        }
        public void moreClick()
        {

        }
        public void selectAll()
        {

        }
        public void deselectAll()
        {

        }
        public void playList_Play()
        {

        }
        public void playList_PlayNext()
        {

        }
        public void clear()
        {

        }
    }
}
