using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE09_q3
{
    // Class: Program
    // Author: Max Lama
    // Purpose: delgate function
    // Restrictions: none
    internal class Program
    {

        // Method: Main
        // Purpose: Hold Delegate function impersonating ReadLine()
        // Restrictions: it only returns a blank string.
        static void Main(string[] args)
        {
            Func<string> fakeReadLine;

            fakeReadLine = () =>
            {
                string returnVal = ""; // How do I acquire user input without using readline????
                return returnVal;
            };
        }
    }
}
