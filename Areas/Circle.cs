using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Circle
    {
        public double Area(double r)
        {
            return Math.PI * (r * r);
        }
        public double Perimeter(double r)
        {
            return (2 * Math.PI) * r;
        }

    }
}
