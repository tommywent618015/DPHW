﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // maak een MP3 player aan
            IObservable player = new MP3Player();
            // maak de displays aan
            IObserver mp3Display1 = new SimpleMP3Player(player);
            IObserver mp3Display2 = new FancyMP3Player(player);
            // zet player op een nieuw nummer
            // (aangezien er geen hardware is, doen we dat hier...)
            player.NextSong();
            player.NextSong();
            player.NextSong();
            Console.ReadKey();

        }
    }
}
