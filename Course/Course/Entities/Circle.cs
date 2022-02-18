using Course.Entities.Enums;
using System;

namespace Course.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        //double PI = 3.14;

        public Circle()
        {
        }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
