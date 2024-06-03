using ShapesAreaCalc.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaCalcTests.ShapeTests
{
    public class CircleTests
    {
        private bool IsAreaCorrect(double exp, double actual)
        {
            return Math.Abs(exp - actual) < 0.1;
        }

        [Fact]
        public void IntRaduisInput()
        {
            var circle = new Circle(5);

            double expectedValue = 78.5;
            double circleArea = circle.GetShapeArea();

            Assert.True(IsAreaCorrect(expectedValue, circleArea));
        }

        [Fact]
        public void DoubleRaduisInput()
        {
            var circle = new Circle(5.5);

            double expectedValue = 94.98;
            double circleArea = circle.GetShapeArea();

            Assert.True(IsAreaCorrect(expectedValue, circleArea));
        }

        [Fact]
        public void NegativeRadiusInput()
        {
            var circle = new Circle(-5.5);

            double expectedValue = 94.98;
            double circleArea = circle.GetShapeArea();

            Assert.True(IsAreaCorrect(expectedValue, circleArea));
        }

        [Fact]
        public void ZeroRadiusInput()
        {
            var circle = new Circle(0);

            double expectedValue = 0;
            double circleArea = circle.GetShapeArea();

            Assert.True(IsAreaCorrect(expectedValue, circleArea));
        }
    }
}
