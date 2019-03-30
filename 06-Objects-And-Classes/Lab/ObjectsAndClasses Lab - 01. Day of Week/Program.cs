using System;
using System.Globalization;

namespace ObjectsAndClasses_Lab___01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();

            DateTime timeAsDateTime = DateTime.ParseExact(time, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(timeAsDateTime.DayOfWeek);
        }
    }
}
