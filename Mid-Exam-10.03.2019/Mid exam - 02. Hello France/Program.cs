using System;
using System.Collections.Generic;
using System.Linq;

namespace Mid_exam___02._Hello_France
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] itemsToBuy = Console.ReadLine().Split('|');
            double budget = double.Parse(Console.ReadLine());

            double clothesMaximumPrice = 50.00;
            double shoesMaximumPrice = 35.00;
            double accessoriesMaximumPrice = 20.50;

            List<double> newPricesList = new List<double>();
            double profit = 0;

            for (int i = 0; i < itemsToBuy.Length; i++)
            {
                string[] currentItemAndPrice = itemsToBuy[i].Split("->");

                string item = currentItemAndPrice[0];
                double price = double.Parse(currentItemAndPrice[1]);

                if (budget < price)
                {
                    break;
                }

                if (item == "Clothes")
                {
                    if (budget >= price && price <= clothesMaximumPrice)
                    {
                        budget -= price;
                        newPricesList.Add(price);
                    }
                }
                else if (item == "Shoes")
                {
                    if (budget >= price && price <= shoesMaximumPrice)
                    {
                        budget -= price;
                        newPricesList.Add(price);
                    }
                }
                else if (item == "Accessories")
                {
                    if (budget >= price && price <= accessoriesMaximumPrice)
                    {
                        budget -= price;
                        newPricesList.Add(price);
                    }
                }

            }

            for (int i = 0; i < newPricesList.Count; i++)
            {
                double previousPrice = newPricesList[i];
                newPricesList[i] = newPricesList[i] + (newPricesList[i] * 0.40);

                profit += newPricesList[i] - previousPrice;
            }

            double totalMoneySum = budget + newPricesList.Sum();

            foreach (var item in newPricesList)
            {
                Console.Write($"{item:F2} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:F2}");

            if (totalMoneySum >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else if (totalMoneySum < 150)
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
