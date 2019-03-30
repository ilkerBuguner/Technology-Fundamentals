using System;

namespace Demo_mid_exam___01._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPriceOfPackage = double.Parse(Console.ReadLine());
            double priceOfSingleEgg = double.Parse(Console.ReadLine());
            double priceOFSingleApron = double.Parse(Console.ReadLine());

            int freePackages = students / 5;

            double neededItemsForStudents = priceOFSingleApron * (students + Math.Ceiling(students * 0.20)) + priceOfSingleEgg * 10 * students + flourPriceOfPackage * (students - freePackages);

            if (neededItemsForStudents <= budget)
            {
                Console.WriteLine($"Items purchased for {neededItemsForStudents:F2}$.");
            }

            if (neededItemsForStudents > budget)
            {
                Console.WriteLine($"{neededItemsForStudents - budget:F2}$ more needed.");
            }

        }
    }
}
