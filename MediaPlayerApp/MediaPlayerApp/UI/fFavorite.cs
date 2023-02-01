using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
