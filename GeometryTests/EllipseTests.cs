using NUnit.Framework;
using GeometryLib.Figures;
using System;

namespace GeometryTests
{
    public class EllipseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = Math.PI)]
        [TestCase(-1, ExpectedResult = 0)]
        [TestCase(50, ExpectedResult = 2500*Math.PI)]
        [TestCase(-50, ExpectedResult = 0)]
        public double Test1(int radius)
        {
            //Arrange

            //Act
            return Circle.Square(radius);

            //Assert
        }
    }
}