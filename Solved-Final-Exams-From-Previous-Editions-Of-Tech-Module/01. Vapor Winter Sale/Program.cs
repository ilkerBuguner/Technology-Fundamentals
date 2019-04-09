using System;
using System.Collections.Generic;
using System.Linq;

namespace TechModule_Final_Retake_Exam_20._12._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DLCAndPrice> gamesDictionary = new Dictionary<string, DLCAndPrice>();

            string[] games = Console.ReadLine().Split(", ");

            for (int i = 0; i < games.Length; i++)
            {
                string currentGame = games[i];
                if (currentGame.Contains('-'))
                {
                    string[] gameAndPrice = currentGame.Split('-');
                    string game = gameAndPrice[0];
                    double price1 = double.Parse(gameAndPrice[1]);
                    DLCAndPrice price = new DLCAndPrice();
                    price.Price = price1;

                    gamesDictionary.Add(game, price);

                }
                else if (currentGame.Contains(':'))
                {
                    string[] gameAndDlc = currentGame.Split(':');
                    string game = gameAndDlc[0];
                    string DLC = gameAndDlc[1];

                    if (gamesDictionary.ContainsKey(game))
                    {
                        gamesDictionary[game].DLC = DLC;
                        gamesDictionary[game].Price = gamesDictionary[game].Price + (gamesDictionary[game].Price * 0.20);
                    }
                }
            }

            foreach (var game in gamesDictionary)
            {
                if (game.Value.DLC == null)
                {
                    game.Value.Price = game.Value.Price - (game.Value.Price * 0.20);
                }
                else
                {
                    game.Value.Price = game.Value.Price - (game.Value.Price * 0.50);
                }
            }

            foreach (var game in gamesDictionary.OrderBy(x => x.Value.Price))
            {
                if (game.Value.DLC != null)
                {
                    Console.WriteLine($"{game.Key} - {game.Value.DLC} - {game.Value.Price:F2}");
                }
            }

            foreach (var game in gamesDictionary.OrderByDescending(x => x.Value.Price))
            {
                if (game.Value.DLC == null)
                {
                    Console.WriteLine($"{game.Key} - {game.Value.Price:F2}");
                }
            }
        }
    }

    class DLCAndPrice
    {
        public string DLC { get; set; }

        public double Price { get; set; }
    }
}
