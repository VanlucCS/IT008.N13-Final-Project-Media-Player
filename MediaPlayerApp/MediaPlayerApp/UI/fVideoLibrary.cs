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

        private void lblSort_Leave(object sender, EventArgs e)
        {
            lblSort.BorderStyle = BorderStyle.None;
        }

        private void btnAddFolder_MouseEnter(object sender, EventArgs e)
        {
            btnAddFolder.BackColor = SystemColors.ControlLight;
        }

        private void btnAddFolder_MouseLeave(object sender, EventArgs e)
        {
            btnAddFolder.BackColor = SystemColors.Control;
        }
    }
}
