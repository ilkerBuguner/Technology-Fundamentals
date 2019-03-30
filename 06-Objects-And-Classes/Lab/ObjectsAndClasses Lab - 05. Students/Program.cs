using System;
using System.Collections.Generic;

namespace ObjectsAndClasses_Lab___05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] studentInfo = input.Split(' ');

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                string age = studentInfo[2];
                string homeTown = studentInfo[3];


                if (IsStudentExisting(studentsList, firstName, lastName))
                {
                    Student student = GetStudent(studentsList, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student();

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;

                    studentsList.Add(student);
                }
                
            }

            string homeTownToAsk = Console.ReadLine();

            foreach (var student in studentsList)
            {
                if (student.HomeTown == homeTownToAsk)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        private static bool IsStudentExisting(List<Student> studentsList, string firstName, string lastName)
        {
            foreach (var student in studentsList)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }

        
    }
}
