using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public static class VehicleFactory
    {
        public static IVehicle Build(int numberOfWheels)
        {
            switch (numberOfWheels)
            {
                case 2:
                    return new Motorbike();
                case 4:
                    return new Car();
                default:
                    return new Truck();
            }
        }
    }
}
