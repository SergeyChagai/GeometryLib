using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryLib.Figures
{
    public class Circle
    {
        public static double Square(double radius)
        {
            if (radius < 0) return 0;
            return Math.PI * radius * radius;
        }
    }
}
