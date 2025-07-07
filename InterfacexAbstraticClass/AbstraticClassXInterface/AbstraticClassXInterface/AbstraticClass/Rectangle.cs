namespace AbstraticClassXInterface.AbstraticClass
{
    internal class Rectangle : Shape
    {
        readonly double _length;
        readonly double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public override double GetArea()
        {
            return _length * _width;
        }

        public override double GetPerimeter()
        {
            return 2 * (_length + _width);
        }

        public override string Gettype()
        {
            return this.GetType().Name;
        }
    }
}
