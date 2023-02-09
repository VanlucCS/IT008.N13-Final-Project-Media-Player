using MediaPlayerApp.BLL;
using MediaPlayerApp.UI;
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
using WMPLib;

namespace MediaPlayerApp.Components
{
    public partial class Playlist : UserControl
    {   
        public fHome parent;
        private string _playListName;
        private string  _playListPath;
        private int _numItems;

        public int NumItems
        {
            get { return _numItems; }
            set { _numItems = value; }
        }

        public string  PlayListPath
        {
            get { return _playListPath; }
            set { _playListPath = value; }
        }
        public string PlayListName
        {
            get { return _playListName; }
            set { _playListName = value; lbPlayListName.Text = value; }
        }

        public Playlist(string PLPath, fHome parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            PlayListPath = PLPath;
        }
        private void Playlist_Load(object sender, EventArgs e)
        {
            FileInfo i = new FileInfo(PlayListPath);
            PlayListName = i.Name.Substring(0,i.Name.Length-4);

            int songCounter = 0;
            // Load Preview
            string[] playListSongs = System.IO.File.ReadAllLines(PlayListPath);
            foreach (string s in playListSongs)
            {
                if (!File.Exists(s))
                {
                    playListSongs = playListSongs.Except(new string[] { s }).ToArray();
                }    
            }    
            if(playListSongs.Length <=1 )
                lblItem.Text = playListSongs.Length.ToString() + " Item";
            else
                lblItem.Text = playListSongs.Length.ToString() + " Items";
            NumItems = playListSongs.Length;
            foreach (string songPath in playListSongs)
            {
                if (songCounter >= 4)
                    break;
                try
                {
                    FileInfo info = new FileInfo(songPath);
                    if (info.Extension == ".mp3")
                    {
                        MusicSong song = new MusicSong(songPath);
                        if (songCounter == 0)
                            pbxImage1.Image = song.PictureSong;
                        if (songCounter == 1)
                            pbxImage2.Image = song.PictureSong;
                        if (songCounter == 2)
                            pbxImage3.BackgroundImage = song.PictureSong;
                        if (songCounter == 3)
                            pbxImage4.BackgroundImage = song.PictureSong;
                        songCounter++;
                    }
                }
                catch (Exception)
                {
                }
            }
        }
        private void Playlist_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlDark;
        }

        private void Playlist_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void btMore_Click(object sender, EventArgs e)
        {
            ContextMenuStrip toolStrip = new ContextMenuStrip();
            toolStrip.ItemClicked += menuClick;
            toolStrip.Items.Clear();
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip.Items.Add("Delete Playlist");
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("Add to Playlist");
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("Rename PlayList");
            int Y = 400;
            toolStrip.Location = new Point(btMore.Location.X + 70, btMore.Location.Y + Y);
            toolStrip.Show(MousePosition);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;
        }
        private void menuClick(object sender, ToolStripItemClickedEventArgs e)
        {
            // click..
            if (e.ClickedItem.Text == "")
            {
                return;
            }
            if (e.ClickedItem.Text == "Delete Playlist")
            {
                DialogResult ok = MessageBox.Show("Bạn có chắn chắn muốn playlist", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ok == DialogResult.OK)
                {
                    try
                    {
                        // Check if file exists    
                        if (File.Exists(this.PlayListPath))
                        {
                            // If file found, delete it    
                            File.Delete(this.PlayListPath);
                            MessageBox.Show("Xóa thành công");
                            this.parent.btPlayList_Click(this.parent, null);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            if (e.ClickedItem.Text == "Add to Playlist")
            {
                ContextMenuStrip toolStrip = new ContextMenuStrip();
                toolStrip.ItemClicked += menuAddToClick;
                toolStrip.Items.Clear();
                toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                toolStrip.Items.Add("Add to Playlist :");
                toolStrip.Items.Add("-");
                DirectoryInfo d = new DirectoryInfo(@"./Data/Playlists");
                FileInfo[] Files = d.GetFiles();
                foreach (FileInfo file in Files)
                {
                    if(PlayListName!= file.Name.Substring(0, file.Name.Length - 4))
                        toolStrip.Items.Add(file.Name.Substring(0, file.Name.Length - 4));
                }
                int Y = 450;
                toolStrip.Location = new Point(btMore.Location.X + 80, btMore.Location.Y + Y);
                toolStrip.Show(MousePosition);
                toolStrip.BringToFront();
                toolStrip.GripStyle = ToolStripGripStyle.Hidden;
                toolStrip.Dock = DockStyle.None;
            }
            if (e.ClickedItem.Text == "Rename PlayList")
            {
                fRenamePlaylist f = new fRenamePlaylist(this);
                f.ShowDialog();
            }
        }
        private void menuAddToClick(object sender, ToolStripItemClickedEventArgs e)
        {
            //MessageBox.Show(e.ClickedItem.Text);
            if (e.ClickedItem.Text == "")
            {
                return;
            }
            if (e.ClickedItem.Text == "Add to Playlist :")
            {
                return;
            }
            // click..
            string[] listPathSongPL = System.IO.File.ReadAllLines(this.PlayListPath);
            string fileName = @"./Data/Playlists/" + e.ClickedItem.Text + ".txt";

            foreach (string songPath in listPathSongPL)
            {
                // check song path dup in playlist 
                string[] listPathSongPL2 = System.IO.File.ReadAllLines(fileName);
                bool dup = false;
                foreach (string songPath2 in listPathSongPL2)
                {
                    if (songPath == songPath2)
                        dup = true;
                }
                if (!dup)
                {
                    using (StreamWriter w = File.AppendText(fileName))
                    {
                        w.WriteLine(songPath);
                    }
                }
            }
            MessageBox.Show("Thên thành công");
            this.parent.btPlayList_Click(this.parent, null);
        }
        private void btPlay_Click(object sender, EventArgs e)
        {
            string[] listPath = System.IO.File.ReadAllLines(PlayListPath);
            if (listPath.Length != 0)
            {

                IWMPPlaylist playlist = this.parent.Media.newPlaylist("Playlist", null);
                foreach (string path in listPath)
                {
                    if (File.Exists(path))
                    {
                        WMPLib.IWMPMedia m = this.parent.Media.newMedia(path);
                        playlist.appendItem(m);
                    }
                }
                this.parent.Media.currentPlaylist = playlist;
                this.parent.Media.Ctlcontrols.play();
            }
            this.parent.AddToRecent(this.PlayListPath);
        }

        private void Playlist_Click(object sender, EventArgs e)
        {
            this.parent.OpenChildForm(new fPlaylistInfo(this, this.parent));
        }
        public void ShowPlayList()
        {
            this.parent.OpenChildForm(new fPlaylistInfo(this, this.parent));
        }

    }
}
