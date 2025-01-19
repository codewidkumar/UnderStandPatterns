using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderStandPatterns.FactoryPattern
{
    class Auto : IVehicle
    {
        public int NumberOfWheels()
        {
            return 3;
        }

        public string VehicleType()
        {
            return "I am a Auto";
        }
    }
}
