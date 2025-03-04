using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task2
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Task2(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double MidValue()
        {
            return (A + B + C) / 3;
        }
    }
}
