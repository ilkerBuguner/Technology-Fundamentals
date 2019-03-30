using System;
using System.Collections.Generic;
using System.Linq;

namespace Mid_exam___03._Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] tokens = input.Split(' ').ToArray();

                if (tokens[0] == "Change")
                {
                    int numberToRemove = int.Parse(tokens[1]);
                    int numberToPlace = int.Parse(tokens[2]);

                    if (numbers.Contains(numberToRemove))
                    {
                        int numberToRemoveIndex = numbers.IndexOf(numberToRemove);
                        numbers.Remove(numberToRemove);
                        numbers.Insert(numberToRemoveIndex, numberToPlace);
                    }
                }

                if (tokens[0] == "Hide")
                {
                    int number = int.Parse(tokens[1]);

                    if (numbers.Contains(number))
                    {
                        numbers.Remove(number);
                    }
                }

                if (tokens[0] == "Switch")
                {
                    int numberToSwitch1 = int.Parse(tokens[1]);
                    int numberToSwitch2 = int.Parse(tokens[2]);

                    if (numbers.Contains(numberToSwitch1) && numbers.Contains(numberToSwitch2))
                    {
                        int indexOfFirstNumber = numbers.IndexOf(numberToSwitch1);
                        int indexOfSecondNUmber = numbers.IndexOf(numberToSwitch2);

                        numbers[indexOfFirstNumber] = numberToSwitch2;
                        numbers[indexOfSecondNUmber] = numberToSwitch1;
                    }
                }

                if (tokens[0] == "Insert")
                {
                    int indexToInsert = int.Parse(tokens[1]);
                    int numToInsert = int.Parse(tokens[2]);
                    
                    if (numbers.Count - 1 > indexToInsert)
                    {
                        numbers.Insert(indexToInsert + 1, numToInsert);
                    }
                }

                if (tokens[0] == "Reverse")
                {
                    numbers.Reverse();
                }
                
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
