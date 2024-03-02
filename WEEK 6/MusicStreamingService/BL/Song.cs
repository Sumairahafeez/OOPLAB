using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStreamingService.BL
{
    internal class Song
    {
        private string Title;
        private string SingerName;
        private int ReleaseYear;
        
        public Song(string title, string singerName, int releaseYear)
        {
            SetTitle(title);
            SetSinger(singerName);
            SetReleaseYear(releaseYear);
           
        }
        public void SetTitle(string title)
        {
            Title = title;
        }
        public string GetTitle()
        {
            return Title;
        }
        public int GetReleaseYear()
        {
            return ReleaseYear;
        }
        public void SetReleaseYear(int releaseYear)
        {
            ReleaseYear = releaseYear;
        }
        public string GetSingerName()
        {
            return SingerName;
        }
        public void SetSinger(string singer)
        {
            SingerName = singer;
        }
    }
}
