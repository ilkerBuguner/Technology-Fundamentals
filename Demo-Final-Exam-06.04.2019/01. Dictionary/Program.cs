using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(" | ");

            for (int i = 0; i < input.Length; i++)
            {
                string currentInput = input[i];
                string[] currentInputAsArray = currentInput.Split(": ");
                string word = currentInputAsArray[0];
                string definition = currentInputAsArray[1];

                if (dict.ContainsKey(word))
                {
                    dict[word].Add(definition);
                }
                else
                {
                    dict[word] = new List<string>();
                    dict[word].Add(definition);
                }

            }

            string[] wordsToShow = Console.ReadLine().Split(" | ");

            for (int i = 0; i < wordsToShow.Length; i++)
            {
                string word = wordsToShow[i];
                if (dict.ContainsKey(word))
                {
                    Console.WriteLine(word);
                    foreach (var definition in dict[word].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($"-{definition}");
                    }
                }
            }

            string command = Console.ReadLine();

            if (command == "End")
            {
                return;
            }
            else if (command == "List")
            {
                foreach (var word in dict.OrderBy(x => x.Key))
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
