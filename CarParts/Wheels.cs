using System;
using DesignPatternExamples.ICarParts;

namespace DesignPatternExamples
{
    public class Wheels : IWheels
    {
        public void  AddWheels(int wheels)
        {
            Console.WriteLine("Added {0} wheels.\n", wheels);
        }
    }
}
