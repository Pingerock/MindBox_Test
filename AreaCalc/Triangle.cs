using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Triangle : ISquareCalculable
    {
        //Triangle sides
        private double a;
        private double b;
        private double c;

        public bool IsRightTriangle { get; private set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("The side of a triangle cannot be negative or equal to zero.");
            }
            else if (a + b <= c || b + c <= a || c + a <= b)
            {
                throw new ArgumentException("This sides can't form a triangle.");
            }

            this.a = a;
            this.b = b;
            this.c = c;
            IsRightTriangle = RightTriangleCheck();
        }

        //Checks if the triangle is right
        private bool RightTriangleCheck()
        {
            // 2 * a^2 = a^2 + b^2 + c^2
            return Math.Pow(GetBiggestSide(), 2) * 2 == Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);
        }

        //Gets the biggest side of a triangle
        public double GetBiggestSide()
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        //Calculates the square of the triangle
        public double SquareCalc()
        {
            double semiPerimeter = (a + b + c) / 2;
            double square = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            return square;
        }
    }
}
