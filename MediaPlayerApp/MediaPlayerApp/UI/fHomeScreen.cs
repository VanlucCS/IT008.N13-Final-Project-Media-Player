﻿using MediaPlayerApp.Components;
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
            int recentCount = 0;
            string[] listPath = System.IO.File.ReadAllLines(@"./Data/RecentMedia.txt");
            foreach (string path in listPath.Reverse())
            {
                if (recentCount < 10)
                {

                    try
                    {
                        FileInfo info = new FileInfo(path);
                        if (info.Extension == ".mp3")
                        {

                            ThumbnailMusic2 thumbnailMusic = new ThumbnailMusic2(path, this.parent);
                            thumbnailMusic.Dock = DockStyle.Top;
                            pnRecent.Controls.Add(thumbnailMusic);
                            recentCount++;
                        }
                        if (info.Extension == ".mp4")
                        {

                            Thumbnail thumbnail = new Thumbnail(path, this);
                            thumbnail.Dock = DockStyle.Top;
                            pnRecent.Controls.Add(thumbnail);
                            recentCount++;

                        }
                        if (info.Extension == ".txt")
                        {

                            Components.Playlist i = new Components.Playlist(path, this.parent);
                            recentCount++;
                            pnRecent.Controls.Add(i);
                        }

                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
}
