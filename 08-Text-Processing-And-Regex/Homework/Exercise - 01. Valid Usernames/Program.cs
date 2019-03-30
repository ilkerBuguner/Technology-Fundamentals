using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");
            List<string> validWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word.Length > 3 && word.Length < 16)
                {
                    bool isValid = true;
                    foreach (var character in word)
                    {
                        if (char.IsLetterOrDigit(character) || character == '-' || character == '_')
                        {
                            continue;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }

                    if (isValid == true)
                    {
                        validWords.Add(word);
                    }
                }
                
            }

            foreach (var word in validWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
