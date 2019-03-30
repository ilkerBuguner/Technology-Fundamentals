using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Exercise___04_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
