using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string encryptedWord = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                char currendChar = word[i];

                encryptedWord += (char)(currendChar + 3);
            }

            Console.WriteLine(encryptedWord);
        }
    }
}
