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

namespace MediaPlayerApp.Components
{
    public partial class Playlist : UserControl
    {
        public Playlist(string path)
        {
            InitializeComponent();
        }

        private void Playlist_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlDark;
        }

        private void Playlist_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void btMore_Click(object sender, EventArgs e)
        {
            ContextMenuStrip toolStrip = new ContextMenuStrip();
            toolStrip.ItemClicked += menuClick;
            toolStrip.Items.Clear();
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip.Items.Add("Delete Playlist");
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("Move to Playlist");
            int Y = 400;
            toolStrip.Location = new Point(btMore.Location.X + 70, btMore.Location.Y + Y);
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
                
            }
            if (e.ClickedItem.Text == "Move to Playlist")
            {
                ContextMenuStrip toolStrip = new ContextMenuStrip();
                toolStrip.ItemClicked += menuClick;
                toolStrip.Items.Clear();
                toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                toolStrip.Items.Add("Playlist 1");
                toolStrip.Items.Add("-");
                toolStrip.Items.Add("Playlist 2");
                int Y = 450;
                toolStrip.Location = new Point(btMore.Location.X + 80, btMore.Location.Y + Y);
                toolStrip.Show(MousePosition);
                toolStrip.BringToFront();
                toolStrip.GripStyle = ToolStripGripStyle.Hidden;
                toolStrip.Dock = DockStyle.None;
            }
        }
    }
}
