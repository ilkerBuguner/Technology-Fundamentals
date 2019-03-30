using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companiesDict = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] companyNameAndEmployeeID = input.Split(" -> ");

                string companyName = companyNameAndEmployeeID[0];
                string employeeID = companyNameAndEmployeeID[1];

                if (companiesDict.ContainsKey(companyName) == false)
                {
                    companiesDict[companyName] = new List<string>();
                }
                if (companiesDict[companyName].Contains(employeeID) == false)
                {
                    companiesDict[companyName].Add(employeeID);
                }

            }

            foreach (var kvp in companiesDict.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
