using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderStandPatterns.FactoryPattern
{
    class Car : IVehicle
    {
        public int NumberOfWheels()
        {
            return 4;
        }

        public string VehicleType()
        {
            return "I am a Car";
        }
    }
}
