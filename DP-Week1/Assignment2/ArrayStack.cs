using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class ArrayStack : IStack
    {
        private int[] items;        
        private bool isEmpty;
        private int count;
        private int currentIndex;
        public int Count { get { return count; } }        
        public bool IsEmpty { get { return isEmpty; } }  
        public int MaxItems { get; set; }       
        public ArrayStack(int maxItems)
        {
            items = new int[maxItems];
            MaxItems = maxItems;
            currentIndex = 0;
        }

        public void Push(int value)
        {
            try
            {
                items[currentIndex] = value;
                currentIndex++;                
                count++;
            }
            catch (Exception)
            {
                if(items.Length == MaxItems)
                {
                    throw new Exception("stack is full");
                }                
            }
            
        }
        public int Pop()
        {            
            try
            {
                currentIndex--;
                count--;
                while (currentIndex < 0)
                {
                    currentIndex += items.Length;
                }               

                if (count == 0)
                {
                    isEmpty = true;
                }
                else
                {
                    isEmpty = false;
                }             

                return items[currentIndex];
            }
            catch (Exception)
            {
                throw new Exception("Stack is empty");
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
