using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class BookStore
    {
        private List<BookStoreItem> Items = new List<BookStoreItem>();
        
        public void AddItem(BookStoreItem item)
        {
            Items.Add(item);
        }

        public void PrintAllItems()
        {
            foreach (BookStoreItem i in Items)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
