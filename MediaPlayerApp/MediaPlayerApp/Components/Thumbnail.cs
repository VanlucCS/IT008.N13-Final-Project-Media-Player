using Guna.UI2.WinForms;
using MediaPlayerApp.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerApp.Components
{
    public partial class Thumbnail : UserControl
    {
        private MusicSong musicSong;
        private ThumbnailMenu thumbnailMenu = new ThumbnailMenu();
        public Thumbnail()
        {
            InitializeComponent();
            thumbnailMenu.Location = new Point(15, 15);
            pictureSong.Controls.Add(thumbnailMenu);
        }
        public Thumbnail(string path)
        {
            InitializeComponent();
            musicSong = new MusicSong(path);     
        }
        private void loadThumbnail()
        {
            pictureSong.BackgroundImage = musicSong.PictureSong;
            nameSongLabel.Text = musicSong.NameSong;
        }

        private void thumbnail_MouseEnter(object sender, EventArgs e)
        {
            playButton.Visible = true;
            moreButton.Visible = true;
        }

        private void thumbnail_MouseLeave(object sender, EventArgs e)
        {
            playButton.Visible = false;
            moreButton.Visible = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {

        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            thumbnailMenu.MaximumSize = new Size(200, 200);
            thumbnailMenu.Width = 190;
            thumbnailMenu.BringToFront();
            thumbnailMenu.showHide();
        }

        private void nameSongLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
