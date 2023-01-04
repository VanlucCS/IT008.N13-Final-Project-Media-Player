using MediaPlayerApp.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerApp
{
    public partial class fHome : Form
    {
        public Form activeForm = null;

        public fHome()
        {
            InitializeComponent();
        }
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            // pn_Childform.Controls.Remove(activeForm);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChildren.Controls.Add(childForm);
            pnChildren.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        
        

        private void togMode_CheckedChanged(object sender, EventArgs e)
        {
            if(togMode.Checked)
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

                 //btHome.FillColor = Color.FromArgb(43, 43, 43);
                 //btHome.ForeColor  = Color.White;
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

                //btHome.FillColor = SystemColors.Control;
                //btHome.ForeColor = Color.Black;

            }

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }
        private void btPlay_Click(object sender, EventArgs e)
        {
            btPlay.Checked = !btPlay.Checked;
            if (btPlay.Checked == true)
            {
                btPlay.Image = MediaPlayerApp.Properties.Resources.play_button;

            }
            else
            {
                btPlay.Image = MediaPlayerApp.Properties.Resources.pause;

            }
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
        private void btHome_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btHome.Checked = !btHome.Checked;
            this.openChildForm(new fHomeScreen(this));

        }
        private void btVideoLibrary_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btVideoLibrary.Checked = !btVideoLibrary.Checked;
            this.openChildForm(new fVideoLibrary(this));
        }

        private void btMusicLibrary_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btMusicLibrary.Checked = !btMusicLibrary.Checked;
            this.openChildForm(new fMusicLibrary(this));
        }

        private void btFravorSong_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btFravorSong.Checked = !btFravorSong.Checked;
            this.openChildForm(new fFavorite(this));
        }

        private void btHisListen_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btHisListen.Checked = !btHisListen.Checked;
            this.openChildForm(new fHistory(this));
        }

        private void btPlayqueue_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btPlayqueue.Checked = !btPlayqueue.Checked;
            this.openChildForm(new fPlayQueue(this));
        }

        private void btPlayList_Click(object sender, EventArgs e)
        {
            resetButtonStage();
            btPlayList.Checked = !btPlayList.Checked;
            this.openChildForm(new fPlaylist(this));
        }

        private void tbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            //media.settings.volume = tbVolumn.Value;
            //if (!bt)
            //{
            //    pictureBox5.Image = _20521587_TH03_Music_Online.Properties.Resources.medium_volume;
            //    soundOn = true;
            //}
            if (true)
            {
                if (tbVolume.Value > 50)
                {
                    btVolume.Image = MediaPlayerApp.Properties.Resources.high_volume;
                }
                else
                    btVolume.Image = MediaPlayerApp.Properties.Resources.medium_volume;
                if (tbVolume.Value == 0)
                    btVolume.Image = MediaPlayerApp.Properties.Resources.no_sound__1_;
            }
        }

        private void btVolume_Click(object sender, EventArgs e)
        {
            btVolume.Checked = !btVolume.Checked;
            if (btVolume.Checked)
            {
                //media.settings.volume = 0;
                tbVolume.Value = 0;
            }
            else
            {
                //media.settings.volume = 50;
                tbVolume.Value = 50;
            }
        }
    }
}
