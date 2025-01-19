using System;

namespace UnderStandPatterns.FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFromConsole = null;
            Console.WriteLine("Enter Vehicle Type");
            inputFromConsole = Console.ReadLine();
            IVehicle Type = VehicleFactory.GetVehicle(inputFromConsole);
            Console.WriteLine("Vehicle is : " + Type.VehicleType());
            Console.WriteLine("Number of wheels : " + Type.NumberOfWheels());
            Console.ReadKey();
        }
    }
}
