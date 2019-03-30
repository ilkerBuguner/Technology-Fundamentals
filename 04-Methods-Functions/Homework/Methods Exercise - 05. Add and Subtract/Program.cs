using System;

namespace Methods_Exercise___05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = SumOfFirstTwoNums(num1, num2);
            int subtract = SubtractOfSumWithLastNum(sum, num3);

            Console.WriteLine(subtract);
        }

        private static int SumOfFirstTwoNums(int num1, int num2)
        {
            return num1 + num2;
        }

        private static int SubtractOfSumWithLastNum(int sum,int num3)
        {
            return sum - num3;
        }
    }
}
