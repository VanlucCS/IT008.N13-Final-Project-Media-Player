using MediaPlayerApp.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediaPlayerApp.Components
{
    public partial class SelectedSong : UserControl
    {
        fMusicLibrary _fMusicLibrary;
        fVideoLibrary _fVideoLibrary;
        fPlaylist _fPlaylist;
        fHomeScreen _fHomeScreen;
        fPlaylistInfo _fPlaylistInfo;
        fFavorite _fFavorite;
        fPlayQueue _fPlayQueue;
        public SelectedSong()
        {
            InitializeComponent();
        }

        public SelectedSong(fMusicLibrary fMusicLibrary)
        {
            InitializeComponent();
            this._fMusicLibrary = fMusicLibrary;
            
        }
        public SelectedSong(fVideoLibrary fVideoLibrary)
        {
            InitializeComponent();
            this._fVideoLibrary = fVideoLibrary;
            guna2Button2.Visible = false;
            btnAddTo.Visible = false;
            btnMore.Visible = false;
        }
        public SelectedSong(fPlaylist fPlaylist)
        {
            InitializeComponent();
            this._fPlaylist = fPlaylist;
        }
        public SelectedSong(fHomeScreen fHomeScreen)
        {
            InitializeComponent();
            this._fHomeScreen = fHomeScreen;
        }
        public SelectedSong(fPlaylistInfo fPlaylistInfo)
        {
            InitializeComponent();
            this._fPlaylistInfo = fPlaylistInfo;
        }
        public SelectedSong(fFavorite fFavorite)
        {
            InitializeComponent();
            this._fFavorite = fFavorite;
        }
        public SelectedSong(fPlayQueue fPlayQueue)
        {
            InitializeComponent();
            this._fPlayQueue = fPlayQueue;
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (_fMusicLibrary!=null)
            {
                //thumbnailMenu.MaximumSize = new Size(200, 200);
                //thumbnailMenu.Width = 190;
                //thumbnailMenu.BringToFront();
                //thumbnailMenu.showHide();
                ContextMenuStrip toolStrip = new ContextMenuStrip();
                toolStrip.ItemClicked += moreClick;
                toolStrip.Items.Clear();
                toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                toolStrip.Items.Add("Edit info");
                toolStrip.Items.Add("Properties");
                toolStrip.Items[0].Image = Resources.pen;
                toolStrip.Items[1].Image = Resources.info;
                int Y = 400;
                toolStrip.Location = new Point(btnMore.Location.X + 70, btnMore.Location.Y + Y);
                toolStrip.Show(MousePosition);
                toolStrip.BringToFront();
                toolStrip.GripStyle = ToolStripGripStyle.Hidden;
                toolStrip.Dock = DockStyle.None;
            } 
            else if (_fVideoLibrary!=null)
            {
            }
            else if (_fPlaylist!=null)
            {

            } 
            else if (_fHomeScreen!=null)
            {

            }
            else if (_fPlaylistInfo != null)
            {

            }
            else if (_fFavorite!=null)
            {

            }  
            else if (_fPlayQueue!=null)
            {

            }    

        }
        private void moreClick(object sender, ToolStripItemClickedEventArgs e)
        {
            // Không biết Thiện làm hàm này chi lun é
            if (_fMusicLibrary!=null)
            {
                if (e.ClickedItem.Text == "Edit info")
                {
                    string path = "";
                    foreach (KeyValuePair<string, bool> item in _fMusicLibrary.SelectedMusic)
                    {
                        if (item.Value == true)
                        {
                            path = item.Key;
                        }
                    }
                    fEditMusic edit = new fEditMusic(path, this._fMusicLibrary);
                    edit.ShowDialog();
                }
                else if (e.ClickedItem.Text == "Properties")
                {
                    string path = "";
                    foreach (KeyValuePair<string, bool> item in _fMusicLibrary.SelectedMusic)
                    {
                        if (item.Value == true)
                        {
                            path = item.Key;
                        }
                    }
                    fEditMusic edit = new fEditMusic(path, this._fMusicLibrary, true);
                    edit.ShowDialog();
                }
            }
            else if (_fVideoLibrary != null)
            {
                _fVideoLibrary.moreClick();
            }
            else if (_fPlaylist != null)
            {
                _fPlaylist.moreClick();
            }
            else if (_fHomeScreen != null)
            {
                _fHomeScreen.moreClick();
            }
            else if (_fPlaylistInfo != null)
            {
                _fPlaylistInfo.moreClick();
            }
            else if (_fFavorite != null)
            {
                _fFavorite.moreClick();
            }
            else if (_fPlayQueue != null)
            {
                _fPlayQueue.moreClick();
            }

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (_fMusicLibrary != null)
            {
                if (guna2CheckBox1.Checked)
                {
                    _fMusicLibrary.selectAll();
                }
                else
                    _fMusicLibrary.deselectAll();
            }
            else if (_fVideoLibrary != null)
            {
                if (guna2CheckBox1.Checked)
                {
                    _fVideoLibrary.selectAll();
                }
                else
                    _fVideoLibrary.deselectAll();
            }
            else if (_fPlaylist != null)
            {
                if (guna2CheckBox1.Checked)
                {
                    _fPlaylist.selectAll();
                }
                else
                    _fPlaylist.deselectAll();
            }
            else if (_fHomeScreen != null)
            {
                if (guna2CheckBox1.Checked)
                {
                    _fHomeScreen.selectAll();
                }
                else
                    _fHomeScreen.deselectAll();
            }
            else if (_fPlaylistInfo != null)
            {
                if (guna2CheckBox1.Checked)
                {
                    _fPlaylistInfo.selectAll();
                }
                else
                    _fPlaylistInfo.deselectAll();
            }
            else if (_fFavorite != null)
            {
                if (guna2CheckBox1.Checked)
                {
                    _fFavorite.selectAll();
                }
                else
                    _fFavorite.deselectAll();
            }
            else if (_fPlayQueue != null)
            {
                if (guna2CheckBox1.Checked)
                {
                    _fPlayQueue.selectAll();
                }
                else
                    _fPlayQueue.deselectAll();
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (_fMusicLibrary != null)
            {
                _fMusicLibrary.playList_Play();
            }
            else if (_fVideoLibrary != null)
            {
                _fVideoLibrary.playList_Play();
            }
            else if (_fPlaylist != null)
            {
                _fPlaylist.playList_Play();
            }
            else if (_fHomeScreen != null)
            {
                _fHomeScreen.playList_Play();
            }
            else if (_fPlaylistInfo != null)
            {
                _fPlaylistInfo.playList_Play();
            }
            else if (_fFavorite != null)
            {
                _fFavorite.playList_Play();
            }
            else if (_fPlayQueue != null)
            {
                _fPlayQueue.playList_Play();
            }

        }

        private void guna2HtmlLabel1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void guna2HtmlLabel1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (_fMusicLibrary != null)
            {
                _fMusicLibrary.playList_PlayNext();
            }
            else if (_fVideoLibrary != null)
            {
                _fVideoLibrary.playList_PlayNext();
            }
            else if (_fPlaylist != null)
            {
                _fPlaylist.playList_PlayNext();
            }
            else if (_fHomeScreen != null)
            {
                _fHomeScreen.playList_PlayNext();
            }
            else if (_fPlaylistInfo != null)
            {
                _fPlaylistInfo.playList_PlayNext();
            }
            else if (_fFavorite != null)
            {
                _fFavorite.playList_PlayNext();
            }
            else if (_fPlayQueue != null)
            {
                _fPlayQueue.playList_PlayNext();
            }

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            if (_fMusicLibrary != null)
            {
                _fMusicLibrary.clear();
            }
            else if (_fVideoLibrary != null)
            {
                _fVideoLibrary.clear();
            }
            else if (_fPlaylist != null)
            {
                _fPlaylist.clear();
            }
            else if (_fHomeScreen != null)
            {
                _fHomeScreen.clear();
            }
            else if (_fPlaylistInfo != null)
            {
                _fPlaylistInfo.clear();
            }
            else if (_fFavorite != null)
            {
                _fFavorite.clear();
            }
            else if (_fPlayQueue != null)
            {
                _fPlayQueue.clear();
            }
        }

        private void btnAddTo_Click(object sender, EventArgs e)
        {
            ContextMenuStrip toolStrip = new ContextMenuStrip();
            toolStrip.ItemClicked += addToClick;
            toolStrip.Items.Clear();
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip.Items.Add("Play queue");
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("New playlist");
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("Playlist");
            toolStrip.Items[0].Image = Resources.lounge_music_playlist_96px;
            toolStrip.Items[2].Image = Resources.plus;
            int Y = 400;
            toolStrip.Location = new Point(btnAddTo.Location.X + 70, btnAddTo.Location.Y + Y);
            toolStrip.Show(MousePosition);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;
        }
        private void addToClick(object sender, ToolStripItemClickedEventArgs e)
        {
            #region Playlist
            if (e.ClickedItem.Text == "New playlist")
            {
                // add new playlist
                List<string> listAdd = new List<string> { };
                if (_fMusicLibrary!=null)
                {
                    foreach (ThumbnailMusic item in _fMusicLibrary.flowLayoutPanel1.Controls)
                    {
                        if (item.guna2CheckBox1.Checked == true)
                        {
                            listAdd.Add(item.Path);
                        }
                    }
                }
                else if (_fVideoLibrary!=null)
                {
                    listAdd = _fVideoLibrary.videoPath;
                }    
                fAddNewPlaylistcs f = new fAddNewPlaylistcs(listAdd.ToArray());
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
                return;
            }
            if (e.ClickedItem.Text == "Playlist")
            {

                ContextMenuStrip toolStrip = new ContextMenuStrip();
                toolStrip.ItemClicked += addToPlaylist;
                toolStrip.Items.Clear();
                toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                DirectoryInfo d = new DirectoryInfo(@"./Data/Playlists");
                FileInfo[] Files = d.GetFiles();
                foreach (FileInfo file in Files)
                {
                    toolStrip.Items.Add(file.Name.Substring(0, file.Name.Length - 4));
                }
                int Y = 400;
                toolStrip.Location = new Point(btnAddTo.Location.X + 70, btnAddTo.Location.Y + Y);
                toolStrip.Show(MousePosition);
                toolStrip.BringToFront();
                toolStrip.GripStyle = ToolStripGripStyle.Hidden;
                toolStrip.Dock = DockStyle.None;
                return;
            } 
            #endregion


        }
        private void addToPlaylist(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                List<string> listAdd = new List<string> { };

                string playListPath = @"./Data/Playlists/" + e.ClickedItem.Text + ".txt";

                foreach (ThumbnailMusic item in _fMusicLibrary.flowLayoutPanel1.Controls)
                {
                    if (item.guna2CheckBox1.Checked == true)
                    {
                        listAdd.Add(item.Path);
                    }
                }
                string fileName = @"./Data/Playlists/" + e.ClickedItem.Text + ".txt";
                foreach (string songPath in listAdd.ToArray())
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
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception)
            {
            }
        }
    
    }
}
