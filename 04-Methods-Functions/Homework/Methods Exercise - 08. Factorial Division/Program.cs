using System;

namespace Methods_Exercise___08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double factorialOfNum1 = FactorialFinder(num1);
            double factorialOfNum2 = FactorialFinder(num2);

            double finalResult = factorialOfNum1 / factorialOfNum2;

            Console.WriteLine($"{finalResult:F2}");
        }

        private static double FactorialFinder(int num)
        {
            double factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
