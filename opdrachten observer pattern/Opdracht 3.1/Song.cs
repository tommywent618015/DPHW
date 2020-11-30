using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._1
{
    public class Song
    {
        List<Song> songlist = new List<Song>();
        public string Artist;
        public string SongName;
        public int SongLength;

        public Song(string songName, string artist, int songLength)
        {
            this.Artist = artist;
            this.SongName = songName;
            this.SongLength = songLength;
        }

        public void Add(Song song)
        {
            songlist.Add(song);
        }
    }
}
