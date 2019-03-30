using System;
using System.Text.RegularExpressions;

namespace Lab___07._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})([-./])(?<month>[A-Z][a-z]{2})(\1)(?<year>\d{4})\b";
            string years = Console.ReadLine();

            MatchCollection matches = Regex.Matches(years, regex);

            foreach (Match dates in matches)
            {
                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}",
                    dates.Groups["day"],
                    dates.Groups["month"],
                    dates.Groups["year"]);
            }
        }
    }
}
