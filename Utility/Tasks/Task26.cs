using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task26
    {
        private int A {  get; set; }
        private int B { get; set; }

        public Task26(int a, int b)
        {
            A = a;
            B = b;
        }

        public int SumA()
        {
            int result = 0;
            result += A % 10;
            A /= 10;
            if(A > 0)
            {
                result += SumA();
            }

            return result;
        }

        public int SumB()
        {
            int CopyB = 0;
            while(B > 0)
            {
                CopyB = CopyB + B % 10;
                B /= 10;
            }
            return CopyB;
        }

        public string Ans()
        {
            int a = SumA(), b = SumB();

            return $"Сумма цифр A: {a}. Сумма цифр B: {b}";
        }
    }
}
