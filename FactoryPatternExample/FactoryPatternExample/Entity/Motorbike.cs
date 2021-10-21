using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Motorbike : IVehicle
    {
        public Motorbike()
        {
            Type = "Motorbike";
        }

        public string Type { get; set; }
    }
}
