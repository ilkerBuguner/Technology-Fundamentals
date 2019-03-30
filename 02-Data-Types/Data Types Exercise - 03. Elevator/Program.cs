using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Exercise___03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfPeople = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());


            double courses = numOfPeople / capacity;

           
            Console.WriteLine(Math.Ceiling(courses));


        }
    }
}
