using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectAndClasses_Exercise___06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] vehicleProps = input.Split(' ');

                string type = vehicleProps[0];
                string model = vehicleProps[1];
                string color = vehicleProps[2];
                double horsePower = double.Parse(vehicleProps[3]);

                if (type == "Car" || type == "car")
                {
                    Car car = new Car() { Model = model, Color = color, HorsePower = horsePower };
                    cars.Add(car);

                }
                if (type == "Truck" || type == "truck")
                {
                    Truck truck = new Truck() { Model = model, Color = color, HorsePower = horsePower };
                    trucks.Add(truck);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }

                foreach (var car in cars)
                {
                    if (car.Model == input)
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                    }
                }

                foreach (var truck in trucks)
                {
                    if (truck.Model == input)
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                    }
                }


            }

            double totalHorsePowerOfCars = 0.0;
            foreach (var car in cars)
            {
                totalHorsePowerOfCars += car.HorsePower;
            }

            var averageCars = 0.0;
            if (cars.Count > 0)
            {
                averageCars = totalHorsePowerOfCars / cars.Count;
            }
            else
            {
                averageCars = 0.0;
            }


            var sumTrucks = 0.0;
            foreach (var item in trucks)
            {
                sumTrucks += item.HorsePower;
            }
            var averageTrucks = 0.0;
            if (trucks.Count > 0)
            {
                averageTrucks = sumTrucks / trucks.Count;
            }
            else
            {
                averageTrucks = 0.0;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCars:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:F2}.");

        }
    }

    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

    }

    class Truck
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }
}
