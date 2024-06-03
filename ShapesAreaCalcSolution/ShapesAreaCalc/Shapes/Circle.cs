using ShapesAreaCalc.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaCalc.Shapes
{
    public class Circle : BaseShape, IShapable
    {
        public Circle(double radius)
        {
            SetShapeParams(radius);
        }

        public double GetShapeArea()
        {
            return Math.PI * Math.Pow(ShapeParams.First(), 2);
        }
    }
}
