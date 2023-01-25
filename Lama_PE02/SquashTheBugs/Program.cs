using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh --> edited by Max Lama for assignment
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            // int i = 0       // Syntax Error
            //  No Semicolon
            int i = 0;

            // declare string to hold all numbers  -- Original code starts line 31
            string allNumbers = null;

            // loop through the numbers 1 through 10
            // for (i = 1; i < 10; ++i)      // Logical Error
            //  loops thru 1 to 9 since it stops at i < 10 and not i <= 10
            for(i = 1; i <= 10; i++)
            {
                // declare string to hold all numbers
                // string allNumbers = null;            // Syntax Error? 
                //  This needs to be declarerd outside of the for loop so that the
                //  later code can reference it, and so that it isn't redeclared
                //  and overwritten each itteration of the for loop.
                //    -> See Line 23

                // output explanation of calculation
                // Console.Write(i + "/" + i - 1 + " = ");      // Syntax Error
                //  Cannot use "-" symbol in string concatenation
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                // Console.WriteLine(i / (i - 1));        // Runtime Error
                // 1 / (1 - 1) = undefined since anything divided by 0 = undefined / infinity / error.
                //  I'm casting to a double for a better approximation, otherwise all of the answers are 1 aside 
                //  from when i = 2. (it also fixes the divide by zero error??
                //  I originally had a try catch block here, but the catch never happened because the double just
                //  sort of takes care of it. -- Not sure why. 
                double moreExact = (double)i / (i - 1);
                Console.WriteLine(moreExact);

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                // i = i + 1;       // Logical Error
                //  This is already being incremented in the for loop.
            }

            // output all numbers which have been processed
            // Console.WriteLine("These numbers have been processed: " allNumbers);         //Syntax Error
            //  No string Concatenation symbol used: +
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}
