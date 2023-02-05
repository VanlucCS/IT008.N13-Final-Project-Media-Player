using Guna.UI2.WinForms;
using MediaPlayerApp.BLL;
using MediaPlayerApp.Properties;
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
            loadThumbnail();
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
            //thumbnailMenu.MaximumSize = new Size(200, 200);
            //thumbnailMenu.Width = 190;
            //thumbnailMenu.BringToFront();
            //thumbnailMenu.showHide();
            ContextMenuStrip toolStrip = new ContextMenuStrip();
            toolStrip.ItemClicked += menuClick;
            toolStrip.Items.Clear();
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip.Items.Add("Play");
            toolStrip.Items.Add("Play next");
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("Add to");
            toolStrip.Items.Add("Remove");
            toolStrip.Items.Add("Properties");
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("Select");
            toolStrip.Items[0].Image = Resources.play_96px;
            toolStrip.Items[1].Image = Resources.playnext;
            toolStrip.Items[3].Image = Resources.plus;
            toolStrip.Items[4].Image = Resources.delete;
            toolStrip.Items[5].Image = Resources.info;
            toolStrip.Items[7].Image = Resources.check;
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
