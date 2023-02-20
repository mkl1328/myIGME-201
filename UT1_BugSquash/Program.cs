using System;

namespace UT1_BugSquash
{
    // Class: Program
    // Author: --EDITED-- by Max Lama
    // Purpose: Question 14 (bug squashing)
    // Restrictions: None
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY       // Syntax Error
            // No semiColon
            int nY;
            int nAnswer;

            // Console.WriteLine(This program calculates x ^ y.);   // Syntax Error
            // Missing Quotes
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                // Console.ReadLine();          // Logical Error
                // Need to assign this to a variable
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            // } while (int.TryParse(sNumber, out nX));     // Logical Error
            // Need to assign this to nY not nX

            //} while (int.TryParse(sNumber, out nY));      // Logical Error
            // Will loop if you put in a valid integer.
            } while (!int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            // Console.WriteLine("{nX}^{nY} = {nAnswer}");       // Syntax Error
            // Need $ in front of quotes for the brackets to function
            Console.WriteLine($"{nX}^{nY} = {nAnswer}");
        }


        // int Power(int nBase, int nExponent)          // Syntax Error?
        // Need to put "static" in front of the function
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                // returnVal = 0;       // Logical Error
                // if returnVal = 0, then when multiplied together everything will = 0;
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                // nextVal = Power(nBase, nExponent + 1);        // Logical Error
                // Need to decrement the exponent
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            // returnVal;           // Syntax error (compile error - Idk if those are the same thing)
            // Need to return this value 
            return returnVal;
        }
    }
}
