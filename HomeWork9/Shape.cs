using System;
using System.Collections.Generic;

namespace HomeWork9
{
    internal abstract class Shape : IComparable<Shape>
    {
        private string name;

        public string Name { get { return name; } set { name = value; } }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();
        public abstract void Print();
        public int CompareTo(Shape s)
        {
            if (s != null)
                return Area().CompareTo(s.Area());
            else throw new Exception("Uncorrect shape");
        }
    }
}