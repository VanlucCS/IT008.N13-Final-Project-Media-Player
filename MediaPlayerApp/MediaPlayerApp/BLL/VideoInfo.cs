using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using Accord.Video.FFMPEG;
using WMPLib;
using MediaPlayerApp.Properties;

namespace MediaPlayerApp.BLL
{
    class VideoInfo
    {
        public string Name;
        public string Date;
        public string Size;
        public string Length;
        public string link_Video;
        public Image picture_Video;
        private static VideoInfo instance;

        public static VideoInfo Instance
        {
            get { if (instance == null) instance = new VideoInfo();
                return instance; }
            private set { instance = value; }
        }

        public string Duration(String file)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayerClass();
            IWMPMedia mediainfo = wmp.newMedia(file);
            int maxTime = Convert.ToInt32(mediainfo.duration);

            return string.Format("{0:00}:{1:00}:{2:00}", maxTime / 3600, (maxTime / 60) % 60, maxTime % 60);
        }
        private string date_Add;
        public string Date_Add
        {
            get { return date_Add; }
            set { date_Add = value; }
        }



        public VideoInfo() { }
        public VideoInfo(string path)
        {
                FileInfo info = new FileInfo(path);
            // check mp4
            //if (info.Extension != ".mp4")
            if (info.Exists)
            {
                this.Name = info.Name.ToString();
                this.Date = info.CreationTime.ToString();
                this.Length = Duration(path);
                this.Link_Video = path;
                this.picture_Video = GetThumbnail(path);
                //this.picture_Video = Resources.lounge_music_playlist_96px;
            }
        }

        private Bitmap GetThumbnail(string fpath)
        {
            VideoFileReader reader = new VideoFileReader();
            // open video file mp4
            reader.Open(fpath);
            return reader.ReadVideoFrame(); ;
        }
        public string Link_Video
        {
            get { return link_Video; }
            set { link_Video = value; }
        }
    }
}
