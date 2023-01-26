using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE03
{
    // Class: Program
    // Author: Max Lama
    // Purpose: Collect 4 numbers from user input, and output the product
    // Restrictions: None
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 1;
            // For loop for collecting 4 doubles   
            for (int i = 0; i < 4; i++)
            {
                bool isNum = false;
                // Data Validation
                while (!isNum) 
                {
                    try
                    {
                        Console.WriteLine($"Please enter in a number. ({i}/4)");
                        double temp = Convert.ToDouble(Console.ReadLine());
                        
                        // Multiply them all Each time collected
                        total *= temp;
                        isNum = true;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number value.");
                    }
                }
                
            }
            // Write product to console
            Console.WriteLine($"The product of those four numbers is: {total}");
        }
    }
}
