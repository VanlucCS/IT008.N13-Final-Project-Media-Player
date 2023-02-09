using MediaPlayerApp.UI;
using MediaPlayerApp.BLL;
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
using System.IO;

namespace MediaPlayerApp
{
    public partial class fHome : Form
    {
        public Form activeForm = null;
        public Timer t;
        public ThumbnailMusic currenSong = new ThumbnailMusic();
        private bool _isStop = false;
        public bool IsStop
        {
            get { return _isStop; }
            set { _isStop = value; }
        }
        public fHome()
        {
            InitializeComponent();
            
            
        }
        private void fHome_Load(object sender, EventArgs e)
        {
            // default song 
            this.Media.URL = "./BH01.mp3";
            this.Media.Ctlcontrols.stop();

            LoadSongInfo(this.Media.URL);
            t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }
        public void LoadSongInfo(string path)
        {
            MusicSong song = new MusicSong(path);
            pbSongpic.Image = song.PictureSong;
            lbSongName.Text = song.NameSong +"\n"+ song.Singer;
        }
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChildren.Controls.Add(childForm);
            pnChildren.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        #region Dark mode option
        private void togMode_CheckedChanged(object sender, EventArgs e)
        {
            if (togMode.Checked)
            {
                // panel
                pnChildren.BackColor = Color.Black;
                pnHeader.BackColor = Color.Black;
                pnLeft.BackColor = Color.FromArgb(43, 43, 43);
                pnControlMedia.BackColor = Color.FromArgb(17, 25, 29);
                pnControlMedia.ForeColor = Color.White;

                btExit.FillColor = Color.Black;
                btExit.IconColor = Color.White;
                btMinisize.FillColor = Color.Black;
                btMinisize.IconColor = Color.White;
                btMaxsize.FillColor = Color.Black;
                btMaxsize.IconColor = Color.White;
            }
            else
            {
                pnChildren.BackColor = SystemColors.Control;
                pnHeader.BackColor = SystemColors.Control;
                pnLeft.BackColor = SystemColors.Control;
                pnControlMedia.BackColor = Color.FromArgb(192, 255, 192);
                pnControlMedia.ForeColor = Color.Black;

                btExit.FillColor = SystemColors.Control;
                btExit.IconColor = Color.Black;
                btMinisize.FillColor = SystemColors.Control;
                btMinisize.IconColor = Color.Black;
                btMaxsize.FillColor = SystemColors.Control;
                btMaxsize.IconColor = Color.Black;

            }
        } 
        #endregion
        #region form navigation
        private void btHome_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btHome.Checked = !btHome.Checked;
            this.OpenChildForm(new fHomeScreen(this));

        }
        private void btVideoLibrary_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btVideoLibrary.Checked = !btVideoLibrary.Checked;
            this.OpenChildForm(new fVideoLibrary(this));
        }

        private void btMusicLibrary_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btMusicLibrary.Checked = !btMusicLibrary.Checked;
            this.OpenChildForm(new fMusicLibrary(this));
        }

        public void btFravorSong_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btFravorSong.Checked = !btFravorSong.Checked;
            this.OpenChildForm(new fFavorite(this));
        }

        private void btHisListen_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btHisListen.Checked = !btHisListen.Checked;
            this.OpenChildForm(new fHistory(this));
        }

        private void btPlayqueue_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btPlayqueue.Checked = !btPlayqueue.Checked;
            this.OpenChildForm(new fPlayQueue(this));
        }

        public void btPlayList_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btPlayList.Checked = !btPlayList.Checked;
            this.OpenChildForm(new fPlaylist(this));
        } 
        #endregion

        private void btPlay_Click(object sender, EventArgs e)
        {
            btPlay.Checked = !btPlay.Checked;
            if (btPlay.Checked == true)
                this.Media.Ctlcontrols.play();
            else
                this.Media.Ctlcontrols.pause();
        }
        private void resetButtonStage()
        {
            btHome.Checked = false;
            btVideoLibrary.Checked = false;
            btMusicLibrary.Checked = false;
            btFravorSong.Checked = false;
            btHisListen.Checked = false;
            btPlayqueue.Checked = false;
            btPlayList.Checked = false;
        }
        private void tbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            Media.settings.volume = tbVolume.Value;
                if (tbVolume.Value > 50)
                {
                    btVolume.Image = MediaPlayerApp.Properties.Resources.high_volume;
                }
                else
                    btVolume.Image = MediaPlayerApp.Properties.Resources.medium_volume;
                if (tbVolume.Value == 0)
                    btVolume.Image = MediaPlayerApp.Properties.Resources.no_sound__1_;
        }
        private void btVolume_Click_1(object sender, EventArgs e)
        {
            if (btVolume.Checked)
            {
                this.Media.settings.volume = 0;
                btVolume.Image = MediaPlayerApp.Properties.Resources.no_sound__1_;
                tbVolume.Value = 0;
            }
            else
            {
                this.Media.settings.volume = 50;
                btVolume.Image = MediaPlayerApp.Properties.Resources.medium_volume;
                tbVolume.Value = 50;
            }
            btVolume.Checked = !btVolume.Checked;
        }

        private void tbProcess_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                this.Media.Ctlcontrols.currentPosition = (double)tbProcess.Value * this.Media.currentMedia.duration / 101.0;
            }
            catch (Exception)
            {
            }
        }

        private void Media_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(this.Media.playState == WMPLib.WMPPlayState.wmppsStopped || this.Media.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                btPlay.Checked = false;
            }
            else if(this.Media.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                btPlay.Checked = true;
            }
            #region Check favor song
            string[] listFvorPath = System.IO.File.ReadAllLines(@"./Data/FavoriteSong.txt");
            foreach (string fvorSongPath in listFvorPath)
            {
                if (this.currenSong.Path == fvorSongPath)
                {
                    btFavorite.Image = MediaPlayerApp.Properties.Resources.lover;
                    btFavorite.Checked = true;
                    return;
                }

            }
                btFavorite.Image = MediaPlayerApp.Properties.Resources.heart_96px;
                    btFavorite.Checked = false;
            #endregion
            #region Check for playnext

            if (this.Media.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                IsStop = true;
            }
            else IsStop = false;

            #endregion
            #region Auto load preview
            string path = "";
            if (!(Media.currentMedia is null))
            {
                path = Media.currentMedia.sourceURL;
                MusicSong musicSong = new MusicSong(path);
                pbSongpic.Image = musicSong.PictureSong;
                lbSongName.Text = musicSong.NameSong + "\n" + musicSong.Singer;
                currenSong = new ThumbnailMusic(path, this, null);
            }
            #endregion
            //LoadSongInfo(this.Media.currentMedia.sourceURL);


        }

        private void btPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (btPlay.Checked == true)
                btPlay.Image = MediaPlayerApp.Properties.Resources.pause;
            else
                btPlay.Image = MediaPlayerApp.Properties.Resources.play_button;

        }
        void t_Tick(object sender, EventArgs e)
        {
            if(Media.currentMedia.duration!= 0)
            {   
                TimeSpan Time = TimeSpan.FromMinutes(Media.Ctlcontrols.currentPosition);
                // update time mediaplayer
                lbTimeCurrentPlay.Text = Time.ToString().Substring(0, 5);
                tbProcess.Value =  (int)(100.0 * (Media.Ctlcontrols.currentPosition / Media.currentMedia.duration));
            }    
        }

        private void btFavorite_Click(object sender, EventArgs e)
        {
            if (this.currenSong == null)
                return;

            btFavorite.Checked = !btFavorite.Checked;
            if (btFavorite.Checked == true)
            {

                btFavorite.Image = MediaPlayerApp.Properties.Resources.lover;
                // add fvor song
                using (StreamWriter w = File.AppendText(@"./Data/FavoriteSong.txt"))
                {
                    w.WriteLine(this.currenSong.Path);
                }
            }
            else
            {
                btFavorite.Image = MediaPlayerApp.Properties.Resources.heart_96px;
                // remove fvor song
                File.WriteAllLines(@"./Data/FavoriteSong.txt",
                    File.ReadLines(@"./Data/FavoriteSong.txt").Where(l => l != this.currenSong.Path).ToList());

            }
        }

        private void Media_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            LoadSongInfo(this.Media.currentMedia.sourceURL);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pbRepeatSong_Click(object sender, EventArgs e)
        {
            if (cbtloop.Visible == false)
            {

                Media.settings.setMode("loop", true);
                cbtloop.Visible = true;
            }
            else
            {
                Media.settings.setMode("loop", false);
                cbtloop.Visible = false;
            }
        }

        private void pbShuffer_Click(object sender, EventArgs e)
        {
            if (cbtshuffer.Visible == false)
            {

                Media.settings.setMode("shuffle", true);
                cbtshuffer.Visible = true;
            }
            else
            {
                Media.settings.setMode("shuffle", false);
                cbtshuffer.Visible = false;
            }
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            Media.Ctlcontrols.next();
        }

        private void pbPrev_Click(object sender, EventArgs e)
        {
            Media.Ctlcontrols.previous();
        }
    }
}
