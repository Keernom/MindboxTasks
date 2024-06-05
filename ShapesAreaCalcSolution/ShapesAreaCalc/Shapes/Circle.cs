using ShapesAreaCalc.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaCalc.Shapes
{
    public class Circle : IShapable
    {
        double _radius;

        public Circle(double radius) 
        {
            if (radius < 0)
            {
                throw new ArgumentException("The circle radius can't be less than zero");
            }

            _radius = radius;
        }

        public double GetShapeArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public double GetShapeArea()
        {
            return Math.PI * Math.Pow(ShapeParams.First(), 2);
        }
    }
}
