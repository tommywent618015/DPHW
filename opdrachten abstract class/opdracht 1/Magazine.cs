using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Magazine : BookStoreItem
    {
        public DayOfWeek ReleaseDay { get; set; }

        public Magazine(string title, float price, int numberOfItems, DayOfWeek releaseDay)
            : base(title, price, numberOfItems)
        {
            this.ReleaseDay = releaseDay;
        }

        public override string ToString()
        {
            return string.Format($"[Magazine] {Title} - {ReleaseDay}, {Price} ({NumberOfItems}x)");
        }
    }
}
