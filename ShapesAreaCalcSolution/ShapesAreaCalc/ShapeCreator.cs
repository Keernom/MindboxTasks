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
        public IShapable Shape { get; private set; }

        public ShapeCreator(double radius)
        {
            Shape = new Circle(radius);
        }

        public ShapeCreator(double a, double b, double c) 
        {
            Shape = new Triangle(a, b, c);
        }
    }
}
