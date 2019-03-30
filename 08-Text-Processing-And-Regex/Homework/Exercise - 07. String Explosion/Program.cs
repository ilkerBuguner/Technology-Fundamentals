using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int explosionStrength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (currentSymbol == '>')
                {
                    explosionStrength = input[i + 1];
                    input.Remove(i + 1, explosionStrength);

                }
            }

            Console.WriteLine(input);
        }
    }
}
