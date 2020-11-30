using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._1
{
    class MP3Player : IObservable
    {
        List<IObserver> observers = new List<IObserver>();
        List<Song> songlist = new List<Song> { new Song("Wish You Were Here", "Pink Floyd", 192), new Song("Dazed and confused", "Led Zeppelin", 240), new Song("Billionaire", "Bruno Mars", 213) };
        Random rnd = new Random();
        
        public Song CurrentSong { get; private set; }

        public void NextSong()
        {
            CurrentSong = songlist[rnd.Next(0, songlist.Count)];
            foreach(IObserver observer in observers)
            {
                observer.Update(CurrentSong);
            }
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
