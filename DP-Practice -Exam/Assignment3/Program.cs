using System;

namespace Assignment3
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
            CopyingMachine copyingMachine1 = CopyingMachine.GetInstance();
            CopyingMachine copyingMachine2 = CopyingMachine.GetInstance();

            Console.WriteLine("copying with 'machine 1'");
            copyingMachine1.Copy(10);
            copyingMachine1.Copy(23);

            Console.WriteLine("copying with 'machine 2'");
            copyingMachine2.Copy(40);
            

            Console.ReadKey();
        }
    }
}
