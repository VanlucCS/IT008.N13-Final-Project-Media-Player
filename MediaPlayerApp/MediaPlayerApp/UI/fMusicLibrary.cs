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
        SelectedSong selectedSong;

        public fMusicLibrary(fHome parent = null)
        {
            this.parent = parent;
            selectedSong = new SelectedSong(this);
            InitializeComponent();
            selectedSong.Location = new Point(5, 45);
            selectedSong.Visible = false;
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
            flowLayoutPanel1.Controls.Clear();
            // get list music string[] path infolder added
            string[] listPath;
            try
            {
                string[] folderadded = System.IO.File.ReadAllLines(@"./Data/Music.txt");
                foreach (string folder in folderadded)
                {
                    if (Directory.Exists(folder))
                    {
                        foreach (string file in Directory.GetFiles(folder))
                        {
                            FileInfo info = new FileInfo(file);
                            if (info.Extension == ".mp3")
                            {

                                ThumbnailMusic thumbnailMusic = new ThumbnailMusic(file, this.parent, this);
                                thumbnailMusic.Dock = DockStyle.Top;
                                thumbnailMusic.Name = file;
                                SelectedMusic.Add(thumbnailMusic.Name, false);
                                flowLayoutPanel1.Controls.Add(thumbnailMusic);
                            }
                            //MessageBox.Show(file);

                        }
                    }    


                }
            }
            catch (Exception)
            {
            }



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
                guna2ComboBox1.Visible = true;
                guna2ComboBox2.Visible = true;
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
                guna2ComboBox1.Visible = false;
                guna2ComboBox2.Visible = false;
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
                guna2ComboBox1.Visible = true;
                guna2ComboBox2.Visible = true;
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
                        loadMusic();
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

    }
}
