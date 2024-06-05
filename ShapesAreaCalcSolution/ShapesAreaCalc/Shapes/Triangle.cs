using ShapesAreaCalc.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaCalc.Shapes
{
    public class Triangle : IShapable
    {
        double _aSide;
        double _bSide;
        double _cSide;

        public Triangle(double a, double b, double c)
        {
            _aSide = a;
            _bSide = b;
            _cSide = c;
        }

        public double GetShapeArea()
        {
            double p = (_aSide + _bSide + _cSide)/2;
            return Math.Sqrt(p * (p - _aSide) * (p - _bSide) * (p - _cSide));
        }

        public string GetShapeFeatures()
        {
            List<string> features = new List<string>();

            if (Math.Pow(_aSide, 2) + Math.Pow(_bSide, 2) == Math.Pow(_cSide, 2))
            {
                features.Add(TriangleFeatures.RightTriangle.ToString());
            }

            return string.Join(" ", features.ToArray());
        }
    }
}
