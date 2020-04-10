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

        public List<BookStoreItem> Add()
        {
            foreach(BookStoreItem item in items)
            {
                items.Add(item);
            }
            return items;
        }
        public void PrintAllItems(List<BookStoreItem> items)
        {
            foreach(BookStoreItem item in items)
            {                
                Console.WriteLine(item);
            }
        }
    }
}
