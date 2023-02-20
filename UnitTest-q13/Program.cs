using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_q13
{
    // Class: Program
    // Author: Max Lama
    // Purpose: Question 13
    // Restrictions: None
    internal class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;

        }

        // Method: Main
        // Purpose: Ask user's name and call a function to give a raise.
        // Restrictions: None
        static void Main(string[] args)
        {
            Console.Write("What's your name? => ");
            employee emp = new employee();
            emp.dSalary = 30000;
            emp.sName = Console.ReadLine();
            bool gotARaise = GiveRaise(emp);
            if (gotARaise)
            {
                emp.dSalary += 19999.99;
                Console.WriteLine($"Congratulations on the raise!\nYour new salary is: {emp.dSalary}");
            }
            else
            {
                Console.WriteLine($"{emp.sName}, your salary is {emp.dSalary}");
            }
        }

        // Method: GiveRaise
        // Purpose: Check if name == Max Lama, if so - give a raise, and return true
        // @param {employee} emp - struct of employee info
        // @return {bool} wether or not the user got a raise
        static bool GiveRaise(employee emp)
        {
            if (emp.sName == "Max Lama") return true;
            return false;
        }
    }
}
