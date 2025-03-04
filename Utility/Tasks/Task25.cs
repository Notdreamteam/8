using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task25
    {
        private string A { get; }
        private string B { get; }
        private string C { get; }

        public Task25(string a, string b, string c)
        {
            A = a;
            B = b;
            C = c;
        }

        public string Least()
        {
            string result = "";

            int binaryIntA = Convert.ToInt32(A, 16);
            int binaryIntB = Convert.ToInt32(B, 16);
            int binaryIntC = Convert.ToInt32(C, 16);

            if (binaryIntA < binaryIntB && binaryIntA < binaryIntC) result += A;
            else if (binaryIntB < binaryIntA && binaryIntB < binaryIntC) result += B;
            else if (binaryIntC < binaryIntB && binaryIntC < binaryIntA) result += C;
            else result += "Нету такого числа";

            return result;
        }
    }
}
