using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using NAudio;
using NAudio.Wave;
using NAudio.Codecs;
using Id3Lib;
using System.IO;

namespace Music_Player_2k16_Independed
{
    class Player
    {
        IWavePlayer MusicPlayer;
        AudioFileReader audioFileReader;
        Mp3FileReader mp3FileReader;

        private bool autoRepeat;
        private string currentFile;
        private bool isMp3;
        //Current Position in Seconds
        private int currentPositon=0;

        public Player()
        {
            MusicPlayer = new WaveOut();
        }

        private void getExtension(string file)
        {
            string extension = Path.GetExtension(file).ToLower();

            if(extension == ".mp3")
            {
                isMp3 = true;
            }
            else
            {
                isMp3 = false;
            }
        }

        public void Play(string file)
        {
            if (File.Exists(file))
            {
                getExtension(file);
                currentFile = file;

                if (isMp3 == true)
                {
                    mp3FileReader = new Mp3FileReader(file);
                    mp3FileReader.CurrentTime = TimeSpan.FromSeconds(currentPositon);
                    MusicPlayer.Dispose();
                    MusicPlayer.Init(mp3FileReader);
                    MusicPlayer.Play();
                }
                else
                {
                    audioFileReader = new AudioFileReader(file);
                    audioFileReader.CurrentTime = TimeSpan.FromSeconds(currentPositon);
                    MusicPlayer.Dispose();
                    MusicPlayer.Init(audioFileReader);
                    MusicPlayer.Play();
                }
            }
        }

        public void Pause()
        {
            if(isMp3 == true)
            {
                currentPositon = mp3FileReader.CurrentTime.Seconds + mp3FileReader.CurrentTime.Minutes*60;
            }
            else
            {
                currentPositon = audioFileReader.CurrentTime.Seconds + audioFileReader.CurrentTime.Minutes * 60;
            }

            MusicPlayer.Pause();
        }

        public void Stop()
        {
            MusicPlayer.Stop();
        }

        public string getTitle()
        {
            if(isMp3 == true)
            {

            }

            return Path.GetFileName(currentFile);
        }

        public double getTotalTime()
        {
            if(isMp3==true)
            {
                return Convert.ToDouble(mp3FileReader.TotalTime.Duration());
            }

            return 0.0f;
        }

        public string getTotalTimeString()
        {
            if (isMp3 == true)
            {
                return mp3FileReader.TotalTime.Minutes + ":" + mp3FileReader.TotalTime.Seconds;
            }

            return "00:00";
        }

        public void setCurrentPosition(double position)
        {
            currentPositon = (int)position;
            if (isMp3 == true)
            {
                mp3FileReader.CurrentTime = TimeSpan.FromSeconds(position);
            }
        }

        public double getCurrentPosition()
        {
            if (isMp3 == true)
            {
                return mp3FileReader.Position;
            }

            return 0.0f;
        }

        public string getCurrentPositionString()
        {
            if (isMp3 == true)
            {
                string fillerMinutes = "";
                string fillerSeconds = "";

                if(mp3FileReader.CurrentTime.Minutes < 10)
                {
                    fillerMinutes = "0";
                }

                if(mp3FileReader.CurrentTime.Seconds < 10)
                {
                    fillerSeconds = "0";
                }

                return fillerMinutes + mp3FileReader.CurrentTime.Minutes + ":" + fillerSeconds + mp3FileReader.CurrentTime.Seconds;
            }

            return "00:00";
        }

        public void setVolume(int volume)
        {
            if (volume >= 0 && volume <= 10)
            {
                float tempVolume = volume * 0.1f;
                MusicPlayer.Volume = tempVolume;
            }
        }

        public float getVolume()
        {
            return (float)MusicPlayer.Volume;
        }
    }
}
