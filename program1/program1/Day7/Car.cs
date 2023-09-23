using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Day7
{
        public enum FuelType
        {
            Petrol,
            Diesel
        }

    public class Car
    {
        public string RegistrationNo;
        public string Model;
        public FuelType FuelType;
        public Wheel[] Wheels { get; } = new Wheel[4];
        public Engine CarEngine;

        public Car(string registrationNo, string model, FuelType fuelType)
        {
            RegistrationNo = registrationNo;
            Model = model;
            FuelType = fuelType;

            for (int i = 0; i < 4; i++)
            {
                Wheels[i] = new Wheel();
            }
            CarEngine = new Engine();
        }
        public class Wheel
        {
        }
        public class Engine
        {

        }
    }
        class car
        {
        public static void TestCar()
        {
            Car myCar = new Car("001", "XUV300", FuelType.Petrol);
            Console.WriteLine($"Registration No: {myCar.RegistrationNo}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Fuel Type: {myCar.FuelType}");

            Console.WriteLine("Wheels:");
            foreach (var wheel in myCar.Wheels)
            {
                Console.WriteLine("Wheel:");
            }
            Console.WriteLine("Car :");
            Console.WriteLine("Engine:");
        }
    }
}


