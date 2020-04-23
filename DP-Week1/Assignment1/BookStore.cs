using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class BookStore
    {
        private List<BookStoreItem> items;

        public BookStore()
        {
            items = new List<BookStoreItem>();
        }

        public void Add(BookStoreItem item)
        {
            items.Add(item);
        }
        public void PrintAllItems()
        {
            foreach(BookStoreItem item in items)
            {                
                Console.WriteLine(item);
            }
        }
    }
}
