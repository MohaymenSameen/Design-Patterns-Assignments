using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Magazine : BookStoreItem
    {
        public DayOfWeek ReleaseDay {get; set;}
        public Magazine(string title, float price, int numberOfItems, DayOfWeek releaseDay)
            :base(title,price,numberOfItems)
        {
            ReleaseDay = releaseDay;
        }
        public override string ToString()
        {
            return String.Format("[Magazine] {0} - {1}, {2:0.00} ({3}x)", Title, ReleaseDay, Price, NumberOfItems);
        }
    }
}
