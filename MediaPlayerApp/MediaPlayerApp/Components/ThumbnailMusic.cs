using MediaPlayerApp.BLL;
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
    public partial class ThumbnailMusic : UserControl
    {
        string songName;
        string artistName;
        string albumName;
        string genre;
        string time;
        string path;
        MusicSong musicSong;
        public ThumbnailMusic()
        {
            InitializeComponent();
        }
        public ThumbnailMusic(string songName, string artistName, string albumName, string time)
        {
            this.songName = songName;
            this.artistName = artistName;
            this.albumName = albumName;
            this.time = time;
            InitializeComponent();
            load();
        }
        public ThumbnailMusic(string path)
        {
            this.path = path; 
            InitializeComponent();
            musicSong = new MusicSong(path);
            this.songName = musicSong.NameSong;
            this.artistName = musicSong.Singer;
            this.time = musicSong.Length;
            this.genre = musicSong.NameGenre;
            load();
        }
        private void load()
        {
            lblSongName.Text = songName == null ? "Unknown" : songName;
            lblArtist.Text = artistName == null ? "Unknown" : artistName;
            lblAlbum.Text = albumName == null ? "Unknown" : albumName;
            lblGenre.Text = genre == null ? "Unknown" : genre;
            lblTime.Text = time == null ? "Unknown" : time;
        }

        private void ThumbnailMusic_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(220, 220, 220);
            this.Cursor = Cursors.Hand;
        }

        private void ThumbnailMusic_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
            this.Cursor = Cursors.Default;
        }

        private void ThumbnailMusic_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
