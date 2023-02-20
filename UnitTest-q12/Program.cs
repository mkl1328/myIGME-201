using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_q12
{
    // Class: Program
    // Author: Max Lama
    // Purpose: Question 12
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: Ask user's name and call a function to give a raise.
        // Restrictions: None
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.Write("What's your name? => ");
            sName = Console.ReadLine();

            bool gotARaise = GiveRaise(sName, ref dSalary);
            if(gotARaise)
            {
                Console.WriteLine($"Congratulations on the raise!\nYour new salary is: {dSalary}");
            }
            else
            {
                Console.WriteLine($"Your salary is {dSalary}");
            }
        }

        // Method: GiveRaise
        // Purpose: Check if name == Max Lama, if so - give a raise, and return true
        // @param {string} name - name of user
        // @param {ref double} salary - reference to the salary of the user.
        // @return {bool} wether or not the user got a raise
        static bool GiveRaise(string name, ref double salary)
        {
            if(name == "Max Lama")
            {
                salary += 19999.99;
                return true;
            }
            return false;
        }
    }
}
