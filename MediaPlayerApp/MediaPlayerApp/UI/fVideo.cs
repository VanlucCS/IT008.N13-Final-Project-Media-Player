using MediaPlayerApp.BLL;
using MediaPlayerApp.Components;
using MediaPlayerApp.Properties;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
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
        private int index = 0;
        private int replay = 0;
        private bool shuffle = false;
        private int X = 0, Y = 0;
        Stack last = new Stack();
        public fVideo(fHome parent = null, Thumbnail thumbnail = null)
        {
            this.parent = parent;
            this.currenVideo = thumbnail;
            InitializeComponent();
            this.player.URL = currenVideo.VideoPath;
            videos = new Thumbnail[] { thumbnail };
            shuffle = false;
            pbxShuffle.Enabled = false;
            pbxNext.Enabled = false;
            pbxBack.Enabled = false;
            pbxNext.Image = Resources.grey_next;
            pbxBack.Image = Resources.grey_back;
        }
        public fVideo(fHome parent = null, Thumbnail[] videos = null)
        {
            this.parent = parent;
            this.videos = videos;
            InitializeComponent();
            this.player.URL = videos[0].VideoPath;
            index = 0;
            pbxBack.Image = Resources.grey_back;
            if (videos.Length < 2)
            {
                pbxBack.Enabled = false;
                pbxNext.Enabled = false;
                pbxNext.Image = Resources.grey_next;
            }
        }


        private void btPlay_Click(object sender, EventArgs e)
        {
            btPlay.Checked = !btPlay.Checked;
            if (btPlay.Checked == true)
            {
                this.player.Ctlcontrols.play();
                btPlay.Image = Resources.video_pause;
            }
            else
            {
                this.player.Ctlcontrols.pause();
                btPlay.Image = Resources.video_play;
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




        private void pbxShuffle_Click(object sender, EventArgs e)
        {
            if (shuffle)
            {
                shuffle = false;
                pbxShuffle.Image = Resources.not_shuffle;
            }
            else
            {
                shuffle = true;
                pbxShuffle.Image = Resources.white_shuffle;
            }
        }

        private void pbxForward_Click(object sender, EventArgs e)
        {
            if (this.player.Ctlcontrols.currentPosition + 30 > player.currentMedia.duration)
                this.player.Ctlcontrols.currentPosition = player.currentMedia.duration;
            else
                this.player.Ctlcontrols.currentPosition += 30;
        }

        private void pbxReplay_Click(object sender, EventArgs e)
        {
            if (replay == 0)
            {
                replay = 1;
                pbxReplay.Image = Resources.video_repeat;
                if (videos.Length==1)
                {
                    player.settings.setMode("loop", true);
                }    
            }
            else if (replay == -1)
            {
                replay = 0;
                pbxReplay.Image = Resources.video_not_repeat;
                player.settings.setMode("loop", false);
            }
            else if (replay == 1)
            {
                replay = -1;
                pbxReplay.Image = Resources.video_repeat_1;
                player.settings.setMode("loop", true);
            }
        }

        private void pbxBackward_Click(object sender, EventArgs e)
        {
            if (this.player.Ctlcontrols.currentPosition - 10 < 0)
                this.player.Ctlcontrols.currentPosition = 0;
            else
                this.player.Ctlcontrols.currentPosition -= 10;
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            if (last.Count != 0)
            {
                index = (int)last.Pop();
                this.player.URL = videos[index].VideoPath;
            }
            if (last.Count == 0)
            {
                pbxBack.Image = Resources.grey_back;
            }
            if (index != videos.Length - 1 || replay != 0)
            {
                pbxNext.Image = Resources.video_next;
            }
        }

        private void pbxNext_Click(object sender, EventArgs e)
        {
            if (shuffle)
            {
                if (index < videos.Length - 1)
                {
                    last.Push(index);
                    Random rnd = new Random();
                    index = rnd.Next(index + 1, videos.Length);
                    this.player.URL = videos[index].VideoPath;

                    pbxBack.Image = Resources.video_back;

                    //e.newState = 1;
                }
                else if (replay == 1)
                {
                    last.Push(index);
                    Random rnd = new Random();
                    index = rnd.Next(videos.Length);

                    this.player.URL = videos[index].VideoPath;

                    pbxBack.Image = Resources.video_back;

                }
            }
            else if (!shuffle)
            {
                if (index < videos.Length - 1)
                {
                    last.Push(index);
                    index++;
                    this.player.URL = videos[index].VideoPath;
                    pbxBack.Image = Resources.video_back;

                    //e.newState = 1;
                }
                else if (replay == 1)
                {
                    last.Push(index);
                    index = 0;
                    this.player.URL = videos[index].VideoPath;
                    pbxBack.Image = Resources.video_back;

                }
            }
            if (index == videos.Length - 1 && replay == 0)
            {
                pbxNext.Image = Resources.grey_next;
            }
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ( videos.Length > 1)
            {
                int statuschk = e.newState;
                if (statuschk == 8)
                {
                    if (replay != -1)
                    {
                        if (shuffle)
                        {
                            if (index < videos.Length - 1)
                            {
                                last.Push(index);
                                Random rnd = new Random();
                                index = rnd.Next(index + 1, videos.Length);
                                this.BeginInvoke(new Action(() =>
                                {
                                    this.player.URL = videos[index].VideoPath;
                                }));
                                pbxBack.Image = Resources.video_back;
                                pbxBack.Enabled = true;
                                //e.newState = 1;
                            }
                            else if (replay == 1)
                            {
                                last.Push(index);
                                Random rnd = new Random();
                                index = rnd.Next(videos.Length);

                                this.BeginInvoke(new Action(() =>
                                {
                                    this.player.URL = videos[index].VideoPath;
                                }));
                                pbxBack.Image = Resources.video_back;
                                pbxBack.Enabled = true;
                            }
                        }
                        else if (!shuffle)
                        {
                            if (index < videos.Length - 1)
                            {
                                last.Push(index);
                                index++;
                                this.BeginInvoke(new Action(() =>
                                {
                                    this.player.URL = videos[index].VideoPath;
                                }));
                                pbxBack.Image = Resources.video_back;
                                pbxBack.Enabled = true;
                                //e.newState = 1;
                            }
                            else if (replay == 1)
                            {
                                last.Push(index);
                                index = 0;
                                this.BeginInvoke(new Action(() =>
                                {
                                    this.player.URL = videos[index].VideoPath;
                                }));
                                pbxBack.Image = Resources.video_back;
                                pbxBack.Enabled = true;
                            }

                        }
                    }
                }
                //if (videos.Length ==1 && replay ==0)
                //{
                //    btPlay.Image = Resources.video_play;
                //}    
                if (index != videos.Length - 1 || replay != 0)
                {
                    pbxNext.Image = Resources.video_next;
                }
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

        private void btExit_Click(object sender, EventArgs e)
        {
            timer1s.Stop();
            player.Dispose();
            this.Close();
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

        private void timer5s_Tick(object sender, EventArgs e)
        {
            pnlBottom.Visible = false;
            pnlHead.Visible = false;
            timer5s.Enabled = false;
        }
    }
}

