using MediaPlayerApp.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
            Thumbnail thumbnail = new Thumbnail("./BH01.mp3");
            flowLayoutPanel1.Controls.Add(thumbnail);
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
    }
}
