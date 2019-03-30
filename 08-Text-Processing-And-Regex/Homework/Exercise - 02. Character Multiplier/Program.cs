using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            string word1 = words[0];
            string word2 = words[1];

            int sum = 0;

            int minLength = Math.Min(word1.Length, word2.Length);
            int maxLength = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += WordsCharMultiplier(word1[i], word2[i]);
            }

            if (word1.Length != word2.Length)
            {
                string longerInput = word1.Length > word2.Length ? longerInput = word1 : longerInput = word2;
                for (int i = minLength; i < maxLength; i++)
                {
                    sum += longerInput[i];
                }
            }
            Console.WriteLine(sum);

        }

        private static int WordsCharMultiplier(char char1, char char2)
        {
            int multiply = char1 * char2;
            return multiply;
        }
    }
}
