using System;

namespace Methods_Exercise___03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char startingChar = char.Parse(Console.ReadLine());
            char endingChar = char.Parse(Console.ReadLine());

            CharactersInRange(startingChar, endingChar);

        }

        private static void CharactersInRange(char startingChar, char endingChar)
        {
            int smalerChar = Math.Min(startingChar, endingChar);
            int biggerChar = Math.Max(startingChar, endingChar);
            for (int i = smalerChar + 1; i < biggerChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
