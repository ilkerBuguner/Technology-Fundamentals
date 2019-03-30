using System;
using System.Linq;
using System.Collections.Generic;

namespace Exericse___01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] wordSymbols = Console.ReadLine().Where(x => x != ' ').ToArray();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < wordSymbols.Length; i++)
            {
                if (!dict.ContainsKey(wordSymbols[i]))
                {
                    dict[wordSymbols[i]] = 0;
                }
                dict[wordSymbols[i]]++;
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
