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
        private string _songName;
        private string _albumName;
        private string _artistName;
        private string _genre;
        private string _time;
        private string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public string SongName
        {
            get { return _songName; }
            set { _songName = value; }
        }

        public string ArtistName
        {
            get { return _artistName; }
            set { _artistName = value; }
        }

        public string AlbumName
        {
            get { return _albumName; }
            set { _albumName = value; }
        }

        MusicSong musicSong;
        public fHome parent; 
        public ThumbnailMusic(fHome parent = null)
        {
            this.parent = parent;
            InitializeComponent();
        }
        public ThumbnailMusic(string songName, string artistName, string albumName, string time, fHome parent = null)
        {
            this.SongName = songName;
            this.ArtistName = artistName;
            this.AlbumName = albumName;
            this.Time = time;
            InitializeComponent();
            load();
        }
        public ThumbnailMusic(string path, fHome parent = null)
        {
            this.parent = parent;
            this.Path = path; 
            InitializeComponent();
            musicSong = new MusicSong(path);
            this.SongName = musicSong.NameSong;
            this.ArtistName = musicSong.Singer;
            this.Time = musicSong.Length;
            this.Genre = musicSong.NameGenre;
            load();
        }
        private void load()
        {
            lblSongName.Text = this.SongName == null ? "Unknown" : this.SongName;
            lblArtist.Text = this.ArtistName == null ? "Unknown" : this.ArtistName;
            lblAlbum.Text = this.AlbumName == null ? "Unknown" : this.AlbumName;
            lblGenre.Text = this.Genre == null ? "Unknown" : this.Genre;
            lblTime.Text = this.Time == null ? "Unknown" : this.Time;
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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //
            if(this.parent.currenSong == this && this.parent.Media.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                this.parent.Media.Ctlcontrols.pause();
                btnPlay.Checked = !btnPlay.Checked;
                return;
            }
            if (this.parent.currenSong == this && this.parent.Media.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                this.parent.Media.Ctlcontrols.play();
                btnPlay.Checked = !btnPlay.Checked;
                return;
            }
            // stop prev song
            if (this.parent.currenSong != null )
                this.parent.currenSong.btnPlay.Checked = false;

            // play chosse song
            this.parent.Media.URL = this.Path;
            this.parent.Media.Ctlcontrols.play();
            // load preview song
            this.parent.pbSongpic.Image = musicSong.PictureSong;
            this.parent.lbSongName.Text = musicSong.NameSong + "\n" + musicSong.Singer;
            this.parent.currenSong = this;
            btnPlay.Checked = !btnPlay.Checked;


        }

        private void btnPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlay.Checked == true)
            {
                btnPlay.Image = MediaPlayerApp.Properties.Resources.pause_button__2_;
            }
            else
            {
                btnPlay.Image = MediaPlayerApp.Properties.Resources.play_96px;

            }    
        }
    }
}
