using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encryptedWord = string.Empty;

            //string pattern = @"[d-z}{|#]+";
            //Regex order = new Regex(pattern);
            //if (order.IsMatch(input))
            //{
            //    Console.WriteLine("This is not the book you are looking for.");
            //    return;
            //}
            bool isValid = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '}' || input[i] == '|' || input[i] == '#' || input[i] >= 100 && input[i] <= 122)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("This is not the book you are looking for.");
                    isValid = false;
                    return;
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                encryptedWord += (char)(currentChar - 3);
            }
            
            string[] substrings = Console.ReadLine().Split(' ');
            string substringToRemove = substrings[0];
            string substringToPlace = substrings[1];


            while (encryptedWord.Contains(substringToRemove))
            {
                encryptedWord = encryptedWord.Replace(substringToRemove, substringToPlace);

            }

            Console.WriteLine(encryptedWord);

            

        }
    }
}
