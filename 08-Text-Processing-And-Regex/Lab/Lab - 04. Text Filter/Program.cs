using System;

namespace Lab___04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                string wordAsterisks = "";
                for (int i = 0; i < word.Length; i++)
                {
                    wordAsterisks += '*';
                }
                text = text.Replace(word, wordAsterisks);
            }

            Console.WriteLine(text);
        }
    }
}
