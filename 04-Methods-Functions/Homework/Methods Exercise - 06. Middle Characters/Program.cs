using System;

namespace Methods_Exercise___06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int inputLength = input.Length;
            ifLengthOfTheInputIsOdd(input, inputLength);
        }

        private static void ifLengthOfTheInputIsOdd(string input, int inputLength)
        {
            if (inputLength % 2 == 1)
            {
                int rightSum = inputLength;
                int leftSum = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    rightSum -= 1;

                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(input[i]);
                    }
                    leftSum += 1;
                }


            }
            else if (inputLength % 2 == 0)
            {
                int rightSum = inputLength;
                int leftSum = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    rightSum -= 1;
                    leftSum += 1;

                    if (leftSum == rightSum)
                    {
                        Console.WriteLine($"{input[i]}{input[i + 1]}");
                    }
                }

            }
        }
    }
}
