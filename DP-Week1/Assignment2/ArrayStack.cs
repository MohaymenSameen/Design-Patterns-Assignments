using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class ArrayStack : IStack
    {
        private int[] items;
        
        private int count;
        private bool isEmpty;
        public int Count
        {
            get { return count; }
            set
            {
                for (int i = 0; i < items.Length; i++)
                {
                    count++;
                }
            }
        }
        public bool IsEmpty
        {
            get { return isEmpty; }
            set
            {
                if(items.Length == 0)
                {
                    isEmpty = true;
                }
                else
                {
                    isEmpty = false;
                }                
            }
        }
        public int MaxItems { get; set; }       
        public ArrayStack(int maxItems)
        {
            items = new int[maxItems];
            MaxItems = maxItems;
        }

        public void Push(int value)
        {
            try
            {
                for (int i = 0; i < items.Length; i++)
                {
                    items[i] += value;
                }
            }
            catch (Exception)
            {
                if(items.Length == MaxItems)
                {                    
                    Console.WriteLine("Stack is full");
                }                
            }
            
        }
        public int Pop()
        {
            try
            {
                int lastItem = 0;
                for (int i = items.Length - 1; i >= 0; i--)
                {
                    //items[i] -= lastItem;  
                    lastItem += items[i];
                }
                //int removeItem = items.;
                return lastItem;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public bool Contains(int value)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if(items[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
