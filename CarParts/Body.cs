using System;
using DesignPatternExamples.ICarParts;

namespace DesignPatternExamples
{
    public class Body : IBody
    {
        public void AddBody()
        {
            Console.WriteLine("Car body added.\n");
        }
    }
}
