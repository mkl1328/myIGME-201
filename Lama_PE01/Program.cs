using System;

namespace Lama_PE01
{
    // Class: Program
    // Author: Max Lama
    // Purpose: Practice Exercise 1 - Print hello world 
    // Restrictions: None
    static internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max Lama");

            var x = 10;
            x += 100;
            Console.WriteLine(x);

            if(x == 10) {
                Console.WriteLine(x + " = 10");
            }
        }
    }
}
