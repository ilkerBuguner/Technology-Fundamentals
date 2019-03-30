using System;
using System.Collections.Generic;

namespace ObjectsAndClasses_Lab___08._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogOfVehicles vehicles = new CatalogOfVehicles();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] vehicleInfo = input.Split('/');

                string typeOfVehicle = vehicleInfo[0];

                if (typeOfVehicle == "Car")
                {
                    Car Car = new Car();

                    string brand = vehicleInfo[1];
                    string model = vehicleInfo[2];
                    int horsePower = int.Parse(vehicleInfo[3]);

                    CatalogOfVehicles.
                }
                else if (typeOfVehicle == "Truck")
                {
                    Truck Truck = new Truck();

                    string brand = vehicleInfo[1];
                    string model = vehicleInfo[2];
                    int weight = int.Parse(vehicleInfo[3]);
                }
            }
        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

    class CatalogOfVehicles
    {
        //public CatalogOfVehicles()
        //{
        //    Trucks = new Truck();
        //    Cars = new Car();
        //}
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}
