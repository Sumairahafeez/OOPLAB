using MusicStreamingService.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStreamingService
{
    internal class Program
    {
        static void Main(string[] args)
        {   //THERE EXISTS AN AGGREGATE RELATIONSHIP BETWEEN THEM
            Song S1 = new Song("Nazrana", "Atif Aslam", 2019);
            Song S2 = new Song("Teri Mitti", "ABC", 2020);
            List<Song> SongList = new List<Song>();
            SongList.Add(S1);
            SongList.Add(S2);
            Playlist P = new Playlist(SongList);
            Console.WriteLine("PlayList has followning songs: ");
            for(int i=0; i<SongList.Count; i++)
            {
                Console.WriteLine(SongList[i].GetTitle()+" by " + SongList[i].GetSingerName());
            }
            Console.ReadKey();
        }
    }
}
