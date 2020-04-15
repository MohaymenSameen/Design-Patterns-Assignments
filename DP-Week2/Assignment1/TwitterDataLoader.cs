using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class TwitterDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("extracting twitter data...");
        }
        public override void Transform()
        {
            Console.WriteLine("transforming twitter data...");
        }
        public override void Load()
        {
            Console.WriteLine("loading twitter data...");
        }
    }
}
