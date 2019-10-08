using System;
using System.Collections.Generic;

namespace ShapeSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Triangle tri = new Triangle(3, 5);
            Square sq = new Square(5);
            Circle circ = new Circle(1);

            List<Shape> shapes = new List<Shape>();
            shapes.Add(circ);
            shapes.Add(tri);
            shapes.Add(sq);

            shapes.Sort();

        }
    }
}
