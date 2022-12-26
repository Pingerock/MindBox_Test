using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaCalc;

namespace AreaCalc_Test
{
    [TestClass]
    public class AreaCalcTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingTriangleTest()
        {
            Triangle triangle1 = new Triangle(1, 2, 3);
            Triangle triangle2 = new Triangle(0, 2, 3);
            Triangle triangle3 = new Triangle(1, 0, 3);
            Triangle triangle4 = new Triangle(1, 2, 0);
            Triangle triangle5 = new Triangle(0, 0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingCircleTest()
        {
            Circle circle = new Circle(0);
        }

        [TestMethod]
        public void CircleCalculationTest()
        {
            Circle circle = new Circle(10);
            Assert.AreEqual(314.15926535897931, circle.SquareCalc());
        }

        [TestMethod]
        public void TriangleCalculationTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.SquareCalc());
        }

        [TestMethod]
        public void RightTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle);
        }
    }
}
