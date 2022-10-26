using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Triangle
    {
        public double Perimeter(double side_a, double side_b, double side_c)
        {
            return side_a + side_b + side_c;

        }
        public double Area(double side_a, double side_b, double side_c)
        {
            return Math.Sqrt(Perimeter(side_a, side_b, side_c) / 2 * (Perimeter(side_a, side_b, side_c) / 2 - side_a) * (Perimeter(side_a, side_b, side_c) / 2 - side_b) * (Perimeter(side_a, side_b, side_c) / 2 - side_c));  

        }



    }
}
