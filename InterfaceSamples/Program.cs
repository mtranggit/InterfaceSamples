using PolygonLibrary;
using System;

namespace InterfaceSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square", square);
            var triangle = new Triangle(5);
            DisplayPolygon("Triangle", triangle);
            var pentagon = new Pentagon(5);
            DisplayPolygon("Pentagon", pentagon);
            var octagon = new Octagon(5);
            DisplayPolygon("Octagon", octagon);
        }

        private static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine($"{polygonType} Number of Sides: {polygon.NumberOfSides}");
                Console.WriteLine($"{polygonType} Side Length: {polygon.SideLength}");
                Console.WriteLine($"{polygonType} Perimter: {polygon.GetPerimeter()}");
                Console.WriteLine($"{polygonType} Area: {Math.Round(polygon.GetArea(), 2)}");
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception was thrown while trying to process {polygonType}:\n {ex.GetType().Name}");
                Console.WriteLine();
            }
        }
    }
}
