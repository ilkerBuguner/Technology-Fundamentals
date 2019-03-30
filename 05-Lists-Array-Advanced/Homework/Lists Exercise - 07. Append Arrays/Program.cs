using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise___07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .Reverse()
                .ToList();
            


            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
