using System;
using System.Collections.Generic;
using System.Linq;

namespace Mid_exam___01
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int group = int.Parse(Console.ReadLine());
            double fuelPerKilometer = double.Parse(Console.ReadLine());
            double foodExpensesPerPersonInDay = double.Parse(Console.ReadLine());
            double oneNightPriceForPerson = double.Parse(Console.ReadLine());


            double totalFoodExpenses = days * group * foodExpensesPerPersonInDay;
            double totalHotelPrice = days * group * oneNightPriceForPerson;

            if (group > 10)
            {
                totalHotelPrice = totalHotelPrice - (totalHotelPrice * 0.25);
            }

            double currentExpenses = totalFoodExpenses + totalHotelPrice;

            for (int i = 1; i <= days; i++)
            {
                double travelledDistance = double.Parse(Console.ReadLine());

                double fuelExpensesForADay = travelledDistance * fuelPerKilometer;
                currentExpenses += fuelExpensesForADay;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    currentExpenses += currentExpenses * 0.4;
                }

                if (i % 7 == 0)
                {
                    double receivedMoney = currentExpenses / group;
                    currentExpenses -= receivedMoney;
                }

                if (currentExpenses > budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {currentExpenses - budget:F2}$ more.");
                    break;
                }
            }


            if (currentExpenses <= budget)
            {
                Console.WriteLine($"You have reached the destination. You have {budget - currentExpenses:F2}$ budget left.");
            }

        }
    }
}
