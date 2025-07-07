using System;

namespace AbstraticClassXInterface.AbstraticClass
{
    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();

        public abstract string Gettype();
        public void Display() => Console.WriteLine($"Tipo: {GetType():F2}, Area: {GetArea():F2}, Perimeter: {GetPerimeter():F2}");

    }
}
