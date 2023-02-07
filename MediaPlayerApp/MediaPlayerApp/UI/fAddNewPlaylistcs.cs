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
    public partial class fAddNewPlaylistcs : Form
    {
        private int dupcal = 0;
        public fAddNewPlaylistcs()
        {
            InitializeComponent();
        }

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            string playListName = tbPlaylistName.Text;
            //Check playlist dupllicate
            bool dup = false;

            do
            {
                dup = false;
                DirectoryInfo d = new DirectoryInfo(@"./Data/Playlists"); 
                FileInfo[] Files = d.GetFiles();
                foreach (FileInfo file in Files)
                {
                    if(dupcal == 0)
                    {
                        if (file.Name.Substring(0, file.Name.Length - 4) == playListName)
                        {
                            dup = true;
                            dupcal++;
                        }
                    }
                    else
                    {
                        if (file.Name.Substring(0, file.Name.Length - 4) == playListName+dupcal.ToString())
                        {
                            dup = true;
                            dupcal++;
                        }
                    }
                }
                if(!dup)
                {
                    if(dupcal != 0)
                        playListName = playListName + dupcal.ToString();
                }    

            } while (dup);

            if (tbPlaylistName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên playlist mới");
                return;
            }    
            string fileName = @"./Data/Playlists/"+ playListName + ".txt";

            try
            {
                // Create a new playlist file     
                using (FileStream fs = File.Create(fileName))
                {
                }
            }
            catch (Exception Ex)
            {
                return;
            }
            MessageBox.Show("Tạo playlist thành công");
            this.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
