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
    public partial class Playlist : UserControl
    {
        public Playlist(string path)
        {
            InitializeComponent();
        }

        private void Playlist_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlDark;
        }

        private void Playlist_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }
    }
}
