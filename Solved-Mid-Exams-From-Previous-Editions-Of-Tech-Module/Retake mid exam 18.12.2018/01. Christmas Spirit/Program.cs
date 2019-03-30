using System;
using System.Collections.Generic;
using System.Linq;


namespace Mid_exam___01._Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            //Ornament Set – 2$ a piece
            //Tree Skirt – 5$ a piece
            //Tree Garlands – 3$ a piece
            //Tree Lights – 15$ a piece


            int totalSpirit = 0;
            int totalCost = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }

                if (i % 2 == 0)
                {
                    totalCost += 2 * quantity;
                    totalSpirit += 5;
                }

                if (i % 3 == 0)
                {
                    totalCost += 5 * quantity;
                    totalCost += 3 * quantity;
                    totalSpirit += 13;
                }

                if (i % 5 == 0)
                {
                    totalCost += 15 * quantity;
                    totalSpirit += 17;

                    if (i % 3 == 0)
                    {
                        totalSpirit += 30;
                    }
                }

                if (i % 10 == 0)
                {
                    totalSpirit -= 20;
                    totalCost += 23;
                }

                

                if ((i == 10 && days % 10 == 0))
                {
                    totalSpirit -= 30;
                }
            }

            Console.WriteLine($"Total cost: {totalCost}");
            Console.WriteLine($"Total spirit: {totalSpirit}");
        }
    }
}
