using System;

namespace Methods_Exercise___07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BlockOfNum(num);
        }

        private static void BlockOfNum(int num)
        {
            for (int rows = 0; rows < num; rows++)
            {
                for (int cols = 0; cols < num; cols++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
