using MediaPlayerApp.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MediaPlayerApp.UI
{
    public partial class fArtistMusic : Form
    {
        private string _artistName;
        private string _totalTime;
        private string _songNumber;
        private List<ThumbnailMusic> _musicList;
        private Bitmap _avatar;
        public Bitmap Avatar
        {
            get { return _avatar; }
            set { _avatar = value; }
        }
        public List<ThumbnailMusic> MusicList
        {
            get { return _musicList; }
            set { _musicList = value; }
        }

        public string ArtistName
        {
            get { return _artistName; }
            set { _artistName = value; }
        }
        public string TotalTime
        {
            get { return _totalTime; }
            set { _totalTime = value; }
        }
        public string SongNumber
        {
            get { return _songNumber; }
            set { _songNumber = value; }
        }
        public fHome parent;
        public fArtistMusic()
        {
            InitializeComponent();
        }
        public fArtistMusic(string artistName, Bitmap avatar, List<ThumbnailMusic> musicList, fHome parent = null)
        {
            ArtistName = artistName;
            Avatar = avatar;
            MusicList = musicList;
            this.parent = parent;
            InitializeComponent();
            load();
        }
        private void load()
        {
            lblArtistName.Text = ArtistName;
            TimeSpan totalTime = TimeSpan.Zero;
            lblTotalTime.Text = "";
            foreach (ThumbnailMusic thumbnail in MusicList)
            {
                pnSong.Controls.Add(thumbnail);
                totalTime += (TimeSpan.Parse(thumbnail.Time));
            }
            if (totalTime.Minutes > 1)
            {
                lblTotalTime.Text += totalTime.ToString("mm") + " mins ";
            }
            else lblTotalTime.Text += totalTime.ToString("mm") + " min ";
            if (totalTime.Seconds > 1)
            {
                lblTotalTime.Text += totalTime.ToString("ss") + " seconds ";
            }
            else lblTotalTime.Text += totalTime.ToString("ss") + " second ";
            lblSongs.Text = MusicList.Count.ToString();
            if (MusicList.Count > 1)
            {
                lblSongs.Text += " songs";
            }
            else lblSongs.Text += " song";
        }

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (ThumbnailMusic music in MusicList)
            {

                string filePath = music.Path;

                list.Add(filePath);
            }
            var myPlayList = parent.Media.playlistCollection.newPlaylist("Selected song list");
            foreach (string filePath in list)
            {
                var media = parent.Media.newMedia(filePath);
                myPlayList.appendItem(media);
            }
            parent.Media.currentPlaylist = myPlayList;
        }
        private void btnAddTo_Click(object sender, EventArgs e)
        {

        }
    }
}
