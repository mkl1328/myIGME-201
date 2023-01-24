using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ColorNameSpace
{
    namespace Color
    {
        static class ColorClass
        {
            public static string sFavColor = null;
        }
    }
}


namespace FavoriteColorAndNumber
{
    using CAlias = ColorNameSpace.Color;
    // Class: Program
    // Author: Max Lama
    // Purpose: Console Read/Write and Exception-handling exercise
    // Restrictions: None
    static internal class Program
    {
        // Method: Main
        // Purpose: Prompt user for thier favorite number and color, and outputs that to the console.
        //          Outputs favorite color, favorite number of times                  
        // Restrictions: None
        static void Main(string[] args)
        {
            //int favNum = 0;
            int nFavNum = 0;
            string sFavNum = null;
            sFavNum = "123";

            int? npFavNum = null;
            //      I dont understand the pointer null thing???


            // Prompt user for fav color
            Console.Write("Enter your favorite color:\t");

            // read from console and store into variable
            CAlias.ColorClass.sFavColor = Console.ReadLine();

            // Prompt user for favorite number
            Console.Write("Enter your favorite number:\t");

            // Check for int input

            
            do
            {

                // read from console and store into variable
                sFavNum = Console.ReadLine();

                try
                {
                   npFavNum = Convert.ToInt32(sFavNum);
                }
                catch
                {
                    Console.WriteLine("Please enter an integer.");
                }
            } while(npFavNum == null);
            

            //Only works once -- 
            //    if (int.TryParse(sFavNum, out nFavNum)) nFavNum = int.Parse(sFavNum);

            // Change text to match their color

            switch (CAlias.ColorClass.sFavColor.ToLower())
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                     break;

                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

            }

            // Output their favorite color - fav number of times
            for (int i = 0; i < nFavNum; i++)
            {
                Console.Write(CAlias.ColorClass.sFavColor);
            }

            //Diff string output:
            //String appending -    ("..." + var)
            //String Embedding -    ($"... + {}")
            //String substitution - ("... {0}", var)

        }
    }
}
