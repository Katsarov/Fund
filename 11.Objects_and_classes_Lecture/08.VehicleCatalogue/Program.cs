using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (input != "end")
            {
                string[] tokens = input.Split("/").ToArray();

                if (tokens[0] == "Car")
                {
                    Car car = new Car();

                    car.Brand = tokens[1];
                    car.Model = tokens[2];
                    car.HorsePower = int.Parse(tokens[3]);
                    
                    cars.Add(car);

                }

                else if (tokens[0] == "Truck")
                {
                    Truck truck = new Truck();

                    truck.Brand = tokens[1];
                    truck.Model = tokens[2];
                    truck.Weight = int.Parse(tokens[3]);

                    trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            List<Car> carsSorted = cars.OrderBy(car => car.Brand).ToList();
            List<Truck> trucksSorted = trucks.OrderBy(truck => truck.Brand).ToList();

            if (carsSorted.Count > 0)
            {
                Console.WriteLine("Cars:");
            }
            
            foreach (Car car in carsSorted)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (trucksSorted.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }

            foreach (Truck truck in trucksSorted)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class VehicleCatalogue
    {
        List<Car> cars { get; set; }
        List<Truck> trucks { get; set; }
    }
}
