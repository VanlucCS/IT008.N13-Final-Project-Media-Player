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

namespace MediaPlayerApp.UI
{
    public partial class fEditMusic : Form
    {
        private string _title;
        private string _album;
        private string _artist;
        private string _albumArtist;
        private string _genre;
        private string _track;
        private string _year;
        private string _fileLocation;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public string AlbumArtist
        {
            get { return _albumArtist; }
            set { _albumArtist = value; }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public string Track
        {
            get { return _track; }
            set { _track = value; }
        }
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public string FileLocation
        {
            get { return _fileLocation; }
            set { _fileLocation = value; }
        }
        MusicSong musicSong;
        public fEditMusic()
        {
            InitializeComponent();
        }
        public fMusicLibrary _fMusicLibrary;
        public fEditMusic(string path, fMusicLibrary _fMusicLibrary)
        {
            InitializeComponent();
            this._fMusicLibrary = _fMusicLibrary;
            FileLocation = path;
            musicSong = new MusicSong(FileLocation);
            this.Title = musicSong.NameSong;
            this.Artist = musicSong.Artist;
            this.AlbumArtist = musicSong.AlbumArtist;
            this.Genre = musicSong.NameGenre;
            this.Track = musicSong.Track;
            this.Year = musicSong.Year;
            this.Album = musicSong.Album;

            load();
        }
        private void load()
        {
            tbTile.Text = this.Title;
            tbArtist.Text = this.Artist;
            tbAlbumArtist.Text = this.AlbumArtist;
            tbAlbum.Text = this.Album;
            tbTrack.Text = this.Track;
            tbYear.Text = this.Year;
            tbGenre.Text = this.Genre;
            lblFilePath.Text = this.FileLocation;
        }
        private void guna2HtmlLabel11_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor= Cursors.Hand;
        }

        private void guna2HtmlLabel11_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TagLib.File mp3File = TagLib.File.Create(FileLocation);

            // Edit the metadata
            mp3File.Tag.Title = tbTile.Text;
            mp3File.Tag.Album = tbAlbum.Text;
            mp3File.Tag.Performers = tbArtist.Text.Split(new[] { ", " }, StringSplitOptions.None);
            mp3File.Tag.Genres = tbGenre.Text.Split(new[] { ", " }, StringSplitOptions.None);
            mp3File.Tag.AlbumArtists = tbAlbumArtist.Text.Split(new[] { ", " }, StringSplitOptions.None);
            mp3File.Tag.Track = Convert.ToUInt32(tbTrack.Text);
            mp3File.Tag.Year = Convert.ToUInt32(tbYear.Text);
            // Save the changes
            mp3File.Save();
            this._fMusicLibrary.loadMusicNew();
            this._fMusicLibrary.selectedChanged();
            this.Close();
        }
    }
}
