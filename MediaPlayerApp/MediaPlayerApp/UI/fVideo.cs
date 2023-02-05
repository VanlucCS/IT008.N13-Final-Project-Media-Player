using MediaPlayerApp.BLL;
using MediaPlayerApp.Components;
using MediaPlayerApp.Properties;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
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
        private int replay = 0;
        private bool shuffle = false;
        private int X =0, Y = 0;
        public fVideo(fHome parent = null, Thumbnail thumbnail = null)
        {
            this.parent = parent;
            this.currenVideo = thumbnail;
            InitializeComponent();
            this.player.URL = currenVideo.VideoPath;
            shuffle = false;
            pbxShuffle.Enabled = false; 

        }
        public fVideo(fHome parent = null, Thumbnail[] videos = null)
        {
            this.parent = parent;
            this.videos = videos;
            InitializeComponent();
            this.player.URL = videos[0].VideoPath;
            index = 0;
            playAll = true;
            
            //this.player
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            timer1s.Stop();
            player.Dispose();
            this.Close();
        }



        private void btPlay_Click(object sender, EventArgs e)
        {
            btPlay.Checked = !btPlay.Checked;
            if (btPlay.Checked == true)
            {
                this.player.Ctlcontrols.play();
                btPlay.Image = Resources.play_96px;
            }
            else
            {
                this.player.Ctlcontrols.pause();
                btPlay.Image = Resources.pause;
            }
        }



        private void tbProcess_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                this.player.Ctlcontrols.currentPosition = (double)tbProcess.Value * this.player.currentMedia.duration / 100.0;
            }
            catch (Exception)
            {
            }
        }

        private void timer1s_Tick(object sender, EventArgs e)
        {
            if (player.currentMedia.duration != 0)
            {
                TimeSpan Time = TimeSpan.FromMinutes(player.Ctlcontrols.currentPosition);
                // update time mediaplayer
                lbTimeCurrentPlay.Text = Time.ToString().Substring(0, 5);
                tbProcess.Value = (int)(100.0 * (player.Ctlcontrols.currentPosition / player.currentMedia.duration));
            }
        }


        private void player_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            if (e.fX != X || e.fY != Y)
            {
                timer5s.Enabled = true;
                pnlBottom.Visible = true;
                pnlHead.Visible = true;
                X = e.fX;
                Y = e.fY;
            }
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (playAll)
            {
                int statuschk = e.newState;
                if (statuschk == 8)
                {
                    if (shuffle)
                    {
                        Random rnd = new Random();
                        index = rnd.Next(index + 1, videos.Length);
                        if (index < videos.Length)
                        {
                            this.BeginInvoke(new Action(() =>
                            {
                                this.player.URL = videos[index].VideoPath;
                            }));
                            return;
                            //e.newState = 1;
                        }
                        else if (replay == 1)
                        {
                            index = rnd.Next( videos.Length);
                            this.BeginInvoke(new Action(() =>
                            {
                                this.player.URL = videos[index].VideoPath;
                            }));
                            return;
                        }
                    }  
                    else if (!shuffle )
                    {
                        if (index < videos.Length -1)
                        {
                            index++;
                            this.BeginInvoke(new Action(() =>
                            {
                                this.player.URL = videos[index].VideoPath;
                            }));
                            return;
                            //e.newState = 1;
                        }
                        else if (replay == 1)
                        {
                            index = 0;
                            this.BeginInvoke(new Action(() =>
                            {
                                this.player.URL = videos[index].VideoPath;
                            }));
                            return;
                        }    
                    }
                }
            }
            if (replay == -1)
            {
                this.BeginInvoke(new Action(() =>
                {
                    this.player.URL = this.player.URL;
                }));
                return;
            }    
        }

        private void pbxShuffle_Click(object sender, EventArgs e)
        {
            shuffle = !shuffle;
        }

        private void pbxForward_Click(object sender, EventArgs e)
        {
            this.player.Ctlcontrols.currentPosition = Math.Min(this.player.Ctlcontrols.currentPosition + 30, player.currentMedia.duration);
        }

        private void pbxReplay_Click(object sender, EventArgs e)
        {
            if (replay == 0)
            {
                replay = 1;
            }
            else if (replay == -1)
            {
                replay = 0;
            }
            else if (replay == 1)
            {
                replay = -1;
            }
        }

        private void pbxBackward_Click(object sender, EventArgs e)
        {
            this.player.Ctlcontrols.currentPosition = Math.Max(this.player.Ctlcontrols.currentPosition - 10,0);
        }

        private void timer5s_Tick(object sender, EventArgs e)
        {
            pnlBottom.Visible = false;
            pnlHead.Visible = false;
            timer5s.Enabled = false;
        }
    }
}

