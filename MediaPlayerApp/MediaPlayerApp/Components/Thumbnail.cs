using Guna.UI2.WinForms;
using MediaPlayerApp.BLL;
using MediaPlayerApp.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MediaPlayerApp.Components
{
    public partial class Thumbnail : UserControl
    {
        private VideoInfo videoInfo;
        private ThumbnailMenu thumbnailMenu = new ThumbnailMenu();
        private string _name;
        private DateTime _date;
        private string _size;
        private string _length;
        private string _path;
        private Image _picture;
        private bool _isChecked;
        fVideoLibrary _fVideoLibrary;
        fHomeScreen _fHomeScreen;
        fFavorite _fFavorite;

        public bool IsChecked
        {
            get { return _isChecked; }
            set { _isChecked = value; }
        }

        public string VideoPath
        {
            get { return _path; }
            set { _path = value; }
        }
        public string VideoName
        {
            get { return _name; }
            set { _name = value; }

        }
        public string VideoSize
        {
            get { return _size; }
            set { _size = value; }
        }
        public DateTime VideoDate
        {
            get { return _date; }
            set { _date = value; }
        }
        public string VideoLength
        {
            get { return _length; }
            set { _length = value; }
        }
        public Image VideoPicture
        {
            get { return _picture; }
            set { _picture = value; }
        }
        public fHome parent;
        public Thumbnail(fHome parent = null)
        {
            this.parent = parent;
            InitializeComponent();
        }
        public Thumbnail()
        {
            InitializeComponent();
            thumbnailMenu.Location = new Point(15, 15);
            pictureSong.Controls.Add(thumbnailMenu);
        }
        public Thumbnail(string path, fHome parent = null)
        {
            InitializeComponent();
            videoInfo = new VideoInfo(path);
            loadThumbnail();
        }
        public Thumbnail(string path, fVideoLibrary parent = null)
        {
            InitializeComponent();
            videoInfo = new VideoInfo(path);
            _fVideoLibrary = parent; 
            loadThumbnail();
        }
        public Thumbnail(string path, fHomeScreen parent = null)
        {
            InitializeComponent();
            videoInfo = new VideoInfo(path);
            _fHomeScreen = parent;
            loadThumbnail();
        }
        public Thumbnail(string path, fFavorite parent = null)
        {
            InitializeComponent();
            videoInfo = new VideoInfo(path);
            _fFavorite = parent;
            loadThumbnail();
        }
        private void loadThumbnail()
        {
            pictureSong.BackgroundImage = videoInfo.picture_Video;
            nameSongLabel.Text = videoInfo.Name;
            VideoPath = videoInfo.Link_Video;
            IsChecked = false;
            VideoDate = videoInfo.Date;
            VideoPicture = videoInfo.picture_Video;
            VideoName = videoInfo.Name;
            VideoLength = videoInfo.Length;
            VideoSize = videoInfo.Size;
            IsChecked = false;
            lblDate.Text = videoInfo.Date.ToString();
        }

        private void thumbnail_MouseEnter(object sender, EventArgs e)
        {
            playButton.Visible = true;
            moreButton.Visible = true;
        }

        private void thumbnail_MouseLeave(object sender, EventArgs e)
        {
            playButton.Visible = false;
            moreButton.Visible = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show()
            if(this._fVideoLibrary != null)
                this._fVideoLibrary.parent.AddToRecent(this.VideoPath);
            if (this._fHomeScreen != null)
                this._fHomeScreen.parent.AddToRecent(this.VideoPath);
            fVideo fvideo = new fVideo(this.parent, this);
            fvideo.ShowDialog();
            // add to recent 
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            //thumbnailMenu.MaximumSize = new Size(200, 200);
            //thumbnailMenu.Width = 190;
            //thumbnailMenu.BringToFront();
            //thumbnailMenu.showHide();
            ContextMenuStrip toolStrip = new ContextMenuStrip();
            toolStrip.ItemClicked += menuClick;
            toolStrip.Items.Clear();
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip.Items.Add("1");
            toolStrip.Items.Add("2");
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("3");
            int Y = 400;
            toolStrip.Location = new Point(moreButton.Location.X + 70, moreButton.Location.Y + Y);
            toolStrip.Show(MousePosition);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;

        }
        private void menuClick(object sender, ToolStripItemClickedEventArgs e)
        {
            // click..
            if (e.ClickedItem.Text == "1")
            {
                MessageBox.Show("1");
            }
        }

        private void cbxChon_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxChon.Checked)
            {
                IsChecked = true;
            }  
            else
            {
                IsChecked = false;
            } 
            if(_fVideoLibrary!= null)
            {
                _fVideoLibrary.selectedChanged();
            } 
            else if (_fHomeScreen !=null)
            {
                _fHomeScreen.selectedChanged();
            }   
            else if (_fFavorite!=null)
            {
                _fFavorite.selectedChanged();
            }    
            
        }
    }
}
