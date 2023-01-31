using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE04
{
    // Class: Program
    // Author: Max Lama
    // Purpose: Record 2 number inputs and check if only one of them is greater than 10
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Author: Max Lama
        // Purpose: Same as program
        // Restrictions: None
        static void Main(string[] args)
        {
            // Make vars for number values
            int num1 = 0;
            int num2 = 0;

            while(true)
            {
                try
                {
                    Console.WriteLine("Insert two integers separated by a space.");
                    string[] nums = Console.ReadLine().Split(' ');
                    num1 = Convert.ToInt32(nums[0]);
                    num2 = Convert.ToInt32(nums[1]);

                    bool bNum1 = num1 > 10;
                    bool bNum2 = num2 > 10; 

                    if((bNum1 || bNum2) && !(bNum1 && bNum2))
                    {
                        Console.WriteLine($"Nice, only one number is greater than ten. \n Your numbers were: {num1} and {num2}.");
                        break;
                    } else
                    {
                        Console.WriteLine("That's not quite right, try again.");
                    }
                }
                catch
                {
                    Console.WriteLine("Please input two valid integers separated by a space.");
                }
            }
        }
    }
}
