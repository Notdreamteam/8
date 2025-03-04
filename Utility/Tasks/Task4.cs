using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task4
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Task4(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool Rectangular()
        {
            if (A + B > B + C && A + B > A + C) return (Math.Pow(A + C, 2) + Math.Pow(B + C, 2)) == Math.Pow(A + B, 2);
            else if (B + C > A + B && B + C > A + C) return (Math.Pow(A + C, 2) + Math.Pow(A + B, 2)) == Math.Pow(B + C, 2);
            else if (C + A > B + C && C + A > A + B) return (Math.Pow(B + C, 2) + Math.Pow(A + B, 2)) == Math.Pow(C + A, 2);
            else return false;
        }
    }
}
