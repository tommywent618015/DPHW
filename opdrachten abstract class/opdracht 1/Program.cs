using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            Book b1 = new Book("Dracula", 15.00f, 5, "Bram Stoker");
            Book b2 = new Book("Joe Speedboat", 12.50f, 3, "Tommy Wieringa");
            Magazine m1 = new Magazine("Time", 3.90f, 10, DayOfWeek.Friday);
            Magazine m2 = new Magazine("Donald Duck", 2.50f, 15, DayOfWeek.Thursday);
            CD cd1 = new CD("The cure", 3.90f, 5, "Seventeen seconds");
            
            BookStore store = new BookStore();
            store.AddItem(b1);
            store.AddItem(b2);
            store.AddItem(m1);
            store.AddItem(m2);
            store.AddItem(cd1);
            store.PrintAllItems();

            Console.ReadKey();
        }
    }
}
