﻿using ShapesAreaCalc;
using ShapesAreaCalc.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaCalcTests.ShapeTests
{
    public class TriangleTests : BaseShapeTests
    {
        [Fact]
        public void IntSidesInput()
        {
            IShapable triangle = new ShapeCreator(3, 4, 5).Shape;

            double expectedValue = 6;
            double triangleArea = triangle.GetShapeArea();

            Assert.True(IsAreaCorrect(expectedValue, triangleArea));
        }

        [Fact]
        public void DoubleSidesInput()
        {
            IShapable triangle = new ShapeCreator(3.5, 4.5, 5.5).Shape;

            double expectedValue = 7.8;
            double triangleArea = triangle.GetShapeArea();

            Assert.True(IsAreaCorrect(expectedValue, triangleArea));
        }

        [Fact]
        public void IsTriangleRight()
        {
            IShapable triangle = new ShapeCreator(3, 4, 5).Shape;

            Assert.Contains(TriangleFeatures.RightTriangle.ToString(), triangle.GetShapeFeatures());
        }

        [Theory]
        [InlineData(-3, 4, 5)]
        [InlineData(3, -4, 5)]
        [InlineData(3, 4, -5)]
        public void NegativeSidesInput(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                IShapable triangle = new ShapeCreator(a, b, c).Shape;
            });
        }
    }
}
