using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListOfShapes = new List<IShape>
            {
                new Triangle(),
                new Circle(),
                new Rectangle()
            };
            
            ListOfShapes.ForEach(
                shape => Console.WriteLine(shape.GetType().Name + " area = " + shape.PrintArea())
            );
        }
    }
}
