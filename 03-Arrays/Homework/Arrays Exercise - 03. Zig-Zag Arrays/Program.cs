using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Exercise___03.Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers1 = new int[n];
            int[] numbers2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    numbers1[i] = input[0];
                    numbers2[i] = input[1];
                }
                else if (i % 2 == 1)
                {
                    numbers1[i] = input[1];
                    numbers2[i] = input[0];
                }
            }

            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.Write(numbers1[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.Write(numbers2[i] + " ");
            }
        }
    }
}
