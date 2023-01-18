using MediaPlayerApp.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerApp.Components
{
    public partial class ThumbnailMenu : UserControl
    {
        private MusicSong musicSong;
        private bool isExpand;
        public ThumbnailMenu()
        {
            InitializeComponent();
            this.Height = 0;
            isExpand = false;  
            this.Width = 120;
        }
        public ThumbnailMenu(string path)
        {
            InitializeComponent();
            musicSong= new MusicSong(path);
            this.Height = 0;
            isExpand= false;
        }
        public void showHide()
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isExpand == false)
            {
                this.Height += 10;
                if (this.Height >= this.MaximumSize.Height)
                {
                    timer1.Stop();
                    this.Height = this.MaximumSize.Height;
                    isExpand= true;
                }
            }
            else if (isExpand == true)
            {
                this.Height-= 10;
                if (this.Height <= 0)
                {
                    this.Height = 0;
                    timer1.Stop();
                    isExpand= false;
                }
            }
        }
    }
}
