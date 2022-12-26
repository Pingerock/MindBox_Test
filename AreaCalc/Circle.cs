using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Circle : ISquareCalculable
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("The radius cannot be negative or zero.");
            }

            this.radius = radius;
        }

        public double SquareCalc()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
