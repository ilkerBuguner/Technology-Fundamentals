using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Exercise___04.Sum_Of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());

                sum += character;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
