﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    interface IStack
    {
        void Push(int value);
        int Pop();
        bool Contains(int value);
        int Count { get; }
        bool IsEmpty { get; }
    }
}
