using MediaPlayerApp.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerApp.UI
{
    public partial class fHomeScreen : Form
    {
        public fHome parent;
        public fHomeScreen(fHome parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            testThumbnail();
        }

        public void testThumbnail()
        {
            Thumbnail thumbnail = new Thumbnail("./BH01.mp3",this);
            pnRecent.Controls.Add(thumbnail);
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

        private void fHomeScreen_Load(object sender, EventArgs e)
        {
            string[] listPath = System.IO.File.ReadAllLines(@"./Data/RecentMedia.txt");
            foreach (string songPath in listPath)
            {
                try
                {
                    FileInfo info = new FileInfo(songPath);
                    if (info.Extension == ".mp3")
                    {

                        ThumbnailMusic2 thumbnailMusic = new ThumbnailMusic2(songPath, this.parent);
                        thumbnailMusic.Dock = DockStyle.Top;
                        pnRecent.Controls.Add(thumbnailMusic);
                    }
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
