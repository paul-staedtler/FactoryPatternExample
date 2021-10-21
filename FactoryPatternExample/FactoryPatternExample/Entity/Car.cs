using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Car : IVehicle
    {
        public Car()
        {
            Type = "Car";
        }

        public string Type { get; set; }
    }
}
