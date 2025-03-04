using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task16
    {
        private double A { get; }
        private double B { get; }
        private double C { get; }

        public Task16(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Less()
        {
            if (A < B && A < C) return A;
            else if (B < A && B < C) return B;
            else return C;
        }

        public string More()
        {
            double square = Less();
            double AreaOfSquare = square * square;
            double AreaOfTriangle = (A + B + C) / 2;
            if (AreaOfSquare > AreaOfTriangle) return "Площадь квадрата больше";
            else if (AreaOfSquare == AreaOfTriangle) return "Обе площади равны";
            else return "Площадь треугольника больше";
        }
    }
}
