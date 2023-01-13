using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerApp.BLL
{
    class MusicSong
    {
        private static MusicSong instance;

        public static MusicSong Instance
        {
            get { if (instance == null) instance = new MusicSong(); return instance; }
            private set { instance = value; }
        }

        private string _nameSong;
        public string Name_Song
        {
            get { return _nameSong; }
            set { _nameSong = value; }
        }
        private string _singer;
        public string Singer
        {
            get { return _singer; }
            set { _singer = value; }
        }
        private string _linkMusic;
        public string LinkMusic
        {
            get { return _linkMusic; }
            set { _linkMusic = value; }
        }
        private Image _pictureSong;
        public Image PictureSong
        {
            get { return _pictureSong; }
            set { _pictureSong = value; }
        }
        private string _dateAdd;
        public string DateAdd
        {
            get { return _dateAdd; }
            set { _dateAdd = value; }
        }
        private string _length;
        public string Length
        {
            get { return _length; }
            set { _length = value; }
        }
        private string _nameGenre;
        public string NameGenre
        {
            get { return _nameGenre; }
            set { _nameGenre = value; }
        }

        //public MusicSong() { }

        public MusicSong(string Name, string Singer, string LinkSong, Image Picture, string DateAdd, string length, string nameGenre)
        {
            this.Length = length;
            this.Picture_Song = Picture;
            this.NameSong = Name;
            this.Singer = Singer;
            this.LinkMusic = LinkSong;
            this.DateAdd = DateAdd;
            this.NameGenre = nameGenre;
        }

        public MusicSong(string path)
        {
            FileInfo info = new FileInfo(path);
            if (info.Extension == ".mp3")
            {
                var fileTag = TagLib.File.Create(info.FullName);
                this.Name_Song = fileTag.Tag.Title;
                this.Singer = fileTag.Tag.FirstPerformer;
                this.NameGenre = fileTag.Tag.FirstGenre;
                this.DateAdd = info.CreationTime.ToString();
                this.Length = fileTag.Properties.Duration.ToString(@"hh\:mm\:ss");
                this.LinkMusic = info.FullName;
                if (this.Name_Genre == null) this.Name_Genre = "Unknown";
                if (this.Singer == null) this.Singer = "Unknown";
                Image temp = null;
                if (fileTag.Tag.Pictures.Length >= 1)
                {
                    var bin = (byte[])(fileTag.Tag.Pictures[0].Data.Data);
                    temp = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);
                }
                else
                {
                    temp = new Bitmap(Properties.Resources.songImg);
                }
                this.PictureSong = temp;
            }
        }
    }
}
}
