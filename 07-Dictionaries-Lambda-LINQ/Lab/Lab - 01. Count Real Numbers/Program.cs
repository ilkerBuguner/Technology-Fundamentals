using System;
using System.Linq;
using System.Collections.Generic;

namespace Associative_Arrays_Lab_and_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var dict = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (dict.ContainsKey(number))
                {
                    dict[number]++;
                }
                else
                {
                    dict[number] = 1;
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
