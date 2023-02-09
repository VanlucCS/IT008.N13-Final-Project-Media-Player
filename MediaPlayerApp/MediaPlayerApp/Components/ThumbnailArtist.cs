using MediaPlayerApp.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerApp.Components
{
    public partial class ThumbnailArtist : UserControl
    {
        private string _artistName;
        private Bitmap _avatar;
        public fHome parent;
        private List<ThumbnailMusic> _thumbnailMusics;

        public List<ThumbnailMusic> ThumbnailMusics
        {
            get { return _thumbnailMusics; }
            set { _thumbnailMusics = value; }
        }

        public string ArtistName
        {
            get { return _artistName; }
            set { _artistName = value; }
        }
        public Bitmap Avatar
        {
            get { return _avatar; }
            set { _avatar = value; }
        }
        public ThumbnailArtist()
        {
            InitializeComponent();
        }
        public ThumbnailArtist(string artistName = "Unknown", List<ThumbnailMusic> thumbnailMusics = null, fHome parent = null)
        {
            InitializeComponent();
            ArtistName = artistName;
            this.parent = parent;
            ThumbnailMusics = thumbnailMusics;
            load();
            
        }
        private void load()
        {
            lblArtistName.Text = ArtistName;
        }

        private void lblArtistName_Click(object sender, EventArgs e)
        {
            this.parent.OpenChildForm(new fArtistMusic(ArtistName, Avatar, ThumbnailMusics, this.parent));
        }
    }
}
