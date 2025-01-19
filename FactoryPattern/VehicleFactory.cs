using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderStandPatterns.FactoryPattern
{
    class VehicleFactory
    {
        public static IVehicle GetVehicle(string Type)
        {
            IVehicle ObjectType = null;
            if (Type.ToLower().Equals("car"))
            {
                ObjectType = new Car();
            }
            if (Type.ToLower().Equals("auto"))
            {
                ObjectType = new Auto();
            }
            if (Type.ToLower().Equals("truck"))
            {
                ObjectType = new Truck();
            }

            return ObjectType;
        }
    }
}
