using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] courseAndStudentName = input.Split(" : ");

                string courseName = courseAndStudentName[0];
                string studentName = courseAndStudentName[1];

                if (courses.ContainsKey(courseName) == false)
                {
                    courses[courseName] = new List<string>();
                }

                courses[courseName].Add(studentName);
            }
            

            foreach (var kvp in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.Write($"{kvp.Key}: {kvp.Value.Count}");
                Console.WriteLine();
                foreach (var item in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
