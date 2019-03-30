using System;
using System.Text.RegularExpressions;

namespace Exercise___08._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([- ])2\1\d{3}\1\d{4}\b";
            string years = Console.ReadLine();

            MatchCollection matches = Regex.Matches(years, pattern);

            Console.WriteLine(string.Join(", ", matches));
            
        }
    }
}
