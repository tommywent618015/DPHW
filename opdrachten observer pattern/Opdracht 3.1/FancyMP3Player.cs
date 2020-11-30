using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._1
{
    class FancyMP3Player : IObserver
    {
        public FancyMP3Player(IObservable player)
        {
            player.AddObserver(this);
        }
        public void Update(Song song)
        {
            TimeSpan t = TimeSpan.FromSeconds(song.SongLength);
            Console.WriteLine($"Fancy display: '{song.SongName}' by {song.Artist} ({string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds)}) ");
        }
    }
}
