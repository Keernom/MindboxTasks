using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaCalc.Abstractions
{
    public abstract class BaseShape
    {
        protected List<double> ShapeParams { get; private set; } = new List<double>();

        public void SetShapeParams(params double[] shapeParams)
        {
            ShapeParams.AddRange(shapeParams);
        }
    }
}
