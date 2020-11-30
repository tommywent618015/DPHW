using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class CD : BookStoreItem
    {
        public string Artist { get; set; }

        public CD(string title, float price, int numberOfItems, string artist) 
            : base(title, price, numberOfItems)
        {
            this.Artist = artist;
        }

        public override string ToString()
        {
            return string.Format($"[CD] {Artist} - {Title}, {Price} ({NumberOfItems}x)");
        }
    }
}
