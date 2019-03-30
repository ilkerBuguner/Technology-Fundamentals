using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectsAndClasses_Lab___04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> listOfStudents = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] studentProps = Console.ReadLine().Split(' ');

                Student student = new Student();

                student.FirstName = studentProps[0];
                student.LastName = studentProps[1];
                student.Grade = double.Parse(studentProps[2]);

                listOfStudents.Add(student);
            }

            listOfStudents = listOfStudents.OrderByDescending(x => x.Grade).ToList();

            foreach (var student in listOfStudents)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade}";
        }
    }
}
