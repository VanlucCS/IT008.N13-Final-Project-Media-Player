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
                foreach (string i in cbGenre.Items)
                {
                    if( item.Genre.ToLower() == i.ToLower())
                        continue;
                }
                this.cbGenre.Items.Add(item.Genre);
            }

        }
        private void loadFavorSong()
        {
            // load path song fvor fr data 
            string[] listPath = System.IO.File.ReadAllLines(@"./Data/FavoriteSong.txt");
            foreach (string songPath in listPath)
            {
                FileInfo info = new FileInfo(songPath);
                if (info.Extension == ".mp3")
                {

                    ThumbnailMusic thumbnailMusic = new ThumbnailMusic(songPath, this.parent);
                    thumbnailMusic.Dock = DockStyle.Top;
                    pnSong.Controls.Add(thumbnailMusic);
                }
            }     
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            ContextMenuStrip toolStrip = new ContextMenuStrip();
            toolStrip.ItemClicked += menuClick;
            toolStrip.Items.Clear();
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip.Items.Add("Delete all");
            toolStrip.Items.Add("2");
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("3");
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
            if (e.ClickedItem.Text == "1")
            {
                MessageBox.Show("1");
            }
        }

        
    }
}
