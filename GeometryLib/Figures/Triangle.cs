using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryLib.Figures
{
    public static class Triangle
    {
        public static double Square(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return 0;
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
