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
    public partial class fPlaylistInfo : Form
    {
        public fHome parent;
        public Playlist playList;
        public fPlaylistInfo(Playlist pl, fHome parent = null)
        {
            this.parent = parent;
            this.playList = pl;
            InitializeComponent();

        }
    }
}
