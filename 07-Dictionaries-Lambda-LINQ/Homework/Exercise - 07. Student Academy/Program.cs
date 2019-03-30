using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string, List<double>> studentDict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (studentDict.ContainsKey(studentName) == false)
                {
                    studentDict[studentName] = new List<double>();

                }
                studentDict[studentName].Add(studentGrade);

            }

            //.Where(x => x.Value >= 4.50).OrderByDescending(x => x.Value)

            foreach (var kvp in studentDict.Where(x => x.Value.Average() >= 4.50).OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
            }
        }
    }
}
