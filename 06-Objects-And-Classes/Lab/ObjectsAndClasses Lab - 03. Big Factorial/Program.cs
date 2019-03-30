using System;
using System.Numerics;

namespace ObjectsAndClasses_Lab___03._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factiorialNum = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 1; i <= factiorialNum; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);

        }
    }
}
