using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class Triangle : Shape
    {
        public double Base {  get; set; }
        public double Height { get; set; }

        public Triangle(double baseSide, double height) 
        {
            Base = baseSide;
            Height = height;
        }

        public override double GetArea()
        {
            return Base * Height / 2;
        }
    }
}
