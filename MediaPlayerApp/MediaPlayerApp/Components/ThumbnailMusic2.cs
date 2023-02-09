using MediaPlayerApp.BLL;
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

namespace MediaPlayerApp.Components
{
    public partial class ThumbnailMusic2 : UserControl
    {
        private string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        public ThumbnailMusic music;
        public fHome parent;
        public ThumbnailMusic2(string path, fHome parent = null)
        {
                this.Path = path;
                this.parent = parent;
            InitializeComponent();
        }
        private void ThumbnailMusic2_Load(object sender, EventArgs e)
        {
            if (File.Exists(Path))
            {
                music = new ThumbnailMusic(Path, this.parent);
                MusicSong musicSong = new MusicSong(Path);
                pictureSong.BackgroundImage = musicSong.PictureSong;
                nameSongLabel.Text = musicSong.NameSong;
                lblDate.Text = musicSong.DateAdd;
            }
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            music.btnPlay_Click(this.parent ,null);
        }
    }
}
