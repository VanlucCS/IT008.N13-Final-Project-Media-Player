using MediaPlayerApp.BLL;
using MediaPlayerApp.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MediaPlayerApp.UI
{
    public partial class fVideo : Form
    {
        public Thumbnail currenVideo = new Thumbnail();
        public fHome parent;
        public Thumbnail[] videos;
        private bool playAll = false;
        private int index = 0;
        private bool replay = false;
        private bool shuffle = false;
        public fVideo(fHome parent = null, Thumbnail thumbnail = null)
        {
            this.parent = parent;
            this.currenVideo = thumbnail;
            InitializeComponent();
            this.player.URL = currenVideo.VideoPath;

        }
        public fVideo(fHome parent = null, Thumbnail[] videos = null)
        {
            this.parent = parent;
            this.videos = videos;
            InitializeComponent();
            this.player.URL = videos[0].VideoPath;
            index = 0;
            playAll = true;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            player.Dispose();
            this.Close();
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (playAll)
            {
                int statuschk = e.newState;
                if (statuschk == 8)
                {
                    if (index < videos.Length)
                    {
                        index++;
                        this.BeginInvoke(new Action(() =>
                        {
                            this.player.URL = videos[index].VideoPath;
                        }));
                        //e.newState = 1;

                    }

                }
            }
        }
    }
}

