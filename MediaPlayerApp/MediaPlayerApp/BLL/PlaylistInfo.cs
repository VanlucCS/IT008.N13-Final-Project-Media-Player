using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerApp.BLL
{
    
    internal class PlaylistInfo
    {
        private static PlaylistInfo instance;
        private static Image Image1;
        private static Image Image2;
        private static Image Image3;
        private static Image Image4;

        public static PlaylistInfo Instance
        {
            get { if (instance == null) instance = new PlaylistInfo(); return instance; }
            private set { instance = value; }
        }

    }
}
