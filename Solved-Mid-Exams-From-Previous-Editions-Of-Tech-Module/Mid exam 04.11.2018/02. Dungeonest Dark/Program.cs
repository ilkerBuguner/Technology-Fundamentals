using System;
using System.Collections.Generic;
using System.Linq;

namespace Mid_Exam___Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;

            string[] rooms = Console.ReadLine().Split('|');

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currentRoom = rooms[i].Split(' ');

                if (currentRoom[0] == "potion")
                {
                    int healPotion = int.Parse(currentRoom[1]);

                    if (healPotion + health >= 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        health += healPotion;
                        Console.WriteLine($"You healed for {healPotion} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    
                }
                else if (currentRoom[0] == "chest")
                {
                    int coinsToAdd = int.Parse(currentRoom[1]);

                    coins += coinsToAdd;
                    Console.WriteLine($"You found {coinsToAdd} coins.");

                }
                else
                {
                    string monsterName = currentRoom[0];
                    int monstersAttack = int.Parse(currentRoom[1]);

                    health -= monstersAttack;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monsterName}.");
                    }
                    else if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monsterName}.");
                        Console.WriteLine($"Best room: {i+1}");
                        break;
                    }
                }
                
            }

            if (health > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
