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
    public partial class fMusicLibrary : Form
    {
        public fHome parent;

        public fMusicLibrary(fHome parent = null)
        {
            this.parent = parent;

            InitializeComponent();
            loadMusic();
        }

        private void lblSongs_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblSongs.Left + (lblSongs.Width - pbxUnderline.Width) / 2;
        }

        private void lblAlbums_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblAlbums.Left + (lblAlbums.Width - pbxUnderline.Width) / 2;
        }

        private void lblArtists_Click(object sender, EventArgs e)
        {
            pbxUnderline.Left = lblArtists.Left + (lblArtists.Width - pbxUnderline.Width) / 2;
        }
        private void loadMusic()
        {
            // get list music string[] path infolder added
            string[] listPath;
            try
            {
                string[] folderadded = System.IO.File.ReadAllLines(@"./Data/Music.txt");
                foreach (string folder in folderadded)
                {
                    foreach (string file in Directory.GetFiles(folder))
                    {
                        FileInfo info = new FileInfo(file);
                        if (info.Extension == ".mp3")
                        {
                            
                            ThumbnailMusic thumbnailMusic = new ThumbnailMusic(file,this.parent);
                            thumbnailMusic.Dock = DockStyle.Top;
                            flowLayoutPanel1.Controls.Add(thumbnailMusic);
                        }
                        //MessageBox.Show(file);

                    }
                    
                }
            }
            catch (Exception)
            {
                return;
            }


            
        }
        private void lbGenre_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.RootFolder = Environment.SpecialFolder.MyComputer;
            if (f.ShowDialog() == DialogResult.OK)
            {
                // check exits
                if (Directory.Exists(f.SelectedPath))
                {
                    string[] folderadded = System.IO.File.ReadAllLines(@"./Data/Music.txt");
                    foreach (string folder in folderadded)
                    {
                        if (f.SelectedPath == folder)
                        {
                            return;
                        }
                    }
                    using (StreamWriter w = File.AppendText(@"./Data/Music.txt"))
                    {
                        w.WriteLine(f.SelectedPath);
                    }
                }
                else
                    return;
                
            }
        }

        private void fMusicLibrary_Load(object sender, EventArgs e)
        {

        }
    }
}
