﻿using System;

namespace Assignment2
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
            IStack myStack = new ArrayStack(50);
            AddValues(myStack);
            ProcessValues(myStack);
            Console.ReadKey();
        }
        void AddValues(IStack stack)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int value = rnd.Next(100);
                stack.Push(value);
                Console.WriteLine($"pushed {value}, new count: {stack.Count}");
            }
        }
        void ProcessValues(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                int value = stack.Pop();
                Console.WriteLine($"popped {value}, new count: {stack.Count}");
            }
        }
    }
}
