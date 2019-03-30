using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> productsAndPricesDict = new Dictionary<string, List<double>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] productProps = input.Split(' ');

                string productName = productProps[0];
                double price = double.Parse(productProps[1]);
                int quantity = int.Parse(productProps[2]);

                if (productsAndPricesDict.ContainsKey(productName) == false)
                {
                    productsAndPricesDict[productName] = new List<double>();
                    productsAndPricesDict[productName].Add(quantity);
                    productsAndPricesDict[productName].Add(price);

                }
                else if (productsAndPricesDict.ContainsKey(productName) == true)
                {
                    productsAndPricesDict[productName][0] += quantity;
                    if (productsAndPricesDict[productName][1] != price)
                    {
                        productsAndPricesDict[productName][1] = price;
                    }
                }
            }

            foreach (var kvp in productsAndPricesDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value[0] * kvp.Value[1]:F2}");
            }
        }
    }
}
