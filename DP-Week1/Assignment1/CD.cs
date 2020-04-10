using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class CD : BookStoreItem
    {
        public string Artist {get; set;}
        public CD(string title, float price, int numberOfItems, string artist)
            :base(title,price,numberOfItems)
        {
            Artist = artist;
        }
        public override string ToString()
        {
            return String.Format("[CD] {0} - {1}, {2:0.00} ({3}x)", Artist, Title, Price, NumberOfItems);
        }
    }
}
