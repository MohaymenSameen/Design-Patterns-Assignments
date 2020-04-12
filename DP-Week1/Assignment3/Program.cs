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
            string message = "";
            Pencil pencil = new Pencil();
            while (message != "stop")
            {
                Console.Write("Enter a message: ");
                message = Console.ReadLine();           

                if (message == "sharpen")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Sharpening the pencil...");
                    pencil.AfterSharpening();
                    message = "";
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                pencil.Write(message);
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
