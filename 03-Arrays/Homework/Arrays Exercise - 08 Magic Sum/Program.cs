using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Exercise___08_Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNumber = numbers[j];
                    if (currentNumber + nextNumber == number)
                    {
                        Console.WriteLine($"{currentNumber} {nextNumber}");
                    }
                }
            }
        }
    }
}
