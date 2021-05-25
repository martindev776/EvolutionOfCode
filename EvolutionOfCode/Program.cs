using System;
using System.Linq;
using EvolutionOfCode.Assignment2_2;

namespace EvolutionOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = Enumerable.Range(0, 9);
            var stuff = (new StrategiesShapes()).Run();

            Console.WriteLine("Hello World!");
        }
    }
}
