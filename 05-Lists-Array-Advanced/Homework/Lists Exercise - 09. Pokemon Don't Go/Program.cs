using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise___09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int sumOfAllRemovedNumbers = 0;

            while (numbers.Count != 0)
            {
                int indexOfTheNumber = int.Parse(Console.ReadLine());

                if (indexOfTheNumber < 0)
                {
                    sumOfAllRemovedNumbers += numbers[0];
                    numbers.RemoveAt(0);
                    int lastNumber = numbers[numbers.Count - 1];
                    numbers.Insert(0, lastNumber);
                }

                if (indexOfTheNumber > numbers.Count - 1)
                {
                    sumOfAllRemovedNumbers += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    int firstNumber = numbers[0];
                    numbers.Insert(numbers[numbers.Count - 1], firstNumber);
                }

                if (indexOfTheNumber >= 0 && indexOfTheNumber < numbers.Count)
                {
                    int currentReceivedNum = numbers[indexOfTheNumber];

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (i == 0)
                        {
                            sumOfAllRemovedNumbers += numbers[indexOfTheNumber];
                            numbers.RemoveAt(indexOfTheNumber);
                            
                        }

                        if (numbers.Count >= 1)
                        {
                        if (currentReceivedNum >= numbers[i])
                        {
                            numbers[i] += currentReceivedNum;
                        }
                        else if (currentReceivedNum < numbers[i])
                        {
                            numbers[i] -= currentReceivedNum;
                        }

                        }

                    }
                }


            }

            Console.WriteLine(sumOfAllRemovedNumbers);

        }
    }
}
