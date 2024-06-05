using ShapesAreaCalc;
using ShapesAreaCalc.Abstractions;
using ShapesAreaCalc.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaCalcTests.ShapeTests
{
    public class CircleTests : BaseShapeTests
    {
        [Fact]
        public void IntRaduisInput()
        {
            IShapable circle = new ShapeCreator(5).Shape;

            double expectedValue = 78.5;
            double circleArea = circle.GetShapeArea();

            Assert.True(IsAreaCorrect(expectedValue, circleArea));
        }

        [Fact]
        public void DoubleRaduisInput()
        {
            IShapable circle = new ShapeCreator(5.5).Shape;

            double expectedValue = 94.98;
            double circleArea = circle.GetShapeArea();

            Assert.True(IsAreaCorrect(expectedValue, circleArea));
        }

        [Fact]
        public void NegativeRadiusInput()
        {
            Assert.Throws<ArgumentException>(() => 
            {
                IShapable circle = new ShapeCreator(-5.5).Shape;
            });
        }

        [Fact]
        public void ZeroRadiusInput()
        {
            IShapable circle = new ShapeCreator(0).Shape;

            double expectedValue = 0;
            double circleArea = circle.GetShapeArea();

            Assert.True(IsAreaCorrect(expectedValue, circleArea));
        }
    }
}
