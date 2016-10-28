using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Music_Player_2k16_Independed
{
    class PlaylistManagement
    {
        private List<string> playlists;
        private List<string> playlistsShort;
        private List<string> currentPlaylistTracks;

        public PlaylistManagement()
        {
            try
            {
                string[] splittedRecentList = Properties.Settings.Default.recentPlaylist.Split(';');

                foreach (string entry in splittedRecentList)
                {
                    addPlaylistOverviewEntry(entry);
                }
            }
            catch (Exception)
            {
            }
        }

        public bool playlistAlreadyInOverview(string playlist)
        {
            foreach (string entry in playlists)
            {
                if (entry == playlist)
                {
                    return true;
                }
            }

            return false;
        }

        public void clearPlaylistOverview()
        {
            playlists.Clear();
            playlistsShort.Clear();
        }

        public void addPlaylistOverviewEntry(string entry)
        {
            if (!playlistAlreadyInOverview(entry))
            {
                playlists.Add(entry);
                playlistsShort.Add(Path.GetFileName(entry));
            }
        }

        public void removeEntryFromPlaylistOverview(string playlist)
        {
            foreach (string entry in playlists)
            {
                if(entry == playlist || entry.Contains(playlist))
                {
                    playlists.Remove(playlist);
                    playlistsShort.Remove(Path.GetFileName(playlist));
                }
            }
        }
    }
}
