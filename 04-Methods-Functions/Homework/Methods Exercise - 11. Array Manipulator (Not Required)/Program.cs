using System;
using System.Linq;
using System.Collections.Generic;

namespace Methods_Exercise___11._Array_Manipulator__Not_Required_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(' ');

                if (tokens[0] == "exchange")
                {
                    int index = int.Parse(tokens[1]);

                    if (index <= numbers.Length - 1|| index < 0)
                    {
                        Exchange(numbers, index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                if (tokens[0] == "max")
                {
                    if (tokens[1] == "even")
                    {
                        MaxEvenChecker(numbers);
                    }
                    else if (tokens[1] == "odd")
                    {
                        MaxOddChecker(numbers);
                    }
                }
                if (tokens[0] == "min")
                {
                    if (tokens[1] == "even")
                    {
                        MinEvenChecker(numbers);
                    }
                    else if (tokens[1] == "odd")
                    {
                        MinOddChecker(numbers);
                    }
                }


                if (tokens[0] == "first")
                {

                    int count = int.Parse(tokens[1]);
                    int[] countedNumbers = new int[count];
                    if (count > numbers.Length - 1)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }


                    if (tokens[2] == "even")
                    {
                        FirstEvenOrOddNumbers(countedNumbers, numbers, count, 0);
                    }
                    else if (tokens[2] == "odd")
                    {
                        FirstEvenOrOddNumbers(countedNumbers, numbers, count, 1);
                    }
                }
                else if (tokens[0] == "last")
                {

                    int count = int.Parse(tokens[1]);

                    int[] countedNumbers = new int[count];
                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (tokens[2] == "even")
                    {
                        LastEvenOrOddNumbers(countedNumbers, numbers, count, 0);
                    }
                    else if (tokens[2] == "odd")
                    {
                        LastEvenOrOddNumbers(countedNumbers, numbers, count, 1);
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void LastEvenOrOddNumbers(int[] countedNumbers, int[] numbers, int count, int devisionResult)
        {
            int currentCount = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == devisionResult && currentCount < count)
                {
                    countedNumbers[currentCount] = numbers[i];
                    currentCount++;
                }
            }

            Array.Reverse(countedNumbers);

            if (currentCount >= count)
            {
                Console.WriteLine($"[{string.Join(", ", countedNumbers)}]");

            }
            else
            {
                Array.Reverse(countedNumbers);
                int[] temporaryArr = new int[currentCount];
                Array.Copy(countedNumbers, temporaryArr, currentCount);
                Console.WriteLine($"[{string.Join(", ", temporaryArr)}]");
            }
        }

        private static void FirstEvenOrOddNumbers(int[] countedNumbers, int[] numbers, int count, int devisionResult)
        {
            int currentCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == devisionResult && currentCount < count)
                {
                    countedNumbers[currentCount] = numbers[i];
                    currentCount++;
                }
            }


            if (currentCount >= count)
            {
             Console.WriteLine($"[{string.Join(", ", countedNumbers)}]");

            }
            else
            {
                int[] temporaryArr = new int[currentCount];
                Array.Copy(countedNumbers, temporaryArr, currentCount);
                Console.WriteLine($"[{string.Join(", ", temporaryArr)}]");
            }

        }

        private static void MinOddChecker(int[] numbers)
        {
            int minOddNum = int.MaxValue;
            int minOddIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    if (minOddNum >= numbers[i])
                    {
                        minOddNum = numbers[i];
                        minOddIndex = i;
                    }
                }
            }
            if (minOddIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minOddIndex);
            }
        }

        private static void MinEvenChecker(int[] numbers)
        {
            int minEvenNum = int.MaxValue;
            int minEvenIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (minEvenNum >= numbers[i])
                    {
                        minEvenNum = numbers[i];
                        minEvenIndex = i;
                    }
                }
            }
            if (minEvenIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minEvenIndex);
            }
        }

        private static void MaxOddChecker(int[] numbers)
        {
            int maxOddNum = int.MinValue;
            int maxOddIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    if (maxOddNum <= numbers[i])
                    {
                        maxOddNum = numbers[i];
                        maxOddIndex = i;
                    }
                }
            }
            if (maxOddIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxOddIndex);
            }
        }

        private static void MaxEvenChecker(int[] numbers)
        {
            int maxEvenNum = int.MinValue;
            int maxEvenIndex = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (maxEvenNum <= numbers[i])
                    {
                        maxEvenNum = numbers[i];
                        maxEvenIndex = i;
                    }
                }
            }
            if (maxEvenIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxEvenIndex);
            }
        }

        private static void Exchange(int[] numbers, int index)
        {
            for (int i = 0; i < index + 1; i++)
            {
                int firstNumber = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = firstNumber;


            }
            
        }
    }
}
