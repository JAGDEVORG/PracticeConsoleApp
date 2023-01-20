using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            VehocleFactory factory = new VehocleFactory();
            IVehicle vehicle = factory.GetVehicle("Bike");
            Console.WriteLine(vehicle.NumberOfWheels());
            Console.WriteLine(vehicle.VehicleType());

            vehicle = factory.GetVehicle("Car");
            Console.WriteLine(vehicle.NumberOfWheels());
            Console.WriteLine(vehicle.VehicleType());

            Console.WriteLine("Main Method!");
        }
    }
    public class VehocleFactory
    {
        public IVehicle GetVehicle(string type)
        {
            IVehicle vehicle = null;
            if (type == "Bike")
            {
                vehicle = new Bike();
            }
            else if (type == "Car")
            {
                vehicle = new Car();
            }
            return vehicle;
        }
    }


    public interface IVehicle
    {
        string VehicleType();
        int NumberOfWheels();
    }
    public class Bike : IVehicle
    {
        private readonly int wheels;
        public Bike()
        {
            this.wheels = 2;
        }
        public int NumberOfWheels()
        {
            return wheels;
        }

        public string VehicleType()
        {
            return "2 Wheeler";
        }
    }
    public class Car : IVehicle
    {
        private readonly int wheels;
        public Car()
        {
            this.wheels = 4;
        }
        public int NumberOfWheels()
        {
            return wheels;
        }

        public string VehicleType()
        {
            return "4 Wheeler";
        }
    }
}
