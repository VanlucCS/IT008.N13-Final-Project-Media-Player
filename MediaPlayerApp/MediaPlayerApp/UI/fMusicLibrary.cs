using MediaPlayerApp.Components;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerApp.UI
{
    public partial class fMusicLibrary : Form
    {
        private string filter = "*****";

        public fHome parent;
        private List<string> _listSong = new List<string>();
        public List<string> ListSong
        {
            get { return _listSong; }
            set { _listSong = value; }
        }
        private Dictionary<string, bool> _selectedMusic = new Dictionary<string, bool>();

        public Dictionary<string, bool> SelectedMusic
        {
            set { _selectedMusic = value; }
            get { return _selectedMusic; }
        }

        private int _count = 0;
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public bool isSelectedAll = false;
        private string _sortBy;
        public string SortBy
        {
            get { return _sortBy; }
            set { _sortBy = value; }
        }
        private int _sortOption = 0;
        private bool _isSortByDate = false;
        private int _screenOption = 0;
        SelectedSong selectedSong;

        public fMusicLibrary(fHome parent = null)
        {
            this.parent = parent;
            selectedSong = new SelectedSong(this);
            InitializeComponent();
            selectedSong.Location = new Point(5, 45);
            selectedSong.Visible = false;
            loadGenres();
            loadMusicNew();
        }

        private void lblSongs_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblSongs.Left + (lblSongs.Width - pbxUnderline.Width) / 2;
            _screenOption = 0;
            loadMusicNew(); 
        }

        private void lblAlbums_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblAlbums.Left + (lblAlbums.Width - pbxUnderline.Width) / 2;
            _screenOption = 1;
            loadMusicNew();
        }

        private void lblArtists_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblArtists.Left + (lblArtists.Width - pbxUnderline.Width) / 2;
            _screenOption = 2;
            loadMusicNew();
        }
        private void loadGenres()
        {
            List<string> genres = new List<string>();
            try
            {
                string[] folderadded = System.IO.File.ReadAllLines(@"./Data/Music.txt"); // Get folder 
                foreach (string folder in folderadded) // Loop over files in each folder
                {
                    if (Directory.Exists(folder))
                    {
                        foreach (string file in Directory.GetFiles(folder)) // loop over files and get file with extension: ".mp3"
                        {
                            FileInfo info = new FileInfo(file);
                            if (info.Extension == ".mp3")
                            {
                                ThumbnailMusic thumbnailMusic = new ThumbnailMusic(file, this.parent, this);

                                thumbnailMusic.Dock = DockStyle.Top;
                                thumbnailMusic.Name = file;
                                if (!genres.Contains(thumbnailMusic.Genre))
                                {
                                    genres.Add(thumbnailMusic.Genre);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
            foreach (string genre in genres)
            {
                cbbGenre.Items.Add(genre);
            }
        }
        public void loadMusicNew()
        {
            flowLayoutPanel1.Controls.Clear();
            SelectedMusic.Clear();
            List<ThumbnailMusic> thumbnailmusicList = new List<ThumbnailMusic>(); // Get thumbnails for sorting
            Dictionary<string, List<ThumbnailMusic>> artistList = new Dictionary<string, List<ThumbnailMusic>>();
            Dictionary<string, List<ThumbnailMusic>> albumList = new Dictionary<string, List<ThumbnailMusic>>();

            #region Get musics
            try
            {
                string[] folderadded = System.IO.File.ReadAllLines(@"./Data/Music.txt"); // Get folder 
                foreach (string folder in folderadded) // Loop over files in each folder
                {
                    if (Directory.Exists(folder))
                    {
                        foreach (string file in Directory.GetFiles(folder)) // loop over files and get file with extension: ".mp3"
                        {
                            FileInfo info = new FileInfo(file);
                            if (info.Extension == ".mp3")
                            {
                                ThumbnailMusic thumbnailMusic = new ThumbnailMusic(file, this.parent, this);

                                thumbnailMusic.Dock = DockStyle.Top;
                                thumbnailmusicList.Add(thumbnailMusic);
                                thumbnailMusic.Name = file;
                                if (artistList.ContainsKey(thumbnailMusic.ArtistName))
                                {
                                    artistList[thumbnailMusic.ArtistName].Add(thumbnailMusic);
                                }
                                else
                                {
                                    artistList.Add(thumbnailMusic.ArtistName, new List<ThumbnailMusic>() { thumbnailMusic });
                                }
                                if (albumList.ContainsKey(thumbnailMusic.AlbumName))
                                {
                                    albumList[thumbnailMusic.AlbumName].Add(thumbnailMusic);
                                }
                                else
                                {
                                    albumList.Add(thumbnailMusic.AlbumName, new List<ThumbnailMusic>() { thumbnailMusic });
                                }

                                SelectedMusic.Add(thumbnailMusic.Name, false);
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
            #endregion
            #region load 'Songs' option 
            if (_screenOption == 0)
            {
                lblSort.Visible = true;
                cbbSortBy.Visible = true;
                lbGenre.Visible = true;
                cbbGenre.Visible = true;
                #region Sort by alphabet
                if (_sortOption == 0) //Sort by alphabet
                {
                    thumbnailmusicList.Sort(delegate (ThumbnailMusic x, ThumbnailMusic y) {
                        return x.SongName.CompareTo(y.SongName);
                    });
                    for (int i = 0; i < thumbnailmusicList.Count; i++)
                    {
                        if (filter == "*****")
                        {
                            flowLayoutPanel1.Controls.Add(thumbnailmusicList[i]);
                        }
                        else if (filter == thumbnailmusicList[i].Genre)
                        {
                            flowLayoutPanel1.Controls.Add(thumbnailmusicList[i]);
                        }
                    }
                }
                #endregion
                #region Sort by artist 
                else if (_sortOption == 1) // Sort by artist
                {
                    thumbnailmusicList.Sort(delegate (ThumbnailMusic x, ThumbnailMusic y) {
                        return x.ArtistName.CompareTo(y.ArtistName);
                    });
                    for (int i = 0; i < thumbnailmusicList.Count; i++)
                    {
                        if (filter == "*****")
                        {
                            flowLayoutPanel1.Controls.Add(thumbnailmusicList[i]);
                        }
                        else if (filter == thumbnailmusicList[i].Genre)
                        {
                            flowLayoutPanel1.Controls.Add(thumbnailmusicList[i]);
                        }
                    }
                }
                #endregion
                #region Sort by album
                else if (_sortOption == 2) // Sort by album
                {
                    thumbnailmusicList.Sort(delegate (ThumbnailMusic x, ThumbnailMusic y) {
                        return x.AlbumName.CompareTo(y.AlbumName);
                    });
                    for (int i = 0; i < thumbnailmusicList.Count; i++)
                    {
                        if (filter == "*****")
                        {
                            flowLayoutPanel1.Controls.Add(thumbnailmusicList[i]);
                        }
                        else if (filter == thumbnailmusicList[i].Genre)
                        {
                            flowLayoutPanel1.Controls.Add(thumbnailmusicList[i]);
                        }
                    }
                }
                #endregion
                #region Sort by release year
                else if (_sortOption == 3) // Sort by release year
                {
                    thumbnailmusicList.Sort(delegate (ThumbnailMusic x, ThumbnailMusic y) {
                        return Convert.ToInt32(x.ReleaseYear).CompareTo(Convert.ToInt32(y.ReleaseYear));
                    });
                    for (int i = 0; i < thumbnailmusicList.Count; i++)
                    {
                        if (filter == "*****")
                        {
                            flowLayoutPanel1.Controls.Add(thumbnailmusicList[i]);
                        }
                        else if (filter == thumbnailmusicList[i].Genre)
                        {
                            flowLayoutPanel1.Controls.Add(thumbnailmusicList[i]);
                        }
                    }
                }
                #endregion
                #region Date added
                else if (_sortOption == 4) // Date added
                {
                    thumbnailmusicList.Sort(delegate (ThumbnailMusic x, ThumbnailMusic y) {
                        return Convert.ToDateTime(x.MusicDate).CompareTo(Convert.ToDateTime(y.MusicDate));
                    });
                    for (int i = 0; i < thumbnailmusicList.Count; i++)
                    {
                        if (filter == "*****")
                        {
                            flowLayoutPanel1.Controls.Add(thumbnailmusicList[i]);
                        }
                        else if (filter == thumbnailmusicList[i].Genre)
                        {
                            flowLayoutPanel1.Controls.Add(thumbnailmusicList[i]);
                        }
                    }
                }
                #endregion
            }
            #endregion
            #region load 'Albums' option
            else if (_screenOption == 1)
            {
                lblSort.Visible = false;
                cbbSortBy.Visible = false;
                lbGenre.Visible = false;
                cbbGenre.Visible = false;
                foreach (KeyValuePair<string, List<ThumbnailMusic>> album in albumList)
                {
                    ThumbnailArtist thumbnailArtist = new ThumbnailArtist(album.Key, album.Value, this.parent);
                    flowLayoutPanel1.Controls.Add(thumbnailArtist);
                }
            }
            #endregion
            #region load 'Artists' option
            else if (_screenOption == 2)
            {
                lblSort.Visible = false;
                cbbSortBy.Visible = false;
                lbGenre.Visible = false;
                cbbGenre.Visible = false;
                foreach (KeyValuePair<string, List<ThumbnailMusic>> artist in artistList)
                {
                    ThumbnailArtist thumbnailArtist = new ThumbnailArtist(artist.Key, artist.Value, this.parent);
                    flowLayoutPanel1.Controls.Add(thumbnailArtist);
                }
            }
            #endregion
        }
        private void lbGenre_Click(object sender, EventArgs e)
        {

        }
        public void deselectAll()
        {
            if (Count == SelectedMusic.Count)
            {
                List<string> keys = new List<string>();
                Count = 0;
                for (int i = 0; i < SelectedMusic.Count; i++)
                {
                    KeyValuePair<string, bool> item = SelectedMusic.ElementAt(i);
                    string path = item.Key;
                    SelectedMusic[path] = false;
                    Count++;

                    Control[] controlsFound = flowLayoutPanel1.Controls.Find(path, true);
                    foreach (ThumbnailMusic song in controlsFound)
                    {
                        song.Guna2CheckBox1.Checked = false;
                    }
                }
                btnShuffleAndPlay.Visible = true;
                lblSort.Visible = true;
                cbbSortBy.Visible = true;
                cbbGenre.Visible = true;
                lbGenre.Visible = true;
                selectedSong.Visible = false;
                Count = 0;
            }
        }
        public void selectAll()
        {
            List<string> keys = new List<string>();
            Count = 0;
            for (int i = 0; i < SelectedMusic.Count; i++)
            {
                KeyValuePair<string, bool> item = SelectedMusic.ElementAt(i);
                string path = item.Key;
                SelectedMusic[path] = true;
                Count++;

                Control[] controlsFound = flowLayoutPanel1.Controls.Find(path, true);
                foreach (ThumbnailMusic song in controlsFound)
                {
                    song.Guna2CheckBox1.Checked = true;
                }
            }
            Count = SelectedMusic.Count;
        }
        public void selectedChanged()
        {
            Count = 0;
            foreach (var item in SelectedMusic)
            {
                string path = item.Key;
                bool isSelected = item.Value;
                if (isSelected)
                {
                    Count++;
                }
            }

            this.Controls.Add(selectedSong);
            if (Count > 0)
            {
                selectedSong.Visible = true;
                selectedSong.BringToFront();
                if (Count > 1)
                {
                    selectedSong.BtnMore.Visible = false;
                }
                else selectedSong.BtnMore.Visible = true;
                if (Count == SelectedMusic.Count)
                {
                    selectedSong.Guna2CheckBox1.Checked = true;
                }
                else selectedSong.Guna2CheckBox1.Checked = false;
                if (Count == 0)
                {
                    return;
                }
                if (Count == 1)
                {
                    selectedSong.LblSongNumber.Text = Count.ToString() + " song selected";
                }
                else
                {
                    selectedSong.LblSongNumber.Text = Count.ToString() + " songs selected";
                } 
                
                

                btnShuffleAndPlay.Visible = false;
                lblSort.Visible = false;
                cbbSortBy.Visible = false;
                cbbGenre.Visible = false;
                lbGenre.Visible = false;
                if (Count == SelectedMusic.Count)
                {
                    isSelectedAll = true;
                }
                else isSelectedAll = false;

            }
            else
            {
                btnShuffleAndPlay.Visible = true;
                lblSort.Visible = true;
                cbbSortBy.Visible = true;
                cbbGenre.Visible = true;
                lbGenre.Visible = true;
                selectedSong.Visible = false;
            }
        }

        public void clear()
        {
            List<string> keys = new List<string>();
            Count = 0;
            for (int i = 0; i < SelectedMusic.Count; i++)
            {
                KeyValuePair<string, bool> item = SelectedMusic.ElementAt(i);
                string path = item.Key;
                SelectedMusic[path] = false;

                Control[] controlsFound = flowLayoutPanel1.Controls.Find(path, true);
                foreach (ThumbnailMusic song in controlsFound)
                {
                    song.Guna2CheckBox1.Checked = false;
                }
            }
        }
        public void moreClick()
        {

        }
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.RootFolder = Environment.SpecialFolder.MyComputer;
            if (f.ShowDialog() == DialogResult.OK)
            {
                // check exits
                if (Directory.Exists(f.SelectedPath))
                {
                    string[] folderadded = System.IO.File.ReadAllLines(@"./Data/Music.txt");
                    foreach (string folder in folderadded)
                    {
                        if (f.SelectedPath == folder)
                        {
                            return;
                        }
                    }
                    using (StreamWriter w = File.AppendText(@"./Data/Music.txt"))
                    {
                        w.WriteLine(f.SelectedPath);
                        loadMusicNew();
                    }
                }
                else
                    return;

            }
        }

        private void fMusicLibrary_Load(object sender, EventArgs e)
        {

        }
        public void playList_PlayNext()
        {
            timer1.Enabled = true;
            for (int index = 0; index < SelectedMusic.Count; index++)
            {
                KeyValuePair<string, bool> item = SelectedMusic.ElementAt(index);
                string filePath = item.Key;
                bool isPlay = item.Value;
                if (isPlay)
                {
                    ListSong.Add(filePath);
                }
            }

        }
        public void playList_Play()
        {
            List<string> list = new List<string>();
            for (int index = 0; index < SelectedMusic.Count; index++)
            {
                KeyValuePair<string, bool> item = SelectedMusic.ElementAt(index);
                string filePath = item.Key;
                bool isPlay = item.Value;
                if (isPlay)
                {
                    list.Add(filePath);
                }
            }
            var myPlayList = parent.Media.playlistCollection.newPlaylist("Selected song list");
            foreach (string filePath in list)
            {
                var media = parent.Media.newMedia(filePath);
                myPlayList.appendItem(media);
            }
            parent.Media.currentPlaylist = myPlayList;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (parent.IsStop == true)
            {
                var myPlayList = parent.Media.playlistCollection.newPlaylist("Selected song list");
                foreach (string filePath in ListSong)
                {
                    var media = parent.Media.newMedia(filePath);
                    myPlayList.appendItem(media);
                }
                parent.Media.currentPlaylist = myPlayList;
                timer1.Enabled = false;
            }
        }

        private void cbbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _sortOption = cbbSortBy.SelectedIndex;
            loadMusicNew();
        }

        private void cbbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbGenre.SelectedIndex == 0)
            {
                filter = "*****";
            }
            else filter = cbbGenre.SelectedItem.ToString();
            loadMusicNew();
        }

        private void btnShuffleAndPlay_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (ThumbnailMusic control in flowLayoutPanel1.Controls)
            {
                list.Add(control.Path);
            }
            var rnd = new Random();
            var randomList = list.OrderBy(item => rnd.Next());
            var myPlayList = parent.Media.playlistCollection.newPlaylist("Selected song list");
            foreach (string filePath in randomList)
            {
                var media = parent.Media.newMedia(filePath);
                myPlayList.appendItem(media);
            }
            parent.Media.currentPlaylist = myPlayList;
        }
    }
}
