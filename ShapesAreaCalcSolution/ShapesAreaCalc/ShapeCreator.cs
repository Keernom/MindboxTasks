using ShapesAreaCalc.Abstractions;
using ShapesAreaCalc.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaCalc
{
    public class ShapeCreator
    {
        /// <summary>
        /// Shape instance
        /// </summary>
        public IShapable Shape { get; private set; }

        /// <summary>
        /// Creates an instance of Circle shape based on radius
        /// </summary>
        public ShapeCreator(double radius)
        {
            Shape = new Circle(radius);
        }

        /// <summary>
        /// Creates an instance of Triangle shape based on three sides
        /// </summary>
        public ShapeCreator(double a, double b, double c) 
        {
            Shape = new Triangle(a, b, c);
        }
    }
}
