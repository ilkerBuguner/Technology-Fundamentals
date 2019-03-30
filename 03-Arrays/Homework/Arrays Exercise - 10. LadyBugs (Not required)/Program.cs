using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_Exercise___10._LadyBugs__Not_required_
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugsIndexes = new int[fieldSize];
            int[] ladyBugsIndexesAsInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < ladyBugsIndexesAsInput.Length; i++)
            {
                ladyBugsIndexes[i] = ladyBugsIndexesAsInput[i];
            }

            Console.WriteLine(string.Join(" ", ladyBugsIndexes));
        }
    }
}
