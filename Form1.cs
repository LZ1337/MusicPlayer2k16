using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace Music_Player_2k16_Independed
{
    public partial class MainForm : Form
    {
        // This part made it possible to move the window without the standard layout.
        public const int WM_NCLBUTTON = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Player MusicPlayer = new Player();
        PlaylistManagement pm = new PlaylistManagement();

        public MainForm()
        {
            InitializeComponent();
            MusicPlayer.setVolume(trackBarVol.Value);
        }

        private bool shuffleMode = false;
        private bool isPlaying = false;

        private void play()
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTON, HT_CAPTION, 0);
            }
        }

        private void panelResize_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.SizeNWSE;
        }

        private void panelResize_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) {
                this.Width = Control.MousePosition.X - this.Location.X;
                this.Height = Control.MousePosition.Y - this.Location.Y;
            }
        }

        private void lblTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTON, HT_CAPTION, 0);
            }
        }

        private void panelResize_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddTrack_Click(object sender, EventArgs e)
        {
            if(openFileDialogTracks.ShowDialog() == DialogResult.OK)
            {
                List<string> tempList = openFileDialogOpenPlaylist.FileNames.Distinct().ToList();

                foreach(string entry in openFileDialogTracks.FileNames)
                {
                    if (!tempList.Contains(entry))
                    {
                        listBoxTracks.Items.Add(entry);
                    }
                }
            }
        }

        private void buttonDeleteTrack_Click(object sender, EventArgs e)
        {
            if(listBoxTracks.Items.Count>0)
            {
                listBoxTracks.Items.Remove(listBoxTracks.SelectedItem.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearchTrack_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialogPlaylist = new SaveFileDialog();

            saveFileDialogPlaylist.FileName = textBoxPlaylistname.Text.ToString();

            if(saveFileDialogPlaylist.ShowDialog()==DialogResult.OK)
            {
                File.Create(saveFileDialogPlaylist.FileName);
                listBoxPlaylists.Items.Add(saveFileDialogPlaylist.FileName);
            }
        }

        private void pictureBoxShuffle_Click(object sender, EventArgs e)
        {
            if(shuffleMode == false)
            {
                pictureBoxShuffle.Image = Properties.Resources.shuffle1;
                shuffleMode = true;
            }
            else
            {
                pictureBoxShuffle.Image = Properties.Resources.shuffle2;
                shuffleMode = false;
            }
        }

        private void pictureBoxRepeat_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxNextTrack_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            if (listBoxTracks.SelectedItem != null && listBoxTracks.Items.Count != 0)
            {
                try
                {
                    if (isPlaying == false)
                    {
                        MusicPlayer.Play(listBoxTracks.SelectedItem.ToString());
                        timerUpdateContent.Start();
                        pictureBoxPlay.Image = Properties.Resources.pause2;
                        isPlaying = true;
                    }
                    else
                    {
                        if (isPlaying == true)
                        {
                            MusicPlayer.Pause();
                            pictureBoxPlay.Image = Properties.Resources.play2;
                            isPlaying = false;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void pictureBoxPreviousTrack_Click(object sender, EventArgs e)
        {

        }

        private void trackBarVol_ValueChanged(object sender, EventArgs e)
        {
            MusicPlayer.setVolume(trackBarVol.Value);
            labelPlayerStats.Text = MusicPlayer.getVolume().ToString()+"/"+trackBarVol.Value;
        }

        private void trackBarCurPos_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void panelResize_MouseMove(object sender, MouseEventArgs e)
        {
                   
        }

        private void buttonBrowseForPlaylist_Click(object sender, EventArgs e)
        {
            if(openFileDialogOpenPlaylist.ShowDialog() == DialogResult.OK)
            {
                listBoxPlaylists.Items.Add(openFileDialogOpenPlaylist.FileName);
            }
        }

        private void trackBarVol_Scroll(object sender, EventArgs e)
        {

        }

        private void timerUpdateContent_Tick(object sender, EventArgs e)
        {
            lblTrackTime.Text = MusicPlayer.getCurrentPositionString() + "/" + MusicPlayer.getTotalTimeString();
        }

        private void listBoxPlaylists_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedFile = listBoxPlaylists.SelectedItem.ToString();
                StreamReader sr = new StreamReader(selectedFile);

                while (!sr.EndOfStream)
                {
                    listBoxTracks.Items.Add(sr.ReadLine());
                }
            }
            catch (Exception)
            {

            }
        }

        private void playlistAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialogOpenPlaylist.ShowDialog() == DialogResult.OK)
            {
                listBoxPlaylists.Items.Add(openFileDialogOpenPlaylist.FileName);
            }
        }

        private void playlistDelete_Click(object sender, EventArgs e)
        {
            listBoxPlaylists.Items.Remove(listBoxPlaylists.SelectedItem.ToString());
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxPlaylists.Items.Clear();
        }

        private void toolStripMenuItemAddTrack_Click(object sender, EventArgs e)
        {
            if (openFileDialogTracks.ShowDialog() == DialogResult.OK)
            {
                List<string> tempList = openFileDialogOpenPlaylist.FileNames.Distinct().ToList();

                foreach (string entry in openFileDialogTracks.FileNames)
                {
                    if (!tempList.Contains(entry))
                    {
                        listBoxTracks.Items.Add(entry);
                    }
                }
            }
        }

        private void toolStripMenuItemRemoveTrack_Click(object sender, EventArgs e)
        {
            listBoxTracks.Items.Remove(listBoxTracks.SelectedItem.ToString());
        }

        private void toolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            listBoxTracks.Items.Clear();
        }

        private void listBoxTracks_Click(object sender, EventArgs e)
        {
            try
            {
                MusicPlayer.setCurrentPosition(0.0f);
                MusicPlayer.Play(listBoxTracks.SelectedItem.ToString());
                timerUpdateContent.Start();
                pictureBoxPlay.Image = Properties.Resources.pause2;
                isPlaying = true;
            }
            catch(Exception)
            {

            }
        }
    }
}
