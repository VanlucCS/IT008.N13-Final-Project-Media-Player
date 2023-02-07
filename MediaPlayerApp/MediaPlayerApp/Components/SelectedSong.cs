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
        fMusicLibrary fLibrary;
        public SelectedSong()
        {
            InitializeComponent();
        }
        public SelectedSong(fMusicLibrary fLibrary)
        {
            InitializeComponent();
            this.fLibrary = fLibrary;
        }
        private void btnMore_Click(object sender, EventArgs e)
        {
            //thumbnailMenu.MaximumSize = new Size(200, 200);
            //thumbnailMenu.Width = 190;
            //thumbnailMenu.BringToFront();
            //thumbnailMenu.showHide();
            ContextMenuStrip toolStrip = new ContextMenuStrip();
            toolStrip.ItemClicked += moreClick;
            toolStrip.Items.Clear();
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip.Items.Add("Show artist");
            toolStrip.Items.Add("Edit info");
            toolStrip.Items.Add("Properties");
            toolStrip.Items[0].Image = Resources.user;
            toolStrip.Items[1].Image = Resources.pen;
            toolStrip.Items[2].Image = Resources.info;
            int Y = 400;
            toolStrip.Location = new Point(btnMore.Location.X + 70, btnMore.Location.Y + Y);
            toolStrip.Show(MousePosition);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;
        }
        private void moreClick(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Edit info")
            {
                string path = "";
                foreach (KeyValuePair<string, bool> item in fLibrary.SelectedMusic)
                {
                    if (item.Value == true)
                    {
                        path = item.Key;
                    }
                }
                fEditMusic edit = new fEditMusic(path);
                edit.ShowDialog();
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                fLibrary.selectAll();
            }
            else 
                fLibrary.deselectAll();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            fLibrary.playList_Play();
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
            fLibrary.playList_PlayNext();
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
            toolStrip.Items[0].Image = Resources.lounge_music_playlist_96px;
            toolStrip.Items[2].Image = Resources.plus;
            int Y = 400;
            toolStrip.Location = new Point(btnAddTo.Location.X + 70, btnAddTo.Location.Y + Y);
            toolStrip.Show(MousePosition);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;
        }
        private void addToClick(object sender, EventArgs e)
        {

        }
    }
}
