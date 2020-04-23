using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class ArrayStack : IStack
    {
        private int[] items;
        private int count;
        private int currentIndex;
        public int Count { get { return count; } }        
        public bool IsEmpty { get { return count==0; } }  
        public int MaxItems { get; set; }       
        public ArrayStack(int maxItems)
        {
            items = new int[maxItems];
            MaxItems = maxItems;
            currentIndex = 0;
        }

        public void Push(int value)
        {            
            items[currentIndex] = value;
            currentIndex++;                
            count++;
            
            if(count == MaxItems)
            {
                throw new Exception("Stack is full");
            }            
        }
        public int Pop()
        {           
            if(count == 0)
            {
                throw new Exception("Stack is empty");
            }
            currentIndex--;
            count--;                    

            return items[currentIndex];           
        }
        public bool Contains(int value)
        {
            foreach (int item in items)
            {
                if(items.Contains(value))
                {
                    return true;
                }
            }          
            return false;
        }        
    }
}
