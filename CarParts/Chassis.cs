using System;
using DesignPatternExamples.ICarParts;

namespace DesignPatternExamples
{
    public class Chassis : IChassis
    {
        public void  AddChassis()
        {
            Console.WriteLine("Chassis added\n");
        }
    }
}
