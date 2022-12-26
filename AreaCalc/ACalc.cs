using System;
using System.Collections.Generic;

namespace AreaCalc
{
    public class ACalc
    {
        // Calculates the square of a triangle
        public double SquareCalc(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
            return triangle.SquareCalc();
        }

        // Calculates the square of a circle
        public double SquareCalc(double radius)
        {
            Circle circle = new Circle(radius);
            return circle.SquareCalc();
        }

        // Guess a figure by number of variables in string
        public double SquareCalc(string input)
        {
            List<double> vars = new List<double>();
            string[] numbers = input.Split(' ');
            foreach (string num in numbers)
            {
                vars.Add(double.Parse(num));
            }
            switch (vars.Count)
            {
                case 1:
                    return SquareCalc(vars[0]);
                case 3:
                    return SquareCalc(vars[0], vars[1], vars[2]);
                default:
                    throw new ArgumentException("Invalid or unsupported input.");
            }
            
        }
    }
}