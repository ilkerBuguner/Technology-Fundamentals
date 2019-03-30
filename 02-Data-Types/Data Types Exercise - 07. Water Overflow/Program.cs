using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Exercise___07.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int quantity = int.Parse(Console.ReadLine());

                if (sum + quantity <= 255)
                {
                    sum += quantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                


            }

            Console.WriteLine(sum);

        }
    }
}
