using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task23
    {
        private int A { get; }
        private int B { get; }
        private int C { get; }

        public Task23(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public string Ans()
        {
            string result = "";
            string binary = "1101011";

            int binaryInt = Convert.ToInt32(binary, 2);

            if (A > binaryInt) result += A;
            else if (B > binaryInt) result += B;
            else if (C > binaryInt) result += C;
            else result += "Нету такого числа";

            return result;
        }
    }
}
