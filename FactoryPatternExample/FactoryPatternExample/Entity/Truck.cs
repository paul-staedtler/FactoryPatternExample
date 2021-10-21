using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Truck : IVehicle
    {
        public Truck()
        {
            Type = "Truck";
        }

        public string Type { get; set; }
    }
}
