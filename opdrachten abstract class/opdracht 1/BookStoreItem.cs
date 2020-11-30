using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    public abstract class BookStoreItem
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public int NumberOfItems { get; set; }

        public BookStoreItem(string title, float price, int numberOfItems)
        {
            this.Title = title;
            this.Price = price;
            this.NumberOfItems = numberOfItems;
        }
    }
}
