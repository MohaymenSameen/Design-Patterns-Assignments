using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }
        void Start()
        {
            BookStore bookStore = new BookStore();

            Book book1 = new Book("Dracula", 15.00f, 5, "Bram Stoker");
            Book book2 = new Book("Joe speedboot", 12.50f, 3, "Tommy Wieringa");
            Magazine magazine1 = new Magazine("Time", 3.90f, 10, DayOfWeek.Friday);
            Magazine magazine2 = new Magazine("Donald Duck", 2.50f, 15, DayOfWeek.Thursday);
            CD cd1 = new CD("Seventeen Seconds", 3.90f, 5, "The Cure");           
            
            bookStore.Add(book1);
            bookStore.Add(book2);
            bookStore.Add(magazine1);
            bookStore.Add(magazine2);
            bookStore.Add(cd1);

            bookStore.PrintAllItems();

            Console.ReadKey();
        }
    }
}
