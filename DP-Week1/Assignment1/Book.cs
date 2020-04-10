using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Book : BookStoreItem
    {
        public string Author {get; set;}

        public Book(string title, float price, int numberOfItems, string author)
            :base(title, price, numberOfItems)
        {
            Author = author;
        }

        public override string ToString()
        {
            return String.Format("[Book] {0} - {1}, {2:0.00} ({3}x)", Author, Title, Price, NumberOfItems);
        }
    }
}
