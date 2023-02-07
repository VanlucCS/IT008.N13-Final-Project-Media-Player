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
        public fVideoLibrary(fHome parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            _isAllVideos = true;
            _isSortByDate = true;
            loadVideo();
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
                                    Thumbnail thumbnail = new Thumbnail(file, this.parent);
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
                                    Thumbnail thumbnail = new Thumbnail(file, this.parent);
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
            //if (Count == SelectedMusic.Count)
            //{
            //    List<string> keys = new List<string>();
            //    Count = 0;
            //    for (int i = 0; i < SelectedMusic.Count; i++)
            //    {
            //        KeyValuePair<string, bool> item = SelectedMusic.ElementAt(i);
            //        string path = item.Key;
            //        SelectedMusic[path] = false;
            //        Count++;

            //        Control[] controlsFound = flowLayoutPanel1.Controls.Find(path, true);
            //        foreach (ThumbnailMusic song in controlsFound)
            //        {
            //            song.Guna2CheckBox1.Checked = false;
            //        }
            //    }
            //    btnShuffleAndPlay.Visible = true;
            //    lblSort.Visible = true;
            //    guna2ComboBox1.Visible = true;
            //    guna2ComboBox2.Visible = true;
            //    lbGenre.Visible = true;
            //    selectedSong.Visible = false;
            //    Count = 0;
            //}
        }
        public void selectAll()
        {
            //List<string> keys = new List<string>();
            //Count = 0;
            //for (int i = 0; i < SelectedMusic.Count; i++)
            //{
            //    KeyValuePair<string, bool> item = SelectedMusic.ElementAt(i);
            //    string path = item.Key;
            //    SelectedMusic[path] = true;
            //    Count++;

            //    Control[] controlsFound = flowLayoutPanel1.Controls.Find(path, true);
            //    foreach (ThumbnailMusic song in controlsFound)
            //    {
            //        song.Guna2CheckBox1.Checked = true;
            //    }
            //}
            //Count = SelectedMusic.Count;
        }
        public void selectedChanged()
        {
            //Count = 0;
            //foreach (var item in SelectedMusic)
            //{
            //    string path = item.Key;
            //    bool isSelected = item.Value;
            //    if (isSelected)
            //    {
            //        Count++;
            //    }
            //}

            //this.Controls.Add(selectedSong);
            //if (Count > 0)
            //{
            //    selectedSong.Visible = true;
            //    selectedSong.BringToFront();
            //    if (Count > 1)
            //    {
            //        selectedSong.BtnMore.Visible = false;
            //    }
            //    else selectedSong.BtnMore.Visible = true;
            //    if (Count == SelectedMusic.Count)
            //    {
            //        selectedSong.Guna2CheckBox1.Checked = true;
            //    }
            //    else selectedSong.Guna2CheckBox1.Checked = false;
            //    if (Count == 0)
            //    {
            //        return;
            //    }
            //    selectedSong.LblSongNumber.Text = Count.ToString();

            //    btnShuffleAndPlay.Visible = false;
            //    lblSort.Visible = false;
            //    guna2ComboBox1.Visible = false;
            //    guna2ComboBox2.Visible = false;
            //    lbGenre.Visible = false;
            //    if (Count == SelectedMusic.Count)
            //    {
            //        isSelectedAll = true;
            //    }
            //    else isSelectedAll = false;

            //}
            //else
            //{
            //    btnShuffleAndPlay.Visible = true;
            //    lblSort.Visible = true;
            //    guna2ComboBox1.Visible = true;
            //    guna2ComboBox2.Visible = true;
            //    lbGenre.Visible = true;
            //    selectedSong.Visible = false;
            //}
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
