using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfShapes = new List<IShape>
            {
                new Triangle(),
                new Circle(),
                new Rectangle()
            };
            
            listOfShapes.ForEach(shape => shape.printArea());
        }
    }
}
