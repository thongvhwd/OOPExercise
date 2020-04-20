using Exercise3.Models;
using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new Shape[] {
                new Circle() {Width = 10},
                new Rectangle() { Width = 10, Height= 5 },
                new Triangle()
                {
                    Height = 10,
                    Width = 20
                }
            };
            Console.WriteLine($"Surface area of shapes in array:");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name}: {shape.CalculateSurface()}");
            }
            Console.ReadLine();
        }
    }
}
