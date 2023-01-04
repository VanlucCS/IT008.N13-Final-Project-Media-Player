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
    public partial class fHistory : Form
    {
        public fHome parent; 
        public fHistory(fHome parent = null)
        {
            this.parent = parent;
            InitializeComponent();
        }
    }
}
