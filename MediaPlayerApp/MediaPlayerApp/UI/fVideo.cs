using MediaPlayerApp.Components;
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
    public partial class fVideo : Form
    {
        public Thumbnail currenVideo = new Thumbnail();
        public fHome parent;
        public fVideo(fHome parent = null, Thumbnail thumbnail = null)
        {
            this.parent = parent;
            this.currenVideo = thumbnail;
            InitializeComponent();
            this.player.URL = "D:\\movie\\Interview with the Vampire (1994) [1080p]\\Interview.with.the.Vampire.1994.1080p.BluRay.x264.YIFY.mp4";

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            player.Dispose();
            this.Close();
        }
    }
}
