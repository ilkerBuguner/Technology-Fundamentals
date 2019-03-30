using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab___02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();

                if (dict.ContainsKey(wordInLowerCase))
                {
                    dict[wordInLowerCase]++;
                }
                else
                {
                    dict[wordInLowerCase] = 1;
                }

            }

            foreach (var word in dict)
            {
                if (word.Value % 2 == 1)
                {
                    Console.Write($"{word.Key} ");
                }
            }

        }
    }
}
