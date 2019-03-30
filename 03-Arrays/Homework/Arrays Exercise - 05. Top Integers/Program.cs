using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Exercise___05.Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (currentNumber <= numbers[j])
                    {
                        break;
                    }
                    if (j == numbers.Length - 1)
                    {
                        Console.Write(currentNumber + " ");
                    }
                }
            }

            Console.WriteLine(numbers[numbers.Length - 1]);
            
        }
    }
}
