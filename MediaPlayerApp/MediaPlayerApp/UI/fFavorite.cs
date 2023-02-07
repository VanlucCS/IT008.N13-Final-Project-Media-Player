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
    public partial class fFavorite : Form
    {
        public fHome parent;
        public fFavorite(fHome parent = null)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void fFavorite_Load(object sender, EventArgs e)
        {
            loadFavorSong();



            // load genre
            foreach (ThumbnailMusic item in pnSong.Controls)
            {
                bool flag = false;
                foreach (string i in cbGenre.Items)
                {
                    if (item.Genre.ToLower() == i.ToLower())
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    this.cbGenre.Items.Add(item.Genre);
            }

        }
        private void loadFavorSong()
        {
            pnSong.Controls.Clear();
            // load path song fvor fr data 
            string[] listPath = System.IO.File.ReadAllLines(@"./Data/FavoriteSong.txt");
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

        private void moreButton_Click(object sender, EventArgs e)
        {
            ContextMenuStrip toolStrip = new ContextMenuStrip();
            toolStrip.ItemClicked += menuClick;
            toolStrip.Items.Clear();
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip.Items.Add("Delete All");
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("Delete Choosing");
            int Y = 400;
            toolStrip.Location = new Point(moreButton.Location.X + 70, moreButton.Location.Y + Y);
            toolStrip.Show(MousePosition);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;
        }
        private void menuClick(object sender, ToolStripItemClickedEventArgs e)
        {
            // click..
            if (e.ClickedItem.Text == "Delete All")
            {
                File.WriteAllLines(@"./Data/FavoriteSong.txt", new string[0]);
                MessageBox.Show("Xóa thành công");
                this.parent.btFravorSong_Click(this.parent, null);
            }
            if (e.ClickedItem.Text == "Delete Choosing")
            {
                foreach (ThumbnailMusic item in pnSong.Controls)
                {
                    #region Rm if checked 
                    //if(item.Ischecked == true)
                    File.WriteAllLines(@"./Data/FavoriteSong.txt",
                        File.ReadLines(@"./Data/FavoriteSong.txt").Where(l => l != this.parent.currenSong.Path).ToList());
                    #endregion

                    MessageBox.Show("Xóa thành công");
                    this.parent.btFravorSong_Click(this.parent, null);
                }
            }
        }

        private void btnShuffleAndPlay_Click(object sender, EventArgs e)
        {
            this.parent.Media.settings.setMode("shuffle", true);
            IWMPPlaylist playlist = this.parent.Media.newPlaylist("Playlist", null);
            foreach (ThumbnailMusic i in pnSong.Controls)
            {
                WMPLib.IWMPMedia m = this.parent.Media.newMedia(i.Path);
                playlist.appendItem(m);
            }
            this.parent.Media.currentPlaylist = playlist;
            this.parent.Media.Ctlcontrols.play();

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortFvorSong();
        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortFvorSong();
        }

        private void SortFvorSong()
        {
            loadFavorSong();
            #region Sort genre
            if (cbGenre.Text != "All genres")
            {
                ThumbnailMusic[] controlArray2 = new ThumbnailMusic[pnSong.Controls.Count];
                this.pnSong.Controls.CopyTo(controlArray2, 0);
                pnSong.Controls.Clear();
                pnSong.Controls.AddRange(Filter(controlArray2));
            }
            #endregion

            #region sort by 
            if (guna2ComboBox1.SelectedIndex == 1)
            {
                ThumbnailMusic[] controlArray = new ThumbnailMusic[pnSong.Controls.Count];
                this.pnSong.Controls.CopyTo(controlArray, 0);
                Array.Sort(controlArray,(c1, c2) => String.Compare(c1.SongName, c2.SongName));

                pnSong.Controls.Clear();
                pnSong.Controls.AddRange(controlArray);
            }
            if (guna2ComboBox1.SelectedIndex == 2)
            {
                ThumbnailMusic[] controlArray = new ThumbnailMusic[pnSong.Controls.Count];
                this.pnSong.Controls.CopyTo(controlArray, 0);
                Array.Sort(controlArray,(c1, c2) => String.Compare(c1.ArtistName, c2.ArtistName));
                pnSong.Controls.Clear();
                pnSong.Controls.AddRange(controlArray);
            }
            if (guna2ComboBox1.SelectedIndex == 0)
            {
                ThumbnailMusic[] controlArray = new ThumbnailMusic[pnSong.Controls.Count];
                this.pnSong.Controls.CopyTo(controlArray, 0);
                //Array.Sort(controlArray, (c1, c2) => String.Compare(c1.musicSong.DateAdd, c2.musicSong.DateAdd)); // them thuoc tinh public cua musicsong trong thumbnailmusic
                pnSong.Controls.Clear();
                pnSong.Controls.AddRange(controlArray);
            }

            #endregion
        }
        public ThumbnailMusic[] Filter(ThumbnailMusic[] input)
        {
            List<ThumbnailMusic> availableCars = new List<ThumbnailMusic>();

            foreach (ThumbnailMusic c in input)
            {
                if (c.Genre == cbGenre.Text)
                    availableCars.Add(c);
            }
            return availableCars.ToArray();
        }
        public void moreClick()
        {

        }
        public void selectAll()
        {

        }
        public void deselectAll()
        {

        }
        public void playList_Play()
        {

        }
        public void playList_PlayNext()
        {

        }
        public void clear()
        {

        }
        public void selectedChanged()
        {

        }
    }
}
