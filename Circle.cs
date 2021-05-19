using System;

namespace Project
{
    public class Circle : IShape
    {
        public void printArea() => Console.WriteLine("Area of a circle = pi*r^2");
    }
}