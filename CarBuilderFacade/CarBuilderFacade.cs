using System;
using DesignPatternExamples.Car_Builder;
using DesignPatternExamples.ICarParts;

namespace DesignPatternExamples
{
    public class CarBuilderFacade
    {
        private readonly IBody _body;
        private readonly IEngine _engine;
        private readonly IChassis _chassis;
        private readonly IInterior _interior;
        private readonly IWheels _wheels;

        public CarBuilderFacade()
        {
            _body = new Body();
            _engine = new Engine();
            _interior = new Interior();
            _chassis = new Chassis();
            _wheels = new Wheels();
        }

        public void  BuildCar()
        {
            _chassis.AddChassis();
            _wheels.AddWheels(4);
            _engine.AddEngine();
            _body.AddBody();
            _interior.AddInterior();

             Console.WriteLine("Car built successfully\n");
        }

        public void ShowCar()
        {
           var coupe = new Coupe();
           coupe.Show();
        }
    }
}
