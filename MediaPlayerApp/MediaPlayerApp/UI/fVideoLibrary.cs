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

namespace MediaPlayerApp.UI
{
    public partial class fVideoLibrary : Form
    {
        public fHome parent;
        public fVideoLibrary(fHome parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            loadVideo();
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
                foreach (string folder in folderadded)
                {
                    if (Directory.Exists(folder))
                    {
                        foreach (string file in Directory.GetFiles(folder))
                        {
                            FileInfo info = new FileInfo(file);
                            if (info.Extension == ".mp4")
                            {
                                Thumbnail thumbnail = new Thumbnail(file, this.parent);
                                thumbnail.Dock = DockStyle.Top;
                                //ThumbnailMusic thumbnailMusi = new ThumbnailMusic(file, this.parent);

                                flowLayoutPanel1.Controls.Add(thumbnail);
                            }
                            //MessageBox.Show(file);

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
    }
}
