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
            foreach (FileInfo file in Files)
            {
                Components.Playlist i = new Components.Playlist(file.FullName,this.parent);
                pnAllPlaylists.Controls.Add(i);
            }

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
    }
}
