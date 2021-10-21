using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of wheels between 1 and 12 to build a vehicle and press enter");

            string wheels = Console.ReadLine();
            IVehicle vehicle = VehicleFactory.Build(Convert.ToInt32(wheels));

            Console.WriteLine($" You built a {vehicle.Type}");
            Console.Read();
        }
    }
}
