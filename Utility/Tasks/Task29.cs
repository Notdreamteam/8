using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task29
    {
        private double Om {  get; set; }
        private double A { get; set; }

        public Task29(double om, double a)
        {
            Om = om;
            A = a;
        }

        public string ChoosingARheostat(double rh, double vh, double vs)
        {
            double current = vh / rh;
            double totalResistance = vs / current;

            if (Om >= totalResistance && A >= current) return "Этот резистор подходит";
            else return "Этот резистор не подходит";
        }
    }   
}
