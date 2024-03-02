using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStreamingService.BL
{
    internal class Playlist
    {
        private List<Song> songList;
        public Playlist(List<Song> songList)
        {
            SetSongsList (songList);
        }

        public void SetSongsList(List<Song> songsList)
        {
            songList = new List<Song>();
        }

    }
}
