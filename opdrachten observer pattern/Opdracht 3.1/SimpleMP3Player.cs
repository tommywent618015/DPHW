using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._1
{
    class SimpleMP3Player : IObserver
    {
        
        public SimpleMP3Player(IObservable player)
        {
            player.AddObserver(this);
        }
        public void Update(Song song)
        {
            Console.WriteLine($"simple display: {song.Artist} - {song.SongName}");
        }
    }
}
