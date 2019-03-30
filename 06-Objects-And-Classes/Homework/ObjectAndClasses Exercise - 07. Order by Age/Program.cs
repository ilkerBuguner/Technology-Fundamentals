using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectAndClasses_Exercise___07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] personInfo = input.Split(' ');

                string name = personInfo[0];
                string ID = personInfo[1];
                int age = int.Parse(personInfo[2]);

                Person newPerson = new Person();

                newPerson.Name = name;
                newPerson.ID = ID;
                newPerson.Age = age;

                listOfPersons.Add(newPerson);

            }

            listOfPersons = listOfPersons.OrderBy(x => x.Age).ToList();

            foreach (var person in listOfPersons)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }

        }
    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
