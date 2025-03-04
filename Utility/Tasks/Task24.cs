using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task24
    {
        private double A { get; }
        private double B { get; }
        private double C { get; }

        public Task24(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double More()
        {
            if (A > B && A > C) return A;
            else if (B > A && B > C) return B;
            else if (C > A && C > A) return C;
            return 0;
        }
    }
}
