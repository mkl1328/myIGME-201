using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot_PE04
{
    // Class: Program
    // Author: Max Lama
    // Purpose: To take user input to determine the scale and view window of the mandelbrot image.
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Author: Max Lama
        // Purpose: same as class
        // Restrictions: none
        static void Main(string[] args)
        {
            // Vars
            double real1;
            double real2;
            double imag1;
            double imag2;

            // Validate input
            // Request input
            while (true)
            {
                try
                {
                    Console.WriteLine("Please input 4 numbers separated by spaces in this format (omit brackets): \n" +
                        "[Real Coord Min] [Real Coord Max] [Imaginary Coord Min] [Imaginary Coord Max]");
                    string[] coordParamsInput = Console.ReadLine().Split(' ');
                    real1 = double.Parse(coordParamsInput[0]);
                    real2 = double.Parse(coordParamsInput[1]);
                    imag1 = double.Parse(coordParamsInput[2]);
                    imag2 = double.Parse(coordParamsInput[3]);

                    double[] coordParams = { real1, real2, imag1, imag2 };

                    //Validate max - min 
                    if(real1 < real2 && imag1 < imag2)
                    {
                        Generate(coordParams);
                        break;
                    } else
                    {
                        Console.WriteLine("Please try again. Make sure the Mins are smaller than the Maxes");
                    }      
                }
                catch
                {
                    Console.WriteLine("Please input valid values");
                }
            }
        }

        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        public static void Generate(double[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            for (imagCoord = args[3]; imagCoord >= args[2]; imagCoord -= (args[3] - args[2]) / 48)
            {
                for (realCoord = args[0]; realCoord <= args[1]; realCoord += (args[1] - args[0]) / 80)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
