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
            toolStrip.Items.Add("Move to Playlist");
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
            if (e.ClickedItem.Text == "Delete Playlist")
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
            if (e.ClickedItem.Text == "Move to Playlist")
            {
                ContextMenuStrip toolStrip = new ContextMenuStrip();
                toolStrip.ItemClicked += menuClick;
                toolStrip.Items.Clear();
                toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                toolStrip.Items.Add("Playlist 1");
                toolStrip.Items.Add("-");
                toolStrip.Items.Add("Playlist 2");
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

        private void btPlay_Click(object sender, EventArgs e)
        {
            this.parent.OpenChildForm(new fPlaylistInfo(this,this.parent));
        }
    }
}
