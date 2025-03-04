using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task6
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Task6(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public string Exp()
        {
            if (A + B + C > 0)
            {
                A *= 2;
                B *= 2;
                C *= 2;
            }
            else
            {
                A = 0;
                B = 0;
                C = 0;
            }
            return $"A = {A}, B = {B}, C = {C}";
        }
    }
}
