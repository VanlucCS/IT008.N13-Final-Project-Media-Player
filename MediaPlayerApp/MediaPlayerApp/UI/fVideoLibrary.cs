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
    public partial class fVideoLibrary : Form
    {
        public fHome parent; 
        public fVideoLibrary(fHome parent = null)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void lblSort_MouseEnter(object sender, EventArgs e)
        {
            lblSort.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblSort_MouseLeave(object sender, EventArgs e)
        {
            lblSort.BorderStyle = BorderStyle.None;
        }

        private void lblAllVideos_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblAllVideos.Left + (lblAllVideos.Width - pbxUnderline.Width) / 2;
        }

        private void lblVideoFolders_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblVideoFolders.Left + (lblVideoFolders.Width - pbxUnderline.Width) / 2;
        }

        private void btnPlayAll_Click(object sender, EventArgs e)
        {

        }
    }
}
