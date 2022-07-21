using System;

namespace HomeWork9
{
    internal class Square : Shape
    {
        private double side;
        private double area;
        private double perimeter;
        public double Side { get { return side; } set { side = value; } }
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return area = (Math.Pow(side, 2));
        }
        public override double Perimeter()
        {
            return perimeter = side * 4;
        }
        public override void Print()
        {
            Console.WriteLine($"Square's name is {Name}, Perimeter is {perimeter}, Area is {area}");
        }
    }
}