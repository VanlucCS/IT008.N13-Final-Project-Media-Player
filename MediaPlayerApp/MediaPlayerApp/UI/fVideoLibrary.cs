using Guna.UI2.WinForms;
using MediaPlayerApp.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediaPlayerApp.UI
{
    public partial class fVideoLibrary : Form
    {
        public fHome parent;
        private bool _isAllVideos;
        private bool _isSortByDate;
        
        SelectedSong selectedSong;
        public fVideoLibrary(fHome parent = null)
        {
            this.parent = parent;
            selectedSong = new SelectedSong(this);
            InitializeComponent();
            selectedSong.Location = new Point(5, 45);
            selectedSong.Visible = false;
            _isAllVideos = true;
            _isSortByDate = true;
            loadVideo();
        }
        private int _count = 0;
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        private void lblAllVideos_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblAllVideos.Left + (lblAllVideos.Width - pbxUnderline.Width) / 2;
            _isAllVideos = true;
            loadVideo();
        }

        private void lblVideoFolders_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblVideoFolders.Left + (lblVideoFolders.Width - pbxUnderline.Width) / 2;
            _isAllVideos = false;
            loadVideo();
        }

        private void btnPlayAll_Click(object sender, EventArgs e)
        {
            Thumbnail[] thumbnails = flowLayoutPanel1.Controls.OfType<Thumbnail>().ToArray();
            fVideo fvideo = new fVideo(null, thumbnails);
            fvideo.ShowDialog();
        }
        private void loadVideo()
        {
            flowLayoutPanel1.Controls.Clear();
            // get list music string[] path infolder added
            string[] listPath;
            
            try
            {
                string[] folderadded = System.IO.File.ReadAllLines(@"./Data/Video.txt");
                if (_isAllVideos )
                {
                    List<Thumbnail> thumbnailsList = new List<Thumbnail>();
                    foreach (string folder in folderadded)
                    {
                        if (Directory.Exists(folder))
                        {
                            foreach (string file in Directory.GetFiles(folder))
                            {
                                FileInfo info = new FileInfo(file);
                                if (info.Extension == ".mp4" || info.Extension == ".mkv")
                                {
                                    //List<> employees = new List<Employee>()
                                    Thumbnail thumbnail = new Thumbnail(file, this);
                                    thumbnail.Dock = DockStyle.Top;
                                    thumbnailsList.Add(thumbnail);

                                    //ThumbnailMusic thumbnailMusi = new ThumbnailMusic(file, this.parent);

                                    //flowLayoutPanel1.Controls.Add(thumbnail);
                                }
                                //MessageBox.Show(file);

                            }
                        }
                    }
                    if (_isSortByDate)
                    {
                        thumbnailsList.Sort(delegate (Thumbnail x, Thumbnail y) {
                            return x.VideoDate.CompareTo(y.VideoDate);
                        });
                        for (int i = thumbnailsList.Count - 1; i >= 0; i--)
                        {
                            flowLayoutPanel1.Controls.Add(thumbnailsList[i]);
                        }
                    } 
                    else
                    {
                        thumbnailsList.Sort(delegate (Thumbnail x, Thumbnail y) {
                            return x.VideoName.CompareTo(y.VideoName);
                        });
                        for (int i = 0; i < thumbnailsList.Count; i++)
                        {
                            flowLayoutPanel1.Controls.Add(thumbnailsList[i]);
                        }
                    }    
                }
                else
                {
                    foreach (string folder in folderadded)
                    {
                        if (Directory.Exists(folder))
                        {
                            bool isEmpty = true;
                            List<Thumbnail> thumbnailsList = new List<Thumbnail>();
                            foreach (string file in Directory.GetFiles(folder))
                            {

                                
                                FileInfo info = new FileInfo(file);
                                if (info.Extension == ".mp4" || info.Extension == ".mkv")
                                {
                                    isEmpty = false;
                                    //List<> employees = new List<Employee>()
                                    Thumbnail thumbnail = new Thumbnail(file, this);
                                    thumbnail.Dock = DockStyle.Top;
                                    thumbnailsList.Add(thumbnail);
                                    //ThumbnailMusic thumbnailMusi = new ThumbnailMusic(file, this.parent);

                                    //flowLayoutPanel1.Controls.Add(thumbnail);
                                }
                                
                                //MessageBox.Show(file);
                                
                            }
                            if (!isEmpty)
                            {
                                Label label = new Label();
                                label.Text = folder;

                                label.Font = lblVideoFolders.Font;
                                label.Width = flowLayoutPanel1.Width;
                                flowLayoutPanel1.Controls.Add(label);
                                if (_isSortByDate)
                                {
                                    thumbnailsList.Sort(delegate (Thumbnail x, Thumbnail y) {
                                        return x.VideoDate.CompareTo(y.VideoDate);
                                    });
                                    for (int i = thumbnailsList.Count - 1; i >= 0; i--)
                                    {
                                        flowLayoutPanel1.Controls.Add(thumbnailsList[i]);
                                    }
                                }
                                else
                                {
                                    thumbnailsList.Sort(delegate (Thumbnail x, Thumbnail y) {
                                        return x.VideoName.CompareTo(y.VideoName);
                                    });
                                    for (int i = 0; i < thumbnailsList.Count; i++)
                                    {
                                        flowLayoutPanel1.Controls.Add(thumbnailsList[i]);
                                    }
                                }
                            }

                        }
                    }
                    
                }    
                
            }
            catch (Exception)
            {
            }



        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (Directory.Exists(fbd.SelectedPath))
                    {
                        string[] folderadded = System.IO.File.ReadAllLines(@"./Data/Video.txt");
                        foreach (string folder in folderadded)
                        {
                            if (fbd.SelectedPath == folder)
                            {
                                return;
                            }
                        }
                        using (StreamWriter w = File.AppendText(@"./Data/Video.txt"))
                        {
                            w.WriteLine(fbd.SelectedPath);
                        }
                    }
                    else
                        return;
                }
            }
            loadVideo();


        }
        public void deselectAll()
        {
            if (Count == flowLayoutPanel1.Controls.OfType<Thumbnail>().ToArray().Length)
            {
                foreach (Thumbnail video in flowLayoutPanel1.Controls.OfType<Thumbnail>())
                {
                    video.cbxChon.Checked = false;
                }    
            }

        }
        public void selectAll()
        {
            foreach (Thumbnail video in flowLayoutPanel1.Controls.OfType<Thumbnail>())
            {
                if (video.cbxChon.Checked == false)
                {
                    video.cbxChon.Checked = true;
                }    
                
            }


        }
        public void selectedChanged()
        {

            // Chưa xong
            Count = 0;
            foreach (Thumbnail video in flowLayoutPanel1.Controls.OfType<Thumbnail>())
            {
                if (video.cbxChon.Checked == true)
                    Count++;
            }    
            
            
            this.Controls.Add(selectedSong);
            if (Count > 0)
            {
                selectedSong.Visible = true;
                selectedSong.BringToFront();
                if (Count > 1)
                {
                    selectedSong.BtnMore.Visible = false;
                }
                else selectedSong.BtnMore.Visible = true;
                if (Count == flowLayoutPanel1.Controls.OfType<Thumbnail>().ToArray().Length)
                {
                    selectedSong.Guna2CheckBox1.Checked = true;
                }
                else selectedSong.Guna2CheckBox1.Checked = false;
                //if (Count == 0)
                //{
                //    selectedSong.Visible = false;
                //    return;
                //}
                if (Count == 1)
                {
                    selectedSong.LblSongNumber.Text = Count.ToString() + " video selected";
                }
                else
                {
                    selectedSong.LblSongNumber.Text = Count.ToString() + " videos selected";
                }


                btnPlayAll.Visible = false;
                lblSort.Visible = false;
                cbxSort.Visible = false;
              

            }
            else
            {
                btnPlayAll.Visible = true;
                lblSort.Visible = true;
                cbxSort.Visible = true;
                selectedSong.Visible = false;
            }
        }
        public void moreClick()
        {

        }
        
        public void playList_Play()
        {

        }
        public void playList_PlayNext()
        {

        }
        public void clear()
        {

        }
        private void cbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxSort.SelectedIndex == 0)
            {
                _isSortByDate = true;
            }
            else
            {
                _isSortByDate = false;
            }
            loadVideo();
                
        }
        
        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            Thumbnail[] thumbnails = flowLayoutPanel1.Controls.OfType<Thumbnail>().ToArray();
            Label[] labels = flowLayoutPanel1.Controls.OfType<Label>().ToArray();
            foreach(Label label in labels)
            {
                label.Width = flowLayoutPanel1.Width;
            }    
        }
    }
}
