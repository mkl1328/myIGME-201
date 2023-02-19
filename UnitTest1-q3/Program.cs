using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1_q3
{
    // Class: Program
    // Author: Max Lama
    // Purpose: Question 3 (and 8)
    // Restrictions: None
    internal class Program
    {
        //declares delegate function with matching input values
        delegate double MyRounder(double value, int places);

        // Method: Main
        // Purpose: Imitate Math.Round(double, int) with a delegate
        // Restrictions: None
        static void Main(string[] args)
        {
            // create and construct rounder variable of type MyRounder
            MyRounder rounder = new MyRounder(Math.Round);

            // call function
            double maxsIdealTestGrade = rounder(99.6, 0);
            Console.WriteLine(maxsIdealTestGrade);

            /**  [ALTERNATIVE WAYS]
             * 
             *      --Abbreviated--
             *      rounder = Math.Round
             *      
             *      --Anonymous--
             *      rounder = delegate (double n1, int n2)
             *      {
             *          double returnVal = Math.Round(n1, n2)
             *          return returnVal
             *      }
             *      
             *      --lambda--
             *      rounder = (n1, n2) => Math.Round(n1, n2);
             * 
             *      --Generic type--
             *      Func<double, int, double> rounder = new Func<double, int, double>(Math.Round);
             * 
             */

            Question8(rounder);
        }

        // Method: Question8
        // Purpose: Calculate given formula and store the information in a multidimensional array.
        // Restrictions: none
        // @param {Myrounder} rounder - delegate function that imitates Math.Round()  -> Func<double, int, double>
        static void Question8(MyRounder rounder)
        {
            // QUESTION 8 (This code also appears in the test document)
            //  formula: z = 4y^3 + 2x^2 - 8x + 7

            double[,,] answers = new double[41, 21, 3];
            int yCounter = 0;
            int xCounter = 0;

            for (double x = 0; x <= 4; x += 0.1) 
            {
                for (double y = -1; y <= 1; y += 0.1)
                {
                    double z;
                    z = (4 * y * y * y) + (2 * x * x) - (8 * x) + 7;
                    answers[xCounter, yCounter, 0] = rounder(x, 1);
                    answers[xCounter, yCounter, 1] = rounder(y, 1);
                    answers[xCounter, yCounter, 2] = rounder(z, 2);
                    // Console.WriteLine($"{answers[xCounter, yCounter, 0]}, {answers[xCounter, yCounter, 1]}, {answers[xCounter, yCounter, 2]}");
                    yCounter++;
                }
                yCounter = 0;
                xCounter++;
            }
        }
    }
}
