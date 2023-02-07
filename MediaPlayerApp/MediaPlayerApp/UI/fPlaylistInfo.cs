using MediaPlayerApp.Components;
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

namespace MediaPlayerApp.UI
{
    public partial class fPlaylistInfo : Form
    {
        public fHome parent;
        public Playlist playList;
        public fPlaylistInfo(Playlist pl, fHome parent = null)
        {
            this.parent = parent;
            this.playList = pl;
            InitializeComponent();

        }
        private void fPlaylistInfo_Load(object sender, EventArgs e)
        {
            this.pbPreviewImage1.Image = playList.pbxImage1.Image;
            this.pbPreviewImage2.Image = playList.pbxImage2.Image;
            this.pbPreviewImage3.Image = playList.pbxImage3.BackgroundImage;
            this.pbPreviewImage4.Image = playList.pbxImage4.BackgroundImage;
            this.lbPlayListName.Text = playList.PlayListName;
            this.lblItem.Text = playList.NumItems.ToString() +" Items";

            // Load
            loadPlayList();
        }
        private void loadPlayList()
        {
            pnSong.Controls.Clear();
            // load path song fvor fr data 
            string[] listPath = System.IO.File.ReadAllLines(playList.PlayListPath);
            foreach (string songPath in listPath)
            {
                try
                {
                    FileInfo info = new FileInfo(songPath);
                    if (info.Extension == ".mp3")
                    {

                        ThumbnailMusic thumbnailMusic = new ThumbnailMusic(songPath, this.parent);
                        thumbnailMusic.Dock = DockStyle.Top;
                        pnSong.Controls.Add(thumbnailMusic);
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            if(pnSong.Controls.Count != 0)
            {

            IWMPPlaylist playlist = this.parent.Media.newPlaylist("Playlist", null);
            foreach (ThumbnailMusic i in pnSong.Controls)
            {
                WMPLib.IWMPMedia m = this.parent.Media.newMedia(i.Path);
                playlist.appendItem(m);
            }
            this.parent.Media.currentPlaylist = playlist;
            this.parent.Media.Ctlcontrols.play();
            }    
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            fRenamePlaylist f = new fRenamePlaylist(this.playList);
            f.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ContextMenuStrip toolStrip = new ContextMenuStrip();
            toolStrip.ItemClicked += menuClick;
            toolStrip.Items.Clear();
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip.Items.Add("Delete Playlist");
            int Y = 400;
            toolStrip.Location = new Point(guna2Button2.Location.X + 70, guna2Button2.Location.Y + Y);
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
                    if (File.Exists(playList.PlayListPath))
                    {
                        // If file found, delete it    
                        File.Delete(playList.PlayListPath);
                        MessageBox.Show("Xóa thành công");
                        this.parent.btPlayList_Click(this.playList.parent, null);
                    }
                }
                catch(Exception)
                {

                }
            }
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
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
                toolStrip.Items.Add(file.Name.Substring(0, file.Name.Length - 4));
            }
            int Y = 400;
            toolStrip.Location = new Point(guna2Button2.Location.X + 70, guna2Button2.Location.Y + Y);
            toolStrip.Show(MousePosition);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;
        }
        private void menuAddToClick(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Add to Playlist :")
            {
                return;
            }
            // click..
            string[] listPathSongPL = System.IO.File.ReadAllLines(playList.PlayListPath);
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
                if(!dup)
                {
                    using (StreamWriter w = File.AppendText(fileName))
                    {
                        w.WriteLine(songPath);
                    }
                }
            }
                        MessageBox.Show("Thên thành công");
        }
    }
}
