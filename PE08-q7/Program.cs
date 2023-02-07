using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE08_q7
{
    // Author: Max Lama
    // Class: Program
    // Purpose: Question 7 - reverse a string.
    // Restrictions: None
    internal class Program
    {
        // Author: Max Lama
        // Purpose: same as Program
        static void Main(string[] args)
        {
            string input = "";
            string reverse = "";

            //Prompt for string
            Console.WriteLine("Give me a line to reverse!");
            //Get string
            input = Console.ReadLine();

            //Loop through string and add it to a new "Reverse string" variable
            for (int i = input.Length; i > 0; i--)
            {
                reverse += input[i-1];
            }
            
            //print to console.
            Console.WriteLine($"Here's the reversed string: \n{reverse}");
        }
    }
}
