using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___10._SoftUni_Exam_Results__Not_Required_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentStats = new Dictionary<string, int>();
            Dictionary<string, int> languageCountDict = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] tokens = input.Split('-');

                if (tokens[1] == "banned")
                {
                    string userToBan = tokens[0];

                    if (studentStats.ContainsKey(userToBan))
                    {
                        studentStats.Remove(userToBan);
                    }
                }
                else
                {
                    string username = tokens[0];
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (!studentStats.ContainsKey(username))
                    {
                        studentStats[username] = points;
                    }
                    else if (studentStats.ContainsKey(username))
                    {
                        if (studentStats[username] < points)
                        {
                            studentStats[username] = points;
                        }
                    }

                    if (!languageCountDict.ContainsKey(language))
                    {
                        languageCountDict[language] = 0;
                    }
                    languageCountDict[language]++;
                }
            }

            Console.WriteLine("Results:");
            foreach (var kvp in studentStats.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var kvp in languageCountDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
