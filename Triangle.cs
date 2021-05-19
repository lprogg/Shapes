using System;

namespace Project
{
    public class Triangle : IShape
    {
        public void printArea() => Console.WriteLine("Area of a triangle = (b*h)/2");
    }
}