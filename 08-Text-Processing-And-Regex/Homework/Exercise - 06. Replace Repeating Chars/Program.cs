using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<char> sortedWord = new List<char>();

            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0)
                {
                    sortedWord.Add(word[i]);
                }
                char currentSymbol = word[i];
                if (i+1 < word.Length)
                {
                    char nextSymbol = word[i + 1];

                    if (currentSymbol != nextSymbol)
                    {
                        sortedWord.Add(nextSymbol);
                    }
                }
                

            }

            Console.WriteLine(string.Join("", sortedWord));
        }
    }
}
