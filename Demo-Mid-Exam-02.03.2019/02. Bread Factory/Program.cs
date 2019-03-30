using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo_mid_exam___02._Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] workDayEvents = Console.ReadLine().Split('|').ToArray();

            int energy = 100;
            int coins = 100;
            bool isHandledAllEvents = true;

            for (int i = 0; i < workDayEvents.Length; i++)
            {
                string currentEvent = workDayEvents[i];
                string[] currentEvenProps = currentEvent.Split('-');

                if (currentEvenProps[0] == "rest")
                {
                    int energyToGain = int.Parse(currentEvenProps[1]);

                    if (energy + energyToGain >= 100)
                    {
                        Console.WriteLine($"You gained {100 - energy} energy.");
                        energy = 100;
                    }
                    else
                    {
                        energy += energyToGain;
                        Console.WriteLine($"You gained {energyToGain} energy.");
                    }

                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (currentEvenProps[0] == "order")
                {
                    int coinsToEarn = int.Parse(currentEvenProps[1]);
                    energy -= 30;
                    if (energy >= 0)
                    {
                        Console.WriteLine($"You earned {coinsToEarn} coins.");
                        coins += coinsToEarn;
                    }
                    else if (energy < 0)
                    {
                        energy += 80;
                        Console.WriteLine("You had to rest!");

                    }
                }
                else
                {
                    string ingredientToBuy = currentEvenProps[0];
                    int ingredientPrice = int.Parse(currentEvenProps[1]);
                    coins -= ingredientPrice;
                    if (coins >= 0)
                    {
                        Console.WriteLine($"You bought {ingredientToBuy}.");
                    }
                    else if(coins <= 0)
                    {
                        Console.WriteLine($"Closed! Cannot afford {ingredientToBuy}.");
                        isHandledAllEvents = false;
                        break;
                    }
                }


            }

            if (isHandledAllEvents == true)
            {
                Console.WriteLine($"Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {energy}");
            }


        }
    }
}
