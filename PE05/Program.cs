using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare the unsorted and sorted arrays
            double[] aUnsorted = new double[5];
            double[] aSorted = new double[5];

            //Data Validation
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a list of space-separated numbers");

                    // read the space-separated string of numbers
                    string sNumberString = Console.ReadLine();

                    // split the string into the an array of strings which are the individual numbers
                    string[] sNumbers = sNumberString.Split(' ');

                    //try to parse each value
                    for (int i = 0; i < sNumberString.Length; i++)
                    {
                        aUnsorted[i] = double.Parse(sNumbers[i]);
                    }

                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter valid numbers");
                }
            }
            // SORTING
            // loop through unsorted array
            for (int i = 0; i < aSorted.Length; i++)
            {
                double tempSortInt = aUnsorted[0];
                for (int j = 1; j < aUnsorted.Length; j++)
                {
                    // Checks already sorted numbers
                    for (int k = 0; k < aSorted.Length; k++)
                    {
                        // If it exists in the sorted array, skip to the next number
                        if (aSorted[k] == tempSortInt)
                        {
                            tempSortInt = aUnsorted[j];
                            // I hope this only breaks out of the current loop.
                            break;
                        }
                    }
                    //check if the current temp num is lower than the next number in the unsorted array.
                    if (tempSortInt < aUnsorted[j])
                    {
                        tempSortInt = aUnsorted[j];
                    }
                }
                aSorted[i] = tempSortInt;
            }
            Console.WriteLine($"Sorted Array: {aSorted}");
        }
    }
}
