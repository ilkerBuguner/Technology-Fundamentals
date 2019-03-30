using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Syntax_Exercise___06_Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfTheFactiorial = 0;
            int modifyNumber = number;


            while (modifyNumber != 0)
            {
                
                
                int currentDigit = modifyNumber % 10;
                modifyNumber = modifyNumber / 10;

                int factorialOfTheCurrentDigit = 1;

                for (int i = 2; i <= currentDigit; i++)
                {
                    factorialOfTheCurrentDigit *= i;
                }
                sumOfTheFactiorial += factorialOfTheCurrentDigit;
                
            }

            if (sumOfTheFactiorial == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
