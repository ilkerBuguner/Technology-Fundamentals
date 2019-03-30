using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Exercise___06_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rightSum = 0;
            int leftSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                rightSum += numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                rightSum -= numbers[i];

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum += numbers[i];
            }

            Console.WriteLine("no");
        }
    }
}
