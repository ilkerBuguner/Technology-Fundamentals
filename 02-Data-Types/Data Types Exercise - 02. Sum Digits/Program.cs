using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Exercise___02.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num != 0)
            {
                int lastNumber = num % 10;
                num /= 10;

                sum += lastNumber;

            }

            Console.WriteLine(sum);
        }
    }
}
