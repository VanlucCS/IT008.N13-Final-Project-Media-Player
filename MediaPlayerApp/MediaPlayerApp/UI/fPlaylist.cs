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
    public partial class fPlaylist : Form
    {
        public fHome parent;
        public fPlaylist(fHome parent = null)
        {
            this.parent = parent;
            InitializeComponent();
        }
    }
}
