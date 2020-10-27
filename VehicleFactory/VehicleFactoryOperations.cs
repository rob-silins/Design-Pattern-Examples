using System;
using DesignPatternExamples.Car_Builder;

namespace DesignPatternExamples
{
    public  class VehicleFactoryOperations : IVehicleFactoryOperations
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

        public  char MakeAnotherVehicle()
        {
            Console.WriteLine("");
            Console.WriteLine("Make another vehicle?");
            Console.WriteLine("Y for yes and N for no\n");

            var answer = '\0';
            while (answer != 'y' && answer != 'n')
            {
                var makeMoreVehicles = Console.ReadKey();
                char.TryParse(makeMoreVehicles.KeyChar.ToString(), out answer);
                if (answer == 'n')
                {
                    Console.WriteLine("\nAlright, see you next time");
                    break;
                }
                Console.WriteLine($"\nA '{answer}' ? Can't work with that response!");
                Console.WriteLine(".... can you just give me a simple Y or N ?\n ");
            }
            return answer;
        }
    }
}
