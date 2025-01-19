using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderStandPatterns.FactoryPattern
{
   public interface IVehicle
    {
        string VehicleType();
        int NumberOfWheels();
    }
}
