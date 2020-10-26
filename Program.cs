using System;

namespace DesignPatternExamples
{
    class Program 
    {
        static void Main(string[] args)
        {
            //var car = new CarBuilderFacade();
            //car.BuildCar();
            //car.ShowCar();

            var factory = new VehicleFactory();
            factory.BuiltAVehicle();

            Console.ReadKey();
        }
    }
}
