using GeometryLib.Figures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryTests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 1, 2, ExpectedResult = 0)]
        [TestCase(1, 2, 3, ExpectedResult = 0)]
        [TestCase(5, 4, 3, ExpectedResult = 6)]
        [TestCase(5, 8, 5, ExpectedResult = 12)]
        [TestCase(-50, 873624, 125, ExpectedResult = 0)]
        public double Test1(double a, double b, double c)
        {
            //Arrange

            //Act
            return Triangle.Square(a, b, c);

            //Assert
        }
    }
}
