using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaCalc.Abstractions
{
    public interface IShapable
    {
        public double GetShapeArea();
        public string GetShapeFeatures();
    }
}
