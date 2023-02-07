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
            Components.Playlist it = new Components.Playlist("");
            flowLayoutPanel1.Controls.Add(it);
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
    }
}
