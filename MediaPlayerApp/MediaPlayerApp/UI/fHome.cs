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
        public fHome()
        {
            InitializeComponent();
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

        private void btHome_Click(object sender, EventArgs e)
        {
            btHome.Checked = !btHome.Checked;
        }
        private void resetButtonStage()
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
    }
}
