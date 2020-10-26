using System;
using DesignPatternExamples.ICarParts;

namespace DesignPatternExamples
{
    public class Engine :IEngine
    {
        public void AddEngine()
        {
            Console.WriteLine("Engine Added.\n");
        }
    }
}
