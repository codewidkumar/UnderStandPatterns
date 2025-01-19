using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderStandPatterns.FactoryPattern
{
    class Truck : IVehicle
    {
        public int NumberOfWheels()
        {
            return 8;
        }

        public string VehicleType()
        {
            return "I am a Truck";
        }
    }
}
