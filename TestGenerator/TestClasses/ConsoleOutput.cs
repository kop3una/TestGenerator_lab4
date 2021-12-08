using System;

namespace SPP4Test
{
    public class ConsoleOutput
    {
        public static void Output() 
        {
            Console.WriteLine("This is 4 lab on SPP!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}