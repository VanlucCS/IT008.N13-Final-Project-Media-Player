using MediaPlayerApp.Components;
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
            loadMusic();
        }

        private void lblSongs_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblSongs.Left + (lblSongs.Width - pbxUnderline.Width) / 2;
        }

        private void lblAlbums_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblAlbums.Left + (lblAlbums.Width - pbxUnderline.Width) / 2;
        }

        private void lblArtists_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblArtists.Left + (lblArtists.Width - pbxUnderline.Width) / 2;
        }
        private void loadMusic()
        {
            Components.
            ThumbnailMusic thumbnailMusic = new ThumbnailMusic("./BH01.mp3");
            thumbnailMusic.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Add(thumbnailMusic);
        }

        private void lbGenre_Click(object sender, EventArgs e)
        {

        }
    }
}
