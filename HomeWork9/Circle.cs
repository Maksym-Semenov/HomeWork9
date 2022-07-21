using System;

namespace HomeWork9
{
    internal class Circle : Shape
    {
        private double radius;
        private double area;
        private double perimeter;
        public double Radius { get { return radius; } set { radius = value; } }
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return area = Math.Round((Math.PI * Math.Pow(radius, 2)), 2);
        }
        public override double Perimeter()
        {
            return perimeter = Math.Round((2 * Math.PI * radius), 2);
        }
        public override void Print()
        {
            Console.WriteLine($"Circle's name is {Name}, Perimeter is {perimeter}, Area = {area}");
        }
    }
}