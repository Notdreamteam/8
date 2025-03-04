using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task11
    {
        private double A { get; set; }
        private double B { get; set; }

        public Task11(double a, double b)
        {
            A = a;
            B = b;
        }

        public string Exp()
        {
            if((A > 0 && B > 0) || (A < 0 && B < 0)) 
            {
                A = 0;
                B = 0;
            }
            else
            {
                A *= -1;
                B *= -1;
            }

            return $"a = {A}, b = {B}\n";
        }
    }
}
