using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerApp.UI
{
    public partial class fMusicLibrary : Form
    {
        public fHome parent;

        public fMusicLibrary(fHome parent = null)
        {
            this.parent = parent;

            InitializeComponent();
        }

        private void lblSongs_Click(object sender, EventArgs e)
        {
            pbUnderline.Left = lblSongs.Left + (lblSongs.Width - pbUnderline.Width) / 2;
        }

        private void lblAlbums_Click(object sender, EventArgs e)
        {
            pbUnderline.Left = lblAlbums.Left + (lblAlbums.Width - pbUnderline.Width) / 2;
        }

        private void lblArtists_Click(object sender, EventArgs e)
        {
            pbUnderline.Left = lblArtists.Left + (lblArtists.Width - pbUnderline.Width) / 2;
        }
    }
}
