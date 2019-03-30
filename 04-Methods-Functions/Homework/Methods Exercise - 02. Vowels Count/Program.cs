using System;

namespace Methods_Exercise___02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            

            VowelCounter(input);


        }

        private static void VowelCounter(string input)
        {
            int vowelsCount = 0;

            for (int i = 0; i < input.Length; i++)
            {

                char currentChar = input[i];

                if (currentChar == 'a' || currentChar == 'u' || currentChar == 'i' || currentChar == 'e'
                    || currentChar == 'o' || currentChar == 'y')
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
