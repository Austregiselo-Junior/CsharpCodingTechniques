using System;

namespace AbstraticClassXInterface.AbstraticClass
{
    internal class Circle : Shape
    {
        readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public override string Gettype()
        {
            return this.GetType().Name;
        }
    }
}
