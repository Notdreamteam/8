using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task20
    {
        private double A { get; }
        private double B { get; }
        private double C { get; }

        public Task20(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public string Define()
        {
            if (((A == B) && C != A) || ((B == C) && A != B) || ((A == C) && B != A)) return "Равнобедренный треугольник";
            else if ((A == B) && A == C) return "Равносторонний треугольник";
            else return "Прямоугольный треугольник";
        }
    }
}
