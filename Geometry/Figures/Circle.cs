using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Figures
{
    public class Circle : Figure
    {
        public Circle(uint radius) { _radius = radius; }

        public override double GetShapeArea() =>
            Math.PI * _radius * _radius;
    }
}
