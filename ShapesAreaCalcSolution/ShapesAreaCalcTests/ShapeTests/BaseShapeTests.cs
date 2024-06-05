using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaCalcTests.ShapeTests
{
    public abstract class BaseShapeTests
    {
        protected bool IsAreaCorrect(double exp, double actual)
        {
            return Math.Abs(exp - actual) < 0.1;
        }
    }
}
