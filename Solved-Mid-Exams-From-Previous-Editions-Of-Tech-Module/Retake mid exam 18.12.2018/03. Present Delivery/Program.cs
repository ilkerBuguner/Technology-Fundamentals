using System;
using System.Collections.Generic;
using System.Linq;

namespace Mid_Exam___3._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();

            int santaIndex = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Merry Xmas!")
                {
                    break;
                }

                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Jump")
                {
                    int timesToJump = int.Parse(tokens[1]);

                    if (santaIndex + timesToJump >= houses.Count)
                    {
                        santaIndex = (santaIndex + timesToJump) % houses.Count;
                    }
                    else
                    {
                        santaIndex += timesToJump;
                    }

                    if (houses[santaIndex] == 0)
                    {
                        Console.WriteLine($"House {santaIndex} will have a Merry Christmas.");
                    }
                    else
                    {
                        houses[santaIndex] -= 2;
                    }
                }
            }

            Console.WriteLine($"Santa's last position was {santaIndex}.");

            List<int> filteredHouses = houses.Where(x => x != 0).ToList();

            if (filteredHouses.Count > 0)
            {
                Console.WriteLine($"Santa has failed {filteredHouses.Count} houses.");
            }
            else
            {
                Console.WriteLine($"Mission was successful.");
            }
        }
    }
}
