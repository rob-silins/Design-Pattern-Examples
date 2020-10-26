using System;
using DesignPatternExamples.Car_Builder;

namespace DesignPatternExamples
{
    public class VehicleFactoryOperations : IVehicleFactoryOperations
    {
        public  IVehicleMaker Validation(string carType)
        {
            IVehicleMaker vehicle = null;
            while (carType != "coupe" && carType != "truck")
            {
                Console.WriteLine(
                    "Currently we can only produce a coupe or a truck, whatever you selected, " +
                    "can't be done bro.... just trucks and coupes\n");
                Console.WriteLine("Try again - truck or coupe?\n");

                carType = Console.ReadLine()?.ToLower();
            }

            if (carType == "coupe")
            {
                vehicle = new Coupe();
                vehicle.Show();
            }

            if (carType == "truck")
            {
                vehicle = new Truck();
                vehicle.Show();
            }
            return vehicle;
        }

        public  string MakeAnotherVehicle()
        {
            Console.WriteLine("");
            Console.WriteLine("Make another vehicle?");
            Console.WriteLine("Y for yes and N for no\n");
            var makeMoreVehicles = Console.ReadLine();
            return makeMoreVehicles;
        }
    }
}
