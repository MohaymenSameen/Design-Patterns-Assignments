﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class CheapHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Storing data not so quickly...");
        }
    }
}
