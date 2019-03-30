using System;
using System.Text.RegularExpressions;

namespace Exercise___08._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            MatchCollection regex = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(" ", regex));
        }
    }
}
