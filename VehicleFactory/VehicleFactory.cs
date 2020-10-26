using System;

namespace DesignPatternExamples
{
    public class VehicleFactory
    {
         private readonly IVehicleFactoryOperations _operations;

         public VehicleFactory()
         {
             _operations = new VehicleFactoryOperations();
         }
        
        public  IVehicleMaker BuiltAVehicle()
        {
            Console.WriteLine(
                "Hi boss! Please select what type of vehicles we will be making today?\n" +
                "Remember, we only make Coupes and Trucks (one unit per production).");

            string carType = Console.ReadLine()?.ToLower();
            
            _operations.Validation(carType);
            
            var makeMoreVehicles = _operations.MakeAnotherVehicle();

            while (makeMoreVehicles == "y")
            {
                Console.WriteLine("\nWhat are we making next ?\n");
                carType = Console.ReadLine()?.ToLower();
                Console.WriteLine("");

                _operations.Validation(carType);
                makeMoreVehicles = _operations.MakeAnotherVehicle();
            }
            return null;
        }
    }
}
