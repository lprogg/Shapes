using System;

namespace Project
{
    public class Rectangle : IShape
    {
        public void printArea() => Console.WriteLine("Area of a rectangle = l*w");
    }
}