using System;
using DesignPatternExamples.ICarParts;

namespace DesignPatternExamples
{
    public class Interior : IInterior
    {
        public void AddInterior()
        {
            Console.WriteLine("Interior installed.\n");
        }
    }
}
