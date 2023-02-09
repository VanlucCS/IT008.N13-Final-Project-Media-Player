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

namespace MediaPlayerApp.UI
{
    public partial class fPlayQueue : Form
    {
        public fHome parent;
        public fPlayQueue(fHome parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            load();
        }
        public void load()
        {
            if (Constants.currentScreen == " " || Constants.currentScreen == "play queue")
            {
                foreach (string path in Constants.playQueue)
                {
                    ThumbnailMusic thumbnail = new ThumbnailMusic(path, this.parent, null);
                    flowLayoutPanel1.Controls.Add(thumbnail);
                }
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Constants.playQueue.Clear();
            Constants.currentIndex = 0;
            flowLayoutPanel1.Controls.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Playlist
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
            toolStrip.Location = new Point(btnAdd.Location.X + 70, btnAdd.Location.Y + Y);
            toolStrip.Show(MousePosition);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;
                return;
            #endregion


        }
        private void addToPlaylist(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                List<string> listAdd = new List<string> { };

                string playListPath = @"./Data/Playlists/" + e.ClickedItem.Text + ".txt";

                foreach (ThumbnailMusic item in flowLayoutPanel1.Controls)
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
