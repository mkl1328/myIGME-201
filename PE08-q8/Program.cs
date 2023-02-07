using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE08_q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -= PLAIN ENGLISH LOGIC =-
            // get string input
            // split string
            // check each word against no through ToLower()
            // replace no with yes
            // Console.Write string

            string input = "";
            string[] words;
            string result = "";
            char[] charsToTrim = { ' ', '.', ',', '!', '?', '(', ')', ':', ';', '-'};

            Console.WriteLine("Please input a sentence with at least one \"No\" in it.");
            input = Console.ReadLine();

            words = input.Split(' ');

            //Foreach wasn't working since I was trying to alter the iteration variable
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower().Trim(charsToTrim) == "no")
                {
                    words[i] = words[i].ToLower();
                    words[i] = words[i].Replace("no", "yes");
                }
                result += $"{words[i]} ";
            }
            Console.WriteLine(result);
            //NOTE: 
            // I was originally planning on using replace, but then I thought it might replace things like "nonsense" with "yesnsense"
            // so I switched to a split and loop.

        }
    }
}
