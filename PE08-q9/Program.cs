using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE08_q9
{
    // Author: Max Lama
    // Class: Program
    // Purpose: to add double qotes around each word
    // Restrictions: - if you give a string with other punctuation it will be treated as part of the word
    //               - if you separate a punctuation mark by itself, it will leave quotes and then the mark
    //               - if you put a punctuation mark before a word, not separated by a space, it will be omitted
    internal class Program
    {
        // Purpose: same as program
        // Restrictions: same as program
        static void Main(string[] args)
        {
            // -= PLAIN ENGLISH LOGIC =-
            // Take input string
            // Split string to word array
            // store punctuation mark
            // trim punctuation mark
            // add quotes
            // add back punctuation mark
            // reconcatenate string
            // write to console

            string input = "";
            string[] words;
            string result = "";
            char[] charsToCheck = { '.', ',', '?', '!', ':' };

            Console.WriteLine("Input a string and get ready to be heavily \"qouted\"... (?)");
            input = Console.ReadLine();

            words = input.Split(' ');

            for(int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                char punctuation = word[word.Length - 1];

                word = word.Trim(charsToCheck);
                word = $"\"{word}\"";

                if (charsToCheck.Contains(punctuation))
                {
                    word += punctuation;
                }
                result += $"{word} "; 
            }
            Console.WriteLine($"Here's your \"qouted\" up line:\n{result}");
        }
    }
}
