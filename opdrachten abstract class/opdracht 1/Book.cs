using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Book : BookStoreItem
    {
        public string Author { get; set; }

        public Book(string title, float price, int numberOfItems, string author)
            : base(title, price, numberOfItems)
        {
            this.Author = author;
        }

        public override string ToString()
        {
            return string.Format($"[Book] {Author} - {Title}, {Price} ({NumberOfItems}x)");
        }
    }
}
